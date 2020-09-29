using System;
namespace Elements_Reloaded
{
    public class Enemy : Player
    {
        protected virtual string LowAttack { get; set; }
        protected virtual string HighAttack { get; set; }
        protected virtual int LowBaseDamage { get; set; } = 20;
        protected virtual int HighBaseDamage { get; set; } = 30;
        public bool IsBoss { get; private set; } = false;

        public Enemy(string name, string elementType) :
            base(name, elementType)
        {
            LifePoints = 70;
            LowAttack = ElementInfo.GetLowAttack(elementType, false);
            HighAttack = ElementInfo.GetHighAttack(elementType, false);
        }

        public Enemy(string name, string elementType, bool isBoss) :
            base(name, elementType)
        {
            IsBoss = isBoss;
            LifePoints = isBoss ? 100 : 70;
            LowAttack = ElementInfo.GetLowAttack(elementType, true);
            HighAttack = ElementInfo.GetHighAttack(elementType, true);
        }

        private dynamic[] _getRandomAttack()
        {
            dynamic[][] AttackList = new dynamic[2][];
            AttackList[0] = new dynamic[2] { LowAttack, LowBaseDamage };
            AttackList[1] = new dynamic[2] { HighAttack, HighBaseDamage };

            int RandIndex = new Random().Next(AttackList.Length);
            return AttackList[RandIndex];
        }

        public int Attack()
        {
            dynamic[] selectedAttack = _getRandomAttack();
            base.Attack((string)selectedAttack[0]);
            return (int)selectedAttack[1];
        }
    }
}
