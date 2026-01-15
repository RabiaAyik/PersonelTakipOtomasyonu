using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirketTakip.Dal
{
    public class DbConnection
    {
       
        protected string connStr = "Server=172.21.54.253;Database=26_132430024;Uid=26_132430024;Password=İnif123.;";

        protected MySqlConnection BaglantiyiAc()
        {
            MySqlConnection con =new MySqlConnection(connStr);
            con .Open();
            return con;
        }
      

    }
}
      

