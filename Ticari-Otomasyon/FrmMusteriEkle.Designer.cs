namespace Ticari_Otomasyon
{
    partial class FrmMusteriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriEkle));
            this.cmbilce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTcKimlik = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefon2 = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtVergiDairesi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMusteriEkle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cmbilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbilce
            // 
            this.cmbilce.Location = new System.Drawing.Point(184, 261);
            this.cmbilce.Name = "cmbilce";
            this.cmbilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbilce.Size = new System.Drawing.Size(217, 20);
            this.cmbilce.TabIndex = 43;
            // 
            // cmbil
            // 
            this.cmbil.Location = new System.Drawing.Point(184, 235);
            this.cmbil.Name = "cmbil";
            this.cmbil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbil.Size = new System.Drawing.Size(217, 20);
            this.cmbil.TabIndex = 42;
            this.cmbil.SelectedIndexChanged += new System.EventHandler(this.cmbil_SelectedIndexChanged);
            // 
            // txtTcKimlik
            // 
            this.txtTcKimlik.Location = new System.Drawing.Point(184, 157);
            this.txtTcKimlik.Mask = "00000000000";
            this.txtTcKimlik.Name = "txtTcKimlik";
            this.txtTcKimlik.Size = new System.Drawing.Size(217, 20);
            this.txtTcKimlik.TabIndex = 38;
            this.txtTcKimlik.ValidatingType = typeof(int);
            // 
            // txtTelefon2
            // 
            this.txtTelefon2.Location = new System.Drawing.Point(184, 131);
            this.txtTelefon2.Mask = "(999) 000-0000";
            this.txtTelefon2.Name = "txtTelefon2";
            this.txtTelefon2.Size = new System.Drawing.Size(217, 20);
            this.txtTelefon2.TabIndex = 37;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(184, 105);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(217, 20);
            this.txtTelefon.TabIndex = 35;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(96, 264);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(21, 13);
            this.labelControl13.TabIndex = 54;
            this.labelControl13.Text = "İlçe:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(184, 209);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(217, 20);
            this.txtMail.TabIndex = 41;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(96, 212);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(22, 13);
            this.labelControl11.TabIndex = 53;
            this.labelControl11.Text = "Mail:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(96, 160);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(17, 13);
            this.labelControl10.TabIndex = 52;
            this.labelControl10.Text = "TC:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(96, 134);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(49, 13);
            this.labelControl9.TabIndex = 51;
            this.labelControl9.Text = "Telefon 2:";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(184, 287);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(217, 96);
            this.txtAdres.TabIndex = 44;
            this.txtAdres.Text = "";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(96, 290);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(32, 13);
            this.labelControl8.TabIndex = 49;
            this.labelControl8.Text = "Adres:";
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(184, 183);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(217, 20);
            this.txtVergiDairesi.TabIndex = 40;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(96, 186);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(56, 13);
            this.labelControl7.TabIndex = 46;
            this.labelControl7.Text = "Vergi Daire:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(96, 108);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 39;
            this.labelControl3.Text = "Telefon:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(184, 79);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(217, 20);
            this.txtSoyad.TabIndex = 34;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(96, 82);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 36;
            this.labelControl2.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(184, 53);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(217, 20);
            this.txtAd.TabIndex = 33;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(96, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 13);
            this.labelControl1.TabIndex = 31;
            this.labelControl1.Text = "Ad:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ticari_Otomasyon.Properties.Resources.crm;
            this.pictureBox1.Location = new System.Drawing.Point(598, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriEkle.ImageOptions.Image")));
            this.btnMusteriEkle.Location = new System.Drawing.Point(211, 415);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(137, 41);
            this.btnMusteriEkle.TabIndex = 45;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(96, 238);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(10, 13);
            this.labelControl4.TabIndex = 56;
            this.labelControl4.Text = "İl:";
            // 
            // FrmMusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 735);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbilce);
            this.Controls.Add(this.cmbil);
            this.Controls.Add(this.txtTcKimlik);
            this.Controls.Add(this.txtTelefon2);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtVergiDairesi);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmMusteriEkle";
            this.Text = "MÜŞTERİ EKLE";
            this.Load += new System.EventHandler(this.FrmMusteriEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cmbilce;
        private DevExpress.XtraEditors.ComboBoxEdit cmbil;
        private System.Windows.Forms.MaskedTextBox txtTcKimlik;
        private System.Windows.Forms.MaskedTextBox txtTelefon2;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btnMusteriEkle;
        private System.Windows.Forms.RichTextBox txtAdres;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtVergiDairesi;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}