using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirketTakip.Entıty
{
    internal class Izin:BaseEntıty
    {
        //public new int Id { get; set; }
        
        public int PersonelId {  get; set; }
        public string PersonelAdSoyad { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public string IzinTuru { get; set; }
        public string Aciklama { get; set; }
        public string Durum { get; set; }
        
    }
}
