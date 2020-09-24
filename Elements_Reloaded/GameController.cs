using System;
using System.Collections.Generic;

namespace Elements_Reloaded
{
    public class GameController
    {
        private static readonly Dictionary<string, Dictionary<string, string[]>> _elementMap =
            new Dictionary<string, Dictionary<string, string[]>>
            {
                {
                    "Water",
                    new Dictionary<string, string[]>
                    {
                        { "Levels", new string[] {"Symbolic Ocean", "Aquatic Sanctuary" } },
                        { "Enemies", new string[] {"Whitewater Sage", "Sr. Whitewater Sage", "Oceanic Prince", "Oceanic King"} }
                    }
                },
                {
                    "Earth",
                    new Dictionary<string, string[]>
                    {
                        { "Levels", new string[] {"High Ground", "Cave of Wonder"} },
                        { "Enemies", new string[] {"Geo Wrangler", "Geo Champion", "Earth Emperor", "Earth God"} }
                    }
                },
                {
                    "Fire",
                    new Dictionary<string, string[]>
                    {
                        { "Levels", new string[] {"Pyrocity", "Flaming Desert"} },
                        { "Enemies", new string[] {"Blazed Knight", "Blazed Bishop", "Scorched Lieutenant", "Scorched General"} }
                    }
                },
                {
                    "Air",
                    new Dictionary<string, string[]>
                    {
                        { "Levels", new string[] {"Windy Bridge", "Floating Sky"} },
                        { "Enemies", new string[] {"Wind Sorceror", "Advanced Wind Sorcerer", "Wind Keeper", "Wind Master"} }
                    }
                }
            };

        public static string GetEnemyName(string elementType, int level, bool isBoss)
        {
            int levelIndex = (level > 5) ? 1 : 0;
            if (isBoss) { levelIndex += 2; };

            return _elementMap[elementType]["Enemies"][levelIndex];
        }


        public static string[] ArrangeLevels(string elementType)
        {
            List<string> LevelOrderList = new List<string>();
            string[] ElementOrder = null;

            if (elementType == "Water")
            {
                ElementOrder = new string[4] { "Air", "Earth", "Water", "Fire" };
            }
            else if (elementType == "Earth")
            {
                ElementOrder = new string[4] { "Water", "Fire", "Earth", "Air" };
            }
            else if (elementType == "Fire")
            {
                ElementOrder = new string[4] { "Earth", "Air", "Fire", "Water" };
            }
            else if (elementType == "Air")
            {
                ElementOrder = new string[4] { "Fire", "Water", "Air", "Earth" };
            }

            for (int i = 0; i < (ElementOrder.Length * 2); i++)
            {
                int LevelIndex = (i > 3) ? 1 : 0;
                int Index = (i > 3) ? i - 4 : i;
                LevelOrderList.Add(_elementMap[ElementOrder[Index]]["Levels"][LevelIndex]);
            }

            return LevelOrderList.ToArray();
        }

        public static Hero CreateHero()
        {
            string[] ElementChoices = new string[4] { "Water", "Earth", "Fire", "Air" };
            Console.WriteLine("Create your hero. Choose wisely");

            Console.WriteLine("Which element type do you want to play as?");
            string SelectedElement = Console.ReadLine();

            Console.WriteLine("Your hero needs a name...");
            string Name = Console.ReadLine();

            Console.WriteLine($"Creating hero {Name}...");

            return new Hero(Name, SelectedElement);
        }

    }     
}
