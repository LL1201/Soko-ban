using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Soko_ban
{
    class Magazziniere
    {
        private Point position;
        
        public Magazziniere(int x, int y)
        {
            position.X = x;
            position.Y = y;
        }

        public int Posx
        {
            get => position.X;
            set => position.X = value;
        }
        public int Posy
        {
            get => position.Y;
            set => position.Y = value;
        }
    }
}
