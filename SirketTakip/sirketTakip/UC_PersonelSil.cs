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
    public partial class UC_PersonelSil : UserControl
    {
        PersonelService _personelService = new PersonelService();
        public UC_PersonelSil()
        {
            InitializeComponent();
        }
        private void PersonelleriGetir()
        {
            
            dgvPersonelSil.DataSource = _personelService.PersonelleriAl();
            
        }
        private void UC_PersonelSil_Load(object sender, EventArgs e)
        {
            
            PersonelleriGetir();
            dgvPersonelSil.ClearSelection();
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            if (dgvPersonelSil.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek personeli seçin");
                return;
            }
          

            int personelId = Convert.ToInt32(
                dgvPersonelSil.SelectedRows[0].Cells["id"].Value
            );
           
            DialogResult dr = MessageBox.Show(
                "Seçili personel silinsin mi?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dr == DialogResult.Yes)
            {
               
                try
                {
                    _personelService.PersonelSil(personelId);
                    MessageBox.Show("Personel silindi");
                    PersonelleriGetir(); //  yenile
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvPersonelSil_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvPersonelSil.ClearSelection();
            dgvPersonelSil.CurrentCell = null;
        }

        private void dgvPersonelSil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
