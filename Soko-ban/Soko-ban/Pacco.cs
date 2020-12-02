using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Soko_ban
{  
    public class Pacco
    {
        private Point position;
        public PictureBox pboxp;
        private int sizePacchi;

        public Pacco(int x, int y, int sizePacchi, Image image)
        {
            position.X = x;
            position.Y = y;

            pboxp = new PictureBox();
            pboxp.Image = new Bitmap(image);
            pboxp.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxp.Visible = true;
            pboxp.Location = new Point(y * sizePacchi, x * sizePacchi);
            pboxp.Size = new Size(sizePacchi, sizePacchi);
            this.sizePacchi = sizePacchi;
        }

        public int Posx
        {
            get => position.X;
            set
            {
                position.X = value;
                pboxp.Location = new Point(position.Y * sizePacchi, position.X * sizePacchi);
            }            
        }
        public int Posy
        {
            get => position.Y;
            set
            {
                position.Y = value;
                pboxp.Location = new Point(position.Y * sizePacchi, position.X * sizePacchi);
            }
        }
    }
}
