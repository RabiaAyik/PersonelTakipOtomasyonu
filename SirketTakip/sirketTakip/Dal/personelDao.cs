using MySql.Data.MySqlClient;
using sirketTakip.Entıty;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirketTakip.Dal
{
    internal class personelDao:DbConnection
    {
        
        public void Add(string gAdSoyad,string gDprtmnAd,string gPozisyon,decimal gMaas,DateTime gIseGrs,string gRol,string gUsrnm,string gPwd,string gEposta)
        {
            using (MySqlConnection con = BaglantiyiAc())
            {
                string sql = @"
                INSERT INTO prsnl
                (prsnlAdSoyad, dprtmnAd, pozisyon, prsnlMaas, iseGiris,role,username,password,prsnlEposta)
                VALUES
                (@ad, @depAd, @poz, @maas, @iseGiris,@role,@un,@pwd,@eps)";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@ad", gAdSoyad);
                cmd.Parameters.AddWithValue("@depAd",gDprtmnAd );
                cmd.Parameters.AddWithValue("@poz", gPozisyon);
                cmd.Parameters.AddWithValue("@maas", gMaas);
                cmd.Parameters.AddWithValue("@iseGiris", gIseGrs);
                cmd.Parameters.AddWithValue("@role", gRol);
                cmd.Parameters.AddWithValue("@un", gUsrnm);
                cmd.Parameters.AddWithValue("@pwd", gPwd);
                cmd.Parameters.AddWithValue("@eps", gEposta);

                cmd.ExecuteNonQuery();
            }
        }
        public DataTable PersonelleriListele()//yönetici için 
        {
            using (MySqlConnection con = BaglantiyiAc())
            {
                string sql = @"SELECT
                     id,
                     prsnlAdSoyad,
                     pozisyon,
                     dprtmnAd,
                     iseGiris,
                     prsnlMaas,
                     role,
                     prsnlEposta
                    FROM prsnl";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }
        public DataTable PersonelleriAl()//ik için
        {
            
            using (MySqlConnection con = BaglantiyiAc())
            {
                string sql = @"SELECT 
                        id ,
                        prsnlAdSoyad,
                        dprtmnAd,
                        pozisyon
                       FROM prsnl";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public void PersoneliSil(int personelId)
        {
            using (MySqlConnection con = BaglantiyiAc())
            {
                string sql = "DELETE FROM prsnl WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", personelId);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable DepartmanaGorePersoneller(string departman)
        {
            string sql = @"
          SELECT 
            prsnlAdSoyad,
            prsnlEposta,
            dprtmnAd
          FROM prsnl
          WHERE dprtmnAd = @dep
          ORDER BY prsnlAdSoyad";

            using (var con = BaglantiyiAc())
            {
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@dep", departman);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public int DepartmanPersonelSayisi(string departman)
        {
            string sql = @"SELECT COUNT(*) FROM prsnl WHERE dprtmnAd = @dep";

            using (var con = BaglantiyiAc())
            {
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@dep", departman);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        public void PersonelGuncelle(personel p)
        {
            using (var con = BaglantiyiAc())
            {
                string sql = @"UPDATE prsnl SET
                        prsnlAdSoyad = @ad,
                        dprtmnAd = @dep,
                        pozisyon = @poz,
                        prsnlMaas = @maas,
                        role = @rol,
                        username = @usr,
                        password = @pwd,
                        prsnlEposta = @epst
                       WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ad", p.PersonelAdSoyad);
                cmd.Parameters.AddWithValue("@dep", p.DepartmanAd);
                cmd.Parameters.AddWithValue("@poz", p.Pozisyon);
                cmd.Parameters.AddWithValue("@maas", p.Maas);
                cmd.Parameters.AddWithValue("@rol", p.Role);
                cmd.Parameters.AddWithValue("@usr", p.Username);
                cmd.Parameters.AddWithValue("@pwd", p.Password);
                cmd.Parameters.AddWithValue("@epst", p.Eposta);
                cmd.Parameters.AddWithValue("@id", p.Id);
                
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable TumPersonelleriGetir()//GÜNCELLEME İŞLEMİ İÇİN
        {
            using (var con = BaglantiyiAc())
            {
                string sql = @"SELECT 
                        id,
                        prsnlAdSoyad,
                        dprtmnAd,
                        pozisyon,
                        prsnlMaas,
                        role,
                        username,
                        password,
                        prsnlEposta
                       FROM prsnl";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable PersonelAra(string arananKisi)//ARAMA TEXTBOXU İÇİN
        {
            using (var con = BaglantiyiAc())
            {
                string sql = @"SELECT 
                        id,
                        prsnlAdSoyad,
                        dprtmnAd,
                        pozisyon,
                        prsnlMaas,
                        role,
                        username,
                        password,
                        prsnlEposta
                       FROM prsnl
                       WHERE prsnlAdSoyad LIKE @ad";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ad", arananKisi + "%");

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
    

