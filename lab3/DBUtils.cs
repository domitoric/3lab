using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace lab3
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "milk_fabric";
            string username = "root";
            string password = "Qwerty2003dima!";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}