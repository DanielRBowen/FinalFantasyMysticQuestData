using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

// File paths (relative to repo root)
string mergedFilePath = "FFMQ_Complete_LLM_Guide_Merged.markdown";
string supplementalFilePath = "FFMQ_Supplemental_Boss_HP.markdown"; // corrected extension
string outputFilePath = "FFMQ_Complete_LLM_Guide_Final.markdown";

if (!File.Exists(mergedFilePath))
{
    Console.WriteLine($"Error: Merged file not found: {mergedFilePath}");
    return;
}
if (!File.Exists(supplementalFilePath))
{
    Console.WriteLine($"Error: Supplemental file not found: {supplementalFilePath}");
    return;
}

// Read the merged and supplemental files
string mergedContent = File.ReadAllText(mergedFilePath);
string supplementalContent = File.ReadAllText(supplementalFilePath);

// Extract HP data from supplemental file (static for now based on provided markdown)
var hpData = new Dictionary<string, (string HP, string Source)>
{
    { "Squidite", ("1500", "https://finalfantasy.fandom.com/wiki/Squidite") },
    { "Pazuzu", ("15000", "https://finalfantasy.fandom.com/wiki/Pazuzu_(Mystic_Quest)") }
};

// Split the content to manipulate the document line-by-line
string[] lines = mergedContent.Split('\n');

// Update Bestiary table
bool inBestiaryTable = false;
for (int i =0; i < lines.Length; i++)
{
    // Detect table header start
    if (lines[i].StartsWith("| Order | Name |", StringComparison.Ordinal))
    {
        inBestiaryTable = true;
        continue;
    }

    if (inBestiaryTable)
    {
        // An empty line or a heading ends the table
        if (string.IsNullOrWhiteSpace(lines[i]) || lines[i].StartsWith("## "))
        {
            inBestiaryTable = false;
            continue;
        }

        if (lines[i].StartsWith("|"))
        {
            var columns = lines[i]
                .Split('|')
                .Select(c => c.Trim())
                .ToArray();

            if (columns.Length >=6)
            {
                // columns: ["", Order, Name, Type, Locations, HP, ... , ""]
                string name = columns[2];
                if (!string.IsNullOrEmpty(name) && hpData.TryGetValue(name, out var hp))
                {
                    // Update HP column (index5)
                    columns[5] = hp.HP;

                    // Rebuild the row excluding the leading and trailing empty cells
                    string rebuilt = "| " + string.Join(" | ", columns.Skip(1).Take(columns.Length -2)) + " |";
                    lines[i] = rebuilt;
                }
            }
        }
    }
}

// Update Story Chronology section entries
for (int i =0; i < lines.Length; i++)
{
    if (lines[i].StartsWith("**LOCATION: Wintry Cave**", StringComparison.Ordinal))
    {
        // Boss line is typically5 lines after the LOCATION line
        int bossLine = i +5;
        if (bossLine < lines.Length)
        {
            // Replace any existing "HP: ..." token up to the next comma or closing paren
            lines[bossLine] = Regex.Replace(
                lines[bossLine],
                @"Squidite\s*\(HP:[^,\)]*",
                $"Squidite (HP: {hpData["Squidite"].HP}");
        }
    }
    else if (lines[i].StartsWith("**LOCATION: Pazuzu's Tower**", StringComparison.Ordinal))
    {
        int bossLine = i +5;
        if (bossLine < lines.Length)
        {
            lines[bossLine] = Regex.Replace(
                lines[bossLine],
                @"Pazuzu\s*\(HP:[^,\)]*",
                $"Pazuzu (HP: {hpData["Pazuzu"].HP}");
        }
    }
}

// Add attribution note to Additional Notes section
string notesSectionHeader = "## Additional Notes";
int notesHeaderIndex = Array.FindIndex(lines, l => l.StartsWith(notesSectionHeader, StringComparison.Ordinal));
string hpNote = "- **Boss HP Estimates**: HP values for Squidite (1500) and Pazuzu (15000) were sourced from https://finalfantasy.fandom.com (estimates), not from Bestiary_Chronological_v2.csv.";
if (notesHeaderIndex != -1)
{
    var before = lines.Take(notesHeaderIndex +1);
    var after = lines.Skip(notesHeaderIndex +1);

    // Only add if not already present
    if (!after.Any(l => l.Contains("Boss HP Estimates")))
    {
        lines = before.Concat(new[] { hpNote }).Concat(after).ToArray();
    }
}

// Write the updated content to a new file
File.WriteAllLines(outputFilePath, lines);
Console.WriteLine($"Merged file written to {outputFilePath}");