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

        public void Start()
        {
            while (CurrentLevel < 10)
            {
                //Level level = new Level(CurrentLevel);
                Level.PlayLevel(CurrentLevel);
                //shop here
            }
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
                int ElementIndex = (CurrentLevel % ElementOrder.Length) - 1;
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

        private static void _displayBattleStats(Hero goodguy, Enemy badguy)
        {
            goodguy.ShowGameStats();
            Console.WriteLine(String.Format("{0} VS {0}", String.Concat(Enumerable.Repeat("-", 3))));
            badguy.ShowGameStats();
        }
    }
}
