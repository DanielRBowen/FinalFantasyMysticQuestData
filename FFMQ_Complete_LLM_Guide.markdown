# Final Fantasy Mystic Quest - Complete LLM-Friendly Guide



**Version**: 1.1  

**Source**: Compiled from all provided CSV and TXT data sources on Final Fantasy Mystic Quest (FFMQ): Final_Fantasy_Mystic_Quest_armor.csv, Monsters.csv, Final_Fantasy_Mystic_Quest_items.csv, ffmq_character_stats.csv, Final_Fantasy_Mystic_Quest_enemy_abilities.csv, Final_Fantasy_Mystic_Quest_battlefields.csv, Final_Fantasy_Mystic_Quest_spells.csv, Locations_Chronological.csv, Final_Fantasy_Mystic_Quest_weapons.csv, Mystic_Quest_Story_Chronology.txt, Final_Fantasy_Mystic_Quest_stats_guide.txt. This guide consolidates *all* data into a single, structured, LLM-friendly Markdown file for easy parsing and accurate information retrieval. No data is truncated, and no external references are required. All information is faithful to the source data without additions or assumptions.



## Sections

- Game Overview and Story Chronology

- Locations (Chronological)

- Characters and Stats

- Leveling and Formulas (Stats Guide)

- Weapons

- Armor and Accessories

- Spells

- Items (Consumables, Key Items, Crests, Coins)

- Bestiary (Enemies and Bosses, Chronological)

- Enemy Abilities

- Battlefields



## Game Overview and Story Chronology

Final Fantasy Mystic Quest (FFMQ) is a simplified RPG with a linear story. The protagonist, Benjamin, travels through regions to restore four elemental crystals (Earth, Water, Fire, Wind) corrupted by monsters. He allies with NPCs (Kaeli, Tristam, Phoebe, Reuben) who join/leave the party at fixed points. The game features dungeons, bosses, optional battlefields for rewards, and a charge-based magic system.



**Story Chronology**: Structured blocks per location in game order, detailing order, story beats (key events), party changes, enemies, boss (if any), items/weapons/armor/spells obtained. Data cleaned from Mystic_Quest_Story_Chronology.txt for clarity and completeness, integrated with Locations_Chronological.csv.



**LOCATION: Hill of Destiny**  

- **Order**: 1  

- **Story Beats**: Benjamin fights Behemoth after an earthquake. A cloaked figure (Old Man) advises saving the Crystal of Earth and meeting in Level Forest. Benjamin automatically proceeds to Level Forest.  

- **Party Changes**: Solo start with Benjamin.  

- **Enemies**: None (tutorial area).  

- **Boss**: Behemoth (HP: 80, EXP: 84, GP: 3; Attacks: Horn).  

- **Items**: None.  

- **Weapons**: Steel Sword (initial).  

- **Armor**: Steel Armor (initial).  

- **Spells**: None initially.



**LOCATION: Level Forest**  

- **Order**: 2 (first visit), 4 (second visit with Kaeli)  

- **Story Beats**: Old Man directs Benjamin to save Crystal of Earth. Push a stone to clear path. Collect potions. Kaeli (in Foresta) joins after showing Tree Wither. She cuts trees for progress. Fight Minotaur, who poisons Kaeli. Volunteer to get Elixir from Sand Temple. Access Brownie and Heal Potion by cutting trees.  

- **Party Changes**: Kaeli joins temporarily; gains Axe ability to cut trees. Party leaves after boss.  

- **Enemies**: Brownie, Slime.  

- **Boss**: Minotaur (HP: 240, EXP: 102, GP: 30; Attacks: Axe, Roundhouse, Scream).  

- **Items**: Cure Potion(s), Heal Potion(s), Tree Wither, Elixir.  

- **Weapons**: Axe.  

- **Armor**: None.  

- **Spells**: Cure, Exit, Heal, Life.



**LOCATION: Foresta**  

- **Order**: 3  

- **Story Beats**: Enter tree homes. Learn Cure spell. Cross bridge, talk to residents. Show Tree Wither to Kaeli to recruit her. Exit to return to Level Forest.  

- **Party Changes**: Kaeli joins party.  

- **Enemies**: None (town).  

- **Boss**: None.  

- **Items**: Cure Potion(s), Tree Wither.  

- **Weapons**: None.  

- **Armor**: None.  

- **Spells**: Cure, Exit, White.



**LOCATION: Battlefield (North of Level Forest)**  

- **Order**: 5  

- **Story Beats**: Optional; fight 10 sets of enemies for 54 EXP reward.  

- **Party Changes**: None.  

- **Enemies**: Mad Plant, Poison Toad.  

- **Boss**: None.  

- **Items**: 54 EXP.  

- **Weapons**: None.  

- **Armor**: None.  

- **Spells**: None.



**LOCATION: Sand Temple**  

- **Order**: 6  

- **Story Beats**: Tristam joins after giving Elixir. Exit temple.  

- **Party Changes**: Tristam joins party.  

- **Enemies**: None.  

- **Boss**: None.  

- **Items**: Elixir.  

- **Weapons**: None.  

- **Armor**: None.  

- **Spells**: Exit.



**LOCATION: Battlefield (West/East of Sand Temple)**  

- **Order**: 7  

- **Story Beats**: Optional clears for rewards: Charm (West), 150 GP (East).  

- **Party Changes**: None.  

- **Enemies**: Poison Toad, Mad Plant, Basilisk, Minotaur Zombie.  

- **Boss**: None.  

- **Items**: Charm, 150 GP.  

- **Weapons**: None.  

- **Armor**: None.  

- **Spells**: None.



**LOCATION: Bone Dungeon**  

- **Order**: 5 (main visit)  

- **Story Beats**: Explore with Tristam. Defeat Flamerus Rex to restore Earth Crystal. Tristam takes treasure but gives Elixir.  

- **Party Changes**: Tristam in party.  

- **Enemies**: Basilisk, others.  

- **Boss**: Flamerus Rex (HP: 2200, EXP: 120, GP: 0; Attacks: Bone Missile, Twin Fang, Rip Earth, Sleep Powder, Chew Off, Poison Flour).  

- **Items**: Steel Shield.  

- **Weapons**: Bomb.  

- **Armor**: Steel Shield.  

- **Spells**: Quake.



**LOCATION: Libra Temple**  

- **Order**: 7  

- **Story Beats**: Obtain Wakewater from old man to thaw a plant in Aquaria.  

- **Party Changes**: None.  

- **Enemies**: None (town).  

- **Boss**: None.  

- **Items**: Wakewater.  

- **Weapons**: None.  

- **Armor**: None.  

- **Spells**: None.



**LOCATION: Aquaria**  

- **Order**: 8  

- **Story Beats**: Use Wakewater to thaw plant. Purchase Steel Helm (200 GP). Progress to Wintry Cave.  

- **Party Changes**: None initially; Phoebe joins later in Wintry Cave.  

- **Enemies**: None (town).  

- **Boss**: None.  

- **Items**: None.  

- **Weapons**: None.  

- **Armor**: Steel Helm.  

- **Spells**: None.



**LOCATION: Wintry Cave**  

- **Order**: 9  

- **Story Beats**: Phoebe joins party. Defeat Squidite to obtain Libra Crest.  

- **Party Changes**: Phoebe joins party.  

- **Enemies**: Various (e.g., Giant Toad).  

- **Boss**: Squidite (HP: 1500, abilities: 6 Psudopods, Blackness, Choke Up, Sucker Stick).  

- **Items**: Libra Crest.  

- **Weapons**: Cat Claw (gift from Phoebe).  

- **Armor**: None.  

- **Spells**: None.



**LOCATION: Life Temple**  

- **Order**: 10  

- **Story Beats**: Progress through story; no specific items or bosses detailed.  

- **Party Changes**: None.  

- **Enemies**: None (temple).  

- **Boss**: None.  

- **Items**: None.  

- **Weapons**: None.  

- **Armor**: None.  

- **Spells**: None.



**LOCATION: Falls Basin**  

- **Order**: 11  

- **Story Beats**: Phoebe gives Jumbo Bomb. Learn Heal spell.  

- **Party Changes**: Phoebe in party.  

- **Enemies**: Various.  

- **Boss**: None specified.  

- **Items**: None.  

- **Weapons**: Jumbo Bomb.  

- **Armor**: None.  

- **Spells**: Heal.



**LOCATION: Ice Pyramid**  

- **Order**: 12  

- **Story Beats**: Use Magic Mirror to reveal invisible monsters. Defeat Ice Golem for River Coin. Find Knight Sword, Noble Armor.  

- **Party Changes**: Phoebe in party.  

- **Enemies**: Various (e.g., Desert Hag, Lamia).  

- **Boss**: Ice Golem (HP: not specified, abilities: Axe Bomber, Snowstorm, Stomp Stomp).  

