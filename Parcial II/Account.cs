using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Parcial_II
{
    class Account
    {
        public int _UserID { get; set; }
        public string _UserFirstname { get; set; }
        public string _UserLastname { get; set; }
        public string _UserEmail { get; set; }
        public string _UserRegisterdate { get; set; }
        public string _Usname { get; set; }
        public string _Uspassword { get; set; }

        private Crud crud = new Crud();

        public MySqlDataReader getUsers()
        {
            string query = "SELECT codUser,firstname,lastname,email,registerdate,ussername,password FROM account";

            return crud.select(query);
        }

        public void NewUser()
        {
            string query = "INSERT INTO account(firstname, lastname, email, registerdate, ussername, password)" +
                    "VALUES ('" + _UserFirstname + "', '" + _UserLastname + "', '" + _UserEmail + "', '" + _UserRegisterdate + "', '" + _Usname + "', '" + _Uspassword + "')";
            crud.executeQuery(query);
        }
    }
}
