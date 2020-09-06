using System;
namespace Elements_Reloaded
{
    public class Enemy : Player
    {
        protected virtual string LowAttack { get; set; }
        protected virtual string HighAttack { get; set; }
        protected virtual int LowBaseDamage { get; set; }
        protected virtual int HighBaseDamage { get; set; }
        public bool IsBoss { get; private set; } = false;

        public Enemy(string name, string elementType) :
            base(name, elementType)
        {
            LifePoints = 70;
        }

        public Enemy(string name, string elementType, bool isBoss) :
            base(name, elementType)
        {
            IsBoss = isBoss;
            LifePoints = isBoss ? 100 : 70;
        }
    }
}
