using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamoka9.Menu
{
    class GameController
    {

        static void StartGame()
        {
            // init game
            GameScreen myGame = new GameScreen(30, 20);

            // fill game with game data.
            myGame.SetHero(new Hero(5, 5, "HERO"));

            Random rnd = new Random();
            int enemyCount = 0;
            for (int i = 0; i < 10; i++)
            {
                myGame.AddEnemy(new Enemy(enemyCount, rnd.Next(0, 10), rnd.Next(0, 10), "enemy" + enemyCount));
                enemyCount++;
            }

            // render loop
            bool needToRender = true;

            do
            {
                // isvalom ekrana
                Console.Clear();
            }
            while (Console.KeyAvailable);
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
            }
            while (needToRender) ;

        }
    }
}
