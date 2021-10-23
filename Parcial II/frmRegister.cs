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
    public partial class frmRegister : MetroForm
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearUser_Click(object sender, EventArgs e)
        {

            DateTime hoy = DateTime.Now;
            Account account = new Account();

            account._UserFirstname = txtUserFirtsName.Text;
            account._UserLastname = txtUserLastName.Text;
            account._Usname = txtUsname.Text;
            account._Uspassword = txtUspassword.Text;
            account._UserEmail = txtUserEmail.Text;
            account._UserRegisterdate = hoy.ToString("dd/MM/yy");

            if (MessageBox.Show(this, "desea continuar?", "Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtUserFirtsName.Text == "")
                {
                    MessageBox.Show(this, "Aun faltan partes del formulario por rellenar!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserFirtsName.Focus();
                }
                else if(txtUserLastName.Text == "")
                {
                    MessageBox.Show(this, "Aun faltan partes del formulario por rellenar!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserLastName.Focus();
                }
                else if (txtUsname.Text == "")
                {
                    MessageBox.Show(this, "Aun faltan partes del formulario por rellenar!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsname.Focus();
                }
                else if (txtUspassword.Text == "")
                {
                    MessageBox.Show(this, "Aun faltan partes del formulario por rellenar!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUspassword.Focus();
                }
                else if (txtUserEmail.Text == "")
                {
                    MessageBox.Show(this, "Aun faltan partes del formulario por rellenar!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserEmail.Focus();
                }
                else
                {
                    account.NewUser();
                    MessageBox.Show(this, "El usuario se registor correctamente!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
            }

        }
    }
}
