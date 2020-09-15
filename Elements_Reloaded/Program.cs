using System;
using System.Linq;

namespace Elements_Reloaded
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hero hero = GameController.CreateHero();
            //hero.ShowGameStats();
            //hero.TakeDamage(15);
            //hero.AcquireItem("peach");
            //hero.Attack();

            Console.WriteLine(String.Format("{0} ELEMENTS {0}", String.Concat(Enumerable.Repeat("-", 10))));
            Console.WriteLine("An RPG game on the four powers of life");

            Gameplay.Start();

            Level level = new Level(hero);

        }
    }
}
