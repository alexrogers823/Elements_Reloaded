using System;

namespace Elements_Reloaded
{
    class Program
    {
        static void Main(string[] args)
        {
            Test sample = new Test();

            Hero sam = new Hero("Sam", "Fire");

            Hero jane = new Hero("Jane", "Earth");

            Enemy steve = new Enemy("Steve", "Water");

            //Console.WriteLine(sample.testMessage());
            sam.ShowGameStats();
            jane.ShowGameStats();

            sam.AcquireWeapon();
            sam.TakeDamage(15);
            sam.ShowGameStats();
            jane.ShowGameStats();

            steve.ShowGameStats();

            sam.AcquireItem("strawberry");
            jane.AcquireItem("stone");

            sam.Attack();

            string[] levels = GameController.ArrangeLevels("Fire");

            foreach (string level in levels)
            {
                Console.WriteLine(level);
            }
        }
    }
}
