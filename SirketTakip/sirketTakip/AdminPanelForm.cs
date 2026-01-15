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
    public partial class AdminPanelForm : Form
    {
       personel _kisi;
        public AdminPanelForm(personel kisi)
        {
           this._kisi= kisi;
            InitializeComponent();
        }
        private void LoadControl(UserControl uc)
        {
            panelContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);
        }
        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            GirisForm girisForm = new GirisForm();
            girisForm.Show();

            this.Close();
        }

        private void btnIzinOnay_Click(object sender, EventArgs e)
        {
            LoadControl(new UC_IzinGir());
        }

        private void btnPrsnlList_Click(object sender, EventArgs e)
        {
            LoadControl(new UC_PersonelList());
        }

        private void btnPerfRapor_Click(object sender, EventArgs e)
        {
            LoadControl(new UC_PerformansRaporlari());
        }

        private void btnDepRapor_Click(object sender, EventArgs e)
        {
            LoadControl(new UC_DepartmanPersonelRaporu());
        }

        private void btnMaasRapor_Click(object sender, EventArgs e)
        {
            LoadControl(new UC_MaasRaporlari());
        }
    }
}
