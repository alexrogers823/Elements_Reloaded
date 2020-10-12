using System;
using System.Linq;

namespace Elements_Reloaded
{
    public class Gameplay
    {
        public static Hero _hero { get; private set; }
        private static string[] _levelElementOrder;
        public static int CurrentLevel { get; set; } = 1;

        public Gameplay()
        {
            _hero = GameController.CreateHero();
            _levelElementOrder = GameController.ArrangeLevels(_hero.ElementType);
        }

        private void _modifyGameplaySettings()
        {
            //where hero replenish and enemy damage are altered 
        }

        public void PlayGame()
        {
            while (CurrentLevel < 10 && _hero.LifePoints > 0)
            {
                StartLevel();
                VisitShop();
            }
        }

        public void StartLevel()
        {
            Level.PlayLevel(CurrentLevel);
        }

        public void VisitShop()
        {

        }

        public static string GetLevelElement()
        {
            string[] ElementOrder = GameController.ArrangeElementOrder(_hero.ElementType);
            if (CurrentLevel == 8 || CurrentLevel == 10)
            {
                return null;
            }
            else if (CurrentLevel == 9)
            {
                return ElementOrder[ElementOrder.Length-1];
            }
            else
            {
                int ElementIndex = (CurrentLevel - 1) % ElementOrder.Length;
                return ElementOrder[ElementIndex];
            }


        }

        public static string GetHeroElementType()
        {
            return _hero.ElementType;
        }

        public static void Battle(Hero goodguy, Enemy badguy)
        {
            int damage;
            while (goodguy.LifePoints > 0 && badguy.LifePoints > 0)
            {
                _displayBattleStats(goodguy, badguy);
                damage = goodguy.Attack();
                badguy.TakeDamage(damage);
                if (badguy.LifePoints > 0)
                {
                    damage = badguy.Attack();
                    goodguy.TakeDamage(damage);
                }
            }
        }

        public static void EndGame()
        {
            Console.WriteLine("Game over");
            Environment.Exit(0);
        }

        private static void _displayBattleStats(Hero goodguy, Enemy badguy)
        {
            goodguy.ShowGameStats();
            Console.WriteLine(String.Format("{0} VS {0}", String.Concat(Enumerable.Repeat("-", 3))));
            badguy.ShowGameStats();
        }
    }
}
