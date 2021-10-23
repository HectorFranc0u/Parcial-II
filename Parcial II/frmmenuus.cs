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
            string datetime = DateTime.Now.ToString("HH:mm:ss MM-dd");
            Account account = new Account();
            account._UserID = frmInicio.valor;
            account._Usname = frmInicio.usuario;
            account._TimeLoggedIn = frmInicio.tiempo + " - " + datetime;

            account.setlog();
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmProfile frmProfile = new frmProfile();
            frmProfile.Show();
        }

        private void frmmenuus_Load(object sender, EventArgs e)
        {
        }
    }
}
