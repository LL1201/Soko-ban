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
        Image pacco, triggered;
        Point triggerI, triggerF;

        public Pacco(int x, int y, int sizePacchi, Image pacco, Image triggered, Point triggerpti, Point triggerptf)
        {
            position.X = x;
            position.Y = y;
            this.pacco = pacco;
            this.triggered = triggered;
            triggerF = triggerptf;
            triggerI = triggerpti;

            //picture box relativa al pacco
            pboxp = new PictureBox();
            pboxp.Image = new Bitmap(pacco);
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
                PicChange();
            }            
        }
        public int Posy
        {
            get => position.Y;
            set
            {
                position.Y = value;
                pboxp.Location = new Point(position.Y * sizePacchi, position.X * sizePacchi);
                PicChange();
            }
        }
        private void PicChange()
        {
            if (paccoOk())
                pboxp.Image = new Bitmap(triggered);
            else if(!paccoOk() && pboxp.Image == triggered)
                pboxp.Image = new Bitmap(pacco);
        }
        public bool paccoOk()
        {
            if (Posx >= triggerI.Y && Posx <= triggerF.Y && Posy >= triggerI.X && Posy <= triggerF.X)
                return true;
            else
                return false;
        }
    }
}
