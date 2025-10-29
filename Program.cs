using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text;

// Run tasks
CleanMonstersCsv();
UpdateBestiaryFromMonsters();

static void UpdateBestiaryFromMonsters()
{
 string monstersCsv = "Monsters.csv";
 string guidePath = "FFMQ_Complete_LLM_Guide.markdown";
 if (!File.Exists(monstersCsv)) { Console.WriteLine($"Skip Bestiary update: missing {monstersCsv}"); return; }
 if (!File.Exists(guidePath)) { Console.WriteLine($"Skip Bestiary update: missing {guidePath}"); return; }

 // Boss name hints to classify Type column
 var bossNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
 {
 "Behemoth","Minotaur","Flamerus Rex","Squidite","Ice Golem","Dualhead Hydra","Twinhead Wyvern","Zuh",
 "Dark King (1st Form)","Dark King (2nd Form)","Dark King (3rd Form)","Dark King (4th Form)","Pazuzu","Skullrus Rex"
 };

 // Load monsters
 var lines = File.ReadAllLines(monstersCsv);
 if (lines.Length <=1) { Console.WriteLine("No monsters rows found."); return; }
 var header = CsvUtil.ParseCsvRow(lines[0]);
 int idxOrder = CsvUtil.IndexOf(header, "EncounterOrder");
 int idxName = CsvUtil.IndexOf(header, "MonsterName");
 int idxLocation = CsvUtil.IndexOf(header, "GameLocation");
 int idxAbilities = CsvUtil.IndexOf(header, "AbilitiesJson");
 int idxHp = CsvUtil.IndexOf(header, "HP");
 int idxExp = CsvUtil.IndexOf(header, "EXP");
 int idxGp = CsvUtil.IndexOf(header, "GP");
 int idxAtk = CsvUtil.IndexOf(header, "Strength");
 int idxDef = CsvUtil.IndexOf(header, "Defense");
 int idxSpd = CsvUtil.IndexOf(header, "Speed");
 int idxMag = CsvUtil.IndexOf(header, "Magic");
 int idxElem = CsvUtil.IndexOf(header, "ElementalAffinitiesJson");
 int idxStatus = CsvUtil.IndexOf(header, "StatusAffinitiesJson");
 int idxWiki = CsvUtil.IndexOf(header, "WikiUrl");
 int idxDrops = CsvUtil.IndexOf(header, "DropsJson");

 var rows = new List<(int Order, string Row)>();
 for (int i =1; i < lines.Length; i++)
 {
 var row = CsvUtil.ParseCsvRow(lines[i]);
 if (row.Count ==0) continue;
 int order = SafeInt(Get(row, idxOrder));
 string name = Get(row, idxName);
 string type = bossNames.Contains(name) ? "Boss" : "Enemy";
 string location = Get(row, idxLocation);
 string hp = Get(row, idxHp);
 string exp = Get(row, idxExp);
 string gp = Get(row, idxGp);
 string atk = Get(row, idxAtk);
 string def = Get(row, idxDef);
 string spd = Get(row, idxSpd);
 string mag = Get(row, idxMag);
 string abilities = FormatAbilities(Get(row, idxAbilities));
 string elem = FormatDict(Get(row, idxElem));
 string status = FormatDict(Get(row, idxStatus));
 string drops = FormatDrops(Get(row, idxDrops));
 string imageUrl = string.Empty; // Not present in Monsters.csv
 string wiki = Get(row, idxWiki);

 // Markdown table row
 string mdRow = $"| {order} | {EscapePipes(name)} | {type} | {EscapePipes(location)} | {hp} | {exp} | {gp} | {atk} | {def} | {spd} | {mag} | {EscapePipes(abilities)} | {EscapePipes(elem)} | {EscapePipes(status)} | {EscapePipes(drops)} | {EscapePipes(imageUrl)} | {EscapePipes(wiki)} |";
 rows.Add((order, mdRow));
 }
 rows.Sort((a,b) => a.Order.CompareTo(b.Order));

 // Rewrite Bestiary table in markdown
 var guideLines = File.ReadAllLines(guidePath).ToList();
 int tableHeaderIdx = guideLines.FindIndex(l => l.StartsWith("| Order | Name | Type |", StringComparison.Ordinal));
 if (tableHeaderIdx == -1) { Console.WriteLine("Bestiary table header not found, aborting update."); return; }
 int tableSepIdx = tableHeaderIdx +1; // assumes separator line next
 int endIdx = guideLines.FindIndex(tableSepIdx +1, l => l.StartsWith("## Enemy Abilities", StringComparison.Ordinal));
 if (endIdx == -1) endIdx = guideLines.Count; // until end if not found

 // Keep header and separator, replace body
 var newGuide = new List<string>();
 newGuide.AddRange(guideLines.Take(tableSepIdx +1));
 newGuide.AddRange(rows.Select(r => r.Row));
 newGuide.AddRange(guideLines.Skip(endIdx));
 File.WriteAllLines(guidePath, newGuide);
 Console.WriteLine($"Updated Bestiary table in {guidePath} from Monsters.csv.");

 static string Get(List<string> row, int idx) => (idx >=0 && idx < row.Count) ? (row[idx] ?? string.Empty) : string.Empty;
 static int SafeInt(string s) => int.TryParse(s, out var v) ? v : int.MaxValue;
 static string EscapePipes(string s) => (s ?? string.Empty).Replace("|", "\\|");
 static string FormatAbilities(string json)
 {
 if (string.IsNullOrWhiteSpace(json)) return string.Empty;
 try
 {
 using var doc = JsonDocument.Parse(json);
 if (doc.RootElement.ValueKind != JsonValueKind.Array) return json;
 var names = new List<string>();
 foreach (var el in doc.RootElement.EnumerateArray())
 {
 if (el.ValueKind == JsonValueKind.String)
 {
 var v = el.GetString();
 if (!string.IsNullOrWhiteSpace(v)) names.Add(v!);
 }
 else if (el.ValueKind == JsonValueKind.Object)
 {
 if (el.TryGetProperty("AbilityName", out var n) && n.ValueKind == JsonValueKind.String)
 names.Add(n.GetString() ?? string.Empty);
 }
 }
 return string.Join("; ", names.Where(n => !string.IsNullOrWhiteSpace(n)));
 }
 catch { return json; }
 }
 static string FormatDict(string json)
 {
 if (string.IsNullOrWhiteSpace(json)) return string.Empty;
 try
 {
 using var doc = JsonDocument.Parse(json);
 if (doc.RootElement.ValueKind == JsonValueKind.Object)
 {
 var parts = new List<string>();
 foreach (var prop in doc.RootElement.EnumerateObject())
 {
 string val = prop.Value.ValueKind == JsonValueKind.String ? prop.Value.GetString() ?? string.Empty : prop.Value.ToString();
 parts.Add($"{prop.Name}: {val}");
 }
 return string.Join("; ", parts);
 }
 }
 catch { }
 return json;
 }
 static string FormatDrops(string json)
 {
 if (string.IsNullOrWhiteSpace(json)) return string.Empty;
 try
 {
 using var doc = JsonDocument.Parse(json);
 if (doc.RootElement.ValueKind == JsonValueKind.Array)
 {
 var vals = new List<string>();
 foreach (var el in doc.RootElement.EnumerateArray())
 {
 if (el.ValueKind == JsonValueKind.String)
 {
 var s = el.GetString();
 if (!string.IsNullOrWhiteSpace(s)) vals.Add(s!);
 }
 else if (el.ValueKind == JsonValueKind.Object)
 {
 if (el.TryGetProperty("Name", out var n) && n.ValueKind == JsonValueKind.String)
 vals.Add(n.GetString() ?? string.Empty);
 }
 }
 return string.Join(", ", vals);
 }
 }
 catch { }
 return string.Empty;
 }
}

