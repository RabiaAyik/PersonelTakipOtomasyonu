using sirketTakip.Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirketTakip.Service
{
    internal class MaasService
    {
        maasDao dao = new maasDao();

        public DataTable MaasRaporuGetir(string gDepartman)
        {
            return dao.MaasRaporuGetir(gDepartman);
        }

        public (decimal toplam, decimal ortalama, decimal max, decimal min) MaasOzetGetir(string departman)
        {
            return dao.MaasOzetGetir(departman);
        }
    }
}
