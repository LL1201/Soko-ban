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
using Newtonsoft.Json;

namespace Soko_ban
{
    public partial class Livello : Form
    {
        public int sizePacchi = 48;
        private int[,] campoGioco;
        private List<Pacco> lstPacchi = new List<Pacco>();
        private Magazziniere m;
        public int livello;
        private Image muro, pacco, magazziniere, trigger;        
        private int tempo = 0;        

        public void LivShow()
        {
            this.ShowDialog();
        }

        public Livello()
        {
            InitializeComponent();
        }
        
        private void Livello_Load(object sender, EventArgs e)
        {
            //apertura file JSON e assegnazione di tutto il suo contenuto a livelli facente parte della classe LevelsRoot
            StreamReader reader = new StreamReader("..\\..\\resources\\livelli.json");
            LevelsRoot livelli = JsonConvert.DeserializeObject<LevelsRoot>(reader.ReadToEnd());
            campoGioco = new int[livelli.Levels[livello].Matrixr, livelli.Levels[livello].Matrixc];
            lblLivello.Text = livelli.Levels[livello].Name;

            muro = Image.FromFile("..\\..\\images\\mattoni.jpg");
            pacco = Image.FromFile("..\\..\\images\\cassa.jpg");
            magazziniere = Image.FromFile("..\\..\\images\\magazziniere.jpg");            

            int cont = 0;
            lstPacchi.Clear();

            //cicli necessari per inserire i valori successivi della lista in una matrice ordinata
            do
            {
                for (int i = 0; i < livelli.Levels[livello].Matrixr; i++)
                {
                    for (int j = 0; j < livelli.Levels[livello].Matrixc; j++)
                    {
                        campoGioco[i, j] = livelli.Levels[livello].Matrix[cont];
                        cont++;
                    }
                }
            } while (cont < livelli.Levels[livello].Matrixr * livelli.Levels[livello].Matrixc);
            pnlCampoGioco.Size = new Size(campoGioco.GetLength(1) * sizePacchi, (campoGioco.GetLength(0) * sizePacchi) + 48);
            //scansione matrice per verificare la presenza di muri e pacchi e quindi per la loro istanziazione e disegno
            for (int i = 0; i < campoGioco.GetLength(1); i++)
            {
                for (int j = 0; j < campoGioco.GetLength(0); j++)
                {
                    if (campoGioco[j, i] == 2)
                        lstPacchi.Add(new Pacco(j, i, sizePacchi, pacco));
                    else if (campoGioco[j, i] == 3)
                    {
                        m = new Magazziniere(j, i, sizePacchi, magazziniere);
                        pnlCampoGioco.Controls.Add(m.pboxm);
                    }
                    else if (campoGioco[j, i] == 1)
                    {                        
                        PictureBox pbox = new PictureBox();
                        pbox.Image = new Bitmap(muro);
                        pbox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pbox.Visible = true;
                        pbox.Location = new Point(i * sizePacchi, j * sizePacchi);
                        pbox.Size = new Size(sizePacchi, sizePacchi);
                        pnlCampoGioco.Controls.Add(pbox);
                    }
                    /*else if (campoGioco[j, i] == -1)
                    {
                        PictureBox pbox = new PictureBox();
                        pbox.Image = new Bitmap(trigger);
                        pbox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pbox.Visible = true;
                        pbox.Location = new Point(i * sizePacchi, j * sizePacchi);
                        pbox.Size = new Size(sizePacchi, sizePacchi);
                        pnlCampoGioco.Controls.Add(pbox);
                    }*/

                }
            }
            reader.Close();            
            foreach (Pacco p in lstPacchi)
            {
                p.pboxp.Location = new Point(p.Posy * sizePacchi, p.Posx * sizePacchi);
                pnlCampoGioco.Controls.Add(p.pboxp);
            }
        }     

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (tmrTempo.Enabled == false)
                tmrTempo.Enabled = true;
            switch (e.KeyCode)
            {
                case Keys.Left:                    
                    KeyFunc(m.Posx, m.Posy, 0, -1);                    
                    break;
                case Keys.Right:                    
                    KeyFunc(m.Posx, m.Posy, 0, 1);                   
                    break;
                case Keys.Up:                    
                    KeyFunc(m.Posx, m.Posy, -1, 0);                    
                    break;
                case Keys.Down:                    
                    KeyFunc(m.Posx, m.Posy, 1, 0);                    
                    break;
            }
        }

        public void KeyFunc(int mx, int my, int x, int y)
        {
            if (campoGioco[mx + x, my + y] == 0)
            {
                campoGioco[mx, my] = 0;                               
                m.Posy += y;
                m.Posx += x;
                m.Mosse++;                
            }
            else if (campoGioco[mx + x, my + y] == 2)
            {
                if (campoGioco[mx + (x * 2), my + (y * 2)] == 0)
                {
                    campoGioco[mx, my] = 0;                    
                    campoGioco[mx + (x * 2), my + (y * 2)] = 2;
                    m.Posy += y;
                    m.Posx += x;

                    Pacco pacco = lstPacchi.Find(s => s.Posx == mx + x && s.Posy == my + y);
                    pacco.Posx += x;
                    pacco.Posy += y;
                    m.Spinte++;
                    m.Mosse++;                    
                }
            }
            lblMosse.Text = Convert.ToString(m.Mosse);
            lblPushes.Text = Convert.ToString(m.Spinte);
        }

        private void tmrTempo_Tick(object sender, EventArgs e)
        {
            tempo++;
            lblTempo.Text = Convert.ToString(TimeSpan.FromSeconds(tempo));
        }        
    }
}
