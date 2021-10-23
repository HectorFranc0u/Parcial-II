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
    public partial class frmLogs : Form
    {
        public frmLogs()
        {
            InitializeComponent();
        }

        private void gtdLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmLogs_Load(object sender, EventArgs e)
        {
            filldgv();
        }

        private void filldgv()
        {
            Account account = new Account();

            gtdLogs.Columns.Add("_UserID", "ID");
            gtdLogs.Columns.Add("_Usname", "USUARIO");
            gtdLogs.Columns.Add("_TimeLoggedIn", "TIMEPO EN EL QUE ESTUVO LOGGEADO");

            MySqlDataReader dataReader = account.getlogs();

            while (dataReader.Read())
            {
                gtdLogs.Rows.Add(
                    dataReader.GetValue(0),
                    dataReader.GetValue(1),
                    dataReader.GetValue(2)
                    );
            }
        }

        private void frmLogs_Load_1(object sender, EventArgs e)
        {
            filldgv();
        }
    }
}
