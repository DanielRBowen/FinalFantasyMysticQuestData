using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;

// Run tasks
FormatGuideTables();

static string ResolvePath(string relativePath)
{
 if (string.IsNullOrWhiteSpace(relativePath)) return relativePath;
 if (Path.IsPathRooted(relativePath) && File.Exists(relativePath)) return relativePath;

 var candidates = new List<string>();
 string cwd = Directory.GetCurrentDirectory();
 string baseDir = AppContext.BaseDirectory;

 // direct and common locations
 candidates.Add(relativePath);
 candidates.Add(Path.Combine(cwd, relativePath));
 candidates.Add(Path.Combine(baseDir, relativePath));

 // project directory (commonly three levels up from bin/<cfg>/<tfm>)
 try { candidates.Add(Path.Combine(Path.GetFullPath(Path.Combine(baseDir, "..", "..", "..")), relativePath)); } catch { }

 // search up to6 levels upwards from cwd
 var dir = cwd;
 for (int i =0; i <6 && !string.IsNullOrEmpty(dir); i++)
 {
 candidates.Add(Path.Combine(dir, relativePath));
 var parent = Directory.GetParent(dir);
 if (parent == null) break;
 dir = parent.FullName;
 }

 foreach (var c in candidates.Distinct())
 {
 try { if (File.Exists(c)) return Path.GetFullPath(c); } catch { }
 }
 return relativePath; // fallback; File.Exists checks will handle missing
}

