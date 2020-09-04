using System;
namespace Elements_Reloaded
{
    public class Player
    {
        protected string Name;
        protected string ElementType;
        protected virtual int LifePoints { get; set; }
        protected bool HasWeapon;
        protected string WeaponAttack;

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
    }
}
