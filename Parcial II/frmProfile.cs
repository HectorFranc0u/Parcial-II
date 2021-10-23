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
using MySql.Data.MySqlClient;

namespace Parcial_II
{
    public partial class frmProfile : MetroForm
    {
        public frmProfile()
        {
            InitializeComponent();
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            if (frmInicio.valor == 1)
            {
                lblemail.Text = "Administrador@gmail.com";
                lblfname.Text = "Administrador Admin";
                lblusername.Text = "admin";
                lblreisterdate.Text = "";
            }
            else
            {
                Account account = new Account();
                account._UserID = frmInicio.valor;
                MySqlDataReader data = account.getdata();

                while (data.Read())
                {
                    lblfname.Text = data.GetValue(0).ToString() + " " + data.GetValue(1).ToString();
                    lblemail.Text = data.GetValue(2).ToString();
                    lblreisterdate.Text = data.GetValue(3).ToString();
                    lblusername.Text = data.GetValue(4).ToString();
                }
            }
        }
    }
}
