using System;
namespace Elements_Reloaded
{
    public class Enemy : Player
    {
        protected virtual string LowAttack { get; set; } = "Example Low Attack";
        protected virtual string HighAttack { get; set; } = "Example High Attack";
        protected virtual int LowBaseDamage { get; set; } = 20;
        protected virtual int HighBaseDamage { get; set; } = 30;
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

        private dynamic[] _getRandomAttack()
        {
            dynamic[][] AttackList = new dynamic[2][];
            AttackList[0] = new dynamic[2] { LowAttack, LowBaseDamage };
            AttackList[1] = new dynamic[2] { HighAttack, HighBaseDamage };

            Console.WriteLine($"DEBUG: First one: {AttackList[0][0]}");
            Console.WriteLine($"DEBUG: Second one: {AttackList[1]}");

            int RandIndex = new Random().Next(AttackList.Length);
            return AttackList[RandIndex];
        }

        public int Attack()
        {
            dynamic[] selectedAttack = _getRandomAttack();
            Console.WriteLine($"DEBUG: selectedAttackdynamic {selectedAttack}");
            Console.WriteLine($"DEBUG: selectedAttack {selectedAttack[0]}");
            base.Attack((string)selectedAttack[0]);
            return (int)selectedAttack[1];
        }
    }
}
