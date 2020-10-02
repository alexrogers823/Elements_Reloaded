using System;
using System.Collections.Generic;

namespace Elements_Reloaded
{
    public class GameController
    {
        //private static string[] _levelOrder = ArrangeLevels(Gameplay.GetHeroElementType());
        private static string[] _levelOrder = ArrangeLevels("Water");

        public static string GetLevelName(int level)
        {
            Dictionary<int, string> LevelNames =
                new Dictionary<int, string>
                {
                    { 1, _levelOrder[0] },
                    { 2, _levelOrder[1] },
                    { 3, _levelOrder[2] },
                    { 4, _levelOrder[3] },
                    { 5, _levelOrder[4] },
                    { 6, _levelOrder[5] },
                    { 7, _levelOrder[6] },
                    { 8, "Lightning Tower" },
                    { 9, _levelOrder[7] },
                    { 10, "Element Dimension" },
                };

            return LevelNames[level];
        }

        public static string GetEnemyName(string elementType, int level, bool isBoss)
        {
            int levelIndex = (level > 5) ? 1 : 0;
            if (isBoss) { levelIndex += 2; };

            return ElementInfo.GetEnemyByElement(elementType, levelIndex);
        }


        public static string[] ArrangeLevels(string elementType)
        {
            List<string> LevelOrderList = new List<string>();
            string[] ElementOrder = ArrangeElementOrder(elementType);

            for (int i = 0; i < (ElementOrder.Length * 2); i++)
            {
                int LevelIndex = (i > 3) ? 1 : 0;
                int ElementIndex = (i > 3) ? i - 4 : i;
                Console.WriteLine($"DEBUG: Making level {i + 1}");
                Console.WriteLine($"DEBUG: Level order list -- {LevelOrderList}");

                Console.WriteLine($"DEBUG: Selected level -- {ElementInfo.GetLevelByElement(elementType, LevelIndex)}");
                LevelOrderList.Add(ElementInfo.GetLevelByElement(elementType, LevelIndex));
            }

            return LevelOrderList.ToArray();
        }

        public static string[] ArrangeElementOrder(string elementType)
        {
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
            else
            {
                Console.WriteLine($"Invalid Element: {elementType} not a part of list");
            }

            return ElementOrder;

        }

        public static Hero CreateHero()
        {
            string[] ElementChoices = new string[4] { "Water", "Earth", "Fire", "Air" };
            Console.WriteLine("Create your hero. Choose wisely");

            Console.WriteLine("Which element type do you want to play as?");
            string SelectedElement = Console.ReadLine();

            Console.WriteLine("Your hero needs a name...");
            string Name = Console.ReadLine();

            Console.WriteLine($"Creating {SelectedElement} type hero {Name}...");

            return new Hero(Name, SelectedElement);
        }

    }     
}
