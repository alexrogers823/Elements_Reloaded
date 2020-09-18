using System;
namespace Elements_Reloaded
{
    public class Gameplay
    {
        private Hero _hero;
        private string[] _levelElementOrder;
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
                Level.PlayLevel(_getLevelElement());
                //shop here
            }
        }

        private string _getLevelElement()
        {
            return _levelElementOrder[CurrentLevel - 1];
        }

        public static void Battle(Hero goodguy, Enemy badguy)
        {
            int damage;
            while (goodguy.LifePoints > 0 && badguy.LifePoints > 0)
            {
                damage = goodguy.Attack();
                badguy.TakeDamage(damage);
                if (badguy.LifePoints > 0)
                {
                    damage = badguy.Attack();
                    goodguy.TakeDamage(damage);
                }
            }
        }
    }
}
