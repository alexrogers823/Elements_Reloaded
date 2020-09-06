using System;
namespace Elements_Reloaded
{
    public class Hero : Player
    {
        private int _magicPoints { get; set; } = 50;
        private int _attackPoints;
        private string _basicAttack;
        private Inventory _inventory { get; } = new Inventory();
        protected override int WeaponBaseDamage { get; set; }
        //variable for base damange absorption (elemental stone)

        public Hero(string name, string elementType) :
            base(name, elementType)
        {
            _attackPoints = 10;
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
    }
}
