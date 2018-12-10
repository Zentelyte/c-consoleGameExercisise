using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamoka9.GUI
{
    sealed class GameWindow : Window
    {
        private Button creditsButton;
        private Button quitButton;
        private Button startButton;
        private TextBlock titleTextBlock;

        public GameWindow() : base(0, 0, 120, 30, '%')
        {
            titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "Super duper zaidimas", "Vardas Pavardaitis kuryba!", "Made in Vilnius Coding School!" });
        }
            private List<Button> buttonList = new List<Button>()
             {
             new Button(20, 13, 18, 5, "Start"),
             new Button(50, 13, 18, 5, "Credits"),
             new Button(80, 13, 18, 5, "Quit")
             };

            public List<Button> ButtonList
        {
            get { return buttonList; }
        }

        // Render(); nereikia, nes automatiskai ispiesia viska ignoruodamas show menu funkcija

        public override void Render()
        {
            base.Render();

            titleTextBlock.Render();

            Console.SetCursorPosition(0, 0);
        }
        public void RenderButton(string mygtukas, bool active=false)
        {
            startButton = buttonList[0];
            creditsButton = buttonList[1];
            quitButton = buttonList[2];
            switch (mygtukas)
            {
                case "start":
                    if (active==true) { startButton.setActive(); } else { startButton.setnotActive(); }
                    startButton.Render();
                    break;
                case "credits":
                    if (active == true) { creditsButton.setActive(); } else { creditsButton.setnotActive(); }
                    creditsButton.Render();
                    break;
                case "quit":
                    if (active == true) { quitButton.setActive(); } else { quitButton.setnotActive(); }
                    quitButton.Render();
                    break;
                default:
                    startButton.setActive();
                    startButton.Render();
                    creditsButton.Render();
                    quitButton.Render();
                    break;

            }

            Console.SetCursorPosition(0, 0);
        }
        }
    }


    


