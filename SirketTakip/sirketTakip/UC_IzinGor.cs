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
    public partial class UC_IzinGor : UserControl
    {
        private personel _aktifKisi;
        private IzinService _izinService = new IzinService();
        public UC_IzinGor(personel kisi)
        {
            InitializeComponent();
            _aktifKisi = kisi;
        }
        
        private void UC_IzinGor_Load(object sender, EventArgs e)
        {
            IzinleriYukle();
            
            dgvIzinGor.ClearSelection();
        }
        private void IzinleriYukle()
        {
            
            dgvIzinGor.DataSource = _izinService.PersonelinIzinleriniGetir(_aktifKisi.PersonelAdSoyad);
        }

        private void dgvIzinGor_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvIzinGor.Rows)
            {
                if (row.Cells["durum"].Value == null)
                    continue;

                string durum = row.Cells["durum"].Value.ToString();

                if (durum == "Beklemede")
                {
                    row.DefaultCellStyle.BackColor = Color.Khaki;
                }
                else if (durum == "Onaylandı")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if (durum == "Reddedildi")
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                }

                // Yazı rengi okunaklı olsun
                row.DefaultCellStyle.ForeColor = Color.Black;
            }

            // Varsayılan mavi seçimi kaldır
            dgvIzinGor.ClearSelection();
        }
    }
}
