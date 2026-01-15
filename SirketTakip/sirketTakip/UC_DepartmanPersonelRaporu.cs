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
    public partial class UC_DepartmanPersonelRaporu : UserControl
    {
        public UC_DepartmanPersonelRaporu()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {
                PersonelService service = new PersonelService();

                string departman = cmbDepartman.Text;

                DataTable dt = service.DepartmanPersonelleriniGetir(departman);
                dgvPersoneller.DataSource = dt;

                int toplam = service.DepartmanKisiSayisi(departman);
                lblToplam.Text = toplam.ToString(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPersoneller_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvPersoneller.ClearSelection();
            dgvPersoneller.CurrentCell = null;
        }
    }
}
