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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            filldgv();
        }

        private void filldgv()
        {
            Account account = new Account();
            dtgUser.Columns.Add("_UserID", "ID");
            dtgUser.Columns.Add("_UserFirstname", "NOMBRE");
            dtgUser.Columns.Add("_UserLastname", "APELLIDO");
            dtgUser.Columns.Add("_UserEmail", "EMAIL");
            dtgUser.Columns.Add("_UserRegisterdate", "FECHA DE REGISTRO");
            dtgUser.Columns.Add("_Usname", "USUARIO");
            dtgUser.Columns.Add("_Uspassword", "CONTRASEÑA");

            MySqlDataReader dataReader = account.getUsers();

            while (dataReader.Read())
            {
                dtgUser.Rows.Add(
                    dataReader.GetValue(0),
                    dataReader.GetValue(1),
                    dataReader.GetValue(2),
                    dataReader.GetValue(3),
                    dataReader.GetValue(4),
                    dataReader.GetValue(5),
                    dataReader.GetValue(6)
                    );
            }
        }
    }
}
