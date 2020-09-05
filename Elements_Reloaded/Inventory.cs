using System;
using System.Collections.Generic;

namespace Elements_Reloaded
{
    public class Inventory
    {
        private List<string> _inventory;

        public Inventory()
        {
            _inventory = new List<string>();
        }

        public void AddItem(string item)
        {
            _inventory.Add(item);
        }

        public void PrintItems()
        {
            foreach(string item in _inventory)
            {
                Console.WriteLine(item);
            }
        }

        //public void ExchangeStone(string stone)
        //{

        //}
    }
}
