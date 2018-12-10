using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamoka9
{
    class Game
    {
        void StartGame()
        {

            Hero Hero = new Hero(5, 5, "hero");
            Hero.PrintInfo();
            Hero.MoveRight();
            Hero.PrintInfo();

            Enemy myEnemy = new Enemy(1, 2, 4, "vardas");
            myEnemy.PrintInfo();
            myEnemy.MoveDown();
            myEnemy.PrintInfo();


            int enemyCount = 0;
            Random rnd = new Random();

            List<Enemy> enemies = new List<Enemy>();

            for (int i = 0; i < 10; i++)
            {
                enemies.Add(new Enemy(enemyCount, rnd.Next(0, 10), rnd.Next(0, 10), "enemy" + enemyCount));
                enemyCount++;
            }

            Hero.PrintInfo();
            foreach (Enemy enemy in enemies)
            {
                enemy.PrintInfo();
            }

            Hero.MoveLeft();
            foreach (Enemy enemy in enemies)
            {
                enemy.MoveDown();
            }

            Hero.PrintInfo();
            foreach (Enemy enemy in enemies)
            {
                enemy.PrintInfo();
            }

            Console.ReadKey();


            GameScreen myGame = new GameScreen(30, 20);
            myGame.SetHero(new Hero(5, 5, "HERO"));


            for (int i = 0; i < 10; i++)
            {
                myGame.AddEnemy(new Enemy(enemyCount, rnd.Next(0, 10), rnd.Next(0, 10), "enemy" + enemyCount));
                enemyCount++;
            }

            myGame.Render();

            myGame.GetHero().MoveLeft();
            myGame.MoveAllEnemiesDown();

            Enemy secondEnemy = myGame.getEnemyById(1);
            if (secondEnemy != null)
            {
                secondEnemy.MoveDown();
            }

            myGame.Render();

            Console.ReadKey();

            bool needToRender = true;

            do
            {
                Console.Clear();

            } while (Console.KeyAvailable);
            {
                ConsoleKeyInfo pressedChar = Console.ReadKey(true);

                switch (pressedChar.Key)
                {
                    case ConsoleKey.Escape:
                        needToRender = false;
                        break;
                    case ConsoleKey.RightArrow:
                        myGame.GetHero().MoveRight();
                        break;
                    case ConsoleKey.LeftArrow:
                        myGame.GetHero().MoveLeft();
                        break;
                }
                myGame.Render();
                System.Threading.Thread.Sleep(250);
            } while (needToRender) ;
        

        }

    }
}
