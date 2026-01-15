using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using sirketTakip.Entıty;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirketTakip.Dal
{
    internal class performansDao:DbConnection
    {
        public void PerformansEkle(Performans p)
        {
            string sql = @"INSERT INTO performans 
                       (personelId, puan, aciklamaa, donem)
                       VALUES (@pid, @puan, @aciklama, @donem)";

            using (var con = BaglantiyiAc())
            {
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@pid", p.PersonelId);
                cmd.Parameters.AddWithValue("@puan", p.Puan);
                cmd.Parameters.AddWithValue("@aciklama", p.Aciklama);
                cmd.Parameters.AddWithValue("@donem", p.Donem);

                cmd.ExecuteNonQuery();
            }
        }
        public bool AyniYilPuanVarMi(int personelId, int donem)
        {
            string sql = @"SELECT COUNT(*) 
                   FROM performans 
                   WHERE personelId = @pid 
                   AND donem = @donem";

            using (var con = BaglantiyiAc())
            {
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@pid", personelId);
                cmd.Parameters.AddWithValue("@donem", donem);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
        public DataTable PerformansRaporuGetir(int gDonem, string gSiralama)
        {
            
            string orderBy = gSiralama == "Yüksekten Düşüğe"
                ? "pf.puan DESC"
                : "pf.puan ASC";

            string sql = $@"
            SELECT 
              p.prsnlAdSoyad AS Personel,
              pf.puan AS Puan,
              pf.aciklamaa AS Açıklama
            FROM performans pf
            INNER JOIN prsnl p ON pf.personelId = p.id
            WHERE pf.donem = @donem          
            ORDER BY {orderBy}"; //AS kullanarak belirlediğimiz isim DataGridViewde görünecek sütun ismi

            using (var con = BaglantiyiAc())
            {
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@donem", gDonem);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
    
}
