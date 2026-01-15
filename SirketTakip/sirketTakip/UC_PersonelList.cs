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
    public partial class UC_PersonelList : UserControl
    {
        PersonelService _personelService = new PersonelService();
        public UC_PersonelList()
        {
            InitializeComponent();
        }
        private void PersonelListeleY()
        {
            dgvPersonelList.DataSource = _personelService.PersonelleriListele();
        }
        private void UC_PersonelList_Load(object sender, EventArgs e)
        {
            PersonelListeleY();
            dgvPersonelList.ClearSelection();
        }

        private void dgvPersonelList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvPersonelList.ClearSelection();
            dgvPersonelList.CurrentCell = null;
        }

        
    }
}
