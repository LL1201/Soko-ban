using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Soko_ban
{
    enum Colore
    {
        rosso,
        giallo,
        blu,
        verde,
        viola
    }
    class Pacco
    {
        private Colore colore;
        private static Random r =new Random();

        public Pacco()
        {
            int c;
            c = r.Next(5);

            switch (c)
            {
                case 0:
                    colore = Colore.rosso;
                    break;
                case 1:
                    colore = Colore.giallo;
                    break;
                case 2:
                    colore = Colore.blu;
                    break;
                case 3:
                    colore = Colore.verde;
                    break;
                case 4:
                    colore = Colore.viola;
                    break;
            }
        }

    }
}
