using MySql.Data.MySqlClient;
using sirketTakip.Entıty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sirketTakip.Dal
{
    public class userDao : DbConnection
    {
        DbConnection conn = new DbConnection();
        public personel Login(string username, string password)
        {

            MessageBox.Show(username + " - " + password);

            using (MySqlConnection con = BaglantiyiAc())
            {
                string sql = @"SELECT * 
                       FROM prsnl 
                       WHERE TRIM(username) = @u 
                       AND TRIM(password) = @p";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@u", username.Trim());
                cmd.Parameters.AddWithValue("@p", password.Trim());

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return new personel
                    {
                        Id = Convert.ToInt32(dr["id"]),
                        PersonelAdSoyad = dr["prsnlAdSoyad"].ToString(),
                        Role = dr["role"].ToString(),

                    };
                }

                return null;

            }
        }
       
    }
}  

