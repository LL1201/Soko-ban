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
using System.Runtime.InteropServices;
using System.Xml;

namespace Soko_ban
{
    public partial class Livello1 : Form
    {
        public int sizePacchi = 48;
        private int[,] campoGioco;
        private Pacco[] vetpacchi;
        private Magazziniere m;    
        
        public Livello1()
        {
            InitializeComponent();
        }

        void drawCampoGioco()
        {
            DrawingControl.SuspendDrawing(pnlCampoGioco);
            pnlCampoGioco.Controls.Clear();
            for ( int i = 0; i < campoGioco.GetLength(1); i++)
            {
                for ( int j = 0; j < campoGioco.GetLength(0); j++)
                {
                    if (campoGioco[j, i] == 1)                    
                        generaElementi("..\\..\\images\\mattoni.jpg", i, j);                    
                    else if(campoGioco[j, i]== 2)                    
                        generaElementi("..\\..\\images\\cassa.jpg", i, j);                    
                    else if(campoGioco[j,i]==3)                    
                        generaElementi("..\\..\\images\\magazziniere.jpg", i, j);
                }
            }
            lblLivello.Text = Convert.ToString(1);
            DrawingControl.ResumeDrawing(pnlCampoGioco);
        }
        private void Livello1_Load(object sender, EventArgs e)
        {            
            int pospacchi = 0;
            vetpacchi = new Pacco[6];
            campoGioco = new int[11, 19]
            {
                {0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},//1
                {0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},//2
                {0, 0, 0, 0, 1, 2, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},//3
                {0, 0, 1, 1, 1, 0, 0, 2, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},//4
                {0, 0, 1, 0, 0, 2, 0, 2, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},//5
                {1, 1, 1, 0, 1, 0, 1, 1, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1},//6
                {1, 0, 0, 0, 1, 0, 1, 1, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1},//7
                {1, 0, 2, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 1},//8
                {1, 1, 1, 1, 1, 0, 1, 1, 1, 0, 1, 0, 1, 1, 0, 0, 0, 0, 1},//9
                {0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1},//10
                {0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0},//11
            };

            for (int i = 0; i < campoGioco.GetLength(1); i++)
            {
                for (int j = 0; j < campoGioco.GetLength(0); j++)
                {
                    if (campoGioco[j, i] == 2)
                    {
                        vetpacchi[pospacchi] = new Pacco(j, i);
                        pospacchi++;
                    }
                    else if (campoGioco[j, i] == 3)
                        m = new Magazziniere(j, i);                    
                }
            }
            drawCampoGioco();
        }

        void generaElementi(string percorso, int i, int j)
        {
            pnlCampoGioco.Size = new Size(campoGioco.GetLength(1) * sizePacchi, (campoGioco.GetLength(0) * sizePacchi)+48);
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
                    KeyFunction(m.Posx, m.Posy, 0, -1);
                    drawCampoGioco();
                    break;
                case Keys.Right:
                    KeyFunction(m.Posx, m.Posy, 0, 1);
                    drawCampoGioco();
                    break;
                case Keys.Up:
                    KeyFunction(m.Posx, m.Posy, -1, 0);
                    drawCampoGioco();
                    break;
                case Keys.Down:
                    KeyFunction(m.Posx, m.Posy, 1, 0);                   
                    drawCampoGioco();
                    break;
            }
        }

        /// <summary>
        /// A seconda del tasto premuto muove l'omino in giro per il labirinto
        /// </summary>
        /// <param name="mx">Posizione x dell'omino</param>
        /// <param name="my">Posizione y dell'omino</param>
        /// <param name="x">Senso di spostamento x: (1 verso destra, -1 verso sinistra)</param>
        /// <param name="y">Senso di spostamento y: (1 verso il basso, -1 verso l'alto)</param>        
        public void KeyFunction(int mx, int my, int x, int y)
        {
            if (campoGioco[mx + x, my + y] == 0)
            {
                campoGioco[mx, my] = 0;
                campoGioco[mx + x, my + y] = 3;
                drawCampoGioco();
                m.Posy += y;
                m.Posx += x;
            }
            else if (campoGioco[mx + x, my + y] == 2)
            {
                if (campoGioco[mx + (x * 2), my + (y * 2)] == 0)
                {
                    campoGioco[mx, my] = 0;
                    campoGioco[mx + x, my + y] = 3;
                    campoGioco[mx + (x * 2), my + (y * 2)] = 2;
                    m.Posy += y;
                    m.Posx += x;
                    for(int i = 0; i < vetpacchi.GetLength(0); i++)
                    {                        
                        if(vetpacchi[i].Posx == mx + x && vetpacchi[i].Posy == my + y)
                        {
                            vetpacchi[i].Posy += y;
                            vetpacchi[i].Posx += x;                               
                        }
                    }                                    
                }
            }
        }
            
        class DrawingControl
        {
            [DllImport("user32.dll")]
            public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);

            private const int WM_SETREDRAW = 11;

            public static void SuspendDrawing(Control parent)
            {
                SendMessage(parent.Handle, WM_SETREDRAW, false, 0);
            }

            public static void ResumeDrawing(Control parent)
            {
                SendMessage(parent.Handle, WM_SETREDRAW, true, 0);
                parent.Refresh();
            }
        }

      
    }
}
