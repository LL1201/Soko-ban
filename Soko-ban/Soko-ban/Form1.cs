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

namespace Soko_ban
{
    public partial class Form1 : Form
    {
        public int sizePacchi = 48;
        private int[,] campoGioco;
        private Pacco[] vetpacchi;
        private Magazziniere m;    
        
        public Form1()
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
            DrawingControl.ResumeDrawing(pnlCampoGioco);
        }
        private void Form1_Load(object sender, EventArgs e)
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
                {1, 0, 2, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 1},//8
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
                    {
                        m = new Magazziniere();
                    }
                }
            }
            drawCampoGioco();            
        }

       void generaElementi(string percorso, int i, int j)
       {
            pnlCampoGioco.Size = new Size(campoGioco.GetLength(1) * sizePacchi, campoGioco.GetLength(0) * sizePacchi);
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
                    if (campoGioco[m.position.X , m.position.Y-1] == 0)
                    { 
                        campoGioco[m.position.X, m.position.Y] = 0;
                        campoGioco[m.position.X, m.position.Y - 1] = 3;
                        drawCampoGioco();
                        m.position.Y--;                       
                    }
                    else if (campoGioco[m.position.X, m.position.Y - 1] == 2)
                    {
                        if(campoGioco[m.position.X, m.position.Y - 2] != 2 && campoGioco[m.position.X, m.position.Y - 2] != 1)
                        {
                            campoGioco[m.position.X, m.position.Y] = 0;
                            campoGioco[m.position.X, m.position.Y - 1] = 3;
                            for(int i=0;i<vetpacchi.GetLength(0);i++)
                            {
                                if (vetpacchi[i].position.X == m.position.X && vetpacchi[i].position.Y == m.position.Y - 1)
                                {
                                    campoGioco[vetpacchi[i].position.X, vetpacchi[i].position.Y - 1] = 2;
                                    vetpacchi[i].position.Y--;
                                    m.position.Y--;
                                }
                            }
                            drawCampoGioco();                            
                        }
                    }
                    break;
                case Keys.Right:
                    if (campoGioco[m.position.X, m.position.Y+1] == 0)
                    {
                        campoGioco[m.position.X, m.position.Y] = 0;
                        campoGioco[m.position.X, m.position.Y + 1] = 3;
                        drawCampoGioco();
                        m.position.Y++;
                    }
                    else if (campoGioco[m.position.X, m.position.Y + 1] == 2)
                    {
                        if (campoGioco[m.position.X, m.position.Y + 2] != 2 && campoGioco[m.position.X, m.position.Y + 2] != 1)
                        {
                            campoGioco[m.position.X, m.position.Y] = 0;
                            campoGioco[m.position.X, m.position.Y + 1] = 3;
                            for (int i = 0; i < vetpacchi.GetLength(0); i++)
                            {
                                if (vetpacchi[i].position.X == m.position.X && vetpacchi[i].position.Y == m.position.Y + 1)
                                {
                                    campoGioco[vetpacchi[i].position.X, vetpacchi[i].position.Y + 1] = 2;
                                    vetpacchi[i].position.Y++;
                                    m.position.Y++;
                                }
                            }
                            drawCampoGioco();
                        }
                    }
                    break;
                case Keys.Up:
                    if (campoGioco[m.position.X-1, m.position.Y] == 0)
                    {
                        campoGioco[m.position.X, m.position.Y] = 0;
                        campoGioco[m.position.X-1, m.position.Y] = 3;
                        drawCampoGioco();
                        m.position.X--;
                    }
                    else if (campoGioco[m.position.X-1, m.position.Y] == 2)
                    {
                        if (campoGioco[m.position.X-2, m.position.Y] != 2 && campoGioco[m.position.X-2, m.position.Y] != 1)
                        {
                            campoGioco[m.position.X, m.position.Y] = 0;
                            campoGioco[m.position.X-1, m.position.Y] = 3;
                            for (int i = 0; i < vetpacchi.GetLength(0); i++)
                            {
                                if (vetpacchi[i].position.Y == m.position.Y && vetpacchi[i].position.X == m.position.X-1)
                                {
                                    campoGioco[vetpacchi[i].position.X-1, vetpacchi[i].position.Y] = 2;
                                    vetpacchi[i].position.X--;
                                    m.position.X--;
                                }
                            }
                            drawCampoGioco();
                        }
                    }
                    break;
                case Keys.Down:
                    if (campoGioco[m.position.X + 1, m.position.Y] == 0)
                    {
                        campoGioco[m.position.X, m.position.Y] = 0;
                        campoGioco[m.position.X + 1, m.position.Y] = 3;
                        drawCampoGioco();
                        m.position.X++;
                    }
                    else if (campoGioco[m.position.X + 1, m.position.Y] == 2)
                    {
                        if (campoGioco[m.position.X + 2, m.position.Y] != 2 && campoGioco[m.position.X + 2, m.position.Y] != 1)
                        {
                            campoGioco[m.position.X, m.position.Y] = 0;
                            campoGioco[m.position.X + 1, m.position.Y] = 3;
                            for (int i = 0; i < vetpacchi.GetLength(0); i++)
                            {
                                if (vetpacchi[i].position.Y == m.position.Y && vetpacchi[i].position.X == m.position.X + 1)
                                {
                                    campoGioco[vetpacchi[i].position.X + 1, vetpacchi[i].position.Y] = 2;
                                    vetpacchi[i].position.X++;
                                    m.position.X++;
                                }
                            }
                            drawCampoGioco();
                        }
                    }
                    break;
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

