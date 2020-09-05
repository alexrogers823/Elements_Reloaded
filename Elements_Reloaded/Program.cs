using System;

namespace Elements_Reloaded
{
    class Program
    {
        static void Main(string[] args)
        {
            Test sample = new Test();

            Hero sam = new Hero("Sam", "fire", false,
                        "weapon", 30, "basic attack");

            Hero jane = new Hero("Jane", "earth", false,
                        "slam", 30, "rock");

            Enemy steve = new Enemy("Steve", "water", false, "Water Whip");

            Console.WriteLine(sample.testMessage());
            sam.ShowGameStats();

            steve.ShowGameStats();

            sam.AcquireItem("strawberry");
            jane.AcquireItem("stone");
        }
    }
}
