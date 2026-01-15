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
using System.Windows.Forms.Design;

namespace sirketTakip
{
    public partial class UC_İzinTalepEt : UserControl
    {
        private personel _aktifKisi;
        public UC_İzinTalepEt(personel kisi)
        {
            InitializeComponent();
            _aktifKisi = kisi;
        }
        void Temizle()
        {
            cmbIzinTuru.SelectedIndex = -1;
            txtAciklama.Clear();
        }
        private void btnİzinTalepEt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbIzinTuru.Text))
            {
                MessageBox.Show(
                    "İzin türü kısmı boş olamaz",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                cmbIzinTuru.Focus();
                return; //  devam etme
            }
            if (string.IsNullOrWhiteSpace(txtAciklama.Text))
            {
                MessageBox.Show(
                    "Açıklama kısmı boş olamaz",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtAciklama.Focus();
                return; //  devam etme
            }


            Izin izin = new Izin
            {
                PersonelId =_aktifKisi.Id,
                BaslangicTarihi = dateTimebaslangic.Value.Date,
                BitisTarihi = dateTimeBitis.Value.Date,
                IzinTuru = cmbIzinTuru.Text,
                Aciklama = txtAciklama.Text
            };

            try
            {
                IzinService service = new IzinService();
                service.IzinTalepEt(izin);

                MessageBox.Show("İzin talebiniz alınmıştır.");
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