// Reformat all Markdown pipe tables in the guide except the Bestiary section
static void FormatGuideTables()
{
 string guidePath = ResolvePath("FFMQ_Complete_LLM_Guide.markdown");
 if (!File.Exists(guidePath)) { Console.WriteLine($"Skip table format: missing {guidePath}"); return; }

 var lines = File.ReadAllLines(guidePath).ToList();

 // Determine Bestiary section range to skip formatting
 int bestiaryStart = IndexOfLine(lines, l => l.TrimStart().StartsWith("## Bestiary", StringComparison.OrdinalIgnoreCase));
 int bestiaryEnd = -1;
 if (bestiaryStart >=0)
 {
 // end is next H2 (## ) after start, or file end
 bestiaryEnd = IndexOfLineFrom(lines, bestiaryStart +1, l => l.TrimStart().StartsWith("## ", StringComparison.Ordinal));
 if (bestiaryEnd <0) bestiaryEnd = lines.Count; // until EOF
 }

 var output = new List<string>(lines.Count);

 int i =0;
 while (i < lines.Count)
 {
 // If inside bestiary, copy through unchanged
 if (bestiaryStart >=0 && i >= bestiaryStart && i < bestiaryEnd)
 {
 output.Add(lines[i]);
 i++;
 continue;
 }

 // Detect a pipe table start
 if (IsPipeTableLine(lines[i]))
 {
 int start = i;
 var block = new List<string>();

 // collect contiguous table-like lines, skipping blank lines in between
 while (i < lines.Count && (IsPipeTableLine(lines[i]) || string.IsNullOrWhiteSpace(lines[i])))
 {
 if (!string.IsNullOrWhiteSpace(lines[i])) block.Add(lines[i]);
 i++;
 }

 if (block.Count ==0)
 {
 // safety fallback
 continue;
 }

 // Separate any existing separator rows and capture alignment if present
 var rows = new List<List<string>>();
 List<Align> alignments = null;
 foreach (var bl in block)
 {
 if (IsSeparatorRow(bl))
 {
 var sepCells = ParseRow(bl);
 alignments ??= sepCells.Select(ParseAlign).ToList();
 continue;
 }
 rows.Add(ParseRow(bl));
 }

 if (rows.Count ==0)
 {
 // nothing to format
 continue;
 }

 // First row is header; remaining are body
 int colCount = rows.Max(r => r.Count);
 if (colCount ==0) { continue; }

 // normalize rows to same column count
 foreach (var r in rows)
 {
 while (r.Count < colCount) r.Add(string.Empty);
 if (r.Count > colCount) r.RemoveRange(colCount, r.Count - colCount);
 }

 if (alignments == null || alignments.Count != colCount)
 {
 // default to left align
 alignments = Enumerable.Repeat(Align.Left, colCount).ToList();
 }
 else if (alignments.Count < colCount)
 {
 // pad alignments if shorter
 int need = colCount - alignments.Count;
 for (int k =0; k < need; k++) alignments.Add(Align.Left);
 }

 // Build formatted table
 var header = rows[0].Select(FormatCell).ToList();
 var body = rows.Skip(1).Select(r => r.Select(FormatCell).ToList()).ToList();

 output.Add(BuildRow(header));
 output.Add(BuildSeparator(alignments));
 foreach (var r in body)
 {
 output.Add(BuildRow(r));
 }

 // remove any trailing blank lines before next content (keep a single blank line if there was spacing originally)
 if (i < lines.Count && string.IsNullOrWhiteSpace(lines[i]))
 {
 // collapse consecutive blanks to a single blank
 while (i < lines.Count && string.IsNullOrWhiteSpace(lines[i])) i++;
 output.Add(string.Empty);
 }
 continue;
 }

 // not a table line, copy as-is
 output.Add(lines[i]);
 i++;
 }

 if (!output.SequenceEqual(lines))
 {
 File.WriteAllLines(guidePath, output);
 Console.WriteLine($"Formatted Markdown tables (excluding Bestiary) in {guidePath}.");
 }
 else
 {
 Console.WriteLine("No table formatting changes needed.");
 }

 static int IndexOfLine(List<string> list, Func<string, bool> predicate)
 {
 for (int j =0; j < list.Count; j++) if (predicate(list[j])) return j;
 return -1;
 }

 static int IndexOfLineFrom(List<string> list, int start, Func<string, bool> predicate)
 {
 for (int j = start; j < list.Count; j++) if (predicate(list[j])) return j;
 return -1;
 }

 static bool IsPipeTableLine(string line)
 {
 if (string.IsNullOrWhiteSpace(line)) return false;
 var t = line.TrimStart();
 if (!t.StartsWith("|")) return false;
 int pipeCount =0;
 bool escaped = false;
 foreach (var ch in t)
 {
 if (escaped) { escaped = false; continue; }
 if (ch == '\\') { escaped = true; continue; }
 if (ch == '|') pipeCount++;
 }
 return pipeCount >=2; // at least two pipes means at least one cell
 }

 static List<string> ParseRow(string line)
 {
 var cells = new List<string>();
 if (line == null) return cells;
 var t = line.Trim();
 // remove optional leading and trailing pipe
 int start =0, end = t.Length -1;
 if (t.StartsWith("|")) start++;
 if (t.EndsWith("|")) end--;
 var sb = new StringBuilder();
 bool escaped = false;
 for (int idx = start; idx <= end; idx++)
 {
 char ch = t[idx];
 if (escaped)
 {
 sb.Append(ch);
 escaped = false;
 continue;
 }
 if (ch == '\\') { escaped = true; continue; }
 if (ch == '|')
 {
 cells.Add(sb.ToString().Trim());
 sb.Clear();
 }
 else
 {
 sb.Append(ch);
 }
 }
 cells.Add(sb.ToString().Trim());
 return cells;
 }

 static bool IsSeparatorRow(string line)
 {
 if (string.IsNullOrWhiteSpace(line)) return false;
 var cells = ParseRow(line);
 if (cells.Count ==0) return false;
 // A separator row has only combinations of dashes and optional leading/trailing colons/spaces
 foreach (var c in cells)
 {
 var s = c.Trim();
 if (s.Length ==0) return false;
 bool hasDash = false;
 foreach (var ch in s)
 {
 if (ch == '-') { hasDash = true; continue; }
 if (ch == ':' || ch == ' ') continue;
 return false;
 }
 if (!hasDash) return false;
 }
 return true;
 }

 static Align ParseAlign(string sepCell)
 {
 var s = (sepCell ?? string.Empty).Trim();
 bool left = s.StartsWith(":");
 bool right = s.EndsWith(":");
 if (left && right) return Align.Center;
 if (right) return Align.Right;
 return Align.Left;
 }

 static string BuildSeparator(IReadOnlyList<Align> aligns)
 {
 var parts = new List<string>(aligns.Count);
 foreach (var a in aligns)
 {
 parts.Add(a switch
 {
 Align.Center => ":---:",
 Align.Right => "---:",
 _ => "---"
 });
 }
 return "| " + string.Join(" | ", parts) + " |";
 }

 static string BuildRow(IReadOnlyList<string> cells)
 {
 return "| " + string.Join(" | ", cells) + " |";
 }

 static string FormatCell(string s)
 {
 if (string.IsNullOrEmpty(s)) return string.Empty;
 // escape pipe characters inside cell
 var replaced = s.Replace("|", "\\|");
 // normalize internal whitespace around newlines/tabs
 return replaced.Trim();
 }
}

enum Align { Left, Right, Center }
