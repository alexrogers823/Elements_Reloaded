using System;
namespace Elements_Reloaded
{
    public class Gameplay
    {
        private Hero _hero = GameController.CreateHero();

        public Gameplay()
        {
        }

        public void Start()
        {
            while (Level.CurrentLevel < 10)
            {
               Level.PlayLevel();
                //shop here
            }
        }
    }
}
