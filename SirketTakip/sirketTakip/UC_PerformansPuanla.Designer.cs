namespace sirketTakip
{
    partial class UC_PerformansPuanla
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
            this.grpPersonel = new System.Windows.Forms.GroupBox();
            this.dgvPersoneller = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prsnlAdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dprtmnAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozisyon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpPuan = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDonem = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.aciklama = new System.Windows.Forms.Label();
            this.numPuan = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.grpPersonel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoneller)).BeginInit();
            this.grpPuan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPuan)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPersonel
            // 
            this.grpPersonel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpPersonel.Controls.Add(this.dgvPersoneller);
            this.grpPersonel.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpPersonel.Location = new System.Drawing.Point(3, 15);
            this.grpPersonel.Name = "grpPersonel";
            this.grpPersonel.Size = new System.Drawing.Size(604, 571);
            this.grpPersonel.TabIndex = 0;
            this.grpPersonel.TabStop = false;
            this.grpPersonel.Text = "Personel seç";
            // 
            // dgvPersoneller
            // 
            this.dgvPersoneller.AllowUserToAddRows = false;
            this.dgvPersoneller.AllowUserToDeleteRows = false;
            this.dgvPersoneller.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersoneller.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersoneller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersoneller.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.prsnlAdSoyad,
            this.dprtmnAd,
            this.pozisyon});
            this.dgvPersoneller.EnableHeadersVisualStyles = false;
            this.dgvPersoneller.Location = new System.Drawing.Point(6, 30);
            this.dgvPersoneller.MultiSelect = false;
            this.dgvPersoneller.Name = "dgvPersoneller";
            this.dgvPersoneller.ReadOnly = true;
            this.dgvPersoneller.RowHeadersVisible = false;
            this.dgvPersoneller.RowHeadersWidth = 51;
            this.dgvPersoneller.RowTemplate.Height = 24;
            this.dgvPersoneller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersoneller.Size = new System.Drawing.Size(592, 535);
            this.dgvPersoneller.TabIndex = 0;
            this.dgvPersoneller.TabStop = false;
            this.dgvPersoneller.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPersoneller_DataBindingComplete);
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
            // pozisyon
            // 
            this.pozisyon.DataPropertyName = "pozisyon";
            this.pozisyon.HeaderText = "Pozisyon";
            this.pozisyon.MinimumWidth = 6;
            this.pozisyon.Name = "pozisyon";
            this.pozisyon.ReadOnly = true;
            this.pozisyon.Width = 125;
            // 
            // grpPuan
            // 
            this.grpPuan.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpPuan.Controls.Add(this.label2);
            this.grpPuan.Controls.Add(this.cmbDonem);
            this.grpPuan.Controls.Add(this.txtAciklama);
            this.grpPuan.Controls.Add(this.aciklama);
            this.grpPuan.Controls.Add(this.numPuan);
            this.grpPuan.Controls.Add(this.label1);
            this.grpPuan.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpPuan.Location = new System.Drawing.Point(613, 39);
            this.grpPuan.Name = "grpPuan";
            this.grpPuan.Size = new System.Drawing.Size(735, 298);
            this.grpPuan.TabIndex = 1;
            this.grpPuan.TabStop = false;
            this.grpPuan.Text = "Puan Seç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dönem:";
            // 
            // cmbDonem
            // 
            this.cmbDonem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDonem.FormattingEnabled = true;
            this.cmbDonem.Items.AddRange(new object[] {
            "2025",
            "2024",
            "2023",
            "2022"});
            this.cmbDonem.Location = new System.Drawing.Point(219, 222);
            this.cmbDonem.Name = "cmbDonem";
            this.cmbDonem.Size = new System.Drawing.Size(167, 33);
            this.cmbDonem.TabIndex = 4;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(219, 103);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(478, 83);
            this.txtAciklama.TabIndex = 3;
            // 
            // aciklama
            // 
            this.aciklama.AutoSize = true;
            this.aciklama.Location = new System.Drawing.Point(29, 101);
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(99, 25);
            this.aciklama.TabIndex = 2;
            this.aciklama.Text = "Açıklama:";
            // 
            // numPuan
            // 
            this.numPuan.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPuan.Location = new System.Drawing.Point(219, 40);
            this.numPuan.Name = "numPuan";
            this.numPuan.Size = new System.Drawing.Size(237, 31);
            this.numPuan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Performans Puanı:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.LimeGreen;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(761, 343);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(276, 55);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Puanı Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // UC_PerformansPuanla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.grpPuan);
            this.Controls.Add(this.grpPersonel);
            this.Name = "UC_PerformansPuanla";
            this.Size = new System.Drawing.Size(1460, 657);
            this.Load += new System.EventHandler(this.UC_PerformansPuanla_Load);
            this.grpPersonel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoneller)).EndInit();
            this.grpPuan.ResumeLayout(false);
            this.grpPuan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPuan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonel;
        private System.Windows.Forms.DataGridView dgvPersoneller;
        private System.Windows.Forms.GroupBox grpPuan;
        private System.Windows.Forms.NumericUpDown numPuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDonem;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prsnlAdSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dprtmnAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozisyon;
        private System.Windows.Forms.Button btnKaydet;
    }
}
