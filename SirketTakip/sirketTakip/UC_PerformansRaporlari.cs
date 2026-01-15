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
using System.Windows.Forms.DataVisualization.Charting;

namespace sirketTakip
{
    public partial class UC_PerformansRaporlari : UserControl
    {
        public UC_PerformansRaporlari()
        {
            InitializeComponent();
        }
        private void GrafigiDoldur(DataTable dt)
        {
           chartPerformans.Series.Clear();
            ChartArea area = chartPerformans.ChartAreas[0];
            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = double.NaN; // otomatik ölçek
            area.RecalculateAxesScale();
            
            area.AxisX.Interval = 1;
            area.AxisX.LabelStyle.Angle = -45;
            
            Series s = new Series("Performans");
            s.ChartType = SeriesChartType.Column;
            s.IsValueShownAsLabel = true;
            s.Font = new Font("Segoe UI", 9, FontStyle.Bold);
           
            foreach (DataRow row in dt.Rows)
            {
                s.Points.AddXY(
                    row["Personel"].ToString(),
                    Convert.ToInt32(row["Puan"])
                );
            }           
            chartPerformans.Series.Add(s);
        }

        private void btnRaporla_Click(object sender, EventArgs e)
        {
            try
            {
                PerformansService perfService = new PerformansService();
                int donem = Convert.ToInt32(cmbDonem.Text);
                string siralama = cmbSirala.Text;

                DataTable dt = perfService.PerformansRaporuGetir(donem, siralama);
                dgvPerformans.DataSource = dt;
                GrafigiDoldur(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UC_PerformansRaporlari_Load(object sender, EventArgs e)
        {
        }

        private void dgvPerformans_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvPerformans.ClearSelection();
            dgvPerformans.CurrentCell = null;
        }
    }
}
