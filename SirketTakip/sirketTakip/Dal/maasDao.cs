using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirketTakip.Dal
{
    internal class maasDao:DbConnection
    {
        public DataTable MaasRaporuGetir(string gDepartman)
        {
            string sql = @"
          SELECT 
            id ,
            prsnlAdSoyad ,
            dprtmnAd ,
            prsnlMaas 
          FROM prsnl";

            if (gDepartman != "Tüm Departmanlar")
                sql += " WHERE dprtmnAd = @dep";

            using (var con = BaglantiyiAc())
            {
                MySqlCommand cmd = new MySqlCommand(sql, con);

                if (gDepartman != "Tüm Departmanlar")
                    cmd.Parameters.AddWithValue("@dep", gDepartman);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public (decimal toplam, decimal ortalama, decimal max, decimal min) MaasOzetGetir(string departman)
        {
            string sql = @"
          SELECT 
            SUM(prsnlMaas),
            AVG(prsnlMaas),
            MAX(prsnlMaas),
            MIN(prsnlMaas)
          FROM prsnl";

            if (departman != "Tüm Departmanlar")
                sql += " WHERE dprtmnAd = @dep";

            using (var con = BaglantiyiAc())
            {
                MySqlCommand cmd = new MySqlCommand(sql, con);

                if (departman != "Tüm Departmanlar")
                    cmd.Parameters.AddWithValue("@dep", departman);

                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                return (
                    dr.IsDBNull(0) ? 0 : dr.GetDecimal(0),
                    dr.IsDBNull(1) ? 0 : dr.GetDecimal(1),
                    dr.IsDBNull(2) ? 0 : dr.GetDecimal(2),
                    dr.IsDBNull(3) ? 0 : dr.GetDecimal(3)
                );
            }
        }
    }
}
