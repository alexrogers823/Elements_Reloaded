using System;
namespace Elements_Reloaded
{
    public class Level
    {
        
        public static int NumberOfEnemies { get; set; } = 5;
        private static string _levelElement { get; set; }
        private static string _minionName { get; set; }
        private static string _bossName { get; set; }

        public Level()
        {
        }

        public static void PlayLevel(int level)
        {
            if (level == 8 || level == 10)
            {
                _setLevel(level, true);
            }
            else
            {
                _setLevel(level);
            }

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

            _clearLevel(boss);
        }

        private static void _setLevel(int level)
        {
            _levelElement = Gameplay.GetLevelElement();
            Console.WriteLine($"DEBUG: Level element set as {_levelElement}");
            _minionName = GameController.GetEnemyName(_levelElement, level, false);
            _bossName = GameController.GetEnemyName(_levelElement, level, true);
        }

        private static void _setLevel(int level, bool isSpecialLevel)
        {
            _levelElement = Gameplay.GetLevelElement();
            Console.WriteLine($"DEBUG: Level element set as {_levelElement}");
            _minionName = GameController.GetEnemyName(_levelElement, level, false);
            _bossName = GameController.GetEnemyName(_levelElement, level, true);
        }

        private static void _introduceLevel()
        {
            GameDialogue.GetLevelIntro(Gameplay.CurrentLevel);
        }

        private static Enemy _sendEnemy()
        {
            Console.WriteLine(GameDialogue.GetEnemyIntro());
            return new Enemy(_minionName, _levelElement);
        }

        private static Enemy _sendBoss()
        {
            Console.WriteLine($"You did good, but now...here comes the boss, {_bossName}!");
            return new Enemy(_bossName, _levelElement, true);
        }

        private static void _clearLevel(Enemy Boss)
        {
            Console.WriteLine($"{Boss} is defeated! You beat the level!");
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
