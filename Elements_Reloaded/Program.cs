using System;
using System.Linq;

namespace Elements_Reloaded
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(String.Format("{0} ELEMENTS {0}", String.Concat(Enumerable.Repeat("-", 10))));
            Console.WriteLine("An RPG game on the four powers of life");

            Gameplay gameplay = new Gameplay();
            gameplay.Start();
        }
    }
}
