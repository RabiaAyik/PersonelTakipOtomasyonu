namespace sirketTakip
{
    partial class UC_IzinGor
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
            this.grpBxIzinGor = new System.Windows.Forms.GroupBox();
            this.dgvIzinGor = new System.Windows.Forms.DataGridView();
            this.personelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prsnlAdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslangicTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izinTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBxIzinGor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzinGor)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBxIzinGor
            // 
            this.grpBxIzinGor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpBxIzinGor.Controls.Add(this.dgvIzinGor);
            this.grpBxIzinGor.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBxIzinGor.Location = new System.Drawing.Point(18, 3);
            this.grpBxIzinGor.Name = "grpBxIzinGor";
            this.grpBxIzinGor.Size = new System.Drawing.Size(1077, 448);
            this.grpBxIzinGor.TabIndex = 0;
            this.grpBxIzinGor.TabStop = false;
            this.grpBxIzinGor.Text = "İzinlerimi Gör";
            // 
            // dgvIzinGor
            // 
            this.dgvIzinGor.AllowUserToAddRows = false;
            this.dgvIzinGor.AllowUserToDeleteRows = false;
            this.dgvIzinGor.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIzinGor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIzinGor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzinGor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelId,
            this.prsnlAdSoyad,
            this.baslangicTarihi,
            this.bitisTarihi,
            this.izinTuru,
            this.aciklama,
            this.durum,
            this.Id,
            this.CreatedDate});
            this.dgvIzinGor.EnableHeadersVisualStyles = false;
            this.dgvIzinGor.Location = new System.Drawing.Point(6, 29);
            this.dgvIzinGor.MultiSelect = false;
            this.dgvIzinGor.Name = "dgvIzinGor";
            this.dgvIzinGor.ReadOnly = true;
            this.dgvIzinGor.RowHeadersVisible = false;
            this.dgvIzinGor.RowHeadersWidth = 51;
            this.dgvIzinGor.RowTemplate.Height = 24;
            this.dgvIzinGor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIzinGor.Size = new System.Drawing.Size(1044, 344);
            this.dgvIzinGor.TabIndex = 0;
            this.dgvIzinGor.TabStop = false;
            this.dgvIzinGor.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvIzinGor_DataBindingComplete);
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
            this.prsnlAdSoyad.HeaderText = "Personel Ad";
            this.prsnlAdSoyad.MinimumWidth = 6;
            this.prsnlAdSoyad.Name = "prsnlAdSoyad";
            this.prsnlAdSoyad.ReadOnly = true;
            this.prsnlAdSoyad.Visible = false;
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
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // CreatedDate
            // 
            this.CreatedDate.DataPropertyName = "CreatedDate";
            this.CreatedDate.HeaderText = "createddate";
            this.CreatedDate.MinimumWidth = 6;
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            this.CreatedDate.Visible = false;
            this.CreatedDate.Width = 125;
            // 
            // UC_IzinGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpBxIzinGor);
            this.Name = "UC_IzinGor";
            this.Size = new System.Drawing.Size(1123, 508);
            this.Load += new System.EventHandler(this.UC_IzinGor_Load);
            this.grpBxIzinGor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzinGor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxIzinGor;
        private System.Windows.Forms.DataGridView dgvIzinGor;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelId;
        private System.Windows.Forms.DataGridViewTextBoxColumn prsnlAdSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslangicTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn izinTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn durum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
    }
}
