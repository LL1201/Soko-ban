using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soko_ban
{
    public partial class Form1 : Form
    {
        public int sizePacchi = 48,i,j;
        private int[,] campoGioco;
        Magazziniere m = new Magazziniere();
        public Form1()
        {
            InitializeComponent();
        }

        void drawCampoGioco()
        {
            pnlCampoGioco.Controls.Clear();
            for ( i = 0; i < 19; i++)
            {
                for ( j = 0; j < 11; j++)
                {
                    if (campoGioco[j, i] == 1)
                    {
                        generaElementi("..\\..\\images\\mattoni.jpg", i, j);
                    }
                    else if(campoGioco[j, i]== 2)
                    {
                        generaElementi("..\\..\\images\\cassa.jpg", i, j);
                    }
                    else if(campoGioco[j,i]==3)
                    {
                        generaElementi("..\\..\\images\\magazziniere.jpg", i, j);
                    }
                       
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            campoGioco = new int[11, 19]
            {
                {0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},//1
                {0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},//2
                {0, 0, 0, 0, 1, 2, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},//3
                {0, 0, 1, 1, 1, 0, 0, 2, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},//4
                {0, 0, 1, 0, 0, 2, 0, 2, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},//5
                {1, 1, 1, 0, 1, 0, 1, 1, 0, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1},//6
                {1, 0, 0, 0, 1, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1},//7
                {1, 0, 2, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 1},//8
                {1, 1, 1, 1, 1, 0, 1, 1, 1, 0, 1, 0, 1, 1, 0, 0, 0, 0, 1},//9
                {0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1},//10
                {0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0},//11
            };
            drawCampoGioco();
        }

       void generaElementi(string percorso, int i, int j)
        {
            pnlCampoGioco.Size = new Size(19 * sizePacchi, 11 * sizePacchi);
            PictureBox pbox = new PictureBox();
            pbox.Image = new Bitmap(percorso);
            pbox.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox.Visible = true;
            pbox.Location = new Point(i * sizePacchi, j * sizePacchi);
            pbox.Size = new Size(sizePacchi, sizePacchi);
            pnlCampoGioco.Controls.Add(pbox);
        }
        
       private void Form1_KeyDown(object sender, KeyEventArgs e)
       {
            switch(e.KeyCode)
            {
                case Keys.Left:
                    //if (campoGioco[m.position.X , m.position.Y] != 1)
                    //{ 
                        campoGioco[m.position.X, m.position.Y] = 0;
                        campoGioco[m.position.X - 1, m.position.Y] = 3;
                        MessageBox.Show(Convert.ToString(m.position.X));
                        drawCampoGioco();
                    //}

                    break;
            }
       }
    }
}

