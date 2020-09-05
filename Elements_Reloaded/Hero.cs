using System;
namespace Elements_Reloaded
{
    public class Hero : Player
    {
        private int _magicPoints { get; set; } = 50;
        private int _attackPoints;
        private string _basicAttack;
        protected override int LifePoints { get; set; } = 100;
        protected override int WeaponBaseDamage { get; set; }

        public Hero(string name, string elementType,
            bool hasWeapon, string weaponAttack,
            int attackPoints, string basicAttack
            ) : base(name, elementType,
                hasWeapon, weaponAttack)
        {
            _attackPoints = attackPoints;
            _basicAttack = basicAttack;
        }

        public override void ShowGameStats()
        {
            Console.WriteLine(
                $"{this.Name}: {this.ElementType} Type," +
                $" {this.LifePoints}, {this._magicPoints}");
        }
    }
}
