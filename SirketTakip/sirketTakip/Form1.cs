using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MySql.Data.MySqlClient;
using sirketTakip.Dal;
using sirketTakip.Service;
using sirketTakip.Entıty;
namespace sirketTakip
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                UserService um = new UserService();
                personel kisi = um.Login(nicknameTxt.Text, sifreTxt.Text);

                if (kisi == null)
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış");
                    return;
                }
                MessageBox.Show("Giriş başarılı. Rol: " + kisi.Role);


                if (kisi.Role == "Yönetici")
                {
                    AdminPanelForm adminForm = new AdminPanelForm(kisi);
                    adminForm.Show();
                    this.Hide();
                }
                else if (kisi.Role == "İK personeli")
                {
                    İKPanelForm ikForm = new İKPanelForm(kisi);
                    ikForm.Show();
                    this.Hide();
                }

                else if (kisi.Role == "Normal Kullanıcı")
                {
                    NKullaniciPanelForm nkForm = new NKullaniciPanelForm(kisi);
                    nkForm.Show();
                    this.Hide();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
