﻿using System;
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

            string LevelName = GameController.GetLevelName(level);
            int LevelEnemiesKilled = 0;

            _introduceLevel(level);

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

            while (LevelEnemiesKilled < NumberOfEnemies)
            {
                Enemy enemy = _sendEnemy();
                // battle enemy
                Gameplay.Battle(Gameplay._hero, enemy);

                // check if hero died. if so, end game. If not, increment i
                if (Gameplay._hero.LifePoints < 0)
                {
                    Gameplay.EndGame();
                }
                else
                {
                    LevelEnemiesKilled++;
                }
            }

            Enemy boss = _sendBoss();
            Gameplay.Battle(Gameplay._hero, boss);
            // check if hero died. if so, end game. If not, clear level
            if (Gameplay._hero.LifePoints < 0)
            {
                Gameplay.EndGame();
            }
            else
            {
                _clearLevel();
            }

        }

        private static void _setLevel(int level)
        {
            _levelElement = Gameplay.GetLevelElement();
            _minionName = GameController.GetEnemyName(_levelElement, level, false);
            _bossName = GameController.GetEnemyName(_levelElement, level, true);
        }

        private static void _setLevel(int level, bool isSpecialLevel)
        {
            _levelElement = Gameplay.GetLevelElement();
            _minionName = GameController.GetEnemyName(_levelElement, level, false);
            _bossName = GameController.GetEnemyName(_levelElement, level, true);
        }

        private static void _introduceLevel(int level)
        {
            Console.WriteLine(String.Format(GameDialogue.GetLevelIntro(level), Gameplay._hero.Name));
            Console.Write("Press ENTER to continue");
            Console.ReadLine();
        }

        private static Enemy _sendEnemy()
        {
            Console.WriteLine(String.Format(GameDialogue.GetEnemyIntro(), _minionName));
            return new Enemy(_minionName, _levelElement);
        }

        private static Enemy _sendBoss()
        {
            Console.WriteLine($"You did good, but now...here comes the boss, {_bossName}!");
            return new Enemy(_bossName, _levelElement, true);
        }

        private static void _clearLevel()
        {
            Console.WriteLine($"{_bossName} is defeated! You beat the level!");
            // Coins += 75
            // XP += 50
            // clear screen
        }

    }
}
