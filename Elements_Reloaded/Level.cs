using System;
namespace Elements_Reloaded
{
    public class Level
    {
        private int _currentLevel { get; set; }

        public Level()
        {
            _currentLevel = 1;
        }

        public void PlayLevel()
        {
            int i = 0;
            string LevelName = GameDialogue.GetLevelName(_currentLevel);

            _introduceLevel();

            Console.WriteLine($"Welcome to the {LevelName}");

            if (_currentLevel == 10)
            {
                Console.WriteLine("Final Stage Begin");
            }
            else
            {
                Console.WriteLine($"Stage {_currentLevel} Begin");
            }

            Console.WriteLine("Enemies: 5");

            while (i < NumberOfEnemies)
            {
                _sendEnemy();
                // battle enemy

                // check if hero died. if so, end game. If not, increment i
            }

            _sendBoss();
            // check if hero died. if so, end game. If not, clear level

            _clearLevel();
        }

        private void _introduceLevel()
        {
            GameDialogue.GetLevelIntro(_currentLevel);
        }

        private void _sendEnemy()
        {
            Console.WriteLine(GameDialogue.GetEnemyIntro());
            return Enemy(name, elementType);
        }

        private void _sendBoss()
        {
            Console.WriteLine($"You did good, but now...here comes the boss, {}!");
            return Enemy(name, elementType, isBoss);
        }

        private void _clearLevel()
        {
            Console.WriteLine($"{} is defeated! You beat the level!");
            // Coins += 75
            // XP += 50
            // clear screen
        }

        private void _incrementLevelNumber()
        {
            _currentLevel++;
        }

    }
}
