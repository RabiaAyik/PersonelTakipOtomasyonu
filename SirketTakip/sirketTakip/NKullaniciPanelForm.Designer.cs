namespace sirketTakip
{
    partial class NKullaniciPanelForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBtn = new System.Windows.Forms.Panel();
            this.btnIzinTalepGör = new System.Windows.Forms.Button();
            this.btnIzinTalep = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.panelBtn.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBtn
            // 
            this.panelBtn.BackColor = System.Drawing.Color.Thistle;
            this.panelBtn.Controls.Add(this.btnCikis);
            this.panelBtn.Controls.Add(this.btnIzinTalepGör);
            this.panelBtn.Controls.Add(this.btnIzinTalep);
            this.panelBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBtn.Location = new System.Drawing.Point(0, 0);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(133, 623);
            this.panelBtn.TabIndex = 0;
            // 
            // btnIzinTalepGör
            // 
            this.btnIzinTalepGör.BackColor = System.Drawing.Color.Pink;
            this.btnIzinTalepGör.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIzinTalepGör.Location = new System.Drawing.Point(0, 331);
            this.btnIzinTalepGör.Name = "btnIzinTalepGör";
            this.btnIzinTalepGör.Size = new System.Drawing.Size(133, 102);
            this.btnIzinTalepGör.TabIndex = 1;
            this.btnIzinTalepGör.Text = "İzin Talebini Gör";
            this.btnIzinTalepGör.UseVisualStyleBackColor = false;
            this.btnIzinTalepGör.Click += new System.EventHandler(this.btnİzinTalepGör_Click);
            // 
            // btnIzinTalep
            // 
            this.btnIzinTalep.BackColor = System.Drawing.Color.Pink;
            this.btnIzinTalep.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIzinTalep.Location = new System.Drawing.Point(0, 197);
            this.btnIzinTalep.Name = "btnIzinTalep";
            this.btnIzinTalep.Size = new System.Drawing.Size(133, 115);
            this.btnIzinTalep.TabIndex = 0;
            this.btnIzinTalep.Text = "İzin Talebi Oluştur";
            this.btnIzinTalep.UseVisualStyleBackColor = false;
            this.btnIzinTalep.Click += new System.EventHandler(this.btnIzinTalep_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(133, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1285, 623);
            this.panelMenu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(131, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(895, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "Soldaki menüden yapacağınız işlemi seçebilirsiniz.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.LightPink;
            this.label2.Location = new System.Drawing.Point(220, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(756, 72);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kullanıcı Paneline Hoşgeldiniz...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sirketTakip.Properties.Resources.kugu;
            this.pictureBox1.Location = new System.Drawing.Point(344, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 314);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Tomato;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Image = global::sirketTakip.Properties.Resources.cikiss;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCikis.Location = new System.Drawing.Point(0, 458);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(137, 89);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // NKullaniciPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1418, 623);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "NKullaniciPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NKullaniciPanelForm";
            this.Load += new System.EventHandler(this.NKullaniciPanelForm_Load);
            this.panelBtn.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnIzinTalepGör;
        private System.Windows.Forms.Button btnIzinTalep;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}