using System;
namespace Elements_Reloaded
{
    public class Player
    {
        private string _elementType;
        private int _lifePoints;
        private bool _hasWeapon;
        private string _weaponAttack;

        public Player(string elementType, int lifePoints,
            bool hasWeapon, string weaponAttack)
        {
            _elementType = elementType;
            _lifePoints = lifePoints;
            _hasWeapon = hasWeapon;
            _weaponAttack = weaponAttack;
        }

        public void TakeDamage(int damage)
        {
            _lifePoints -= damage;
        }

        public int GetLP()
        {
            return _lifePoints;
        }
    }
}
