using System;

namespace Elements_Reloaded
{
    class Program
    {
        static void Main(string[] args)
        {
            Test sample = new Test();

            Player john = new Player("fire", 20, false, "weapon");

            Console.WriteLine(sample.testMessage());
            Console.WriteLine(john.GetLP());
            john.TakeDamage(5);
            Console.WriteLine(john.GetLP());
        }
    }
}
