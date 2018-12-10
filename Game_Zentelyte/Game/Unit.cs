using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamoka9
{
    class Unit
    {
        
        protected int x;
        protected int y;
        protected string name;

        public Unit(int x, int y, string name) //konstruktorius
        {
            this.x = x;
            this.y = y;
            this.name = name;

        }

        public void PrintInfo() // atspausdina i ekrana
        {
            Console.WriteLine($"komentaras Unit {x} + {y} + {name}");
        }
    }

}
