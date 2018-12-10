using System;
using Pamoka9.Menu;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamoka9.GUI
{
    class Button : GuiObject
    {
        private Frame activeFrame;
        private Frame notActiveFrame;
        private TextLine textLine;
        private bool isActive = false;

        public Button(int x, int y, int width, int height, string buttonText) : base(x, y, width, height)
        {
            notActiveFrame = new Frame(x, y, width, height, '+');
            activeFrame = new Frame(x, y, width, height, '#');

            textLine = new TextLine(x + 1, y + 1 + ((height - 2) / 2), width - 2, buttonText);
        }

        public override void Render()
        {

            if (isActive)
            {
                activeFrame.Render();
            }
            else
            {
                notActiveFrame.Render();
            }

            textLine.Render();
        }

        public void setActive()
        {
            isActive = true;
        }
        public void setnotActive()
        {
            isActive = false;
        }
    }
}
