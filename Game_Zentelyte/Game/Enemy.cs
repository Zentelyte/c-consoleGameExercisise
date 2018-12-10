using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pamoka9
{
    class Enemy : Unit
    {
        private int id;

        /*public Enemy(int id, int x, int y, string name) //konstruktorius pries sukuriant unit klase, kuria isplecia hero
         // pries tai virsuje buvo kintamieji, bet kadangi jie yra tie patys kintamieji, kuriuos turi unit, nereikia ju dubliuoti
        {
            this.id = id;
            this.x = x;
            this.y = y;
            this.name = name;

        }*/

        public Enemy(int id, int x, int y, string name) : base(x, y, name)
        {
            this.id = id;
        }


        public void MoveDown() // pajudina i desine
        {
            y++;
        }

        public int GetId()
        {
            return id;
        }

    }
}
