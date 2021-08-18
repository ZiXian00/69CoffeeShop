using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace _69CoffeeShop.Class
{
    class Connection
    {
        public static string connStr { get; set; } = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        public MySqlConnection conn { get; set; } = new MySqlConnection(connStr);

    }
}