// Clean Monsters.csv: remove PlayerAttack/PlayerDamageDone/EnemyDefense, rename WikiAttack->Strength, WikiDefense->Defense,
// replace ImageUrl with WikiUrl populated from bestiary_wiki_links.json, and simplify AbilitiesJson to a list of names
static void CleanMonstersCsv()
{
 string monstersCsv = "Monsters.csv";
 string wikiMapJson = "bestiary_wiki_links.json";
 if (!File.Exists(monstersCsv)) { Console.WriteLine($"Skip CSV: missing {monstersCsv}"); return; }

 // Load wiki urls
 var wikiMap = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
 if (File.Exists(wikiMapJson))
 {
 using var js = File.OpenRead(wikiMapJson);
 var entries = JsonSerializer.Deserialize<List<WikiLink>>(js, new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new();
 foreach (var e in entries)
 {
 if (!string.IsNullOrWhiteSpace(e?.Name) && !string.IsNullOrWhiteSpace(e?.WikiUrl))
 wikiMap[e.Name.Trim()] = e.WikiUrl.Trim();
 }
 }
 else
 {
 Console.WriteLine($"Warning: {wikiMapJson} not found. WikiUrl column will be empty.");
 }

 var allLines = File.ReadAllLines(monstersCsv);
 if (allLines.Length ==0) { Console.WriteLine("Monsters.csv is empty, skipping."); return; }

 var header = CsvUtil.ParseCsvRow(allLines[0]);
 int idxPlayerAttack = CsvUtil.IndexOf(header, "PlayerAttack");
 int idxPlayerDamageDone = CsvUtil.IndexOf(header, "PlayerDamageDone");
 int idxEnemyDefense = CsvUtil.IndexOf(header, "EnemyDefense");
 int idxImageUrl = CsvUtil.IndexOf(header, "ImageUrl");
 int idxMonsterName = CsvUtil.IndexOf(header, "MonsterName");
 int idxWikiAttack = CsvUtil.IndexOf(header, "WikiAttack");
 int idxWikiDefense = CsvUtil.IndexOf(header, "WikiDefense");
 int idxAbilitiesJson = CsvUtil.IndexOf(header, "AbilitiesJson");

 var indicesToRemove = new HashSet<int>();
 if (idxPlayerAttack >=0) indicesToRemove.Add(idxPlayerAttack);
 if (idxPlayerDamageDone >=0) indicesToRemove.Add(idxPlayerDamageDone);
 if (idxEnemyDefense >=0) indicesToRemove.Add(idxEnemyDefense);

 // Build new header with renames and ImageUrl -> WikiUrl
 var newHeader = new List<string>();
 for (int i =0; i < header.Count; i++)
 {
 if (indicesToRemove.Contains(i)) continue;
 string name = header[i];
 if (i == idxWikiAttack) name = "Strength";
 else if (i == idxWikiDefense) name = "Defense";
 else if (i == idxImageUrl) name = "WikiUrl";
 newHeader.Add(name);
 }

 var output = new List<string> { CsvUtil.ToCsvRow(newHeader) };
 for (int li =1; li < allLines.Length; li++)
 {
 if (string.IsNullOrWhiteSpace(allLines[li])) { output.Add(string.Empty); continue; }
 var row = CsvUtil.ParseCsvRow(allLines[li]);
 while (row.Count < header.Count) row.Add(string.Empty);

 var newRow = new List<string>(newHeader.Count);
 for (int i =0; i < header.Count; i++)
 {
 if (indicesToRemove.Contains(i)) continue;
 if (i == idxImageUrl)
 {
 var name = idxMonsterName >=0 && idxMonsterName < row.Count ? row[idxMonsterName] : string.Empty;
 string wiki = string.Empty;
 if (!string.IsNullOrWhiteSpace(name))
 {
 if (!wikiMap.TryGetValue(name, out wiki))
 {
 var norm = name.Trim();
 if (!wikiMap.TryGetValue(norm, out wiki))
 {
 var norm2 = norm.Replace("'", string.Empty);
 wikiMap.TryGetValue(norm2, out wiki);
 }
 }
 }
 newRow.Add(wiki ?? string.Empty);
 }
 else if (i == idxAbilitiesJson)
 {
 var abilitiesCell = i < row.Count ? row[i] : string.Empty;
 var simplified = CsvUtil.SimplifyAbilitiesJson(abilitiesCell);
 newRow.Add(simplified);
 }
 else
 {
 newRow.Add(i < row.Count ? row[i] : string.Empty);
 }
 }
 output.Add(CsvUtil.ToCsvRow(newRow));
 }

 File.WriteAllLines(monstersCsv, output);
 Console.WriteLine("Monsters.csv cleaned and updated with WikiUrl and simplified AbilitiesJson.");
}

public static class CsvUtil
{
 public static int IndexOf(IReadOnlyList<string> list, string value)
 {
 for (int i =0; i < list.Count; i++)
 {
 if (string.Equals(list[i], value, StringComparison.Ordinal)) return i;
 }
 return -1;
 }

 public static List<string> ParseCsvRow(string line)
 {
 var result = new List<string>();
 if (line == null) return result;
 int i =0;
 while (i < line.Length)
 {
 if (line[i] == ',') { result.Add(string.Empty); i++; continue; }
 string field;
 if (line[i] == '"')
 {
 i++; // skip opening quote
 var sb = new System.Text.StringBuilder();
 bool done = false;
 while (!done && i < line.Length)
 {
 if (line[i] == '"')
 {
 if (i +1 < line.Length && line[i +1] == '"') { sb.Append('"'); i +=2; }
 else { i++; done = true; }
 }
 else { sb.Append(line[i]); i++; }
 }
 if (i < line.Length && line[i] == ',') i++;
 field = sb.ToString();
 }
 else
 {
 int start = i;
 while (i < line.Length && line[i] != ',') i++;
 field = line.Substring(start, i - start);
 if (i < line.Length && line[i] == ',') i++;
 }
 result.Add(field);
 }
 if (line.EndsWith(",")) result.Add(string.Empty);
 return result;
 }

 public static string ToCsvRow(IReadOnlyList<string> fields)
 {
 var parts = new List<string>(fields.Count);
 foreach (var f in fields)
 {
 string v = f ?? string.Empty;
 bool needsQuote = v.Contains(',') || v.Contains('"') || v.Contains('\n') || v.Contains('\r');
 if (needsQuote) v = '"' + v.Replace("\"", "\"\"") + '"';
 parts.Add(v);
 }
 return string.Join(',', parts);
 }

 public static string SimplifyAbilitiesJson(string json)
 {
 if (string.IsNullOrWhiteSpace(json)) return json ?? string.Empty;
 try
 {
 using var doc = JsonDocument.Parse(json);
 if (doc.RootElement.ValueKind != JsonValueKind.Array)
 return json; // leave as-is if not array
 var names = new List<string>();
 foreach (var el in doc.RootElement.EnumerateArray())
 {
 if (el.ValueKind == JsonValueKind.Object)
 {
 string? name = null;
 foreach (var prop in el.EnumerateObject())
 {
 if (string.Equals(prop.Name, "AbilityName", StringComparison.OrdinalIgnoreCase))
 {
 if (prop.Value.ValueKind == JsonValueKind.String)
 name = prop.Value.GetString();
 break;
 }
 }
 if (!string.IsNullOrWhiteSpace(name)) names.Add(name!);
 }
 else if (el.ValueKind == JsonValueKind.String)
 {
 var s = el.GetString();
 if (!string.IsNullOrWhiteSpace(s)) names.Add(s!);
 }
 }
 return JsonSerializer.Serialize(names);
 }
 catch
 {
 // If parsing fails, leave original content
 return json;
 }
 }
}

public class WikiLink
{
 public string Name { get; set; } = string.Empty;
 public string WikiUrl { get; set; } = string.Empty;
}
