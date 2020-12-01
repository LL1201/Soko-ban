using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soko_ban
{
    class Magazziniere
    {
        private Point position;
        public PictureBox pboxm;
        private int mosse, spinte;
        private int sizePacchi;
        
        public Magazziniere(int x, int y, int sizePacchi, Image image)
        {
            position.X = x;
            position.Y = y;
            mosse = spinte = 0;

            pboxm = new PictureBox();
            pboxm.Image = new Bitmap(image);
            pboxm.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxm.Visible = true;
            pboxm.Location = new Point(position.Y * sizePacchi, position.X * sizePacchi);
            pboxm.Size = new Size(sizePacchi, sizePacchi);
            this.sizePacchi = sizePacchi;
        }
        public int Posx
        {
            get => position.X;
            set
            {
                position.X = value;
                pboxm.Location = new Point(position.Y * sizePacchi, position.X * sizePacchi);
            }
        }
        public int Posy
        {
            get => position.Y;
            set
            {
                position.Y = value;
                pboxm.Location = new Point(position.Y * sizePacchi, position.X * sizePacchi);
            }
        }
        public int Mosse
        {
            get => mosse;
            set => mosse = value;
        }
        public int Spinte
        {
            get => spinte;
            set => spinte = value;
        }        
    }
}
