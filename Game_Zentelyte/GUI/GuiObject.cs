using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamoka9.GUI
{
    abstract class GuiObject // abstract klase nes jos objektu nebus daugiau // 
    {
        protected int _x;
        protected int _y;
        protected int _height;
        protected int _width;

        public GuiObject(int x, int y, int width, int height)
        {
            _x = x; // x reiksme atkeliauja is objekto ir isiraso i kintamaji klases
            _y = y;
            _width = width;
            _height = height;
        }

        public abstract void Render(); // rodo ekrana // abstract todel negali declare body, uztat vaikai render turi tai padaryti
       
    }
}
