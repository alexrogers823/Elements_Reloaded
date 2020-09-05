using System;
namespace Elements_Reloaded
{
    public abstract class Player
    {
        protected string Name;
        protected string ElementType;
        protected virtual int LifePoints { get; set; }
        protected bool HasWeapon;
        protected string WeaponAttack;
        protected virtual int WeaponBaseDamage { get; set; }

        public Player(string name, string elementType,
            bool hasWeapon, string weaponAttack)
        {
            Name = name;
            ElementType = elementType;
            HasWeapon = hasWeapon;
            WeaponAttack = weaponAttack;
        }

        public void TakeDamage(int damage)
        {
            LifePoints -= damage;
        }

        public int GetLP()
        {
            return LifePoints;
        }

        public virtual void ShowGameStats()
        {
            Console.WriteLine(
                $"{this.Name}: {this.ElementType} Type," +
                $" {this.LifePoints}");
        }
    }
}
