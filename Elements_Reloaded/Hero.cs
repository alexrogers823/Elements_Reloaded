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
                $" {this.LifePoints}, {this._magicPoints}" +
                $" {this._attackPoints}, {this._basicAttack}" +
                $" {this.HasWeapon}, {this.WeaponAttack}");
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

        public void Attack()
        {
            string selectedAttack = this._basicAttack;
            base.Attack(selectedAttack);
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
