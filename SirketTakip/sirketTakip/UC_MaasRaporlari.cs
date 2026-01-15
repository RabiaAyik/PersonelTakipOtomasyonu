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
    public partial class UC_MaasRaporlari : UserControl
    {
        public UC_MaasRaporlari()
        {
            InitializeComponent();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            cmbDepartman.SelectedIndex = 0;
            dgvMaasRapor.DataSource = null;

            lblToplamMaas.Text = "";
            lblOrtMaas.Text = "";
            lblMaxMaas.Text = "";
            lblMinMaas.Text = "";
        }

        private void btnRaporla_Click(object sender, EventArgs e)
        {
            MaasService service = new MaasService();
            string departman = cmbDepartman.Text;

            dgvMaasRapor.DataSource = service.MaasRaporuGetir(departman);

            var ozet = service.MaasOzetGetir(departman);

            lblToplamMaas.Text = $"Toplam Maaş: {ozet.toplam:C}";
            lblOrtMaas.Text = $"Ortalama Maaş: {ozet.ortalama:C}";
            lblMaxMaas.Text = $"En Yüksek Maaş: {ozet.max:C}";
            lblMinMaas.Text = $"En Düşük Maaş: {ozet.min:C}";
        }
    }
}
