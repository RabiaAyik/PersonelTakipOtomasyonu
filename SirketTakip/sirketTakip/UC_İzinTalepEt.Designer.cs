namespace sirketTakip
{
    partial class UC_İzinTalepEt
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.aciklamaLbl = new System.Windows.Forms.Label();
            this.dateTimeBitis = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimebaslangic = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIzinTuru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnİzinTalepEt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Controls.Add(this.aciklamaLbl);
            this.groupBox1.Controls.Add(this.dateTimeBitis);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimebaslangic);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbIzinTuru);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(16, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(891, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İzin Talebi Oluştur";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(103, 231);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(528, 108);
            this.txtAciklama.TabIndex = 7;
            // 
            // aciklamaLbl
            // 
            this.aciklamaLbl.AutoSize = true;
            this.aciklamaLbl.Location = new System.Drawing.Point(6, 231);
            this.aciklamaLbl.Name = "aciklamaLbl";
            this.aciklamaLbl.Size = new System.Drawing.Size(91, 20);
            this.aciklamaLbl.TabIndex = 6;
            this.aciklamaLbl.Text = "Açıklama:";
            // 
            // dateTimeBitis
            // 
            this.dateTimeBitis.Location = new System.Drawing.Point(312, 108);
            this.dateTimeBitis.Name = "dateTimeBitis";
            this.dateTimeBitis.Size = new System.Drawing.Size(200, 27);
            this.dateTimeBitis.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bitiş Tarih:";
            // 
            // dateTimebaslangic
            // 
            this.dateTimebaslangic.Location = new System.Drawing.Point(6, 108);
            this.dateTimebaslangic.Name = "dateTimebaslangic";
            this.dateTimebaslangic.Size = new System.Drawing.Size(200, 27);
            this.dateTimebaslangic.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Başlangıç Tarih:";
            // 
            // cmbIzinTuru
            // 
            this.cmbIzinTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIzinTuru.FormattingEnabled = true;
            this.cmbIzinTuru.Items.AddRange(new object[] {
            "YILLIK İZİN",
            "MAZERET İZNİ",
            "RAPOR İZNİ"});
            this.cmbIzinTuru.Location = new System.Drawing.Point(138, 43);
            this.cmbIzinTuru.Name = "cmbIzinTuru";
            this.cmbIzinTuru.Size = new System.Drawing.Size(207, 28);
            this.cmbIzinTuru.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İzin Türü:";
            // 
            // btnİzinTalepEt
            // 
            this.btnİzinTalepEt.BackColor = System.Drawing.Color.LightGreen;
            this.btnİzinTalepEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİzinTalepEt.Location = new System.Drawing.Point(678, 446);
            this.btnİzinTalepEt.Name = "btnİzinTalepEt";
            this.btnİzinTalepEt.Size = new System.Drawing.Size(229, 43);
            this.btnİzinTalepEt.TabIndex = 1;
            this.btnİzinTalepEt.Text = "İzin Talebini Gönder";
            this.btnİzinTalepEt.UseVisualStyleBackColor = false;
            this.btnİzinTalepEt.Click += new System.EventHandler(this.btnİzinTalepEt_Click);
            // 
            // UC_İzinTalepEt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnİzinTalepEt);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_İzinTalepEt";
            this.Size = new System.Drawing.Size(1304, 647);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbIzinTuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label aciklamaLbl;
        private System.Windows.Forms.DateTimePicker dateTimeBitis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimebaslangic;
        private System.Windows.Forms.Button btnİzinTalepEt;
    }
}
