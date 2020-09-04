using System;

namespace Elements_Reloaded
{
    class Program
    {
        static void Main(string[] args)
        {
            Test sample = new Test();

            Player john = new Player("John", "fire", false, "weapon");
            Hero sam = new Hero("Sam", "fire", false,
                        "weapon", 30, "basic attack");

            Console.WriteLine(sample.testMessage());
            sam.ShowGameStats();
        }
    }
}
