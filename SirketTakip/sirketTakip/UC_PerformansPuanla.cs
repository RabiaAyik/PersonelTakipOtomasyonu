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
    public partial class UC_PerformansPuanla : UserControl
    {
        public UC_PerformansPuanla()
        {
            InitializeComponent();
        }
        PersonelService _personelService=new PersonelService();
        private void PersonelleriAl()
        {
            dgvPersoneller.DataSource = _personelService.PersonelleriAl();         
        }
        private void UC_PerformansPuanla_Load(object sender, EventArgs e)
        {
            PersonelleriAl();
             dgvPersoneller.ClearSelection();         
        }
        private void dgvPersoneller_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvPersoneller.ClearSelection();
            dgvPersoneller.CurrentCell = null;
        }
        private void Temizle()
        {
            numPuan.Value = 0;
            txtAciklama.Clear();
            cmbDonem.SelectedIndex = -1;
            dgvPersoneller.ClearSelection();
        }
       
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (dgvPersoneller.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir personel seçiniz");
                return;
            }
            //if (numPuan.Value == 0)
            //{
            //    MessageBox.Show("Performans puanı 0 olamaz");
            //    return;
            //}
            int personelId = Convert.ToInt32(
        dgvPersoneller.SelectedRows[0].Cells["id"].Value);

            string personelAdSoyad =
                dgvPersoneller.SelectedRows[0].Cells["prsnlAdSoyad"].Value.ToString();

            Performans p = new Performans
            {
                PersonelId = personelId,
                Puan = (int)numPuan.Value,
                Aciklama = txtAciklama.Text,
                Donem = cmbDonem.Text
            };

            try
            {
                PerformansService service = new PerformansService();
                service.PerformansKaydet(p);
                
                MessageBox.Show(
                    $"Performans kaydedildi !\n\n" +
                    $"Personel: {personelAdSoyad}\n" +
                    $"Puan: {p.Puan}\n" +
                    $"Açıklama: {p.Aciklama}",
                    "Başarılı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
