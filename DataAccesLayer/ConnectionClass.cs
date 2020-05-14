using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace DataAccesLayer
{
    public class ConnectionClass
    {
        internal MySqlConnection Con { get; }

        public ConnectionClass(string connectionstring)
        {
            Con = new MySqlConnection(connectionstring);
        }

        public ConnectionClass()
        {
            Con = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi368029;Database=dbi368029;Pwd=Tetdrubbef7");
        }
    }
}
