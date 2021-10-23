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
        public string _TimeLoggedIn { get; set; }

        private Crud crud = new Crud();

        public MySqlDataReader getUsers()
        {
            string query = "SELECT codUser,firstname,lastname,email,registerdate,ussername,password FROM account";

            return crud.select(query);
        }

        public MySqlDataReader getdata()
        {
            string query = "SELECT firstname,lastname,email,registerdate,ussername FROM account WHERE codUser = '"+ _UserID +"'";
            return crud.select(query);
        }

        public MySqlDataReader getlogin()
        {
            string query = "SELECT * FROM account WHERE ussername = '" + _Usname + "' AND password = '" + _Uspassword + "'   ";
            return crud.select(query);
        }

        public void NewUser()
        {
            string query = "INSERT INTO account(firstname, lastname, email, registerdate, ussername, password)" +
                    "VALUES ('" + _UserFirstname + "', '" + _UserLastname + "', '" + _UserEmail + "', '" + _UserRegisterdate + "', '" + _Usname + "', '" + _Uspassword + "')";
            crud.executeQuery(query);
        }

        public void setlog()
        {
            string query = "INSERT INTO userlog(codUser, username, timeLoggedIn)" +
                    "VALUES ('" + _UserID + "', '" + _Usname + "', '" + _TimeLoggedIn + "')";
            crud.executeQuery(query);
        }

        public MySqlDataReader getlogs()
        {
            string query = "SELECT codUser,username,timeLoggedIn FROM userlog";
            return crud.select(query);
        }
    }
}
