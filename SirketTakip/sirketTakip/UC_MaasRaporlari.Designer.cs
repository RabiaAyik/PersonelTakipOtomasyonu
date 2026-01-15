namespace sirketTakip
{
    partial class UC_MaasRaporlari
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRaporla = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lblToplamMaas = new System.Windows.Forms.Label();
            this.lblOrtMaas = new System.Windows.Forms.Label();
            this.lblMaxMaas = new System.Windows.Forms.Label();
            this.lblMinMaas = new System.Windows.Forms.Label();
            this.dgvMaasRapor = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prsnlAdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dprtmnAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prsnlMaas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaasRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnRaporla);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbDepartman);
            this.panel1.Location = new System.Drawing.Point(43, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 83);
            this.panel1.TabIndex = 0;
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Items.AddRange(new object[] {
            "YÖNETİM DEPARTMANI",
            "ÜRETİM DEPARTMANI",
            "FİNANS DEPARTMANI",
            "PAZARLAMA VE SATIŞ DEPARTMANI",
            "BİLGİ TEKNOLOJİLERİ DEPARTMANI",
            "AR-GE DEPARTMANI",
            "İNSAN KAYNAKLARI DEPARTMANI"});
            this.cmbDepartman.Location = new System.Drawing.Point(176, 26);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(255, 32);
            this.cmbDepartman.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Departman Seç:";
            // 
            // btnRaporla
            // 
            this.btnRaporla.BackColor = System.Drawing.Color.Green;
            this.btnRaporla.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporla.Location = new System.Drawing.Point(509, 21);
            this.btnRaporla.Name = "btnRaporla";
            this.btnRaporla.Size = new System.Drawing.Size(204, 40);
            this.btnRaporla.TabIndex = 2;
            this.btnRaporla.Text = "Raporla";
            this.btnRaporla.UseVisualStyleBackColor = false;
            this.btnRaporla.Click += new System.EventHandler(this.btnRaporla_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Red;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(537, 429);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(162, 44);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lblToplamMaas
            // 
            this.lblToplamMaas.AutoSize = true;
            this.lblToplamMaas.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamMaas.Location = new System.Drawing.Point(715, 156);
            this.lblToplamMaas.Name = "lblToplamMaas";
            this.lblToplamMaas.Size = new System.Drawing.Size(130, 24);
            this.lblToplamMaas.TabIndex = 1;
            this.lblToplamMaas.Text = "Toplam Maaş:";
            // 
            // lblOrtMaas
            // 
            this.lblOrtMaas.AutoSize = true;
            this.lblOrtMaas.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrtMaas.Location = new System.Drawing.Point(715, 210);
            this.lblOrtMaas.Name = "lblOrtMaas";
            this.lblOrtMaas.Size = new System.Drawing.Size(145, 24);
            this.lblOrtMaas.TabIndex = 2;
            this.lblOrtMaas.Text = "Ortalama Maaş:";
            // 
            // lblMaxMaas
            // 
            this.lblMaxMaas.AutoSize = true;
            this.lblMaxMaas.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaxMaas.Location = new System.Drawing.Point(716, 277);
            this.lblMaxMaas.Name = "lblMaxMaas";
            this.lblMaxMaas.Size = new System.Drawing.Size(151, 24);
            this.lblMaxMaas.TabIndex = 3;
            this.lblMaxMaas.Text = "En Yüksek Maaş:";
            // 
            // lblMinMaas
            // 
            this.lblMinMaas.AutoSize = true;
            this.lblMinMaas.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMinMaas.Location = new System.Drawing.Point(716, 336);
            this.lblMinMaas.Name = "lblMinMaas";
            this.lblMinMaas.Size = new System.Drawing.Size(144, 24);
            this.lblMinMaas.TabIndex = 4;
            this.lblMinMaas.Text = "En Düşük Maaş:";
            // 
            // dgvMaasRapor
            // 
            this.dgvMaasRapor.AllowUserToAddRows = false;
            this.dgvMaasRapor.AllowUserToDeleteRows = false;
            this.dgvMaasRapor.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaasRapor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaasRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaasRapor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.prsnlAdSoyad,
            this.dprtmnAd,
            this.prsnlMaas});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaasRapor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMaasRapor.EnableHeadersVisualStyles = false;
            this.dgvMaasRapor.Location = new System.Drawing.Point(59, 132);
            this.dgvMaasRapor.Name = "dgvMaasRapor";
            this.dgvMaasRapor.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaasRapor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMaasRapor.RowHeadersVisible = false;
            this.dgvMaasRapor.RowHeadersWidth = 51;
            this.dgvMaasRapor.RowTemplate.Height = 24;
            this.dgvMaasRapor.Size = new System.Drawing.Size(640, 279);
            this.dgvMaasRapor.TabIndex = 5;
            this.dgvMaasRapor.TabStop = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Personel No";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // prsnlAdSoyad
            // 
            this.prsnlAdSoyad.DataPropertyName = "prsnlAdSoyad";
            this.prsnlAdSoyad.HeaderText = "Personel Ad Soyad";
            this.prsnlAdSoyad.MinimumWidth = 6;
            this.prsnlAdSoyad.Name = "prsnlAdSoyad";
            this.prsnlAdSoyad.ReadOnly = true;
            this.prsnlAdSoyad.Width = 125;
            // 
            // dprtmnAd
            // 
            this.dprtmnAd.DataPropertyName = "dprtmnAd";
            this.dprtmnAd.HeaderText = "Departman";
            this.dprtmnAd.MinimumWidth = 6;
            this.dprtmnAd.Name = "dprtmnAd";
            this.dprtmnAd.ReadOnly = true;
            this.dprtmnAd.Width = 125;
            // 
            // prsnlMaas
            // 
            this.prsnlMaas.DataPropertyName = "prsnlMaas";
            this.prsnlMaas.HeaderText = "Maaş";
            this.prsnlMaas.MinimumWidth = 6;
            this.prsnlMaas.Name = "prsnlMaas";
            this.prsnlMaas.ReadOnly = true;
            this.prsnlMaas.Width = 125;
            // 
            // UC_MaasRaporlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.dgvMaasRapor);
            this.Controls.Add(this.lblMinMaas);
            this.Controls.Add(this.lblMaxMaas);
            this.Controls.Add(this.lblOrtMaas);
            this.Controls.Add(this.lblToplamMaas);
            this.Controls.Add(this.panel1);
            this.Name = "UC_MaasRaporlari";
            this.Size = new System.Drawing.Size(1393, 613);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaasRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnRaporla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToplamMaas;
        private System.Windows.Forms.Label lblOrtMaas;
        private System.Windows.Forms.Label lblMaxMaas;
        private System.Windows.Forms.Label lblMinMaas;
        private System.Windows.Forms.DataGridView dgvMaasRapor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prsnlAdSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dprtmnAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn prsnlMaas;
    }
}