- **Items**: Magic Mirror, River Coin.  

- **Weapons**: Knight Sword.  

- **Armor**: Noble Armor.  

- **Spells**: None.



**LOCATION: Spencer's Place**  

- **Order**: 13  

- **Story Beats**: Tristam gives Dragon Claw, Spencer gives Venus Key. Obtain Mobius Crest via Rainbow Bridge.  

- **Party Changes**: Tristam joins/rejoins.  

- **Enemies**: None.  

- **Boss**: None.  

- **Items**: Venus Key, Mobius Crest.  

- **Weapons**: Dragon Claw.  

- **Armor**: None.  

- **Spells**: None.



**LOCATION: Wintry Temple**  

- **Order**: 14  

- **Story Beats**: Progress through story; no specific items or bosses detailed.  

- **Party Changes**: None.  

- **Enemies**: Freezer Crab, Gather.  

- **Boss**: None.  

- **Items**: None.  

- **Weapons**: None.  

- **Armor**: None.  

- **Spells**: None.



**LOCATION: Focus Tower (Multiple Visits)**  

- **Order**: 6, 15, 21  

- **Story Beats**: Central hub. Use coins (Sand, River, Sun, Sky) to access crystal rooms. Find Venus Shield.  

- **Party Changes**: Varies by visit.  

- **Enemies**: Various (e.g., Jelly).  

- **Boss**: Varies (e.g., Skullrus Rex, Dualhead Hydra).  

- **Items**: Venus Shield, Sand Coin, River Coin, Sun Coin, Sky Coin.  

- **Weapons**: None.  

- **Armor**: Venus Shield.  

- **Spells**: Blizzard, Fire, Aero.



**LOCATION: Fireburg**  

- **Order**: 16  

- **Story Beats**: Tristam gives Multi-Key. Purchase Battle Axe (500 GP). Progress to Mine.  

- **Party Changes**: Tristam in party.  

- **Enemies**: None (town).  

- **Boss**: None.  

- **Items**: Multi-Key, Gemini Crest (nearby battlefield).  

- **Weapons**: Battle Axe, Mega Grenade (gift from Arion’s friend).  

- **Armor**: None.  

- **Spells**: Thunder (battlefield reward).



**LOCATION: Mine**  

- **Order**: 17  

- **Story Beats**: Find Charm Claw.  

- **Party Changes**: None.  

- **Enemies**: Flazzard, Red Cap.  

- **Boss**: None specified.  

- **Items**: None.  

- **Weapons**: Charm Claw.  

- **Armor**: None.  

- **Spells**: None.



**LOCATION: Sealed Temple**  

- **Order**: 18  

- **Story Beats**: Progress through story; no specific items or bosses detailed.  

- **Party Changes**: None.  

- **Enemies**: None.  

- **Boss**: None.  

- **Items**: None.  

- **Weapons**: None.  

- **Armor**: None.  

- **Spells**: None.



**LOCATION: Volcano**  

- **Order**: 19  

- **Story Beats**: Use Mask to reveal monsters in gas. Find Moon Helm. Learn White spell.  

- **Party Changes**: None.  

- **Enemies**: Ghost, Red Bone, Zombie, Iflyte, Stheno.  

- **Boss**: None specified.  

- **Items**: Mask.  

- **Weapons**: None.  

- **Armor**: Moon Helm.  

- **Spells**: White.



**LOCATION: Lava Dome**  

- **Order**: 20  

- **Story Beats**: Defeat Dualhead Hydra for Sun Coin. Learn Life spell.  

- **Party Changes**: None.  

- **Enemies**: Various.  

- **Boss**: Dualhead Hydra (HP: 14000, abilities: Fire Breath, Hypno-Sleep, Scrunch, Thunder, Stone Gas).  

- **Items**: Sun Coin.  

- **Weapons**: None.  

- **Armor**: None.  

- **Spells**: Life.



**LOCATION: Rope Bridge**  

- **Order**: 22  

- **Story Beats**: Progress to Alive Forest.  

- **Party Changes**: None.  

- **Enemies**: None.  

- **Boss**: None.  

- **Items**: None.  

- **Weapons**: None.  

- **Armor**: None.  

- **Spells**: None.



**LOCATION: Alive Forest**  

- **Order**: 23  

- **Story Beats**: Find Giant's Axe.  

- **Party Changes**: Kaeli in party.  

- **Enemies**: Plant Man.  

- **Boss**: None specified.  

- **Items**: None.  

- **Weapons**: Giant's Axe.  

- **Armor**: None.  

- **Spells**: None.



**LOCATION: Giant Tree**  

- **Order**: 24  

- **Story Beats**: Learn Meteor spell.  

- **Party Changes**: None.  

- **Enemies**: Various.  

- **Boss**: None specified.  

- **Items**: None.  

- **Weapons**: None.  

- **Armor**: None.  

- **Spells**: Meteor.



**LOCATION: Kaidge Temple**  

- **Order**: 25  

- **Story Beats**: Progress through story; no specific items or bosses detailed.  

- **Party Changes**: None.  

- **Enemies**: None.  

- **Boss**: None.  

- **Items**: None.  

- **Weapons**: None.  

- **Armor**: None.  

- **Spells**: None.



**LOCATION: Light Temple**  

- **Order**: 26  

- **Story Beats**: Progress through story; no specific items or bosses detailed.  

- **Party Changes**: None.  

- **Enemies**: None.  

- **Boss**: None.  

- **Items**: None.  

- **Weapons**: None.  

- **Armor**: None.  

- **Spells**: None.



**LOCATION: Windia**  

- **Order**: 27  

- **Story Beats**: Purchase Cupid Locket (300 GP). Progress to Windhole Temple.  

- **Party Changes**: None.  

- **Enemies**: None (town).  

- **Boss**: None.  

- **Items**: None.  

- **Weapons**: None.  

- **Armor**: Cupid Locket.  

- **Spells**: None.



**LOCATION: Windhole Temple**  

- **Order**: 28  

- **Story Beats**: Progress to Mount Gale.  

- **Party Changes**: None.  

- **Enemies**: Vampire, Water Hag.  

- **Boss**: None specified.  

- **Items**: None.  

- **Weapons**: None.  

- **Armor**: None.  

- **Spells**: None.



**LOCATION: Mount Gale**  

- **Order**: 29  

- **Story Beats**: Find Apollo Helm.  

- **Party Changes**: None.  

- **Enemies**: None specified.  

- **Boss**: None specified.  

- **Items**: None.  

- **Weapons**: None.  

- **Armor**: Apollo Helm.  

- **Spells**: None.



**LOCATION: Pazuzu's Tower**  

- **Order**: 30  

- **Story Beats**: Defeat Pazuzu for Sky Coin. Find Excalibur. Learn Flare spell.  

- **Party Changes**: None.  

- **Enemies**: Various.  

- **Boss**: Pazuzu (HP: 15000, abilities: Sky Attack, Stone Beak, Windstorm).  

- **Items**: Sky Coin.  

- **Weapons**: Excalibur.  

- **Armor**: None.  

- **Spells**: Flare.



**LOCATION: Ship Dock**  

- **Order**: 31  

- **Story Beats**: Progress to Mac's Ship.  

- **Party Changes**: None.  

- **Enemies**: None.  

- **Boss**: None.  

- **Items**: None.  

- **Weapons**: None.  

- **Armor**: None.  

- **Spells**: None.



**LOCATION: Mac's Ship**  

- **Order**: 32  

- **Story Beats**: Find Gaia's Armor. Use Captain's Cap to progress.  

- **Party Changes**: None.  

- **Enemies**: None specified.  

- **Boss**: None specified.  

- **Items**: Captain's Cap.  

- **Weapons**: None.  

- **Armor**: Gaia's Armor.  

- **Spells**: None.



**LOCATION: Doom Castle**  

- **Order**: 33  

- **Story Beats**: Confront Dark King (4 forms) to complete the game. Find Aegis Shield.  

- **Party Changes**: Varies (typically Benjamin + ally).  

- **Enemies**: Shadow, Gorgon, Minotaur Zombie, Phanquid, Iflyte, Cerberus, others.  

- **Boss**: Dark King (4 forms, HP: 40000 each; Attacks: Dark Cane, Fire Sword, Ice Sword, Dark Sabre, Mirror Sword, Quake Axe, Cure Arrow, Lazer, Spider Kids, Silver Web, Golden Web, Mega Flare, Mega White).  

- **Items**: Aegis Shield, Arrow(s), Refresher(s), Heal Potion(s).  

- **Weapons**: None.  

- **Armor**: Aegis Shield.  

- **Spells**: None.



## Locations (Chronological)

From Locations_Chronological.csv, for quick reference:



1. Hill of Destiny

2. Level Forest

3. Foresta

4. Sand Temple

5. Bone Dungeon

