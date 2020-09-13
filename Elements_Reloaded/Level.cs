using System;
namespace Elements_Reloaded
{
    public class Level
    {
        public static int CurrentLevel { get; set; } = 1;
        public static int NumberOfEnemies { get; set; } = 5;

        public Level()
        {
        }

        public static void PlayLevel()
        {
            int i = 0;
            string LevelName = GameDialogue.GetLevelName(CurrentLevel);

            _introduceLevel();

            Console.WriteLine($"Welcome to the {LevelName}");

            if (CurrentLevel == 10)
            {
                Console.WriteLine("Final Stage Begin");
            }
            else
            {
                Console.WriteLine($"Stage {CurrentLevel} Begin");
            }

            Console.WriteLine($"Enemies: {NumberOfEnemies}");

            while (i < NumberOfEnemies)
            {
                Enemy enemy = _sendEnemy();
                // battle enemy

                // check if hero died. if so, end game. If not, increment i
            }

            _sendBoss();
            // check if hero died. if so, end game. If not, clear level

            _clearLevel();
        }

        private static void _introduceLevel()
        {
            GameDialogue.GetLevelIntro(CurrentLevel);
        }

        private static Enemy _sendEnemy()
        {
            string EnemyName = GameController.GetEnemyName(elementType, false);
            Console.WriteLine(GameDialogue.GetEnemyIntro());
            return new Enemy(EnemyName, elementType);
        }

        private static void _sendBoss()
        {
            string BossName = GameController.GetEnemyName(elementType, true);
            Console.WriteLine($"You did good, but now...here comes the boss, {}!");
            return new Enemy(BossName, elementType, true);
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
            CurrentLevel++;
        }

    }
}
