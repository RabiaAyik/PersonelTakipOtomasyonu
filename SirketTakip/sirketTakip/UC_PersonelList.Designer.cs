namespace sirketTakip
{
    partial class UC_PersonelList
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
            this.dgvPersonelList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prsnlAdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozisyon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dprtmnAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iseGiris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prsnlMaas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prsnlEposta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBxPrsnlList = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelList)).BeginInit();
            this.grpBxPrsnlList.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPersonelList
            // 
            this.dgvPersonelList.AllowUserToAddRows = false;
            this.dgvPersonelList.AllowUserToDeleteRows = false;
            this.dgvPersonelList.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonelList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersonelList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonelList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.prsnlAdSoyad,
            this.pozisyon,
            this.dprtmnAd,
            this.iseGiris,
            this.prsnlMaas,
            this.role,
            this.prsnlEposta});
            this.dgvPersonelList.EnableHeadersVisualStyles = false;
            this.dgvPersonelList.Location = new System.Drawing.Point(22, 29);
            this.dgvPersonelList.MultiSelect = false;
            this.dgvPersonelList.Name = "dgvPersonelList";
            this.dgvPersonelList.RowHeadersVisible = false;
            this.dgvPersonelList.RowHeadersWidth = 51;
            this.dgvPersonelList.RowTemplate.Height = 24;
            this.dgvPersonelList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonelList.Size = new System.Drawing.Size(1321, 423);
            this.dgvPersonelList.TabIndex = 1;
            this.dgvPersonelList.TabStop = false;
            this.dgvPersonelList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPersonelList_DataBindingComplete);
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
            this.prsnlAdSoyad.HeaderText = "Ad Soyad";
            this.prsnlAdSoyad.MinimumWidth = 6;
            this.prsnlAdSoyad.Name = "prsnlAdSoyad";
            this.prsnlAdSoyad.ReadOnly = true;
            this.prsnlAdSoyad.Width = 125;
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
            // dprtmnAd
            // 
            this.dprtmnAd.DataPropertyName = "dprtmnAd";
            this.dprtmnAd.HeaderText = "Departman";
            this.dprtmnAd.MinimumWidth = 6;
            this.dprtmnAd.Name = "dprtmnAd";
            this.dprtmnAd.ReadOnly = true;
            this.dprtmnAd.Width = 125;
            // 
            // iseGiris
            // 
            this.iseGiris.DataPropertyName = "iseGiris";
            this.iseGiris.HeaderText = "İşe Giriş Tarihi";
            this.iseGiris.MinimumWidth = 6;
            this.iseGiris.Name = "iseGiris";
            this.iseGiris.ReadOnly = true;
            this.iseGiris.Width = 125;
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
            // role
            // 
            this.role.DataPropertyName = "role";
            this.role.HeaderText = "Rol";
            this.role.MinimumWidth = 6;
            this.role.Name = "role";
            this.role.ReadOnly = true;
            this.role.Width = 125;
            // 
            // prsnlEposta
            // 
            this.prsnlEposta.DataPropertyName = "prsnlEposta";
            this.prsnlEposta.HeaderText = "E-Posta";
            this.prsnlEposta.MinimumWidth = 6;
            this.prsnlEposta.Name = "prsnlEposta";
            this.prsnlEposta.ReadOnly = true;
            this.prsnlEposta.Width = 125;
            // 
            // grpBxPrsnlList
            // 
            this.grpBxPrsnlList.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpBxPrsnlList.Controls.Add(this.dgvPersonelList);
            this.grpBxPrsnlList.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxPrsnlList.Location = new System.Drawing.Point(17, 3);
            this.grpBxPrsnlList.Name = "grpBxPrsnlList";
            this.grpBxPrsnlList.Size = new System.Drawing.Size(1349, 542);
            this.grpBxPrsnlList.TabIndex = 2;
            this.grpBxPrsnlList.TabStop = false;
            this.grpBxPrsnlList.Text = "Personel Listesi";
            // 
            // UC_PersonelList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpBxPrsnlList);
            this.Name = "UC_PersonelList";
            this.Size = new System.Drawing.Size(1403, 653);
            this.Load += new System.EventHandler(this.UC_PersonelList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelList)).EndInit();
            this.grpBxPrsnlList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPersonelList;
        private System.Windows.Forms.GroupBox grpBxPrsnlList;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prsnlAdSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozisyon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dprtmnAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn iseGiris;
        private System.Windows.Forms.DataGridViewTextBoxColumn prsnlMaas;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn prsnlEposta;
    }
}
