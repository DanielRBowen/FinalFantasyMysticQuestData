# FinalFantasyMysticQuestData

Structured, machine-friendly data for Final Fantasy Mystic Quest. Use this repository to power apps, scripts, or LLMs with a single, comprehensive guide and the raw/source data it was compiled from.

## Quick access
- Complete guide (recommended): [FFMQ_Complete_LLM_Guide_Final.markdown](./FFMQ_Complete_LLM_Guide_Final.markdown)
 - Sections:
 - [Game Overview and Story Chronology](./FFMQ_Complete_LLM_Guide_Final.markdown#game-overview-and-story-chronology)
 - [Locations (Chronological)](./FFMQ_Complete_LLM_Guide_Final.markdown#locations-chronological)
 - [Characters and Stats](./FFMQ_Complete_LLM_Guide_Final.markdown#characters-and-stats)
 - [Leveling and Formulas](./FFMQ_Complete_LLM_Guide_Final.markdown#leveling-and-formulas-stats-guide)
 - [Weapons](./FFMQ_Complete_LLM_Guide_Final.markdown#weapons)
 - [Armor and Accessories](./FFMQ_Complete_LLM_Guide_Final.markdown#armor-and-accessories)
 - [Spells](./FFMQ_Complete_LLM_Guide_Final.markdown#spells)
 - [Items](./FFMQ_Complete_LLM_Guide_Final.markdown#items-consumables-key-items-crests-coins)
 - [Bestiary](./FFMQ_Complete_LLM_Guide_Final.markdown#bestiary-enemies-and-bosses-chronological)
 - [Enemy Abilities](./FFMQ_Complete_LLM_Guide_Final.markdown#enemy-abilities)
 - [Battlefields](./FFMQ_Complete_LLM_Guide_Final.markdown#battlefields)

## What’s in this repo
- `FFMQ_Complete_LLM_Guide_Final.markdown` – unified, LLM-friendly guide compiled from all sources (primary artifact).
- `FFMQ_Complete_LLM_Guide_Merged.markdown` – intermediate merged guide prior to supplemental updates.
- `FFMQ_Supplemental_Boss_HP.markdown` – community-sourced HP estimates for bosses with missing HP in the original data (not canonical to CSVs).
- `Program.cs` – top-level C# program that applies supplemental HP to the merged guide and writes the final guide.
- `FinalFantasyMysticQuestData.csproj` – minimal project file to run the program.
- Source CSV/TXT data files used to build the guide (armor, items, spells, locations, bestiary, etc.).

## Usage
- Ensure .NET SDK8/9+ is installed.
- From the repo root, run the program to rebuild the final guide (writes `FFMQ_Complete_LLM_Guide_Final.markdown`):
 - `dotnet run --configuration Release`

## Notes and attribution
- The final guide consolidates repository CSV/TXT sources for consistency and ease of parsing.
- Boss HP for Squidite and Pazuzu in the final guide are annotated from community sources (see `FFMQ_Supplemental_Boss_HP.markdown`).
- This project is not affiliated with Square Enix. Data and wiki links are provided for reference.
