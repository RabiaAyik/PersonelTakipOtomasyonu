using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using sirketTakip.Entıty;
using System.Drawing;
using System.Data.Common;
using System.Collections;
using System.Windows.Forms;

namespace sirketTakip.Dal
{
    internal class IzinDao : DbConnection
    {
        public void IzinEkle(Izin izin)//normal kullanıcı için
        {
            using (var con = BaglantiyiAc())
            {
                string sql = @"INSERT INTO izinler
            (personelId, baslangicTarihi, bitisTarihi, izinTuru, aciklama, durum)
            VALUES (@pid, @bas, @bit, @tur, @ack, 'Beklemede')";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@pid", izin.PersonelId);
                cmd.Parameters.AddWithValue("@bas", izin.BaslangicTarihi);
                cmd.Parameters.AddWithValue("@bit", izin.BitisTarihi);
                cmd.Parameters.AddWithValue("@tur", izin.IzinTuru);
                cmd.Parameters.AddWithValue("@ack", izin.Aciklama);

                cmd.ExecuteNonQuery();
            }
        }
        public void IzinDurumGuncelle(int izinId, string yeniDurum)//ik için
        {
            using (var con = BaglantiyiAc())
            {
                string sql = "UPDATE izinler SET durum = @durum WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@durum", yeniDurum);
                cmd.Parameters.AddWithValue("@id", izinId);
                cmd.ExecuteNonQuery();
            }
        }
        
        public List<Izin> PersonelinIzinleriniGetir(string personelAdSoyad)//Normal kullanıcı için
        {
            List<Izin> izinler = new List<Izin>();

            string query = @"SELECT 
                        i.personelId,
                        p.prsnlAdSoyad,
                        i.baslangicTarihi,
                        i.bitisTarihi,
                        i.izinTuru,
                        i.aciklama,
                        i.durum
                        FROM izinler i
                       INNER JOIN prsnl p ON i.personelId = p.id
                      WHERE p.prsnlAdSoyad = @pad
                     ORDER BY baslangicTarihi DESC";

            using (var con = BaglantiyiAc())
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@pad", personelAdSoyad);

                
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    izinler.Add(new Izin
                    {
                        PersonelId = Convert.ToInt32(dr["personelId"]),
                        PersonelAdSoyad =dr["prsnlAdSoyad"].ToString(),
                        BaslangicTarihi = Convert.ToDateTime(dr["baslangicTarihi"]),
                        BitisTarihi = Convert.ToDateTime(dr["bitisTarihi"]),
                        IzinTuru = dr["izinTuru"].ToString(),
                        Aciklama = dr["aciklama"].ToString(),
                        Durum = dr["durum"].ToString()
                    });
                }
            }

            return izinler;
        }

        public DataTable BeklemedeIzinleriGetir()//ik için
        {
            
            using (var con = BaglantiyiAc())
            {
                string sql = @"
               SELECT
                i.id,
                i.personelId,
                p.prsnlAdSoyad,
                i.baslangicTarihi,
                i.bitisTarihi,
                i.izinTuru,
                i.aciklama,
                i.durum
               FROM izinler i
               INNER JOIN prsnl p ON i.personelId = p.id
              WHERE TRIM(LOWER(i.durum)) = 'beklemede'
               ORDER BY i.baslangicTarihi ASC";


                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
