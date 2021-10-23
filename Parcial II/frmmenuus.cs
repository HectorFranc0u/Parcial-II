using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_II
{
    public partial class frmmenuus : Form
    {
        public frmmenuus()
        {
            InitializeComponent();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmProfile frmProfile = new frmProfile();
            frmProfile.Show();
        }
    }
}
