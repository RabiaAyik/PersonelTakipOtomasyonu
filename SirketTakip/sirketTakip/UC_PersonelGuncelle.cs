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
    public partial class UC_PersonelGuncelle : UserControl
    {
        public UC_PersonelGuncelle()
        {
            InitializeComponent();
        }
        int seciliPersonelId = -1;
        private void UC_PersonelGuncelle_Load(object sender, EventArgs e)
        {
            PersonelService service = new PersonelService();
            dgvPersoneller.DataSource = service.TumPersonelleriGetir();

            dgvPersoneller.ClearSelection();
        }

        private void dgvPersoneller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvPersoneller.Rows[e.RowIndex];

            seciliPersonelId = Convert.ToInt32(row.Cells["id"].Value);
            txtAdSoyad.Text = row.Cells["prsnlAdSoyad"].Value.ToString();
            cmbDepartman.Text = row.Cells["dprtmnAd"].Value.ToString();
            cmbPozisyon.Text = row.Cells["pozisyon"].Value.ToString();
            numMaas.Value = Convert.ToDecimal(row.Cells["prsnlMaas"].Value);
            cmbRol.Text = row.Cells["role"].Value.ToString();
            txtKullaniciAd.Text = row.Cells["username"].Value.ToString();
            txtSifre.Text = row.Cells["password"].Value.ToString();
            txtEposta.Text = row.Cells["prsnlEposta"].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliPersonelId == -1)
            {
                MessageBox.Show("Lütfen personel seçiniz");
                return;
            }

            personel p = new personel
            {
                Id = seciliPersonelId,
                PersonelAdSoyad = txtAdSoyad.Text,
                DepartmanAd = cmbDepartman.Text,
                Pozisyon = cmbPozisyon.Text,
                Maas = numMaas.Value,
                Role = cmbRol.Text,
                Username=txtKullaniciAd.Text,
                Password=txtSifre.Text,
                Eposta = txtEposta.Text,
            };

            PersonelService service = new PersonelService();
            service.PersonelGuncelle(p);

            MessageBox.Show("Personel başarıyla güncellendi");

            dgvPersoneller.DataSource = service.TumPersonelleriGetir();
            dgvPersoneller.ClearSelection();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            PersonelService service = new PersonelService();

            if (string.IsNullOrWhiteSpace(txtAra.Text))
            {
                dgvPersoneller.DataSource = service.TumPersonelleriGetir();
            }
            else
            {
                dgvPersoneller.DataSource = service.PersonelAra(txtAra.Text);
            }

            dgvPersoneller.ClearSelection();
        }

        private void dgvPersoneller_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvPersoneller.ClearSelection();
            dgvPersoneller.CurrentCell = null;
        }
    }
}

