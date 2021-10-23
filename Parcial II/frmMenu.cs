using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace Parcial_II
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmProfile frmProfile = new frmProfile();
            frmProfile.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUsers frmUsers = new frmUsers();
            frmUsers.Show();
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            frmLogs frmLogs = new frmLogs();
            frmLogs.Show();
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

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
