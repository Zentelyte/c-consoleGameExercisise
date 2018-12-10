using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamoka9
{
    class Hero : Unit // deklaruojame kad hero isplecia unita, cia patys rasom dvitaski, taip padarome hero unit klases dalimi
    {


        /* public Hero(int x, int y, string name) //konstruktorius pries sukuriant unit klase, kuria isplecia hero
         {
             this.x = x;
             this.y = y;
             this.name = name;
        }*/

        public Hero(int x, int y, string name) : base(x, y, name)
        {

        }

        public void MoveRight() // pajudina i desine
        {
            x++;
        }


        public void MoveLeft() // pajudina i kaire
        {
            x--;
        }

    }

    }

