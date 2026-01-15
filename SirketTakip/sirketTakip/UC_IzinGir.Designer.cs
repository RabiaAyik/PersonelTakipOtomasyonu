namespace sirketTakip
{
    partial class UC_IzinGir
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
            this.grpBxIzin = new System.Windows.Forms.GroupBox();
            this.dgvIzinler = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prsnlAdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslangicTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izinTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnReddet = new System.Windows.Forms.Button();
            this.grpBxIzin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzinler)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBxIzin
            // 
            this.grpBxIzin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpBxIzin.Controls.Add(this.dgvIzinler);
            this.grpBxIzin.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBxIzin.Location = new System.Drawing.Point(24, 3);
            this.grpBxIzin.Name = "grpBxIzin";
            this.grpBxIzin.Size = new System.Drawing.Size(1196, 500);
            this.grpBxIzin.TabIndex = 0;
            this.grpBxIzin.TabStop = false;
            this.grpBxIzin.Text = "İzinleri Görüntüle";
            // 
            // dgvIzinler
            // 
            this.dgvIzinler.AllowUserToAddRows = false;
            this.dgvIzinler.AllowUserToDeleteRows = false;
            this.dgvIzinler.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIzinler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIzinler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzinler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.personelId,
            this.prsnlAdSoyad,
            this.baslangicTarihi,
            this.bitisTarihi,
            this.izinTuru,
            this.aciklama,
            this.durum});
            this.dgvIzinler.EnableHeadersVisualStyles = false;
            this.dgvIzinler.Location = new System.Drawing.Point(6, 29);
            this.dgvIzinler.MultiSelect = false;
            this.dgvIzinler.Name = "dgvIzinler";
            this.dgvIzinler.ReadOnly = true;
            this.dgvIzinler.RowHeadersVisible = false;
            this.dgvIzinler.RowHeadersWidth = 51;
            this.dgvIzinler.RowTemplate.Height = 24;
            this.dgvIzinler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIzinler.Size = new System.Drawing.Size(1184, 229);
            this.dgvIzinler.TabIndex = 0;
            this.dgvIzinler.TabStop = false;
            this.dgvIzinler.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvIzinler_DataBindingComplete);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // personelId
            // 
            this.personelId.DataPropertyName = "personelId";
            this.personelId.HeaderText = "Personel No";
            this.personelId.MinimumWidth = 6;
            this.personelId.Name = "personelId";
            this.personelId.ReadOnly = true;
            this.personelId.Width = 125;
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
            // baslangicTarihi
            // 
            this.baslangicTarihi.DataPropertyName = "baslangicTarihi";
            this.baslangicTarihi.HeaderText = "Başlangıç Tarihi";
            this.baslangicTarihi.MinimumWidth = 6;
            this.baslangicTarihi.Name = "baslangicTarihi";
            this.baslangicTarihi.ReadOnly = true;
            this.baslangicTarihi.Width = 125;
            // 
            // bitisTarihi
            // 
            this.bitisTarihi.DataPropertyName = "bitisTarihi";
            this.bitisTarihi.HeaderText = "Bitiş Tarihi";
            this.bitisTarihi.MinimumWidth = 6;
            this.bitisTarihi.Name = "bitisTarihi";
            this.bitisTarihi.ReadOnly = true;
            this.bitisTarihi.Width = 125;
            // 
            // izinTuru
            // 
            this.izinTuru.DataPropertyName = "izinTuru";
            this.izinTuru.HeaderText = "İzin Türü";
            this.izinTuru.MinimumWidth = 6;
            this.izinTuru.Name = "izinTuru";
            this.izinTuru.ReadOnly = true;
            this.izinTuru.Width = 125;
            // 
            // aciklama
            // 
            this.aciklama.DataPropertyName = "aciklama";
            this.aciklama.HeaderText = "Açıklama";
            this.aciklama.MinimumWidth = 6;
            this.aciklama.Name = "aciklama";
            this.aciklama.ReadOnly = true;
            this.aciklama.Width = 125;
            // 
            // durum
            // 
            this.durum.DataPropertyName = "durum";
            this.durum.HeaderText = "Durum";
            this.durum.MinimumWidth = 6;
            this.durum.Name = "durum";
            this.durum.ReadOnly = true;
            this.durum.Width = 125;
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.Green;
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.Location = new System.Drawing.Point(488, 519);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(193, 57);
            this.btnOnayla.TabIndex = 1;
            this.btnOnayla.Text = "Seçili İzni Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click_1);
            // 
            // btnReddet
            // 
            this.btnReddet.BackColor = System.Drawing.Color.Red;
            this.btnReddet.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReddet.Location = new System.Drawing.Point(843, 519);
            this.btnReddet.Name = "btnReddet";
            this.btnReddet.Size = new System.Drawing.Size(193, 57);
            this.btnReddet.TabIndex = 2;
            this.btnReddet.Text = "Seçili İzni Reddet";
            this.btnReddet.UseVisualStyleBackColor = false;
            this.btnReddet.Click += new System.EventHandler(this.btnReddet_Click_1);
            // 
            // UC_IzinGir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReddet);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.grpBxIzin);
            this.Name = "UC_IzinGir";
            this.Size = new System.Drawing.Size(1257, 596);
            this.grpBxIzin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzinler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnReddet;
        public System.Windows.Forms.GroupBox grpBxIzin;
        public System.Windows.Forms.DataGridView dgvIzinler;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelId;
        private System.Windows.Forms.DataGridViewTextBoxColumn prsnlAdSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslangicTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn izinTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn durum;
    }
}
