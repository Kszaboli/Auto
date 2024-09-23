using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Auto
{
    public class Connection
    {
        public MySqlConnection connection;
        public string Host;
        public string Database;
        public string User;
        public string Password;
        public string ConnectionString;

        public Connection()
        {
            Host = "127.0.0.1";
            Database = "auto";
            User = "root";
            Password = "";

            ConnectionString = "SERVER=" + Host + ";DATABASE=" + Database + ";UID=" + User + ";PASSWORD=" + Password + ";SslMode=None";

            connection = new MySqlConnection(ConnectionString);
        }       
    }
}
