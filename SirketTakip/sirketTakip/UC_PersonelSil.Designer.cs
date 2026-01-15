namespace sirketTakip
{
    partial class UC_PersonelSil
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
            this.grpPrsnlSil = new System.Windows.Forms.GroupBox();
            this.dgvPersonelSil = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stnAdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stnDprtmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stnPozisyon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPersonelSil = new System.Windows.Forms.Button();
            this.grpPrsnlSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelSil)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPrsnlSil
            // 
            this.grpPrsnlSil.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpPrsnlSil.Controls.Add(this.dgvPersonelSil);
            this.grpPrsnlSil.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpPrsnlSil.Location = new System.Drawing.Point(21, 16);
            this.grpPrsnlSil.Name = "grpPrsnlSil";
            this.grpPrsnlSil.Size = new System.Drawing.Size(804, 450);
            this.grpPrsnlSil.TabIndex = 0;
            this.grpPrsnlSil.TabStop = false;
            this.grpPrsnlSil.Text = "Personel Sil";
            // 
            // dgvPersonelSil
            // 
            this.dgvPersonelSil.AllowUserToAddRows = false;
            this.dgvPersonelSil.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonelSil.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersonelSil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonelSil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.stnAdSoyad,
            this.stnDprtmn,
            this.stnPozisyon});
            this.dgvPersonelSil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersonelSil.EnableHeadersVisualStyles = false;
            this.dgvPersonelSil.Location = new System.Drawing.Point(3, 26);
            this.dgvPersonelSil.MultiSelect = false;
            this.dgvPersonelSil.Name = "dgvPersonelSil";
            this.dgvPersonelSil.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonelSil.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPersonelSil.RowHeadersVisible = false;
            this.dgvPersonelSil.RowHeadersWidth = 51;
            this.dgvPersonelSil.RowTemplate.Height = 24;
            this.dgvPersonelSil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonelSil.Size = new System.Drawing.Size(798, 421);
            this.dgvPersonelSil.TabIndex = 0;
            this.dgvPersonelSil.TabStop = false;
            this.dgvPersonelSil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonelSil_CellContentClick);
            this.dgvPersonelSil.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPersonelSil_DataBindingComplete);
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
            // stnAdSoyad
            // 
            this.stnAdSoyad.DataPropertyName = "prsnlAdSoyad";
            this.stnAdSoyad.HeaderText = "Ad Soyad";
            this.stnAdSoyad.MinimumWidth = 6;
            this.stnAdSoyad.Name = "stnAdSoyad";
            this.stnAdSoyad.ReadOnly = true;
            this.stnAdSoyad.Width = 125;
            // 
            // stnDprtmn
            // 
            this.stnDprtmn.DataPropertyName = "dprtmnAd";
            this.stnDprtmn.HeaderText = "Departman";
            this.stnDprtmn.MinimumWidth = 6;
            this.stnDprtmn.Name = "stnDprtmn";
            this.stnDprtmn.ReadOnly = true;
            this.stnDprtmn.Width = 125;
            // 
            // stnPozisyon
            // 
            this.stnPozisyon.DataPropertyName = "pozisyon";
            this.stnPozisyon.HeaderText = "Pozisyon";
            this.stnPozisyon.MinimumWidth = 6;
            this.stnPozisyon.Name = "stnPozisyon";
            this.stnPozisyon.ReadOnly = true;
            this.stnPozisyon.Width = 125;
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.BackColor = System.Drawing.Color.Red;
            this.btnPersonelSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPersonelSil.Location = new System.Drawing.Point(427, 495);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(264, 50);
            this.btnPersonelSil.TabIndex = 1;
            this.btnPersonelSil.Text = "Seçili Personeli Sil";
            this.btnPersonelSil.UseVisualStyleBackColor = false;
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click);
            // 
            // UC_PersonelSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPersonelSil);
            this.Controls.Add(this.grpPrsnlSil);
            this.Name = "UC_PersonelSil";
            this.Size = new System.Drawing.Size(1245, 647);
            this.Load += new System.EventHandler(this.UC_PersonelSil_Load);
            this.grpPrsnlSil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelSil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPersonelSil;
        private System.Windows.Forms.Button btnPersonelSil;
        public System.Windows.Forms.GroupBox grpPrsnlSil;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn stnAdSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn stnDprtmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stnPozisyon;
    }
}
