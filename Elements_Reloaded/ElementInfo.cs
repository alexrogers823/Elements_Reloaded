using System;
using System.Collections.Generic;

namespace Elements_Reloaded
{
    public static class ElementInfo
    {

        public static string GetWeaponName(string element)
        {
            Dictionary<string, string> Weapons = new Dictionary<string, string>()
            {
                { "Water", "Nautic Whiplash" },
                { "Earth", "Ground Boomerang" },
                { "Fire", "Flamethrower" },
                { "Air", "Breathtaker" }
            };

            return Weapons[element];
        }

        public static string GetWeaponName(string element, bool isBoss)
        {
            Dictionary<string, Dictionary<string, string>> Weapons =
                new Dictionary<string, Dictionary<string, string>>
            {
                {
                    "Water",
                    new Dictionary<string, string>
                    {
                        { "Minion", "Strong Current" },
                        { "Boss", "Hydroplanar Eruption" }
                    }
                },
                {
                    "Earth",
                    new Dictionary<string, string>
                    {
                        { "Minion", "Stonewall" },
                        { "Boss", "Geological Crush" }
                    }
                },
                {
                    "Fire",
                    new Dictionary<string, string>
                    {
                        { "Minion", "Stream of Flames" },
                        { "Boss", "Third-Degree Incision" }
                    }
                },
                {
                    "Air",
                    new Dictionary<string, string>
                    {
                        { "Minion", "Wind Slash" },
                        { "Boss", "Ozone Strike" }
                    }
                }
            };

            return isBoss ? Weapons[element]["Boss"]
                : Weapons[element]["Minion"];
        }

        public static string GetBasicAttack(string element)
        {
            Dictionary<string, string> Attacks = new Dictionary<string, string>
            {
                { "Water", "Rushing Waterfall" },
                { "Earth", "Boulder Impact" },
                { "Fire", "Ring of Fire" },
                { "Air", "Wind Pressure" }
            };

            return Attacks[element];
        }

        public static string GetLowAttack(string element, bool isBoss)
        {
            Dictionary<string, Dictionary<string, string>> Attacks =
                new Dictionary<string, Dictionary<string, string>>
            {
                {
                    "Water",
                    new Dictionary<string, string>
                    {
                        { "Minion", "Aqua Attack" },
                        { "Boss", "Aquatic Outburst" }
                    }
                },
                {
                    "Earth",
                    new Dictionary<string, string>
                    {
                        { "Minion", "Earthquake" },
                        { "Boss", "Crying Terra" }
                    }
                },
                {
                    "Fire",
                    new Dictionary<string, string>
                    {
                        { "Minion", "Fireball Blast" },
                        { "Boss", "Scorched Wave" }
                    }
                },
                {
                    "Air",
                    new Dictionary<string, string>
                    {
                        { "Minion", "Air Rush" },
                        { "Boss", "Suffication" }
                    }
                }
            };

            return isBoss ? Attacks[element]["Boss"]
                : Attacks[element]["Minion"];
        }

        public static string GetHighAttack(string element, bool isBoss)
        {
            Dictionary<string, Dictionary<string, string>> Attacks =
                new Dictionary<string, Dictionary<string, string>>
            {
                {
                    "Water",
                    new Dictionary<string, string>
                    {
                        { "Minion", "Typhoon" },
                        { "Boss", "Tsunami" }
                    }
                },
                {
                    "Earth",
                    new Dictionary<string, string>
                    {
                        { "Minion", "Meteor Shower" },
                        { "Boss", "Rock Shelter" }
                    }
                },
                {
                    "Fire",
                    new Dictionary<string, string>
                    {
                        { "Minion", "Inferno" },
                        { "Boss", "Hell on Earth" }
                    }
                },
                {
                    "Air",
                    new Dictionary<string, string>
                    {
                        { "Minion", "Tornado" },
                        { "Boss", "Flight of Death" }
                    }
                }
            };

            return isBoss ? Attacks[element]["Boss"]
                : Attacks[element]["Minion"];
        }

        public static string GetEnemyByElement(string element, int index)
        {
            Dictionary<string, Dictionary<string, string[]>> ElementMap =
            new Dictionary<string, Dictionary<string, string[]>>
            {
                {
                    "Water",
                    new Dictionary<string, string[]>
                    {
                        { "Enemies", new string[] {"Whitewater Sage", "Sr. Whitewater Sage", "Oceanic Prince", "Oceanic King"} }
                    }
                },
                {
                    "Earth",
                    new Dictionary<string, string[]>
                    {
                        { "Enemies", new string[] {"Geo Wrangler", "Geo Champion", "Earth Emperor", "Earth God"} }
                    }
                },
                {
                    "Fire",
                    new Dictionary<string, string[]>
                    {
                        { "Enemies", new string[] {"Blazed Knight", "Blazed Bishop", "Scorched Lieutenant", "Scorched General"} }
                    }
                },
                {
                    "Air",
                    new Dictionary<string, string[]>
                    {
                        { "Enemies", new string[] {"Wind Sorceror", "Advanced Wind Sorcerer", "Wind Keeper", "Wind Master"} }
                    }
                }
            };

            return ElementMap[element]["Enemies"][index];
        }

        public static string GetLevelByElement(string element, int index)
        {
            Dictionary<string, Dictionary<string, string[]>> ElementMap =
            new Dictionary<string, Dictionary<string, string[]>>
            {
                {
                    "Water",
                    new Dictionary<string, string[]>
                    {
                        { "Levels", new string[] {"Symbolic Ocean", "Aquatic Sanctuary" } },
                    }
                },
                {
                    "Earth",
                    new Dictionary<string, string[]>
                    {
                        { "Levels", new string[] {"High Ground", "Cave of Wonder"} },
                    }
                },
                {
                    "Fire",
                    new Dictionary<string, string[]>
                    {
                        { "Levels", new string[] {"Pyrocity", "Flaming Desert"} },
                    }
                },
                {
                    "Air",
                    new Dictionary<string, string[]>
                    {
                        { "Levels", new string[] {"Windy Bridge", "Floating Sky"} },
                    }
                }
            };

            return ElementMap[element]["Levels"][index];
        }
    }
}
