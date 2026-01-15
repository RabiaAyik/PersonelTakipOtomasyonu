using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirketTakip.Entıty
{
    public class personel : BaseEntıty
    {
        //public string Name { get; set; }
        //public string Surname { get; set; }
        public decimal Maas { get; set; }
       // public int DepartmentId { get; set; }
        public string DepartmanAd {  get; set; }
        public string Pozisyon { get; set; }    
        public string Eposta { get; set; }
        public string PersonelAdSoyad {  get; set; }    
        public string Username { get; set; }
        public string Password { get; set; }
       // public int EmployeeId { get; set; }
        
        public string Role { get; set; } 
       
    }
}
