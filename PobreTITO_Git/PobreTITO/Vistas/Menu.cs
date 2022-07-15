using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PobreTITO
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_RECLAMOS_Click(object sender, EventArgs e)
        {
            Reclamo reclamo = new Reclamo();
            reclamo.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
