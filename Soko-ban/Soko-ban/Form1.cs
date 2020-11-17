using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soko_ban
{
    public partial class Form1 : Form
    {
        public int sizePacchi = 48;
        private int[,] campoGioco;
        public Form1()
        {
            InitializeComponent();
        }

        void drawCampoGioco()
        {
            pnlCampoGioco.Controls.Clear();
            campoGioco = new int[11, 19]
            {
                {0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},//1
                {0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},//2
                {0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},//3
                {0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},//4
                {0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},//5
                {1, 1, 1, 0, 1, 0, 1, 1, 0, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1},//6
                {1, 0, 0, 0, 1, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1},//7
                {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},//8
                {1, 1, 1, 1, 1, 0, 1, 1, 1, 0, 1, 0, 1, 1, 0, 0, 0, 0, 1},//9
                {0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1},//10
                {0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0},//11
            };

            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    if (campoGioco[j, i] == 1)
                    {
                        pnlCampoGioco.Size = new Size(19 * sizePacchi, 11 * sizePacchi);
                        PictureBox pbox = new PictureBox();
                        pbox.Image = new Bitmap(@"mattoni.jpg");
                        pbox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pbox.Visible = true;
                        pbox.Location = new Point(i * sizePacchi, j * sizePacchi);
                        pbox.Size = new Size(sizePacchi, sizePacchi);
                        pnlCampoGioco.Controls.Add(pbox);
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            drawCampoGioco();
        }
    }
}
