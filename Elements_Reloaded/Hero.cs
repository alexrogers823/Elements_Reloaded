using System;
namespace Elements_Reloaded
{
    public class Hero : Player
    {
        private int _magicPoints { get; set; } = 50;
        private int _attackPoints;
        private string _basicAttack;
        private Inventory _inventory { get; } = new Inventory();
        protected bool HasWeapon { get; set; } = false;
        protected override int LifePoints { get; set; } = 100;
        protected override int WeaponBaseDamage { get; set; }
        //variable for base damange absorption (elemental stone)

        public Hero(string name, string elementType,
            string weaponAttack,
            string basicAttack
            ) : base(name, elementType,
                weaponAttack)
        {
            _attackPoints = 10;
            _basicAttack = basicAttack;
        }

        public override void ShowGameStats()
        {
            Console.WriteLine(
                $"{this.Name}: {this.ElementType} Type," +
                $" {this.LifePoints}, {this._magicPoints}");
        }

        public void AcquireItem(string item)
        {
            _inventory.AddItem(item);
            Console.WriteLine($"Added {item} to {this.Name}'s inventory");
            _inventory.PrintItems();
        }
    }
}
