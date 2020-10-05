using System;
using System.Collections.Generic;

namespace Elements_Reloaded
{
    public class Hero : Player
    {
        private int _magicPoints { get; set; } = 50;
        private int _attackPoints { get; set; } = 10;
        private string _basicAttack;
        private Dictionary<string, int> _heroStats { get; } =
            new Dictionary<string, int>
            {
                { "XP", 0 },
                { "Coins", 0 },
                { "Enemies Killed", 0 }
            };
        private Inventory _inventory { get; } = new Inventory();
        protected override int WeaponBaseDamage { get; set; }
        //variable for base damange absorption (elemental stone)

        public Hero(string name, string elementType) :
            base(name, elementType)
        {
            LifePoints = 100;
            _basicAttack = ElementInfo.GetBasicAttack(elementType);
            WeaponAttack = ElementInfo.GetWeaponName(elementType);
        }

        public override void ShowGameStats()
        {
            Console.WriteLine(
                $"{this.Name}: {this.ElementType} Type," +
                $" LP: {this.LifePoints}, MP: {this._magicPoints}");
        }

        public void AcquireItem(string item)
        {
            _inventory.AddItem(item);
            Console.WriteLine($"Added {item} to {this.Name}'s inventory");
            _inventory.PrintItems();
        }

        public void AcquireWeapon()
        {
            HasWeapon = true;
        }

        public int Attack()
        {
            string selectedAttack = this._inputAttack();
            base.Attack(selectedAttack);
            return _attackPoints;
        }

        private string _inputAttack()
        {
            string[] ListOfValidAttacks = new string[4]; //Change this later since you don't know how many attacks
            ListOfValidAttacks[0] = _basicAttack;
            ListOfValidAttacks[1] = WeaponAttack;

            Console.WriteLine("Choose your attack");
            for (int i = 0; i < ListOfValidAttacks.Length; i++)
            {
                if (ListOfValidAttacks[i] != null)
                {
                    Console.WriteLine($"{i}: {ListOfValidAttacks[i]}");
                }
            }

            int attackNumber = Convert.ToInt32(Console.ReadLine());

            return ListOfValidAttacks[attackNumber];

        }

        public void DefeatEnemy(Enemy enemy)
        {
            Console.WriteLine($"{this.Name} has defeated {enemy.Name}!");
            if (enemy.IsBoss)
            {
                _heroStats["XP"] += 50;
                _heroStats["Coins"] += 75;
            }
            else
            {
                _heroStats["XP"] += 5;
                _heroStats["Coins"] += 5;
            }
                _heroStats["Enemies Killed"]++;
        }
    }
}
