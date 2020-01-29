﻿using SmartHunter.Core.Config;
using System.Collections.Generic;

namespace SmartHunter.Config
{
    public class LocalizationConfig
    {
        [PreserveCollectionIntegrity]
        public Dictionary<string, string> Strings = new Dictionary<string, string>()
        {
            { "LOC_UNKNOWN_PLAYER", "Player" },
            { "LOC_WIDGET_MONSTER", "Monster Widget" },
            { "LOC_WIDGET_TEAM", "Team Widget" },
            { "LOC_WIDGET_PLAYER", "Player Widget" },

            { "LOC_MONSTER_NARGACUGA", "Nargacuga" },
            { "LOC_MONSTER_NAMIELLE", "Namielle" },
            { "LOC_MONSTER_SHARA_ISHVALDA", "Shara Ishvalda" },
            { "LOC_MONSTER_BANBARO", "Banbaro" },
            { "LOC_MONSTER_TIGREX", "Tigrex" },
            { "LOC_MONSTER_BRUTE_TIGREX", "Brute Tigrex" },
            { "LOC_MONSTER_ZINOGRE", "Zinogre" },
            { "LOC_MONSTER_PAOLUMU_NIGHTSHADE", "Nightshade Paolumu" },
            { "LOC_MONSTER_EBONY_ODOGARON", "Ebony Odogaron" },
            { "LOC_MONSTER_ANJANATH_FULGUR", "Fulgur Anjanath" },
            { "LOC_MONSTER_PUKEI_PUKEI_CORAL", "Coral Pukei-Pukei" },
            { "LOC_MONSTER_BRACHYDIOS", "Brachydios" },
            { "LOC_MONSTER_VELKHANA", "Velkhana" },
            { "LOC_MONSTER_BEOTODUS", "Beotodus" },
            { "LOC_MONSTER_GLAVENUS", "Glavenus" },
            { "LOC_MONSTER_ACIDIC_GLAVENUS", "Acidic Glavenus" },
            { "LOC_MONSTER_BLACKVEIL_VAAL_HAZAK", "Blackveil Vaal Hazak" },
            { "LOC_MONSTER_BARIOTH", "Barioth" },
            { "LOC_MONSTER_SAVAGE_DEVILJHO", "Savage Deviljho" },
            { "LOC_MONSTER_RUINER_NERGIGANTE", "Ruiner Nergigante" },
            { "LOC_MONSTER_VIPER_TOBI_KADACHI", "Viper Tobi Kadachi" },
            { "LOC_MONSTER_SHRIEKING_LEGIANA", "Shrieking Legiana" },
            { "LOC_MONSTER_SEETHING_BAZELGEUSE", "Seething Bazelgeuse" },
            { "LOC_MONSTER_YIAN_GARUGA", "Yian Garuga" },
            { "LOC_MONSTER_SCARRED_YIAN_GARUGA", "Scarred Yian Garuga" },
			{ "LOC_MONSTER_GOLD_RATHIAN", "Gold Rathian" },
			{ "LOC_MONSTER_SILVER_RATHALOS", "Silver Rathalos" },

            //{ "LOC_MONSTER_UKNOWN", "Unknown Monster" },
            { "LOC_MONSTER_UKNOWN", "Kono Dio da!" },
            { "LOC_MONSTER_ANJANATH", "Anjanath" },
            { "LOC_MONSTER_AZURE_RATHALOS", "Azure Rathalos" },
            { "LOC_MONSTER_BARROTH", "Barroth" },
            { "LOC_MONSTER_BAZELGEUSE", "Bazelgeuse" },
            { "LOC_MONSTER_BEHEMOTH", "Behemoth" },
            { "LOC_MONSTER_BLACK_DIABLOS", "Black Diablos" },
            { "LOC_MONSTER_DEVILJHO", "Deviljho" },
            { "LOC_MONSTER_DIABLOS", "Diablos" },
            { "LOC_MONSTER_DODOGAMA", "Dodogama" },
            { "LOC_MONSTER_GREAT_GIRROS", "Great Girros" },
            { "LOC_MONSTER_GREAT_JAGRAS", "Great Jagras" },
            { "LOC_MONSTER_JYURATODUS", "Jyuratodus" },
            { "LOC_MONSTER_KIRIN", "Kirin" },
            { "LOC_MONSTER_KULU_YA_KU", "Kulu-Ya-Ku" },
            { "LOC_MONSTER_KULVE_TAROTH", "Kulve Taroth" },
            { "LOC_MONSTER_KUSHALA_DAORA", "Kushala Daora" },
            { "LOC_MONSTER_LAVASIOTH", "Lavasioth" },
            { "LOC_MONSTER_LEGIANA", "Legiana" },
            { "LOC_MONSTER_LUNASTRA", "Lunastra" },
            { "LOC_MONSTER_NERGIGANTE", "Nergigante" },
            { "LOC_MONSTER_ODOGARON", "Odogaron" },
            { "LOC_MONSTER_PAOLUMU", "Paolumu" },
            { "LOC_MONSTER_PINK_RATHIAN", "Pink Rathian" },
            { "LOC_MONSTER_PUKEI_PUKEI", "Pukei-Pukei" },
            { "LOC_MONSTER_RADOBAAN", "Radobaan" },
            { "LOC_MONSTER_RATHALOS", "Rathalos" },
            { "LOC_MONSTER_RATHIAN", "Rathian" },
            { "LOC_MONSTER_TEOSTRA", "Teostra" },
            { "LOC_MONSTER_TOBI_KADACHI", "Tobi-Kadachi" },
            { "LOC_MONSTER_TZITZI_YA_KU", "Tzitzi-Ya-Ku" },
            { "LOC_MONSTER_URAGAAN", "Uragaan" },
            { "LOC_MONSTER_VAAL_HAZAK", "Vaal Hazak" },
            { "LOC_MONSTER_XENO_JIIVA", "Xeno'jiiva" },
            { "LOC_MONSTER_ZORAH_MAGDAROS", "Zorah Magdaros" },
            { "LOC_PART_UKNOWN", "Unknown Part" },

            { "LOC_PART_HEAD_SNOW", "Head Snow" },
            { "LOC_PART_BODY_SNOW", "Body Snow" },
            { "LOC_PART_TAIL_SNOW", "Tail Snow" },

            { "LOC_PART_HEAD_ICE", "Head Ice" },
            { "LOC_PART_BODY_ICE", "Body Ice" },
            { "LOC_PART_WINGS_ICE", "Wings Ice" },
            { "LOC_PART_ARMS_ICE", "Arms Ice" },
            { "LOC_PART_LEGS_ICE", "Legs Ice" },
            { "LOC_PART_TAIL_ICE", "Tail Ice" },

            { "LOC_PART_HEAD_ROCK", "Head Rock" },
            { "LOC_PART_NECK_LEFT_ROCK", "Left Neck Rock" },
            { "LOC_PART_NECK_RIGHT_ROCK", "Right Right Rock" },
            { "LOC_PART_TAIL_ROCK", "Tail Rock" },
            { "LOC_PART_WING_LEFT_ROCK", "Left Wing Rock" },
            { "LOC_PART_WING_RIGHT_ROCK", "Right Wing Rock" },
            { "LOC_PART_ARM_LEFT_ROCK", "Left Arm Rock" },
            { "LOC_PART_ARM_RIGHT_ROCK", "Right Arm Rock" },
            { "LOC_PART_LEGS_ROCK", "Legs Rock" },

            { "LOC_PART_FIN", "Fin" },
            { "LOC_PART_HEAD", "Head" },
            { "LOC_PART_HEAD_LEFT", "Left Head" },
            { "LOC_PART_HEAD_RIGHT", "Right Head" },
            { "LOC_PART_BODY", "Body" },
            { "LOC_PART_ABDOMEN", "Abdomen" },
            { "LOC_PART_CHEST", "Chest" },
            { "LOC_PART_REAR", "Rear" },
            { "LOC_PART_ARMS", "Arms" },
            { "LOC_PART_ARM_LEFT", "Left Arm" },
            { "LOC_PART_ARM_RIGHT", "Right Arm" },
            { "LOC_PART_LEGS", "Legs" },
            { "LOC_PART_LEG_LEFT", "Left Leg" },
            { "LOC_PART_LEG_RIGHT", "Right Leg" },
            { "LOC_PART_LIMBS", "Limbs" },
            { "LOC_PART_LIMBS_LEFT", "Left Limbs" },
            { "LOC_PART_LIMBS_RIGHT", "Right Limbs" },
            { "LOC_PART_TAIL", "Tail" },
            { "LOC_PART_WINGS", "Wings" },
            { "LOC_PART_WING_LEFT", "Left Wing" },
            { "LOC_PART_WING_RIGHT", "Right Wing" },
            { "LOC_PART_HEAD_MUD", "Muddy Head" },
            { "LOC_PART_BODY_MUD", "Muddy Body" },
            { "LOC_PART_ARMS_MUD", "Muddy Arms" },
            { "LOC_PART_LEG_LEFT_MUD", "Muddy Left Leg" },
            { "LOC_PART_LEG_RIGHT_MUD", "Muddy Right Leg" },
            { "LOC_PART_TAIL_MUD", "Muddy Tail" },
            { "LOC_PART_HORNS", "Horns" },
            { "LOC_PART_MANE", "Mane" },
            { "LOC_PART_ROCK", "Rock" },
            { "LOC_PART_BALLOON", "Balloon" },
            { "LOC_PART_JAW", "Jaw" },
            { "LOC_PART_BACK", "Back" },
            { "LOC_PART_BONE_LEFT", "Left Bone" },
            { "LOC_PART_BONE_RIGHT", "Right Bone" },
            { "LOC_PART_NECK", "Neck" },
            { "LOC_PART_HAND_LEFT", "Left Hand" },
            { "LOC_PART_HAND_RIGHT", "Right Hand" },
            { "LOC_PART_FOOT_LEFT", "Left Foot" },
            { "LOC_PART_FOOT_RIGHT", "Right Foot" },
            { "LOC_PART_HORNS_GOLD", "Golden Horns" },
            { "LOC_PART_MANE_GOLD", "Golden Mane" },
            { "LOC_PART_CHEST_LEFT_GOLD", "Golden Left Chest" },
            { "LOC_PART_CHEST_RIGHT_GOLD", "Golden Right Chest" },
            { "LOC_PART_ARM_LEFT_GOLD", "Golden Left Arm" },
            { "LOC_PART_ARM_RIGHT_GOLD", "Golden Right Arm" },
            { "LOC_PART_LEG_LEFT_GOLD", "Golden Left Leg" },
            { "LOC_PART_LEG_RIGHT_GOLD", "Golden Right Leg" },
            { "LOC_PART_TAIL_LEFT_GOLD", "Golden Left Tail" },
            { "LOC_PART_TAIL_RIGHT_GOLD", "Golden Right Tail" },
            { "LOC_REMOVABLE_PART_UKNOWN", "Unknown Removable Part" },
            { "LOC_REMOVABLE_PART_TAIL", "Removable Tail" },
            { "LOC_REMOVABLE_PART_HORNS", "Removable Horns" },
            { "LOC_REMOVABLE_PART_HORNS_2", "Removable Horn Chip" },

            { "LOC_STATUS_EFFECT_UNKNOWN", "Unknown Status Effect" },
            { "LOC_STATUS_EFFECT_POISON", "Poison" },
            { "LOC_STATUS_EFFECT_PARALYSIS", "Paralysis" },
            { "LOC_STATUS_EFFECT_SLEEP", "Sleep" },
            { "LOC_STATUS_EFFECT_BLAST", "Blast" },
            { "LOC_STATUS_EFFECT_MOUNT", "Mount" },
            { "LOC_STATUS_EFFECT_EXHAUST", "Exhaust" },
            { "LOC_STATUS_EFFECT_STUN", "Stun" },
            { "LOC_STATUS_EFFECT_KO", "KO" },
            { "LOC_STATUS_EFFECT_TRANQUILIZE", "Tranquilize" },
            { "LOC_STATUS_EFFECT_FLASH", "Flash" },
            { "LOC_STATUS_EFFECT_DUNG", "Dung" },
            { "LOC_STATUS_EFFECT_KNOW_DOWN", "Kown Down" },
            { "LOC_STATUS_EFFECT_SMOKING", "Smoking" },
            { "LOC_STATUS_EFFECT_VIOLATED", "Violated" },

            //To test monster parts
            { "LOC_PART_0", "0" },
            { "LOC_PART_1", "1" },
            { "LOC_PART_2", "2" },
            { "LOC_PART_3", "3" },
            { "LOC_PART_4", "4" },
            { "LOC_PART_5", "5" },
            { "LOC_PART_6", "6" },
            { "LOC_PART_7", "7" },
            { "LOC_PART_8", "8" },
            { "LOC_PART_9", "9" },
            { "LOC_PART_10", "10" },
            { "LOC_PART_11", "11" },
            { "LOC_PART_12", "12" },
            { "LOC_PART_13", "13" },
            { "LOC_PART_14", "14" },
            { "LOC_PART_15", "15" },
            { "LOC_PART_16", "16" },
            { "LOC_PART_17", "17" },
            { "LOC_PART_18", "18" },
            { "LOC_PART_19", "19" },
            { "LOC_PART_20", "20" },
            { "LOC_PART_21", "21" },
            { "LOC_PART_22", "22" },
            { "LOC_PART_23", "23" },
            { "LOC_PART_24", "24" },
            { "LOC_PART_25", "25" },
            { "LOC_PART_26", "26" },
            { "LOC_PART_27", "27" },
            { "LOC_PART_28", "28" },
            { "LOC_PART_29", "29" },
            { "LOC_PART_30", "30" },
            { "LOC_PART_31", "31" },
            { "LOC_PART_32", "32" },

            //statuses
            { "LOC_STATUS_0", "Status 0" },

            // Hunting Horn
            { "LOC_STATUS_EFFECT_SELF_IMPROVEMENT", "Self-improvement" },
            { "LOC_STATUS_EFFECT_ATTACK_UP_S", "Attack Up (S)" },
            { "LOC_STATUS_EFFECT_ATTACK_UP_L", "Attack Up (L)" },
            { "LOC_STATUS_EFFECT_HEALTH_BOOST_S", "Health Boost (S)" },
            { "LOC_STATUS_EFFECT_HEALTH_BOOST_L", "Health Boost (L)" },
            { "LOC_STATUS_EFFECT_STAMINA_USE_REDUCED_S", "Stamina Use Reduced (S)" },
            { "LOC_STATUS_EFFECT_STAMINA_USE_REDUCED_L", "Stamina Use Reduced (L)" },
            { "LOC_STATUS_EFFECT_WIND_PRESSURE_NEGATED", "Wind Pressure Negated" },
            { "LOC_STATUS_EFFECT_ALL_WIND_PRESSURE_NEGATED", "All Wind Pressure Negated" },
            { "LOC_STATUS_EFFECT_DEFENSE_UP_S", "Defense Up (S)" },
            { "LOC_STATUS_EFFECT_DEFENSE_UP_L", "Defense Up (L)" },
            { "LOC_STATUS_EFFECT_TOOL_USE_DRAIN_REDUCED_S", "Tool Use Drain Reduced (S)" },
            { "LOC_STATUS_EFFECT_TOOL_USE_DRAIN_REDUCED_L", "Tool Use Drain Reduced (L)" },
            { "LOC_STATUS_EFFECT_HEALTH_RECOVERY_S", "Health Rec. (S)" },
            { "LOC_STATUS_EFFECT_HEALTH_RECOVERY_L", "Health Rec. (L)" },
            { "LOC_STATUS_EFFECT_EARPLUGS_S", "Earplugs (S)" },
            { "LOC_STATUS_EFFECT_EARPLUGS_L", "Earplugs (L)" },
            { "LOC_STATUS_EFFECT_DIVINE_PROTECTION", "Divine Protection" },
            { "LOC_STATUS_EFFECT_SCOUTFLY_POWER_UP", "Scoutfly Power Up" },
            { "LOC_STATUS_EFFECT_ENVIRONMENTAL_DAMAGE_NEGATED", "Envir. Damage Negated" },
            { "LOC_STATUS_EFFECT_STUN_NEGATED", "Stun Negated" },
            { "LOC_STATUS_EFFECT_PARALYSIS_NEGATED", "Paralysis Negated" },
            { "LOC_STATUS_EFFECT_TREMORS_NEGATED", "Tremors Negated" },
            { "LOC_STATUS_EFFECT_MUCK_RESISTANCE", "Muck Res" },
            { "LOC_STATUS_EFFECT_FIRE_RESISTANCE_BOOST_S", "Fire Res Boost (S)" },
            { "LOC_STATUS_EFFECT_FIRE_RESISTANCE_BOOST_L", "Fire Res Boost (L)" },
            { "LOC_STATUS_EFFECT_WATER_RESISTANCE_BOOST_S", "Water Res Boost (S)" },
            { "LOC_STATUS_EFFECT_WATER_RESISTANCE_BOOST_L", "Water Res Boost (L)" },
            { "LOC_STATUS_EFFECT_THUNDER_RESISTANCE_BOOST_S", "Thunder Res Boost (S)" },
            { "LOC_STATUS_EFFECT_THUNDER_RESISTANCE_BOOST_L", "Thunder Res Boost (L)" },
            { "LOC_STATUS_EFFECT_ICE_RESISTANCE_BOOST_S", "Ice Res Boost (S)" },
            { "LOC_STATUS_EFFECT_ICE_RESISTANCE_BOOST_L", "Ice Res Boost (L)" },
            { "LOC_STATUS_EFFECT_DRAGON_RESISTANCE_BOOST_S", "Dragon Res Boost (S)" },
            { "LOC_STATUS_EFFECT_DRAGON_RESISTANCE_BOOST_L", "Dragon Res Boost (L)" },
            { "LOC_STATUS_EFFECT_ELEMENTAL_ATTACK_BOOST", "Elemental Attack Boost" },
            { "LOC_STATUS_EFFECT_BLIGHT_NEGATED", "Blight Negated" },
            { "LOC_STATUS_EFFECT_KNOCKBACKS_NEGATED", "Knockbacks Negated" },
            { "LOC_STATUS_EFFECT_ELEMENTAL_RESISTANCE_UP", "Elemental Resistance Up" },
            { "LOC_STATUS_EFFECT_AFFINITY_UP", "Affinity Up" },
            { "LOC_STATUS_EFFECT_ALL_AILMENTS_NEGATED", "All Ailments Negated" },
            { "LOC_STATUS_EFFECT_WIND_PRESSURE_NEGATED_AND_EARPLUGS_S", "Wind Pressure Negated & Earplugs (S)" },
            { "LOC_STATUS_EFFECT_ABNORMAL_STATUS_ATTACK_INCREASED", "Abnormal Status Atk. Increased" },
            
            // Orchestra
            { "LOC_STATUS_EFFECT_HEALTH_RECOVERY", "Health Recovery" },
            { "LOC_STATUS_EFFECT_HEALTH_BOOST", "Health Boost" },
            { "LOC_STATUS_EFFECT_STAMINA_USE_REDUCED", "Stamina Use Reduced" },
            
            // Debuffs
            { "LOC_STATUS_EFFECT_FIREBLIGHT", "Fireblight" },
            { "LOC_STATUS_EFFECT_THUNDERBLIGHT", "Thunderblight" },
            { "LOC_STATUS_EFFECT_ICEBLIGHT", "Iceblight" },
            { "LOC_STATUS_EFFECT_WATERBLIGHT", "Waterblight" },
            { "LOC_STATUS_EFFECT_DRAGONBLIGHT", "Dragonblight" },
            { "LOC_STATUS_EFFECT_BLEEDING", "Bleeding" },
            { "LOC_STATUS_EFFECT_BLEEDING_RECOVERY", "Bleeding Recovery" },
            { "LOC_STATUS_EFFECT_EFFLUVIA", "Effluvia" },
            { "LOC_STATUS_EFFECT_DEFENSE_DOWN", "Defense Down" },
            { "LOC_STATUS_EFFECT_ELEMENTAL_RESISTANCE_DOWN", "Elemental Resistance Down" },
            { "LOC_STATUS_EFFECT_NO_ITEMS", "No Items" },
            { "LOC_STATUS_EFFECT_BLASTBLIGHT", "Blastblight" },
            
            // Buffs
            { "LOC_STATUS_EFFECT_DASH_JUICE", "Dash Juice" },
            { "LOC_STATUS_EFFECT_WIGGLY_LITCHI", "Wiggly Litchi" },
            { "LOC_STATUS_EFFECT_IMMUNIZER", "Immunizer" },            
            { "LOC_STATUS_EFFECT_MIGHT_PILL", "Might Pill" },
            { "LOC_STATUS_EFFECT_MIGHT_SEED", "Might Seed" },            
            { "LOC_STATUS_EFFECT_ADAMANT_PILL", "Adamant Pill" },
            { "LOC_STATUS_EFFECT_ADAMANT_SEED", "Adamant Seed" },            
            { "LOC_STATUS_EFFECT_DEMON_POWDER", "Demon Powder" },
            { "LOC_STATUS_EFFECT_HARDSHELL_POWDER", "Hardshell Powder" },            
            { "LOC_STATUS_EFFECT_DEMONDRUG", "Demondrug" },
            { "LOC_STATUS_EFFECT_MEGA_DEMONDRUG", "Mega Demondrug" },
            { "LOC_STATUS_EFFECT_ARMORSKIN", "Armorskin" },
            { "LOC_STATUS_EFFECT_MEGA_ARMORSKIN", "Mega Armorskin" },
            { "LOC_STATUS_EFFECT_COOL_DRINK", "Cool Drink" },
            { "LOC_STATUS_EFFECT_PROTECTIVE_POLISH", "Protective Polish" },
            { "LOC_STATUS_EFFECT_AFFINITY_SLIDING", "Affinity Sliding" },

            // Equipment
            { "LOC_EQUIPMENT_MANTLE_GHILLIE", "Ghillie Mantle" },
            { "LOC_EQUIPMENT_MANTLE_TEMPORAL", "Temporal Mantle" },
            { "LOC_EQUIPMENT_MANTLE_ROCKSTEADY", "Rocksteady Mantle" },
            { "LOC_EQUIPMENT_MANTLE_CHALLENGER", "Challenger Mantle" },
            { "LOC_EQUIPMENT_MANTLE_VITALITY", "Vitality Mantle" },
            { "LOC_EQUIPMENT_MANTLE_FIREPROOF", "Fireproof Mantle" },
            { "LOC_EQUIPMENT_MANTLE_WATERPROOF", "Waterproof Mantle" },
            { "LOC_EQUIPMENT_MANTLE_ICEPROOF", "Iceproof Mantle" },
            { "LOC_EQUIPMENT_MANTLE_THUNDERPROOF", "Thunderproof Mantle" },
            { "LOC_EQUIPMENT_MANTLE_DRAGONPROOF", "Dragonproof Mantle" },
            { "LOC_EQUIPMENT_MANTLE_GLIDER", "Glider Mantle" },
            { "LOC_EQUIPMENT_MANTLE_EVASION", "Evasion Mantle" },
            { "LOC_EQUIPMENT_MANTLE_IMPACT", "Impact Mantle" },
            { "LOC_EQUIPMENT_MANTLE_APOTHECARY", "Apothecary Mantle" },
            { "LOC_EQUIPMENT_MANTLE_IMMUNITY", "Immunity Mantle" },
            { "LOC_EQUIPMENT_MANTLE_BANDIT", "Bandit Mantle" },
            { "LOC_EQUIPMENT_AFFINITY_BOOSTER", "Affinity Booster" },

            // Weapon
            { "LOC_WEAPON_INSECT_GLAIVE_ATTACK", "Attack Up" },
            { "LOC_WEAPON_INSECT_GLAIVE_SPEED", "Speed Up" },
            { "LOC_WEAPON_INSECT_GLAIVE_DEFENSE", "Defense Up" },
            { "LOC_WEAPON_LONGSWORD_SPIRIT_GAUGE_REGEN", "Spirit Gauge Regen" },
            { "LOC_WEAPON_LONGSWORD_STEADY_SPIRIT_LEVEL", "Steady Spirit Level" },
            { "LOC_WEAPON_CHARGE_BLADE_SHIELD_CHARGE", "Shield Charge" },
            { "LOC_WEAPON_CHARGE_BLADE_BLADE_CHARGE", "Blade Charge" },
            { "LOC_WEAPON_SWITCH_AXE_AMPED_STATE", "Amped State" },
            { "LOC_WEAPON_HAMMER_POWER_CHARGE", "Power Charge" },

            { "LOC_PART_SHELL", "Shell" },
            { "LOC_PART_EXHAUST_ORGAN_CENTRAL", "Central Exhaust Organ" },
            { "LOC_PART_EXHAUST_ORGAN_HEAD", "Head Exhaust Organ" },
            { "LOC_PART_EXHAUST_ORGAN_CRATER", "Crater Exhaust Organ" },
            { "LOC_PART_EXHAUST_ORGAN_REAR", "Rear Exhaust Organ" },
            { "LOC_PART_WEAK_SHELL_LEFT", "Left Weak Shell" },
            { "LOC_PART_WEAK_SHELL_RIGHT", "Right Weak Shell" },

            { "LOC_STATUS_EFFECT_SHOCK_TRAP", "Shock Trap" },
            { "LOC_STATUS_EFFECT_PITFALL_TRAP", "Pitfall Trap" },
            { "LOC_STATUS_EFFECT_ELDERSEAL", "Elderseal" },

            { "LOC_EQUIPMENT_ASSASSINS_HOOD", "Assassin's Hood" },
            { "LOC_MONSTER_LESHEN", "Leshen" },
            { "LOC_MONSTER_ANCIENT_LESHEN", "Ancient Leshen" },
            { "LOC_REMOVABLE_PART_ANTLER_LEFT", "Removable Left Antler" },
            { "LOC_REMOVABLE_PART_ANTLER_RIGHT", "Removable Right Antler" },
            { "LOC_JAGRAS_SUMMONER", "Jagras Summoner" },

            { "LOC_STATUS_EFFECT_RAGE", "Rage" },
            { "LOC_STATUS_EFFECT_STAMINA", "Stamina" },
            { "LOC_STATUS_EFFECT_FATIGUE", "Fatigue" },
        };
        
        public LocalizationConfig()
        {

        }
    }
}
