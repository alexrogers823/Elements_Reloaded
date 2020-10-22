using System;
namespace Elements_Reloaded
{
    public static class Shop
    {
        public static void BuyItem(string item)
        {
            // add item to hero inventory
            Console.WriteLine($"{item.Name} added to inventory!");
        }

        public static void DisplayEligibleContent()
        {
            //Iterate through items that hero does not have and are qualified to receive
        }

        public static void ExchangeStone(string currentStone, string desiredStone)
        {
            // switch out current stone with desired stone
            Console.WriteLine($"Now equipped with {desiredStone}!");
        }
    }
}
