using System;
namespace Elements_Reloaded
{
    public class Level
    {
        
        public static int NumberOfEnemies { get; set; } = 5;
        private static string _levelElement { get; set; }

        public Level()
        {
        }

        public static void PlayLevel(int level)
        {
            _setLevelElement();
            string LevelName = GameDialogue.GetLevelName(level);
            int i = 0;

            _introduceLevel();

            Console.WriteLine($"Welcome to the {LevelName}");

            if (level == 10)
            {
                Console.WriteLine("Final Stage Begin");
            }
            else
            {
                Console.WriteLine($"Stage {level} Begin");
            }

            Console.WriteLine($"Enemies: {NumberOfEnemies}");

            while (i < NumberOfEnemies)
            {
                Enemy enemy = _sendEnemy();
                // battle enemy
                Gameplay.Battle(Gameplay._hero, enemy);

                // check if hero died. if so, end game. If not, increment i
            }

            Enemy boss = _sendBoss();
            Gameplay.Battle(Gameplay._hero, boss);
            // check if hero died. if so, end game. If not, clear level

            _clearLevel();
        }

        private static void _setLevelElement()
        {
            _levelElement = Gameplay.GetLevelElement();
        }

        private static void _introduceLevel()
        {
            GameDialogue.GetLevelIntro(Gameplay.CurrentLevel);
        }

        private static Enemy _sendEnemy()
        {
            string EnemyName = GameController.GetEnemyName(_levelElement, false);
            Console.WriteLine(GameDialogue.GetEnemyIntro());
            return new Enemy(EnemyName, _levelElement);
        }

        private static Enemy _sendBoss()
        {
            string BossName = GameController.GetEnemyName(_levelElement, true);
            Console.WriteLine($"You did good, but now...here comes the boss, {}!");
            return new Enemy(BossName, _levelElement, true);
        }

        private static void _clearLevel()
        {
            Console.WriteLine($"{} is defeated! You beat the level!");
            // Coins += 75
            // XP += 50
            _incrementLevelNumber();
            // clear screen
        }

        private static void _incrementLevelNumber()
        {
            Gameplay.CurrentLevel++;
        }

    }
}
