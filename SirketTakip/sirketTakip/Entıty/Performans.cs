using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirketTakip.Entıty
{
    internal class Performans:BaseEntıty
    {
        public int PersonelId { get; set; }
        public int Puan { get; set; }
        public string Aciklama { get; set; }
        public string Donem { get; set; }
    }
}
