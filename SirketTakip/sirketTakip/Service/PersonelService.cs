using sirketTakip.Dal;
using sirketTakip.Entıty;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sirketTakip.Service
{
    internal class PersonelService
    {
        personelDao _personelDao = new personelDao();
        internal void AddPersonel(string gAdSoyad, string gDprtmnAd, string gPozisyon, decimal gMaas, DateTime gIseGrs,string gRol,string gUsrnm,string gPwd,string gEposta)
        {
            if (string.IsNullOrWhiteSpace(gAdSoyad))
                throw new Exception("Ad boş olamaz");

            if (string.IsNullOrWhiteSpace(gDprtmnAd))
                throw new Exception("Departman boş olamaz");

            if (string.IsNullOrWhiteSpace(gPozisyon))
                throw new Exception("Pozisyon boş olamaz");

            _personelDao.Add( gAdSoyad,gDprtmnAd,gPozisyon,gMaas, gIseGrs,gRol,gUsrnm,gPwd,gEposta);

        }
        public DataTable PersonelleriAl()
        {
            
            return _personelDao.PersonelleriAl();
        }
        public DataTable PersonelleriListele()
        {
            return _personelDao.PersonelleriListele();
        }
        public void PersonelSil(int personelId)
        {
            if (personelId <= 0)
                throw new Exception("Geçersiz personel");

            _personelDao.PersoneliSil(personelId);
        }
        public DataTable DepartmanPersonelleriniGetir(string departman)
        {
            if (string.IsNullOrWhiteSpace(departman))
                throw new Exception("Departman seçilmelidir.");

            return _personelDao.DepartmanaGorePersoneller(departman);
        }

        public int DepartmanKisiSayisi(string departman)
        {
            return _personelDao.DepartmanPersonelSayisi(departman);
        }
        public DataTable TumPersonelleriGetir()
        {
            return _personelDao.TumPersonelleriGetir();
        }

        public void PersonelGuncelle(personel p)
        {
            if (string.IsNullOrWhiteSpace(p.PersonelAdSoyad))
                throw new Exception("Ad Soyad boş olamaz");

            if (string.IsNullOrWhiteSpace(p.DepartmanAd))
                throw new Exception("Departman boş olamaz");

            if (string.IsNullOrWhiteSpace(p.Pozisyon))
                throw new Exception("Pozisyon boş olamaz");

            if (string.IsNullOrWhiteSpace(p.Role))
                throw new Exception("Rol boş olamaz");

            if (string.IsNullOrWhiteSpace(p.Eposta))
                throw new Exception("E-posta boş olamaz");

            if (string.IsNullOrWhiteSpace(p.Username))
                throw new Exception("Kullanıcı Adı boş olamaz");

            if (string.IsNullOrWhiteSpace(p.Password))
                throw new Exception("Şifre boş olamaz");

            _personelDao.PersonelGuncelle(p);
        }
        public DataTable PersonelAra(string arananKisi)
        {
            return _personelDao.PersonelAra(arananKisi);
        }
    }
}
