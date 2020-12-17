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
    public partial class MenuGioco : Form
    {
        public MenuGioco()
        {
            InitializeComponent();
        }        

        private void btnLiv_Click(object sender, EventArgs e)
        {
            frmLivello livello1 = new frmLivello();
            switch (((Button)sender).Name)
            {
                case "btnLiv1":                    
                    livello1.livello = 0;
                    livello1.LivShow();
                    break;
                case "btnLiv2":                    
                    livello1.livello = 1;
                    livello1.LivShow();
                    break;
                case "btnLiv3":
                    livello1.livello = 2;
                    livello1.LivShow();
                    break;
                case "btnLiv4":
                    livello1.livello = 3;
                    livello1.LivShow();
                    break;
            }
        }
    }
}
