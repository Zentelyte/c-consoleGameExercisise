using System;
using Pamoka9.GUI;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamoka9.Menu
{
    class GuiController
    {
        public GuiController() // guicontroller konstruktorius sukuria game ir credit window objektus 
        {
            GameWindow _gameWindow = new GameWindow();
            CreditWindow _creditWindow = new CreditWindow();
        }

        public void ShowMenu()
        {
            GameWindow gameWindow = new GameWindow();
            gameWindow.Render();
            gameWindow.RenderButton("all");
            ConsoleKeyInfo cki;
            bool StartActive = true, creditsActive = false, quitActive = false;
            while (true)
            {
                // Start a console read operation. Do not display the input.
                cki = Console.ReadKey(true);

                // cki.Key - access key //LeftArrow
                if (cki.Key == ConsoleKey.RightArrow && StartActive == true)
                {
                    gameWindow.RenderButton("start", false);
                    gameWindow.RenderButton("credits", true);
                    StartActive = false;
                    creditsActive = true;
                }
                else if (cki.Key == ConsoleKey.RightArrow && creditsActive == true)
                {
                    gameWindow.RenderButton("start", false);
                    gameWindow.RenderButton("credits", false);
                    gameWindow.RenderButton("quit", true);
                    StartActive = false;
                    creditsActive = false;
                    quitActive = true;
                }
                else if (cki.Key == ConsoleKey.LeftArrow && creditsActive == true)
                {
                    gameWindow.RenderButton("start", true);
                    gameWindow.RenderButton("credits", false);
                    gameWindow.RenderButton("quit", false);
                    StartActive = true;
                    creditsActive = false;
                    quitActive = false;
                }
                else if (cki.Key == ConsoleKey.LeftArrow && quitActive == true )
                {
                    gameWindow.RenderButton("start", false);
                    gameWindow.RenderButton("credits", true);
                    gameWindow.RenderButton("quit", false);
                    StartActive = false;
                    creditsActive = true;
                    quitActive = false;
                }
               
                if (cki.Key == ConsoleKey.Escape) break;
            }

            /* {
        ConsoleKeyInfo keyInfo = Console.ReadKey();

        for (int i = 0; i < buttonList.Count; i++) //  ????
        {
            if (keyInfo.Key == ConsoleKey.RightArrow || keyInfo.Key == ConsoleKey.LeftArrow)
                buttonList[i].setActive();
        }*/
            /* do
             {
                 ConsoleKeyInfo keyInfo = Console.ReadKey();

                 // Your code could perform some useful task in the following loop. However, 
                 // for the sake of this example we'll merely pause for a quarter second.

             } while (Console.KeyAvailable == false);
                     Thread.Sleep(250); // Loop until input is entered.

               //  cki = Console.ReadKey(true);
             } //while (cki.Key != ConsoleKey.X);*/
        }


    }
    
}
