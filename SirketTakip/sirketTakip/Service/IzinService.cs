using sirketTakip.Dal;
using sirketTakip.Entıty;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirketTakip.Service
{
    internal class IzinService
    {

        private readonly IzinDao _izinDao = new IzinDao();
       
        private void KontrolEt(Izin izin)
        {
            int gunSayisi = (izin.BitisTarihi - izin.BaslangicTarihi).Days + 1;//aynı gün seçildiyse 1 gün alsın diye +1

            if (izin.IzinTuru == "YILLIK İZİN")
            {
                if (gunSayisi > 14) //yıllık iznin gün sayısı kontrol edilir
                {
                    throw new Exception("Yıllık izin en fazla 14 gün olabilir.");
                }
            }
        }
        public List<Izin> PersonelinIzinleriniGetir(string adSoyad)
        {
            return _izinDao.PersonelinIzinleriniGetir(adSoyad);
        }
        public void IzinTalepEt(Izin izin)
        {
            if (izin.BitisTarihi < izin.BaslangicTarihi)
                throw new Exception("Bitiş tarihi başlangıçtan önce olamaz");
            KontrolEt(izin);
            _izinDao.IzinEkle(izin);
        }
        public DataTable BeklemedeIzinleriGetir()
        {
            return _izinDao.BeklemedeIzinleriGetir();
        }

        public void Onayla(int izinId)
        {
            _izinDao.IzinDurumGuncelle(izinId, "Onaylandı");
        }

        public void Reddet(int izinId)
        {
            _izinDao.IzinDurumGuncelle(izinId, "Reddedildi");
        }
    }
}