6. Focus Tower

7. Libra Temple

8. Aquaria

9. Wintry Cave

10. Life Temple

11. Falls Basin

12. Ice Pyramid

13. Spencer's Place

14. Wintry Temple

15. Focus Tower

16. Fireburg

17. Mine

18. Sealed Temple

19. Volcano

20. Lava Dome

21. Focus Tower

22. Rope Bridge

23. Alive Forest

24. Giant Tree

25. Kaidge Temple

26. Light Temple

27. Windia

28. Windhole Temple

29. Mount Gale

30. Pazuzu's Tower

31. Ship Dock

32. Mac's Ship

33. Doom Castle



## Characters and Stats

From ffmq_character_stats.csv. Stats at specific levels/joins. Benjamin levels up; others fixed.



- **Benjamin (Level 1)**: Life 40, Attack 7, Defense 6, Speed 8, Magic 10, Accuracy 75, Evade 0, MagicLeftWhite 3, MagicLeftBlack 1, MagicLeftWizard 0. Equipment: Steel Sword, Steel Armor. Spells: None. SourceURL: https://finalfantasy.fandom.com/wiki/Benjamin

- **Kaeli (Level 3 first join)**: Life 120, Attack 11, Defense 11, Speed 11, Magic 9, Accuracy 76, Evade 0, MagicLeftWhite 3, MagicLeftBlack 0, MagicLeftWizard 0. Equipment: Axe, Relica Armor, Magic Ring. Spells: Life. SourceURL: https://finalfantasy.fandom.com/wiki/Kaeli

- **Kaeli (Level 31 rejoin)**: Life 1280, Attack 96, Defense 73, Speed 77, Magic 55, Accuracy 90, Evade 0, MagicLeftWhite 35, MagicLeftBlack 17, MagicLeftWizard 0. Equipment: Giant's Axe, Steel Helm, Relica Armor, Magic Ring. Spells: Cure, Heal, Life, Aero. SourceURL: https://finalfantasy.fandom.com/wiki/Kaeli

- **Tristam (Level 7 first)**: Life 360, Attack 23, Defense 10, Speed 28, Magic 16, Accuracy 78, Evade 5, MagicLeftWhite 7, MagicLeftBlack 0, MagicLeftWizard 0. Equipment: Ninja Star, Moon Helm, Black Robe. Spells: Life. SourceURL: https://finalfantasy.fandom.com/wiki/Tristam

- **Tristam (Level 23 rejoin)**: Life 1120, Attack 68, Defense 31, Speed 80, Magic 26, Accuracy 86, Evade 5, MagicLeftWhite 23, MagicLeftBlack 0, MagicLeftWizard 0. Equipment: Ninja Star, Moon Helm, Black Robe, Charm. Spells: Life. SourceURL: https://finalfantasy.fandom.com/wiki/Tristam

- **Phoebe (Level 15 first)**: Life 680, Attack 47, Defense 20, Speed 36, Magic 49, Accuracy 82, Evade 0, MagicLeftWhite 21, MagicLeftBlack 10, MagicLeftWizard 5. Equipment: Cat Claw, Bow of Grace, Arrow, Mystic Robe, Magic Ring. Spells: Cure, Heal, Life, Fire, Thunder. SourceURL: https://finalfantasy.fandom.com/wiki/Phoebe_(Mystic_Quest)

- **Phoebe (Level 34 rejoin)**: Life 1480, Attack 70, Defense 39, Speed 66, Magic 94, Accuracy 92, Evade 0, MagicLeftWhite 40, MagicLeftBlack 20, MagicLeftWizard 10. Equipment: Bow of Grace, Arrow, Ether Shield, Steel Helm, Mystic Robe, Magic Ring. Spells: Cure, Heal, Life, Blizzard, Fire, Aero, Thunder, White. SourceURL: https://finalfantasy.fandom.com/wiki/Phoebe_(Mystic_Quest)

- **Reuben (Level 23 first)**: Life 1040, Attack 84, Defense 61, Speed 61, Magic 35, Accuracy 86, Evade 0, MagicLeftWhite 23, MagicLeftBlack 0, MagicLeftWizard 0. Equipment: Morning Star, Steel Helm, Flame Armor, Charm. Spells: Life. SourceURL: https://finalfantasy.fandom.com/wiki/Reuben

- **Reuben (Level 31 rejoin)**: Life 1320, Attack 99, Defense 68, Speed 70, Magic 41, Accuracy 90, Evade 0, MagicLeftWhite 31, MagicLeftBlack 0, MagicLeftWizard 7. Equipment: Morning Star, Steel Helm, Flame Armor, Charm. Spells: Life, White. SourceURL: https://finalfantasy.fandom.com/wiki/Reuben



## Leveling and Formulas (Stats Guide)

From Final_Fantasy_Mystic_Quest_stats_guide.txt. Benjamin-only leveling (cap 41). Allies fixed.



**Scope**: Stats apply to party members and enemies. Benjamin levels; allies fixed. EXP accrues post-cap for potential Magic Left boosts.



**Level-Up Gains (Benjamin)**:  

- Life: +40 per level  

- Attack: +2.5 per level  

- Defense: +2 per level  

- Speed: +2 per level  

- Magic: +1 per level  

- Accuracy: +0.5 per level  

- On level-up, HP scales to maintain same percentage filled.



**Experience**:  

- EXP to Next Level: `13 * (Level ** 3) + 61 * (Level ** 2)`  # Level = current  

- Post-Cap: Every 10,000,000 EXP may add +2 or +3 to each Magic Left category (up to 99).



**Magic Left**: Charges per school. Spells cost 1 charge. Benjamin max typical at cap: White 42, Black 21, Wizard 10.



**Stat Definitions**:  

- **Level**: Character level (Benjamin only).  

- **Life (HP)**: Hit points; 0 = KO.  

- **Magic Left**: White/Black/Wizard charges.  

- **Attack**: Physical damage base.  

- **Defense**: Reduces damage.  

- **Speed**: Turn order; +5 from some gear.  

- **Magic**: Magic damage power; +5 from some gear.  

- **Accuracy**: Hit chance.  

- **Evade**: Dodge/run chance.



**Displayed Attack (Benjamin, floored)**:  

`Attack_Display = floor( (Level * 2.5 + 5) + (Speed - (Level * 2 + 6)) / 2 + WeaponAttack )`



**Physical Damage (Single Hit)**:  

`DamageBeforeClamp = (Attack * 4) - Defense`  

`FinalDamage = max(0, round(DamageBeforeClamp * weakness / split))`



**Black Magic Damage**:  

`Damage = max(0, round( ((SpellPower * 4) + (Magic * 3) - Defense) * weakness / split ))`



**Wizard Magic Damage**:  

`Damage = max(0, round( ((SpellPower * 6) + (Magic * 9) - (Defense * 2)) * weakness / split ))`



**Variables**:  

- weakness: Elemental modifier (e.g., 2.0 weak, 1.0 neutral, 0.5 resist).  

- split: Damage split factor (1 single-target, 2 multi-target).



**Equipment Modifiers (Examples)**:  

- **Attack +5**: Steel Helm, Moon Helm, Apollo Helm.  

- **Speed +5**: Knight Sword, Excalibur, Ninja Star, Bow of Grace, Steel Shield, Venus Shield, Aegis Shield, Black Robe, Ether Shield.  

- **Magic +5**: Cat Claw, Charm Claw, Dragon Claw, Charm, Magic Ring, Cupid Locket.



**Examples**:  

1. **Physical (neutral, single-target)**: Attack=120, Defense=60, weakness=1.0, split=1  

   `Damage = max(0, round((120 * 4 - 60) * 1 / 1)) = 420`  

2. **Black Magic (weak, multi-target)**: SpellPower=135, Magic=60, Defense=50, weakness=2.0, split=2  

   `Damage = max(0, round(((135 * 4) + (60 * 3) - 50) * 2 / 2)) = 670 per target`  

3. **Wizard Magic (resistant, single-target)**: SpellPower=200, Magic=70, Defense=80, weakness=0.5, split=1  

   `Damage = max(0, round(((200 * 6) + (70 * 9) - (80 * 2)) * 0.5 / 1)) = 835`



**Notes**: Rounding and regional/version differences may affect exact results. Weakness/split values are data-driven per action/target.



## Weapons

From Final_Fantasy_Mystic_Quest_weapons.csv.



| Category | Name | BasePower | AttackPower | Obtained | Notes |

|----------|------|-----------|-------------|----------|-------|

| Swords | Steel Sword | 5 | 12.5~117.5 | Initial: Benjamin | |

| Swords | Knight Sword | 45 | 55~160 | Find: Ice Pyramid | Speed +5 |

| Swords | Excalibur | 125 | 135~240 | Find: Pazuzu's Tower | Speed +5 |

