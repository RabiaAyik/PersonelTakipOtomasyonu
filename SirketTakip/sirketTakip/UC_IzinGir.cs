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
    public partial class UC_IzinGir : UserControl
    {
        private IzinService _izinService = new IzinService();
        public UC_IzinGir()
        {
            InitializeComponent();
           
            IzinleriYukle();
        }
       
        public void IzinleriYukle()
        {
            dgvIzinler.AutoGenerateColumns = false; //true;
            dgvIzinler.DataSource = _izinService.BeklemedeIzinleriGetir();
            dgvIzinler.ClearSelection();

        }

        private void btnOnayla_Click_1(object sender, EventArgs e)
        {
            if (dgvIzinler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir izin seçin");
                return;
            }

            int izinId = Convert.ToInt32(dgvIzinler.SelectedRows[0].Cells["id"].Value);

            _izinService.Onayla(izinId);
            MessageBox.Show("İzin onaylandı");

           dgvIzinler.DataSource = _izinService.BeklemedeIzinleriGetir();
            dgvIzinler.ClearSelection();

        }

        private void btnReddet_Click_1(object sender, EventArgs e)
        {
            if (dgvIzinler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir izin seçin");
                return;
            }

            int izinId = Convert.ToInt32(dgvIzinler.SelectedRows[0].Cells["id"].Value);

            _izinService.Reddet(izinId);
            MessageBox.Show("İzin reddedildi");

            dgvIzinler.DataSource = _izinService.BeklemedeIzinleriGetir();
            dgvIzinler.ClearSelection();
        }

        private void dgvIzinler_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvIzinler.Rows)
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
            dgvIzinler.ClearSelection();
        }
    }
    
    
}
