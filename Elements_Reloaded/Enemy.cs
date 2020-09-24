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

        private object[] _getRandomAttack()
        {
            object[][] AttackList = new object[2][];
            AttackList[0] = new object[2] { LowAttack, LowBaseDamage };
            AttackList[1] = new object[2] { HighAttack, HighBaseDamage };

            int RandIndex = new Random().Next(AttackList.Length);
            return AttackList[RandIndex];
        }

        public int Attack()
        {
            object[] selectedAttack = _getRandomAttack();
            base.Attack((string)selectedAttack[0]);
            return (int)selectedAttack[1];
        }
    }
}
