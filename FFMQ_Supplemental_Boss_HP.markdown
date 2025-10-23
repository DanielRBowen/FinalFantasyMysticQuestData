# Final Fantasy Mystic Quest - Supplemental Boss HP Data

**Version**: 1.0  
**Purpose**: This file provides estimated HP values for bosses missing HP data in the original Bestiary_Chronological_v2.csv, sourced from community estimates (e.g., https://finalfantasy.fandom.com). Use this to update the Bestiary and Story Chronology sections in `FFMQ_Complete_LLM_Guide_Merged.markdown` if desired. Merge with GitHub Copilot by adding these HP values to the relevant boss entries.

## Boss HP Updates
| Boss | Location | Estimated HP | Source |
|------|----------|--------------|--------|
| Squidite | Wintry Cave | 1,500 | https://finalfantasy.fandom.com/wiki/Squidite |
| Pazuzu | Pazuzu's Tower | 15,000 | https://finalfantasy.fandom.com/wiki/Pazuzu_(Mystic_Quest) |

### Merge Instructions
- **Bestiary Table**:
  - Locate the Squidite entry (Order 11) in the Bestiary table and update the HP column from "not specified" to 1,500.
  - Locate the Pazuzu entry (Order not specified in original, but typically after Twinhead Wyvern, Order 35) and add/update the HP to 15,000.
- **Story Chronology**:
  - Update the Wintry Cave entry (Order 9) to include Squidite’s HP: 1,500.
  - Update the Pazuzu’s Tower entry (Order 30) to include Pazuzu’s HP: 15,000.
- **Attribution**: These values are estimates from community sources, not the original CSVs, and should be noted as such in the Additional Notes section.