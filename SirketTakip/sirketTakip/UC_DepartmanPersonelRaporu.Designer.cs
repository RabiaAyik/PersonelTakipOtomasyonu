namespace sirketTakip
{
    partial class UC_DepartmanPersonelRaporu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblToplam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPersoneller = new System.Windows.Forms.DataGridView();
            this.prsnlAdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prsnlEposta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dprtmnAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListele = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoneller)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.lblToplam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbDepartman);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(20, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrele";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(632, 50);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(17, 24);
            this.lblToplam.TabIndex = 3;
            this.lblToplam.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Toplam Personel:";
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Items.AddRange(new object[] {
            "YÖNETİM DEPARTMANI",
            "ÜRETİM DEPARTMANI",
            "FİNANS DEPARTMANI",
            "PAZARLAMA VE SATIŞ DEPARTMANI",
            "BİLGİ TEKNOLOJİLERİ DEPARTMANI",
            "AR-GE DEPARTMANI",
            "İNSAN KAYNAKLARI DEPARTMANI"});
            this.cmbDepartman.Location = new System.Drawing.Point(201, 47);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(227, 32);
            this.cmbDepartman.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departman Seç:";
            // 
            // dgvPersoneller
            // 
            this.dgvPersoneller.AllowUserToAddRows = false;
            this.dgvPersoneller.AllowUserToDeleteRows = false;
            this.dgvPersoneller.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersoneller.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersoneller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersoneller.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prsnlAdSoyad,
            this.prsnlEposta,
            this.dprtmnAd});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPersoneller.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPersoneller.EnableHeadersVisualStyles = false;
            this.dgvPersoneller.Location = new System.Drawing.Point(20, 242);
            this.dgvPersoneller.MultiSelect = false;
            this.dgvPersoneller.Name = "dgvPersoneller";
            this.dgvPersoneller.ReadOnly = true;
            this.dgvPersoneller.RowHeadersVisible = false;
            this.dgvPersoneller.RowHeadersWidth = 51;
            this.dgvPersoneller.RowTemplate.Height = 24;
            this.dgvPersoneller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersoneller.Size = new System.Drawing.Size(687, 222);
            this.dgvPersoneller.TabIndex = 1;
            this.dgvPersoneller.TabStop = false;
            this.dgvPersoneller.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPersoneller_DataBindingComplete);
            // 
            // prsnlAdSoyad
            // 
            this.prsnlAdSoyad.DataPropertyName = "prsnlAdSoyad";
            this.prsnlAdSoyad.HeaderText = "Personel Ad Soyad ";
            this.prsnlAdSoyad.MinimumWidth = 6;
            this.prsnlAdSoyad.Name = "prsnlAdSoyad";
            this.prsnlAdSoyad.ReadOnly = true;
            this.prsnlAdSoyad.Width = 125;
            // 
            // prsnlEposta
            // 
            this.prsnlEposta.DataPropertyName = "prsnlEposta";
            this.prsnlEposta.HeaderText = "E posta";
            this.prsnlEposta.MinimumWidth = 6;
            this.prsnlEposta.Name = "prsnlEposta";
            this.prsnlEposta.ReadOnly = true;
            this.prsnlEposta.Width = 125;
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
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.LightGreen;
            this.btnListele.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(20, 130);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(119, 48);
            this.btnListele.TabIndex = 2;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // UC_DepartmanPersonelRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dgvPersoneller);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_DepartmanPersonelRaporu";
            this.Size = new System.Drawing.Size(1382, 641);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoneller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.DataGridView dgvPersoneller;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridViewTextBoxColumn prsnlAdSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn prsnlEposta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dprtmnAd;
    }
}
