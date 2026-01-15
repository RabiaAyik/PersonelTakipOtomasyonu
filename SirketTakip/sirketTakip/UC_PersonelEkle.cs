using sirketTakip.Entıty;
using sirketTakip.Service;
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
    public partial class UC_PersonelEkle : UserControl
    {
        public UC_PersonelEkle()
        {
            InitializeComponent();
        }
        private void Temizle()
        {
            prsnlAdTxt.Clear();
            dprtmnAdCmb.SelectedIndex = -1;
            pozisyonCmb.SelectedIndex = -1;                     
            maasNumeric.Value = 0;
            rolCmb.SelectedIndex = -1;
            txtKullaniciAd.Clear();
            txtSifre.Clear();
            txtEposta.Clear();

        }
        private void btnPrsnlEkle_Click(object sender, EventArgs e)
        {
            try
            {
                PersonelService ps = new PersonelService();

                ps.AddPersonel(
                    prsnlAdTxt.Text,
                    dprtmnAdCmb.Text,
                    pozisyonCmb.Text,                     
                    Convert.ToDecimal(maasNumeric.Text),
                    IseGirisDateTime.Value,
                    rolCmb.Text,
                    txtKullaniciAd.Text,
                    txtSifre.Text,
                    txtEposta.Text
                );

                MessageBox.Show("Personel başarıyla eklendi");
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void rolCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rolCmb.SelectedItem == null || dprtmnAdCmb.SelectedItem == null)
                return;

            string secilenRol = rolCmb.SelectedItem.ToString();
            string secilenDepartman = dprtmnAdCmb.SelectedItem.ToString();

            if (secilenRol == "İK personeli" &&
                secilenDepartman != "İNSAN KAYNAKLARI DEPARTMANI")
            {
                MessageBox.Show(
                    "İK personeli rolü sadece İnsan Kaynakları departmanı için seçilebilir!",
                    "Yetki Hatası",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                rolCmb.SelectedIndex = -1;
            }
            if( secilenDepartman =="İNSAN KAYNAKLARI DEPARTMANI"&&
                secilenRol=="Normal Kullanıcı")
            {
                MessageBox.Show(
                    "Normal Kullanıcı rolünü İK Departmanı alamaz!",
                    "Yetki Hatası",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

            }
        }
    }
}
