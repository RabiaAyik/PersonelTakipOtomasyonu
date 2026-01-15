using sirketTakip.Dal;
using sirketTakip.Entıty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sirketTakip.Service
{
    internal class UserService
    {
        userDao ud = new userDao();

        public personel Login(string gUsername, string gPassword)
        {
            if (string.IsNullOrEmpty(gUsername) || string.IsNullOrEmpty(gPassword))
                throw new Exception("Kullanıcı adı ve şifre boş olamaz");
            
            return ud.Login(gUsername, gPassword);
        }
       

    }
}
