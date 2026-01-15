using sirketTakip.Dal;
using sirketTakip.Entıty;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace sirketTakip.Service
{
    internal class PerformansService
    {
        private performansDao _performansDao = new performansDao();

        public void PerformansKaydet(Performans p)
        {
            if (p.Puan < 0 || p.Puan > 100)
                throw new Exception("Performans puanı 0-100 arasında olmalıdır");

            if (_performansDao.AyniYilPuanVarMi(p.PersonelId,Convert.ToInt32(p.Donem )))
            {
                throw new Exception("Bu personele seçilen yıl için zaten performans puanı verilmiş.");
            }
            _performansDao.PerformansEkle(p);
        }
            
        public DataTable PerformansRaporuGetir(int gDonem, string gSiralama)
        {
           
            //if (int.IsNullOrEmpty(donem))
            //    throw new Exception("Dönem seçilmelidir");

            return _performansDao.PerformansRaporuGetir(gDonem, gSiralama);
        }
    }
}
