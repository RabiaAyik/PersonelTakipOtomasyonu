using sirketTakip.Entıty;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sirketTakip
{
    public partial class NKullaniciPanelForm : Form
    {
        
        private personel _aktifKisi;
        public NKullaniciPanelForm(personel kisi)
        {
            
            InitializeComponent();
            this._aktifKisi = kisi;
        }
        
        private void LoadControl(UserControl uc)
        {
            panelMenu.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMenu.Controls.Add(uc);
        }          
        private void NKullaniciPanelForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Hoşgeldiniz!"+" "+_aktifKisi.PersonelAdSoyad);
        }
       
        private void btnİzinTalepGör_Click(object sender, EventArgs e)
        {
            UC_IzinGor uc = new UC_IzinGor(_aktifKisi);
            LoadControl(uc);
        }

        private void btnIzinTalep_Click(object sender, EventArgs e)
        {
            LoadControl(new UC_İzinTalepEt(_aktifKisi));
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            GirisForm girisForm = new GirisForm();
            girisForm.Show();

            this.Close();
        }
    }
}
