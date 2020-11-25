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

        private void btnAvvia_Click(object sender, EventArgs e)
        {
            Livello livello1 = new Livello();
            livello1.livello = Convert.ToInt32(txtLevel.Text) - 1;
            livello1.LivShow();
        }
    }
}