| Axes | Axe | 9 | 16.5~121.5 (Kaeli 20) | Gift: Kaeli (after defeating Minotaur in Level Forest) | Axe-elemental |

| Axes | Battle Axe | 62.5 | 70~175 | Buy: Fireburg - 500 GP | Axe-elemental |

| Axes | Giant's Axe | 105 | 112.5~217.5 (Kaeli 194) | Find: Alive Forest | Axe-elemental |

| Claws | Cat Claw | 2.5 | 10~115 (Phoebe 44) | Gift: Phoebe (Wintry Cave) | Magic +5. Can inflict Poison; Paralyze |

| Claws | Charm Claw | 37.5 | 45~150 | Find: Mine | Magic +5. Can inflict Poison; Paralyze; Sleep; Confuse; Blind |

| Claws | Dragon Claw | 80 | 87.5~192.5 | Gift: Tristam (Spencer's Place) | Magic +5. Can inflict Poison; Paralyze; Sleep; Confuse; Blind; Petrify; Silence |

| Bombs | Bomb | 63 | - | Buy: Tristam (Bone Dungeon) | Bomb-elemental |

| Bombs | Jumbo Bomb | 112.5 | - | Gift: Phoebe (Falls Basin) | Bomb-elemental |

| Bombs | Mega Grenade | 162 | - | Gift: Arion's friend (Fireburg) | Bomb-elemental |

| Other | Morning Star | 100 | 107.5~212.5 (175 1st time; 187 2nd time) | Initial: Reuben | Axe-elemental |

| Other | Ninja Star | 20 | 27~152 (48 1st time; 93 2nd time) | Initial: Tristam | Shoot-elemental. Speed +5. Can inflict Poison; Paralyze |

| Other | Bow of Grace (Arrow) | 40 | 47~172 (87 1st time; 115 2nd time) | Initial: Phoebe (after giving Benjamin Cat Claw) | Shoot-elemental. Speed +5. Can inflict Blind |

| Other | Bare Hands | Current Power/2 | Varies | Used when a character runs out of Ammo for their weapon | Only available to Benjamin; Tristam; Phoebe |



## Armor and Accessories

From Final_Fantasy_Mystic_Quest_armor.csv.



| Category | Name | Defense | Evade | Obtained | Notes |

|----------|------|---------|-------|----------|-------|

| Helmet | Steel Helm | 4 | 5 | Buy: Aquaria for 200 GP | Attack +5 |

| Helmet | Moon Helm | 9 | 9 | Found: Lava Dome | Attack +5. Resist Fire |

| Helmet | Apollo Helm | 15 | 15 | Found: Mount Gale | Attack +5. Resist Fire |

| Body Armor | Steel Armor | 6 | 4 | Initial: Benjamin | |

| Body Armor | Noble Armor | 12 | 10 | Found: Ice Pyramid | Resist Water and Poison |

| Body Armor | Gaia's Armor | 15 | 11 | Found: Mac's Ship | Resist Water, Wind, Thunder, Poison, Sleep |

| Shield | Steel Shield | 5 | 6 | Found: Bone Dungeon | Speed +5 |

| Shield | Venus Shield | 10 | 12 | Found: Focus Tower | Speed +5. Resist Paralyze |

| Shield | Aegis Shield | 14 | 14 | Found: Doom Castle | Speed +5. Resist Paralyze and Petrify |

| Accessory | Charm | 1 | 1 | Reward: Battlefield north of Level Forest | Magic +5 |

| Accessory | Magic Ring | 3 | 3 | Reward: Battlefield west of Aquaria | Magic +5. Resist Silence |

| Accessory | Cupid Locket | 6 | 6 | Buy: Windia for 300 GP | Magic +5. Resist Silence, Blind, Confusion |

| NPC Armor | Black Robe | 13 | 15 | Initial: Tristam | Speed +5. Resist Fatal |

| NPC Armor | Flame Armor | 14 | 14 | Initial: Reuben | Resist Fire |

| NPC Armor | Mystic Robe | 13 | 12 | Initial: Phoebe | Resist Water, Wind, Thunder |

| NPC Armor | Relica Armor | 15 | 15 | Initial: Kaeli | Resist Water and Petrify |

| NPC Armor | Ether Shield | 12 | 12 | Initial: Phoebe (upon rejoining) | Speed +5. Resist Paralyze, Sleep, Drain |



## Spells

From Final_Fantasy_Mystic_Quest_spells.csv.



| School | Spell | SpellPower | Element | Found | Field Effect | Battle Effect |

|--------|-------|------------|---------|-------|--------------|---------------|

| White | Exit | - | - | Battlefield north of Libra Temple | Warp to world map | Removes one enemy; no EXP/GP; no effect on bosses |

| White | Cure | 50 | Restorative/Undead | Foresta | Restore HP | Damages undead; reflectable (no party effect) |

| White | Heal | - | - | Falls Basin | Remove status ailments | Inflicts one status on enemy (Poison/Confuse/Sleep/Paralyze/Petrify) |

| White | Life | - | - | Lava Dome | Revive to full HP; heals HP/status | Fatal vs enemies (bug); JP/EU: Fatal vs undead only |

| Black | Quake | 25*3 | Earth | Bone Dungeon | - | All enemies; reflectable |

| Black | Blizzard | 135 | Water | Focus Tower | - | Single or all; reflectable |

| Black | Fire | 85 | Fire | Focus Tower | - | Single or all; reflectable |

| Black | Aero | 235 | Wind | Focus Tower | - | Single or all; reflectable |

| Wizard | Thunder | 180 | Lightning | Battlefield far west of Fireburg | - | Single or all; reflectable |

| Wizard | White | 140*3 | Non-elemental | Volcano | - | Reflectable |

| Wizard | Meteor | 170*3 | Earth | Giant Tree | - | All enemies; reflectable |

| Wizard | Flare | 200*3 | Fire | Pazuzu's Tower | - | Reflectable |



## Items (Consumables, Key Items, Crests, Coins)

From Final_Fantasy_Mystic_Quest_items.csv.



**Consumables**:  

- **Cure**: Restores target's HP.  

- **Heal**: Removes target's status ailments.  

- **Refresher**: Restores stat(s) losses during battle.  

- **Seed**: Fully restores target's MP.



**Key Items**:  

- **Captain's Cap**: Given by Kaeli, give to Captain Mac.  

- **Elixir**: Given by Tristam after Bone Dungeon, cures Kaeli.  

- **Magic Mirror**: Found in Ice Pyramid, reveals invisible monsters.  

- **Mask**: Found on Volcano slopes, reveals monsters in gas.  

- **Multi-Key**: Given by Tristam in Fireburg, unlocks door.  

- **Thunder Rock**: Given by Reuben's father Arion, powers Rainbow Bridge Machine.  

- **Tree Wither**: Given by old man in Level Forest, convinces Kaeli.  

- **Venus Key**: Given by Spencer, unlocks Venus Shield chest in Focus Tower.  

- **Wakewater**: Given by old man in Libra Temple, thaws plant in Aquaria.



**Crests**:  

- **Libra Crest**: Found in Wintry Cave after Squidite. Enables Libra Panels.  

- **Gemini Crest**: Found in Battlefield near Fireburg. Enables Gemini Panels.  

- **Mobius Crest**: Found in Spencer's Place via Rainbow Bridge. Enables Mobius Panels.



**Coins**:  

- **Sand Coin**: Guarded by Skullrus Rex, opens Earth Door in Focus Tower.  

- **River Coin**: Guarded by Ice Golem, opens Water Door in Focus Tower.  

- **Sun Coin**: Guarded by Dualhead Hydra, opens Fire Door in Focus Tower.  

- **Sky Coin**: Guarded by Pazuzu, opens Wind Door in Focus Tower.



## Bestiary (Enemies and Bosses, Chronological)

From Monsters.csv. Complete table with all entries.



| Order | Name | Type | Locations | HP | EXP | GP | Attack | Defense | Speed | Magic | Abilities | Elemental Affinities | Status Affinities | Drops | ImageUrl | WikiUrl |

| 1 | Behemoth | Boss | Hill of Destiny | 80 | 84 | 3 | 1 | 25 | 12 | 1 | Horn | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Behemoth_(Mystic_Quest) |
| 2 | Brownie | Enemy | Level Forest | 50 | 66 | 3 | 3 | 1 | 3 | 1 | Punch; Kick | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Brownie |
| 3 | Slime | Enemy | Level Forest (left area) | 55 | 72 | 3 | 3 | 2 | 3 | 1 | Hydro Acid; Stab | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 150% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Slime_(Mystic_Quest) |
| 4 | Minotaur | Boss | Level Forest | 240 | 102 | 30 | 4 | 50 | 12 | 8 | Axe; Scream; Roundhouse | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Minotaur_(Mystic_Quest) |
| 5 | Mad Plant | Enemy | Battlefields; Sand Temple | 60 | 57 | 3 | 4 | 3 | 3 | 2 | Branch; Full Nelson | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 150%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Mad_Plant |
| 6 | Poison Toad | Enemy | Bone Dungeon | 70 | 63 | 3 | 5 | 4 | 3 | 4 | Poison Fluid; Whip Tongue | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Poison_Toad_(Mystic_Quest) |
| 7 | Basilisk | Enemy | Bone Dungeon | 93 | 81 | 3 | 8 | 6 | 6 | 5 | Claw; Fang | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Basilisk_(Mystic_Quest) |
| 8 | Sandworm | Enemy | Bone Dungeon | 140 | 99 | 3 | 9 | 8 | 3 | 6 | Scrunch; Quicksand; Poison Fluid | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 150%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 150%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Sand_Worm_(Mystic_Quest) |
| 9 | Roc | Enemy | Bone Dungeon (blocked door chest area) | 100 | 93 | 3 | 7 | 5 | 9 | 6 | Blinder; Beak | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 50%; Wind: 100%; Shoot: 150%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Roc_(Mystic_Quest) |
| 10 | Skeleton | Enemy | Bone Dungeon (bridge/teeth areas) | 120 | 93 | 3 | 9 | 10 | 8 | 6 | Head Butt; Spooky Laugh; Sword | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 150%; Wind: 100%; Shoot: 100%; Zombie: 150%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Skeleton_(Mystic_Quest) |
| 11 | Gorgon | Enemy | Bone Dungeon; Doom Castle | 150 | 114 | 3 | 11 | 11 | 12 | 8 | Bite; Body Odor; Dash; Iron Nail; Horn; Body Oder | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Gorgon_(Mystic_Quest) |
| 12 | Minotaur Zombie | Enemy | Bone Dungeon (later floor) | 240 | 120 | 30 | 13 | 13 | 13 | 10 | Axe; Blinder; Scream; Stare; Roundhouse | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 150%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Minotaur_Zombie_(Mystic_Quest) |
| 13 | Flamerus Rex | Boss | Bone Dungeon (boss room) | 2 | 120 | 0 | 70 | 60 | 32 | 28 | Bone Missile; Rip Earth; Sleep Powder; Twin Fang; Chew Off; Poison Flour | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 150%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Flamerus_Rex |
| 14 | Mintmint | Enemy | Battlefields; Libra Temple | 160 | 117 | 3 | 12 | 11 | 12 | 9 | Kick; Punch; Stare | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Mint_Mint |
| 15 | Giant Toad | Enemy | Wintry Cave | 180 | 114 | 3 | 14 | 14 | 15 | 14 | Body Odor; Poison Fluid; Whip Tongue | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Giant_Toad_(Mystic_Quest) |
| 16 | Scorpion | Enemy | Wintry Cave | 210 | 129 | 3 | 16 | 16 | 18 | 16 | Poison Sting; Rapier; Scissor; Tail | Fire: 150%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Scorpion_(Mystic_Quest) |
| 17 | Edgehog | Enemy | Wintry Cave | 220 | 135 | 3 | 17 | 21 | 19 | 10 | Blinder; Para-needle; Rapier; Sting | Fire: 150%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Edgehog |
| 18 | Land Worm | Enemy | Wintry Cave | 265 | 144 | 6 | 18 | 16 | 4 | 13 | Scrunch; Quake; Quicksand | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 150%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 150%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Land_Worm_(Mystic_Quest) |
| 19 | Centaur | Enemy | Wintry Cave | 230 | 123 | 6 | 17 | 18 | 22 | 14 | Bow & Arrow; Double Kick; Riddle | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Centaur_(Mystic_Quest) |
| 20 | Land Turtle | Enemy | Wintry Cave | 270 | 144 | 6 | 20 | 32 | 16 | 16 | Bite; Body Slam; Para-claw; Rapier | Fire: 100%; Water: 150%; Thunder: 100%; Earth: 100%; Wind: 150%; Shoot: 100%; Zombie: 100%; Axe: 150%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Land_Turtle_(Mystic_Quest) |
| 21 | Sparna | Enemy | Wintry Cave (boss supporting groups) | 260 | 153 | 6 | 19 | 17 | 26 | 18 | Sonic Scream; Beak; Tornado; Iron Nail | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 50%; Wind: 100%; Shoot: 150%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Sparna |
| 22 | Squidite | Boss | Wintry Cave | 2500 | 219 | 6 | 50 | 50 | 30 | 31 | Blackness; Chokup; Electrapulse; 6 Psudopods; Sucker Stick; Choke Up | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 50%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Squidite |
| 23 | Desert Hag | Enemy | Falls Basin; Ice Pyramid | 280 | 168 | 6 | 23 | 24 | 20 | 16 | Double Hit; Fin; Water Gun; Watergun | Fire: 150%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Desert_Hag |
| 24 | Lamia | Enemy | Falls Basin; Ice Pyramid | 300 | 150 | 6 | 21 | 18 | 18 | 20 | Gaze; Sleep Lure; Wraparound | Fire: 100%; Water: 150%; Thunder: 100%; Earth: 100%; Wind: 150%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Lamia_(Mystic_Quest) |
| 25 | Snow Crab | Enemy | Falls Basin | 3000 | 234 | 6 | 100 | 50 | 34 | 32 | Full Nelson; Giant Blade; Icy Foam; Stare; Tornado | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 150%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Snow_Crab_(Mystic_Quest) |
| 26 | Mage | Enemy | Ice Pyramid (various floors) | 330 | 186 | 6 | 21 | 10 | 21 | 25 | Blizzard; Cure; Muffle | Fire: 150%; Water: 100%; Thunder: 100%; Earth: 50%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Mage_(Mystic_Quest) |
| 27 | Phanquid | Enemy | Ice Pyramid; Doom Castle | 400 | 231 | 9 | 30 | 27 | 29 | 24 | 6 Psudopods; Blackness; Electrapulse; Sucker Stick; Ice Breath; Choke Up | Fire: 150%; Water: 50%; Thunder: 100%; Earth: 100%; Wind: 50%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Phanquid |
| 28 | Sphinx | Enemy | Ice Pyramid | 360 | 201 | 9 | 27 | 32 | 30 | 22 | Bite; Heal; Ice Breath; Riddle; Claw | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 50%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Sphinx_(Mystic_Quest) |
| 29 | Stoney Roost | Enemy | Ice Pyramid (platform rooms) | 350 | 165 | 6 | 25 | 23 | 24 | 24 | Coldness; Dive; Stone Beak | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 50%; Wind: 100%; Shoot: 150%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Stoney_Roost |
| 30 | Gather | Enemy | Ice Pyramid (central mechanic) | 360 | 192 | 9 | 24 | 27 | 25 | 26 | Blind Flash; Para-stare; Psudopod; Self Destruct; Pseudopod; Self-destruct | Fire: 100%; Water: 150%; Thunder: 100%; Earth: 100%; Wind: 150%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 150% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Gather |
| 31 | Freezer Crab | Enemy | Ice Pyramid; Doom Castle | 410 | 237 | 9 | 31 | 40 | 32 | 28 | Full Nelson; Giant Blade; Icy Fiam; Whirlwater; Icy Foam | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 150%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Freezer_Crab |
| 32 | Ice Golem | Boss | Ice Pyramid | 6500 | 246 | 0 | 80 | 48 | 41 | 48 | Axe Bomber; Hypno Sleep; Ice Block; Mega Punch; Snow Storm; Stomp Stomp; Hypno-Sleep; Snowstorm | Fire: 150%; Water: 50%; Thunder: 100%; Earth: 50%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Ice_Golem_(Mystic_Quest) |
| 33 | Jelly | Enemy | World map battlefield after Focus | 420 | 243 | 9 | 31 | 30 | 28 | 25 | Dissolve; Hydro Acid; Stab | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 150% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Jelly_(Mystic_Quest) |
| 34 | Sting Rat | Enemy | Battlefields; Fireburg | 420 | 252 | 9 | 33 | 40 | 36 | 28 | Para-needle; Poison Sting; Sting; Blinder | Fire: 100%; Water: 150%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Sting_Rat |
| 35 | Plant Man | Enemy | Mine | 460 | 258 | 9 | 34 | 33 | 34 | 30 | Bad Breath; Branch; Full Nelson; Poison Thorn | Fire: 150%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 150%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Plant_Man |
| 36 | Flazzard | Enemy | Mine | 450 | 261 | 9 | 34 | 34 | 34 | 31 | Claw; Fang; Flame; Para-claw; Para-stare | Fire: 50%; Water: 150%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Flazzard |
| 37 | Red Cap | Enemy | Mine | 480 | 294 | 12 | 36 | 36 | 38 | 32 | Hypnosleep; Kick; Punch; Stare; Hypno-Sleep | Fire: 100%; Water: 150%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Red_Cap_(Mystic_Quest) |
| 38 | Zombie | Enemy | Mine (conveyor cave) | 500 | 324 | 12 | 35 | 38 | 35 | 29 | Mucus; Para-touch; Rotten Mucus; Bad Breath; "Didn't do anything" | Fire: 100%; Water: 150%; Thunder: 100%; Earth: 100%; Wind: 150%; Shoot: 100%; Zombie: 150%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Zombie_(Mystic_Quest) |
| 39 | Red Bone | Enemy | Mine (platforms) | 510 | 315 | 12 | 39 | 40 | 38 | 34 | Head Butt; Sleep Powder; Spooky Laugh; Sword | Fire: 100%; Water: 150%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 150%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Red_Bone_(Mystic_Quest) |
| 40 | Jinn | Enemy | Mine | 6000 | 504 | 15 | 115 | 58 | 52 | 115 | Beam; Dragon Cut; Fire; Flame Pillar; Hypno-sleep | Fire: 50%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Jinn_(Mystic_Quest) |
| 41 | Ghost | Enemy | Sealed Temple / Volcano approaches | 550 | 330 | 12 | 39 | 37 | 40 | 38 | Attatch; Coldness; Confu-touch; Power Drain; Multiply; "Didn't do anything"; Attach | Fire: 100%; Water: 50%; Thunder: 100%; Earth: 50%; Wind: 100%; Shoot: 100%; Zombie: 150%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Ghost_(Mystic_Quest) |
| 42 | Nitemare | Enemy | Volcano | 535 | 330 | 12 | 40 | 43 | 46 | 35 | Bow & Arrow; Double Kick; Hypnosleep; Riddle; Hypno-Sleep | Fire: 50%; Water: 150%; Thunder: 100%; Earth: 100%; Wind: 150%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Nitemare_(Mystic_Quest) |
| 43 | Werewolf | Enemy | Volcano; Lava Dome | 555 | 354 | 12 | 41 | 45 | 44 | 38 | Bark; Body Odor; Quake; Triple Fang | Fire: 100%; Water: 150%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Were_Wolf_(Mystic_Quest) |
| 44 | Medusa | Enemy | Volcano | 6500 | 510 | 0 | 100 | 56 | 62 | 68 | Para-snake; Poison Snake; Screech Voice; Snake Head; Stone Gaze | Fire: 100%; Water: 50%; Thunder: 100%; Earth: 100%; Wind: 50%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Medusa_(Mystic_Quest) |
| 45 | Hot Wings | Enemy | Volcano / Focus approach battlefields | 450 | 261 | 9 | 43 | 42 | 48 | 40 | Cure; Dive; Flame Sweep; Stone Beak | Fire: 50%; Water: 100%; Thunder: 100%; Earth: 50%; Wind: 150%; Shoot: 150%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Hot_Wings |
| 46 | Avizzard | Enemy | Mount Gale / Windia approaches | 666 | 420 | 15 | 49 | 52 | 52 | 38 | Double Sword; Fire; Silence Song; Spooky Laugh | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 50%; Wind: 150%; Shoot: 150%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Avizzard |
| 47 | Fangpire | Enemy | Lava Dome | 600 | 381 | 15 | 46 | 44 | 48 | 40 | Drain; Sonic Boom; Tornado; Uppercut | Fire: 150%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Fangpire |
| 48 | Adamant Turtle | Enemy | Lava Dome | 630 | 420 | 15 | 47 | 70 | 44 | 40 | Blinder; Body Slam; Flame; Scrunch; Para-claw | Fire: 50%; Water: 100%; Thunder: 100%; Earth: 150%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 150%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Adamant_Turtle_(Mystic_Quest) |
| 49 | Ninja | Enemy | Lava Dome | 585 | 372 | 12 | 44 | 44 | 49 | 36 | Blowdart; Lullaby; Scimitar; Smokescreen; Blow Dart | Fire: 100%; Water: 150%; Thunder: 100%; Earth: 100%; Wind: 150%; Shoot: 150%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Ninja_(Mystic_Quest) |
| 50 | Stheno | Enemy | Lava Dome; Doom Castle | 630 | 432 | 15 | 47 | 48 | 51 | 43 | Bad Breath; Para-claw; Screech Voice; Stone Gaze; Snake Head | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 150%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Stheno_(Mystic_Quest) |
| 51 | Salamand | Enemy | Lava Dome | 640 | 411 | 15 | 50 | 48 | 49 | 46 | Claw; Fang; Poison Breath; Flame; Thunder | Fire: 50%; Water: 150%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Salamand_(Mystic_Quest) |
| 52 | Iflyte | Enemy | Lava Dome; Doom Castle | 660 | 420 | 12 | 50 | 49 | 50 | 45 | Dragon Cut; Flame Sweep; Hypno-sleep; Flame; Flame Pillar; Beam; Bearhug | Fire: 50%; Water: 150%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Iflyte_(Mystic_Quest) |
| 53 | Pazuzu | Boss | Pazuzu's Tower | 25000 | 618 | 0 | 100 | 95 | 78 | 93 | Hurricane; Piledriver; Psycheshield; Sky Attack; Windstorm; PsychShield; Stone Beak | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 50%; Wind: 150%; Shoot: 150%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Pazuzu_(Mystic_Quest) |
| 54 | Dualhead Hydra | Boss | Lava Dome | 14000 | 429 | 0 | 125 | 145 | 60 | 115 | Fire Breath; Para-breath; Poison Breath; Scrunch; Stone Gas; Poisonbreath; Thunder | Fire: 50%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Dualhead_Hydra |
| 55 | Mad Toad | Enemy | Lava Dome | 740 | 480 | 18 | 55 | 56 | 57 | 48 | Body Odor; Electrapulse; Poison Fluid; Stone Gaze; Whip Tongue; Poison-touch | Fire: 100%; Water: 150%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Mad_Toad_(Mystic_Quest) |
| 56 | Mummy | Enemy | Focus Tower / Doom Castle lower | 685 | 459 | 15 | 51 | 56 | 53 | 46 | Body Slam; Neck Choke; Poison Flour; Stone Gaze; Multiply; Sleep Powder | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 150%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Mummy_(Mystic_Quest) |
| 57 | Specter | Enemy | Focus Tower (ghost rooms) | 690 | 453 | 15 | 49 | 47 | 52 | 46 | Attatch; Double-hit; Power Drain; Multiply; Coldness; Double Hit; Attach; Confu-touch | Fire: 100%; Water: 50%; Thunder: 100%; Earth: 50%; Wind: 150%; Shoot: 150%; Zombie: 150%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Specter_(Mystic_Quest) |
| 58 | Live Oak | Enemy | Giant Tree | 710 | 447 | 15 | 52 | 53 | 51 | 44 | Branch; Corrode Gas; Full Nelson; Poison Thorn; Electrapulse | Fire: 150%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 150%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Live_Oak |
| 59 | Snipion | Enemy | Giant Tree | 690 | 459 | 18 | 51 | 55 | 56 | 52 | Doom Powder; Poison Sting; Twin Shears; Tail; Scissors | Fire: 150%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Snipion |
| 60 | Leech | Enemy | Giant Tree | 745 | 504 | 18 | 54 | 56 | 52 | 45 | Firebal; Quicksand; Quake; Scrunch; Fireball; Poison Sting; Drain | Fire: 50%; Water: 100%; Thunder: 100%; Earth: 150%; Wind: 150%; Shoot: 100%; Zombie: 100%; Axe: 150%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Leech_(Mystic_Quest) |
| 61 | Ooze | Enemy | Doom Castle (slime pools) | 750 | 540 | 18 | 57 | 58 | 59 | 49 | Dissolve; Hydro Acid; Spark; Stab; Thunder Beam | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 150% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Ooze_(Mystic_Quest) |
| 62 | Skuldier | Enemy | Doom Castle (armory) | 750 | 513 | 18 | 57 | 61 | 57 | 50 | Doom Powder; Headbutt; Spooky Laugh; Sword; Head Butt; Sleep Powder | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 150%; Shoot: 150%; Zombie: 150%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Skuldier_(Mystic_Quest) |
| 63 | Gidrah | Enemy | Doom Castle (mid-late) | 13 | 729 | 18 | 130 | 75 | 78 | 80 | Para-gas; Stone Gas; Three Heads; Tornado; Para Gas; Quake; Poison-touch | Fire: 50%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 150%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Gidrah |
| 64 | Water Hag | Enemy | Doom Castle (water sections) | 765 | 576 | 18 | 57 | 60 | 60 | 45 | Cure; Fin; Neck Choke; Whirlwater; Head Butt; Watergun | Fire: 150%; Water: 50%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Water_Hag_(Mystic_Quest) |
| 65 | Vampire | Enemy | Mount Gale | 780 | 561 | 18 | 59 | 57 | 62 | 54 | Blizzard; Cure; Drain; Sonic Boom; Typhoon; Uppercut | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 150%; Shoot: 150%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Vampire_(Mystic_Quest) |
| 66 | Dullahan | Enemy | Mount Gale | 14000 | 750 | 21 | 160 | 85 | 72 | 83 | Doom Dance; Hypno-sleep; Headdoomerang; Rapier; Thunder Beam; Headoomerang | Fire: 50%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Dullahan_(Mystic_Quest) |
| 67 | Garuda | Enemy | Focus Tower (sky sections) | 825 | 588 | 18 | 61 | 61 | 69 | 52 | Beak; Iron Nail; Muffle; Typhoon; Blinder | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 50%; Wind: 150%; Shoot: 150%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Garuda_(Mystic_Quest) |
| 68 | Beholder | Enemy | Focus Tower (eye rooms) | 810 | 576 | 18 | 61 | 63 | 60 | 57 | Blind Flash; Doom Gaze; Psudopod; Selfdestruct; Thunder Beam; Pseudopod; Self-destruct | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 150% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Beholder_(Mystic_Quest) |
| 69 | Manticor | Enemy | Pazuzu's Tower | 840 | 612 | 21 | 63 | 70 | 68 | 55 | Bite; Fireball; Quake; Stone Gaze; Thunder; Blinder; Stone Gas | Fire: 50%; Water: 150%; Thunder: 100%; Earth: 50%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Manticor_(Mystic_Quest) |
| 70 | Chimera | Enemy | Focus Tower (final sections) | 870 | 684 | 21 | 65 | 66 | 69 | 58 | Para-gas; Quake; Sonic Boom; Tornado; Thunder; Para Gas; Stone Gas; Poison-touch | Fire: 50%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 150%; Shoot: 150%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Chimera_(Mystic_Quest) |
| 71 | Gargoyle | Enemy | Focus Tower (gargoyle rooms) | 888 | 669 | 21 | 66 | 73 | 70 | 58 | Drain; Silence Song; Stone Beak; Thunder; Double Sword; Blizzard | Fire: 100%; Water: 50%; Thunder: 100%; Earth: 50%; Wind: 150%; Shoot: 150%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Gargoyle_(Mystic_Quest) |
| 72 | Thanatos | Enemy | Pazuzu's Tower; Doom Castle | 900 | 654 | 21 | 67 | 68 | 68 | 57 | Cure; Doom Dance; Headoomerang; Muffle; Rapier; Thunder Beam; Hypno-Sleep | Fire: 100%; Water: 150%; Thunder: 100%; Earth: 100%; Wind: 150%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Thanatos_(Mystic_Quest) |
| 73 | Sorcerer | Enemy | Focus Tower (mage towers) | 840 | 627 | 21 | 59 | 56 | 70 | 65 | Blizzard; Cure; Quake; Thunder; Muffle | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 50%; Wind: 150%; Shoot: 150%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Sorcerer_(Mystic_Quest) |
| 74 | Naga | Enemy | Pazuzu's Tower | 870 | 627 | 21 | 65 | 65 | 67 | 60 | Silence Song; Sleep Lure; Thunder; Wraparound; Gaze | Fire: 100%; Water: 150%; Thunder: 100%; Earth: 100%; Wind: 150%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Naga_(Mystic_Quest) |
| 75 | Shadow | Enemy | Mac's Ship; Doom Castle | 925 | 675 | 21 | 70 | 67 | 78 | 56 | Blow Dart; Doom Dance; Scimitar; Smokescreen; Multiply; "Didn't do anything"; Self-destruct | Fire: 100%; Water: 150%; Thunder: 100%; Earth: 100%; Wind: 150%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Shadow_(Mystic_Quest) |
| 76 | Stone Golem | Enemy | Doom Castle | 10000 | 762 | 0 | 5 | 98 | 99 | 98 | Axe Bomber; Hypno Sleep; Ice Block; Mega Punch; Snow Storm; Stomp Stomp; Thunder; Stone Block; Stare; Corrode Gas | Fire: 50%; Water: 100%; Thunder: 100%; Earth: 50%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Stone_Golem_(Mystic_Quest) |
| 77 | Twinhead Wyvern | Boss | Doom Castle | 15000 | 600 | 0 | 235 | 90 | 108 | 250 | Fire Breath; Para-breath; Poison Breath; Scrunch; Stone Gas; Poisonbreath; Thunder; Bite; Tornado | Fire: 50%; Water: 150%; Thunder: 100%; Earth: 100%; Wind: 150%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Twinhead_Wyvern |
| 78 | Skullrus Rex | Boss | Focus Tower (ancient bone room) | 10 | 759 | 0 | 10 | 180 | 98 | 96 | Bone Missile; Rip Earth; Sleep Powder; Twin Fang; Stone Gas; Quake; Poison Flour | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 150%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Skullrus_Rex |
| 79 | Cerberus | Enemy | Doom Castle | 935 | 675 | 21 | 70 | 71 | 72 | 64 | Triple Fang; Confu-touch; Power Drain; Stone Gaze; Quake; Bark; Petri-touch; Fireball | Fire: 150%; Water: 100%; Thunder: 100%; Earth: 100%; Wind: 100%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Cerberus_(Mystic_Quest) |
| 80 | Zuh | Boss | Doom Castle | 20000 | 750 | 0 | 240 | 95 | 100 | 98 | Hurricane; Piledriver; Psycheshield; Sky Attack; Windstorm; Doom Dance; PsychShield | Fire: 100%; Water: 100%; Thunder: 100%; Earth: 50%; Wind: 150%; Shoot: 150%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Zuh |
| 81 | Dark King (1st Form) | Boss | Doom Castle (throne room) | 40 | 0 | 0 | 50 | 120 | 86 | 75 | Dark Sabre; Fire Sword; Ice Sword; Golden Web; Mirror Sword; Mega Flare; Mega White; Quake Axe; Spark; Spider Kids; Super Stab; Dark Cane; Iron Nail; Para-stare | Fire: 100%; Water: 50%; Thunder: 100%; Earth: 50%; Wind: 50%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Dark_King_(boss) |
| 82 | Dark King (2nd Form) | Boss | Doom Castle (throne room) | 40 | 0 | 0 | 50 | 120 | 86 | 75 | Dark Sabre; Fire Sword; Ice Sword; Golden Web; Mirror Sword; Mega Flare; Mega White; Quake Axe; Spark; Spider Kids; Super Stab; Dark Cane; Iron Nail; Para-stare | Fire: 100%; Water: 50%; Thunder: 100%; Earth: 50%; Wind: 50%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Dark_King_(boss) |
| 83 | Dark King (3rd Form) | Boss | Doom Castle (throne room) | 40 | 0 | 0 | 50 | 120 | 86 | 75 | Dark Sabre; Fire Sword; Ice Sword; Golden Web; Mirror Sword; Mega Flare; Mega White; Quake Axe; Spark; Spider Kids; Super Stab; Dark Cane; Iron Nail; Para-stare | Fire: 100%; Water: 50%; Thunder: 100%; Earth: 50%; Wind: 50%; Shoot: 100%; Zombie: 100%; Axe: 100%; Bomb: 100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Dark_King_(boss) |
| 84 | Dark King (4th Form) | Boss | Doom Castle (throne room) | 40 | 0 | 0 | 50 | 120 | 86 | 75 | Dark Sabre; Fire Sword; Ice Sword; Golden Web; Mirror Sword; Mega Flare | Fire:100%; Water:50%; Thunder:100%; Earth:50%; Wind:50%; Shoot:100%; Zombie:100%; Axe:100%; Bomb:100% | Poison: Immune; Sleep: Immune; Confusion: Immune; Paralyze: Immune; Blind: Immune; Petrify: Immune; Silence: Immune; Fatal: Immune |  |  | https://finalfantasy.fandom.com/wiki/Dark_King_(boss) |
## Enemy Abilities

From Final_Fantasy_Mystic_Quest_enemy_abilities.csv. Complete table.



| Ability | AttackPower | Description | Enemies |

|---------|-------------|-------------|---------|

| 6 Psudopods | 50 | Damage attack, hits both players up to 6 times. | Squidite |

| Attach | 10 | Damage attack. | Ghost; Specter |

| Axe | 5 | Damage attack. | Minotaur; Minotaur Zombie |

| Axe Bomber | 10 | Damage. | Ice Golem; Stone Golem |

| Bad Breath | - | Inflicts Paralyze. | Plant Man; Stheno |

| Bark | 70 | Non-elemental attack. | Were Wolf |

| Beak | 5 | Damage attack. | Garuda; Roc; Sparna |

| Beam | 22 | Damage attack. | Iflyte; Jinn |

| Bearhug | 2 | Damage attack. | Iflyte |

| Bite | 10 | Damage attack. | Gorgon; Manticor; Twinhead Wyvern |

| Blackness | 75 | Non-elemental attack that can inflict Blind. | Squidite |

| Blind Flash | - | Inflicts Blind. | Beholder; Gather |

| Blinder | 75 | Non-elemental attack that can inflict Blind. | Adamant Turtle; Edgehog; Garuda; Manticor; Roc |

| Blizzard | 10 | Water attack. | Gargoyle; Mage; Sorcerer; Vampire |

| Blow Dart | 15 | Shoot attack. | Ninja; Shadow |

| Body Odor | - | Inflicts Paralyze. | Mad Toad |

| Body Slam | 10 | Damage attack. | Adamant Turtle; Land Turtle |

| Bone Missile | 6 | Non-elemental attack. | Flamerus Rex; Skullrus Rex |

| Bow & Arrow | 15 | Shoot attack. | Centaur; Nightmare |

| Branch | 5 | Damage attack. | Mad Plant; Plant Man |

| Chew Off | 1 | Damage attack. | Flamerus Rex |

| Choke Up | 50 | Damage attack. | Phanquid; Squidite |

| Claw | 5 | Damage attack. | Basilisk; Flazzard; Salamand; Sphinx |

| Coldness | 65 | Water attack. | Ghost; Specter; Stoney Roost |

| Confu-touch | - | Counters physical attacks by inflicting Confusion. | Specter |

| Corrode Gas | 50 | Inflicts Fatal. | Stone Golem; Live Oak |

| Counterattack | Varies | Counters physical attacks with an attack of their own. | Desert Hag; Water Hag |

| Cure | 0/25 | Weak/strong versions. Restores HP. | Mage; Sorcerer; Thanatos; Water Hag |

| Cure Arrow | 70 | Shoot attack to a single target and restores HP to the user. | Dark King |

| Dark Cane | 80 | Damage attack with a 100% critical hit rate. | Dark King |

| Dark Sabre | 115 | Damage attack. | Dark King |

| Dash | 20 | Damage attack. | Gorgon |

| Didn't do anything | - | Enemy skips their turn. | Ghost; Zombie; Shadow |

| Dissolve | 100 | Drain attack. | Jelly; Ooze |

| Dive | 10 | Damage attack. | Hot Wings; Stoney Roost |

Continuation of the Enemy Abilities table from Final_Fantasy_Mystic_Quest_enemy_abilities.csv, starting from where the previous file was cut off ("Doom Dance").



| Ability | AttackPower | Description | Enemies |

|---------|-------------|-------------|---------|

| Doom Dance | 200 | Non-elemental attack that can inflict Fatal. | Zuh |

| Doom Powder | - | Inflicts Fatal. | Skuldier |

| Dragon Cut | 12 | Damage attack. | Iflyte |

| Electrapulse | 75 | Thunder attack. | Phanquid |

| Fang | 10 | Damage attack. | Basilisk; Leech |

| Fin | 10 | Damage attack. | Desert Hag; Water Hag |

| Fire | 10 | Fire attack. | Salamand; Sorcerer |

| Fire Breath | 92/120 | Fire attack. Weak/strong versions. | Dualhead Hydra; Twinhead Wyvern |

| Fire Pillar | 10 | Fire attack. | Jinn |

| Flame | 15 | Fire attack. | Flazzard |

| Flame Pillar | 15 | Fire attack. | Iflyte |

| Full Nelson | 5 | Damage attack. | Freezer Crab; Mad Plant; Plant Man |

| Golden Web | - | Inflicts Paralyze. | Dark King |

| Horn | 5 | Damage attack. | Behemoth |

| Hurricane | 150 | Wind attack. | Zuh |

| Hydro Acid | 5 | Damage attack. | Slime |

| Hypno-Sleep | - | Inflicts Sleep. | Dualhead Hydra |

| Ice Sword | 115 | Water attack. | Dark King |

| Iron Nail | 115 | Damage attack. | Dark King |

| Kick | 5 | Damage attack. | Brownie |

| Lazer | 150 | Non-elemental attack. | Dark King |

| Mega Flare | 200 | Fire attack. | Dark King |

| Mega White | 200 | Non-elemental attack. | Dark King |

| Mirror Sword | 115 | Damage attack. | Dark King |

| Para-stare | - | Inflicts Paralyze. | Dark King |

| Piledriver | 150 | Damage attack. | Zuh |

| Poison Flour | - | Inflicts Poison. | Flamerus Rex |

| Punch | 5 | Damage attack. | Brownie |

| Quake Axe | 115 | Earth attack. | Dark King |

| Quicksand | 10 | Earth attack. | Sand Worm |

| Rapier | 10 | Damage attack. | Scorpion |

| Riddle | 10 | Damage attack. | Sphinx |

| Rip Earth | 10 | Earth attack. | Flamerus Rex |

| Roundhouse | 5 | Damage attack. | Minotaur |

| Scissors | 10 | Damage attack. | Scorpion |

| Scrunch | 50 | Damage attack. | Dualhead Hydra; Sand Worm; Twinhead Wyvern |

| Screech Voice | - | Inflicts Silence. | Stheno |

| Silver Web | - | Inflicts Paralyze. | Dark King |

| Sky Attack | 150 | Damage attack. | Pazuzu; Zuh |

| Sleep Lure | - | Inflicts Sleep. | Lamia |

| Sleep Powder | - | Inflicts Sleep. | Flamerus Rex; Skuldier |

| Sonic Boom | 75 | Non-elemental attack. | Vampire |

| Spark | 100 | Thunder attack. | Jelly; Ooze |

| Spider Kids | - | Non-elemental attack. | Dark King |

| Spooky Laugh | - | Inflicts Confusion. | Skuldier |

| Stab | 5 | Damage attack. | Slime |

| Stare | - | Inflicts Paralyze. | Minotaur Zombie; Red Cap |

| Stinger | 10 | Damage attack. | Mad Toad |

| Stone Beak | 10 | Damage attack that can inflict Petrify. | Pazuzu |

| Stone Gas | - | Inflicts Petrify. | Dualhead Hydra |

| Stone Gaze | - | Inflicts Petrify. | Stheno |

| Stomp Stomp | 10 | Damage attack. | Ice Golem |

| Sucker Stick | 50 | Damage attack. | Phanquid; Squidite |

| Sword | 10 | Damage attack. | Red Bone; Skuldier |

| Thunder | 10 | Thunder attack. | Dualhead Hydra; Twinhead Wyvern |

| Thunder Beam | 100 | Thunder attack. | Ooze |

| Tornado | 150 | Wind attack. | Twinhead Wyvern |

| Twin Fang | 5 | Damage attack. | Flamerus Rex |

| Typhoon | 150 | Wind attack. | Vampire |

| Uppercut | 75 | Damage attack. | Vampire |

| Watergun | 10 | Water attack. | Desert Hag; Water Hag |

| Whirlwater | 100 | Water attack. | Water Hag |

| Whip Tongue | 5 | Damage attack. | Giant Toad; Poison Toad |

| Windstorm | 150 | Wind attack. | Pazuzu |



## Battlefields

From Final_Fantasy_Mystic_Quest_battlefields.csv. Complete table.



| Location | Enemies | Reward |

|----------|---------|--------|

| North of Level Forest | Poison Toad, Mad Plant | 54 Exp |

| West of Sand Temple | Poison Toad, Mad Plant, Basilisk | Charm |

| East of Sand Temple | Sand Worm, Basilisk, Minotaur Zombie | 150 GP |

| South of Libra Temple | Mint Mint | 99 Exp |

| East of Libra Temple | Giant Toad, Mint Mint | 300 GP |

| South of Aquaria | Giant Toad, Edgehog, Mint Mint | Magic Ring |

| East of Aquaria | Giant Toad, Edgehog, Mint Mint | 99 Exp |

| West of Wintry Cave | Desert Hag | 600 GP |

| South of Ice Pyramid | Desert Hag, Lamia, Mage | 540 Exp |

| North of Libra Temple | Phanquid, Sphinx | Exit spell |

| North of Wintry Temple | Freezer Crab, Gather | 744 Exp |

| North of Focus Tower | Jelly | 900 GP |

| Further north of Focus Tower | Jelly, Sting Rat | Gemini Crest |

| East of Fireburg | Plant Man | 816 Exp |

| West of Fireburg | Flazzard, Plant Man, Sting Rat | 1200 GP |

| South of the Mine | Flazzard, Red Cap | Thunder spell |

| West of the Volcano | Ghost, Red Bone, Zombie | 1200 Exp |

| East of the Volcano | Iflyte, Stheno | 1068 Exp |

| Southwest of Windia | Ooze, Skuldier, Water Hag | 2808 Exp |

| South of Windia | Vampire, Water Hag | 2700 Exp |
