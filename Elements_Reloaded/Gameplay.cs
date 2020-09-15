using System;
namespace Elements_Reloaded
{
    public class Gameplay
    {
        private Hero _hero;

        public Gameplay()
        {
            _hero = GameController.CreateHero();
        }

        public void Start()
        {
            while (Level.CurrentLevel < 10)
            {
               Level.PlayLevel();
                //shop here
            }
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
