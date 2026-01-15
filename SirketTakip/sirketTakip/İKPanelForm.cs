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
    public partial class İKPanelForm : Form
    {
        personel _personel;
        public İKPanelForm(personel personel)
        {
            this._personel = personel;
            InitializeComponent();
        }
        private void LoadControl(UserControl uc)
        {
            pnlMenu.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlMenu.Controls.Add(uc);
        }
        private void İKPanelForm_Load(object sender, EventArgs e)
        {

        }


        private void btnPrsnlEkle_Click(object sender, EventArgs e)
        {
            LoadControl(new UC_PersonelEkle());
        }

        private void btnPrsnlSil_Click(object sender, EventArgs e)
        {
            LoadControl(new UC_PersonelSil());
        }

        private void btnIzinGiris_Click_1(object sender, EventArgs e)
        {
           
             LoadControl(new UC_IzinGir());
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            GirisForm girisForm = new GirisForm();
            girisForm.Show();

            this.Close();
        }

        private void btnPerformans_Click(object sender, EventArgs e)
        {
            LoadControl(new UC_PerformansPuanla());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadControl(new UC_PersonelGuncelle());
        }

        

       
    }
}
