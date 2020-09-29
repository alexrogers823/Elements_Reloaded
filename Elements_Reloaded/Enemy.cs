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

        private Object[] _getRandomAttack()
        {
            Object[][] AttackList = new Object[2][];
            AttackList[0] = new Object[2] { LowAttack, LowBaseDamage };
            AttackList[1] = new Object[2] { HighAttack, HighBaseDamage };

            Console.WriteLine($"DEBUG: First one: {AttackList[0][0]}");
            Console.WriteLine($"DEBUG: Second one: {AttackList[1]}");

            int RandIndex = new Random().Next(AttackList.Length);
            return AttackList[RandIndex];
        }

        public int Attack()
        {
            Object[] selectedAttack = _getRandomAttack();
            Console.WriteLine($"DEBUG: selectedAttackObject {selectedAttack}");
            Console.WriteLine($"DEBUG: selectedAttack {selectedAttack[0]}");
            base.Attack((string)selectedAttack[0]);
            return (int)selectedAttack[1];
        }
    }
}
