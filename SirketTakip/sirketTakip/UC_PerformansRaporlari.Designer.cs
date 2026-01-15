namespace sirketTakip
{
    partial class UC_PerformansRaporlari
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cmbSirala = new System.Windows.Forms.ComboBox();
            this.cmbDonem = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRaporla = new System.Windows.Forms.Button();
            this.dgvPerformans = new System.Windows.Forms.DataGridView();
            this.chartPerformans = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPerformans)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSirala
            // 
            this.cmbSirala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSirala.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSirala.FormattingEnabled = true;
            this.cmbSirala.Items.AddRange(new object[] {
            "Yüksekten Düşüğe",
            "Düşükten Yükseğe"});
            this.cmbSirala.Location = new System.Drawing.Point(258, 26);
            this.cmbSirala.Name = "cmbSirala";
            this.cmbSirala.Size = new System.Drawing.Size(185, 33);
            this.cmbSirala.TabIndex = 0;
            // 
            // cmbDonem
            // 
            this.cmbDonem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDonem.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDonem.FormattingEnabled = true;
            this.cmbDonem.Items.AddRange(new object[] {
            "2025",
            "2024",
            "2023",
            "2022"});
            this.cmbDonem.Location = new System.Drawing.Point(648, 26);
            this.cmbDonem.Name = "cmbDonem";
            this.cmbDonem.Size = new System.Drawing.Size(210, 33);
            this.cmbDonem.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbSirala);
            this.groupBox1.Controls.Add(this.cmbDonem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(44, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(891, 108);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrele";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dönem:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sıralama Şekli:";
            // 
            // btnRaporla
            // 
            this.btnRaporla.BackColor = System.Drawing.Color.LightGreen;
            this.btnRaporla.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporla.Location = new System.Drawing.Point(950, 56);
            this.btnRaporla.Name = "btnRaporla";
            this.btnRaporla.Size = new System.Drawing.Size(209, 42);
            this.btnRaporla.TabIndex = 3;
            this.btnRaporla.Text = "Göster";
            this.btnRaporla.UseVisualStyleBackColor = false;
            this.btnRaporla.Click += new System.EventHandler(this.btnRaporla_Click);
            // 
            // dgvPerformans
            // 
            this.dgvPerformans.AllowUserToAddRows = false;
            this.dgvPerformans.AllowUserToDeleteRows = false;
            this.dgvPerformans.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPerformans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPerformans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPerformans.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPerformans.EnableHeadersVisualStyles = false;
            this.dgvPerformans.Location = new System.Drawing.Point(31, 158);
            this.dgvPerformans.MultiSelect = false;
            this.dgvPerformans.Name = "dgvPerformans";
            this.dgvPerformans.ReadOnly = true;
            this.dgvPerformans.RowHeadersVisible = false;
            this.dgvPerformans.RowHeadersWidth = 51;
            this.dgvPerformans.RowTemplate.Height = 24;
            this.dgvPerformans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerformans.Size = new System.Drawing.Size(558, 380);
            this.dgvPerformans.TabIndex = 4;
            this.dgvPerformans.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPerformans_DataBindingComplete);
            // 
            // chartPerformans
            // 
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea1.Name = "ChartArea1";
            this.chartPerformans.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPerformans.Legends.Add(legend1);
            this.chartPerformans.Location = new System.Drawing.Point(630, 158);
            this.chartPerformans.Name = "chartPerformans";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "#";
            series1.Legend = "Legend1";
            series1.Name = "Performans";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartPerformans.Series.Add(series1);
            this.chartPerformans.Size = new System.Drawing.Size(518, 380);
            this.chartPerformans.TabIndex = 5;
            this.chartPerformans.Text = "chartPerformans";
            // 
            // UC_PerformansRaporlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartPerformans);
            this.Controls.Add(this.dgvPerformans);
            this.Controls.Add(this.btnRaporla);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_PerformansRaporlari";
            this.Size = new System.Drawing.Size(1375, 636);
            this.Load += new System.EventHandler(this.UC_PerformansRaporlari_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPerformans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSirala;
        private System.Windows.Forms.ComboBox cmbDonem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRaporla;
        private System.Windows.Forms.DataGridView dgvPerformans;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPerformans;
    }
}
