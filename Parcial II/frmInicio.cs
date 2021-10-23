using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Parcial_II
{
    public partial class frmInicio : Form
    {
        public static int valor;
        public static string usuario;
        public static string tiempo;
        public frmInicio()
        {
            InitializeComponent();

        }
        private void llbRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.Show();
        }
        private void validation()
        {
            MessageBox.Show(this, "Aun faltan partes del formulario por rellenar!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string datetime = DateTime.Now.ToString("HH:mm:ss MM-dd");

            Account account = new Account();

            account._Usname = txtUser.Text;
            account._Uspassword = txtPws.Text;

            MySqlDataReader dataReader = account.getlogin();

            if (txtUser.Text == "")
            {
                validation();
                txtUser.Focus();
            }
            else if (txtPws.Text == "")
            {
                validation();
                txtPws.Focus();
            }
            else
            {
                if (txtUser.Text == "admin" & txtPws.Text == "admin")
                {
                    valor = 1;
                    usuario = account._Usname;
                    tiempo = datetime;
                    MessageBox.Show(this, "Inicio de sesion como administrador exitoso!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMenu frmMenu = new frmMenu();
                    frmMenu.Show();

                }
                else if (dataReader.Read())
                {
                    valor = Convert.ToInt32(dataReader.GetValue(0));
                    usuario = txtUser.Text;
                    tiempo = datetime;
                    MessageBox.Show(this, "Inicio de sesion como usuario exitoso!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmmenuus frmmenuus = new frmmenuus();
                    frmmenuus.Show();
                }
                else
                {
                    MessageBox.Show(this, "error al iniciar sesion!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            txtPws.Text = "";
            txtUser.Text = "";
        }
    }
}
