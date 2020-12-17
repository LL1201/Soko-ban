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

        private void btnLiv1_Click(object sender, EventArgs e)
        {
            frmLivello livello1 = new frmLivello();
            livello1.livello = 0;
            livello1.LivShow();
        }

        private void btnLiv2_Click(object sender, EventArgs e)
        {
            frmLivello livello1 = new frmLivello();
            livello1.livello = 1;
            livello1.LivShow();
        }

        private void btnLiv3_Click(object sender, EventArgs e)
        {
            frmLivello livello1 = new frmLivello();
            livello1.livello = 2;
            livello1.LivShow();
        }
    }
}
