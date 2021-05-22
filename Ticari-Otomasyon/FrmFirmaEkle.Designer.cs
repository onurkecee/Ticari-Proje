namespace Ticari_Otomasyon
{
    partial class FrmFirmaEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFirmaEkle));
            this.cmbSektor = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtVergiDairesi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.cmbil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtFax = new System.Windows.Forms.MaskedTextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTelefon3 = new System.Windows.Forms.MaskedTextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmbilce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbYetkiliGorev = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtYetkiliTC = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefon2 = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefon1 = new System.Windows.Forms.MaskedTextBox();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtYetkili = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnFirmaEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSektor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYetkiliGorev.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSektor
            // 
            this.cmbSektor.Location = new System.Drawing.Point(222, 52);
            this.cmbSektor.Name = "cmbSektor";
            this.cmbSektor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSektor.Properties.Items.AddRange(new object[] {
            "Bilişim",
            "Sağlık",
            "Eğitim",
            "Çağrı Merkezi",
            "Taşımacılık(Kargo, Lojistik)",
            "Üretim",
            "Güvenlik",
            "Tekstil",
            "Diğer"});
            this.cmbSektor.Size = new System.Drawing.Size(218, 20);
            this.cmbSektor.TabIndex = 43;
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(222, 341);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(217, 20);
            this.txtVergiDairesi.TabIndex = 57;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(135, 344);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(63, 13);
            this.labelControl14.TabIndex = 71;
            this.labelControl14.Text = "Vergi Dairesi:";
            // 
            // cmbil
            // 
            this.cmbil.Location = new System.Drawing.Point(222, 289);
            this.cmbil.Name = "cmbil";
            this.cmbil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbil.Size = new System.Drawing.Size(218, 20);
            this.cmbil.TabIndex = 54;
            this.cmbil.SelectedIndexChanged += new System.EventHandler(this.cmbil_SelectedIndexChanged);
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(135, 292);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(10, 13);
            this.labelControl10.TabIndex = 70;
            this.labelControl10.Text = "İl:";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(222, 262);
            this.txtFax.Mask = "(999) 000-0000";
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(217, 20);
            this.txtFax.TabIndex = 53;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(134, 265);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(22, 13);
            this.labelControl6.TabIndex = 69;
            this.labelControl6.Text = "Fax:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(222, 236);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(217, 20);
            this.txtMail.TabIndex = 52;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(134, 239);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(22, 13);
            this.labelControl5.TabIndex = 68;
            this.labelControl5.Text = "Mail:";
            // 
            // txtTelefon3
            // 
            this.txtTelefon3.Location = new System.Drawing.Point(222, 209);
            this.txtTelefon3.Mask = "(999) 000-0000";
            this.txtTelefon3.Name = "txtTelefon3";
            this.txtTelefon3.Size = new System.Drawing.Size(217, 20);
            this.txtTelefon3.TabIndex = 51;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(134, 212);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 13);
            this.labelControl4.TabIndex = 67;
            this.labelControl4.Text = "Telefon 3:";
            // 
            // cmbilce
            // 
            this.cmbilce.Location = new System.Drawing.Point(222, 315);
            this.cmbilce.Name = "cmbilce";
            this.cmbilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbilce.Size = new System.Drawing.Size(218, 20);
            this.cmbilce.TabIndex = 56;
            // 
            // cmbYetkiliGorev
            // 
            this.cmbYetkiliGorev.Location = new System.Drawing.Point(222, 104);
            this.cmbYetkiliGorev.Name = "cmbYetkiliGorev";
            this.cmbYetkiliGorev.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbYetkiliGorev.Properties.Items.AddRange(new object[] {
            "Firma Sahibi",
            "Müdür",
            "Muhasebe",
            "İşçi(Çalışan)"});
            this.cmbYetkiliGorev.Size = new System.Drawing.Size(218, 20);
            this.cmbYetkiliGorev.TabIndex = 46;
            // 
            // txtYetkiliTC
            // 
            this.txtYetkiliTC.Location = new System.Drawing.Point(222, 130);
            this.txtYetkiliTC.Mask = "00000000000";
            this.txtYetkiliTC.Name = "txtYetkiliTC";
            this.txtYetkiliTC.Size = new System.Drawing.Size(218, 20);
            this.txtYetkiliTC.TabIndex = 48;
            this.txtYetkiliTC.ValidatingType = typeof(int);
            // 
            // txtTelefon2
            // 
            this.txtTelefon2.Location = new System.Drawing.Point(222, 182);
            this.txtTelefon2.Mask = "(999) 000-0000";
            this.txtTelefon2.Name = "txtTelefon2";
            this.txtTelefon2.Size = new System.Drawing.Size(217, 20);
            this.txtTelefon2.TabIndex = 50;
            // 
            // txtTelefon1
            // 
            this.txtTelefon1.Location = new System.Drawing.Point(222, 156);
            this.txtTelefon1.Mask = "(999) 000-0000";
            this.txtTelefon1.Name = "txtTelefon1";
            this.txtTelefon1.Size = new System.Drawing.Size(217, 20);
            this.txtTelefon1.TabIndex = 49;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(135, 315);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(21, 13);
            this.labelControl13.TabIndex = 66;
            this.labelControl13.Text = "İlçe:";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(135, 107);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(63, 13);
            this.labelControl12.TabIndex = 65;
            this.labelControl12.Text = "Yetkili Görev:";
            // 
            // txtYetkili
            // 
            this.txtYetkili.Location = new System.Drawing.Point(222, 78);
            this.txtYetkili.Name = "txtYetkili";
            this.txtYetkili.Size = new System.Drawing.Size(217, 20);
            this.txtYetkili.TabIndex = 45;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(135, 81);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(31, 13);
            this.labelControl11.TabIndex = 64;
            this.labelControl11.Text = "Yetkili:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(134, 185);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(49, 13);
            this.labelControl9.TabIndex = 63;
            this.labelControl9.Text = "Telefon 2:";
            // 
            // btnFirmaEkle
            // 
            this.btnFirmaEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFirmaEkle.ImageOptions.Image")));
            this.btnFirmaEkle.Location = new System.Drawing.Point(244, 502);
            this.btnFirmaEkle.Name = "btnFirmaEkle";
            this.btnFirmaEkle.Size = new System.Drawing.Size(130, 41);
            this.btnFirmaEkle.TabIndex = 60;
            this.btnFirmaEkle.Text = "Firma Ekle";
            this.btnFirmaEkle.Click += new System.EventHandler(this.btnFirmaEkle_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(222, 367);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(217, 96);
            this.txtAdres.TabIndex = 59;
            this.txtAdres.Text = "";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(134, 367);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(32, 13);
            this.labelControl8.TabIndex = 58;
            this.labelControl8.Text = "Adres:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(135, 133);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(47, 13);
            this.labelControl7.TabIndex = 55;
            this.labelControl7.Text = "Yetkili TC:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(134, 156);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 47;
            this.labelControl3.Text = "Telefon:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(134, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 13);
            this.labelControl2.TabIndex = 44;
            this.labelControl2.Text = "Sektör:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(222, 26);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(217, 20);
            this.txtAd.TabIndex = 42;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(134, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 13);
            this.labelControl1.TabIndex = 41;
            this.labelControl1.Text = "Ad:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ticari_Otomasyon.Properties.Resources.firma;
            this.pictureBox1.Location = new System.Drawing.Point(619, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 400);
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // FrmFirmaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 735);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbSektor);
            this.Controls.Add(this.txtVergiDairesi);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.cmbil);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtTelefon3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cmbilce);
            this.Controls.Add(this.cmbYetkiliGorev);
            this.Controls.Add(this.txtYetkiliTC);
            this.Controls.Add(this.txtTelefon2);
            this.Controls.Add(this.txtTelefon1);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.txtYetkili);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.btnFirmaEkle);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmFirmaEkle";
            this.Text = "FİRMA EKLE";
            this.Load += new System.EventHandler(this.FrmFirmaEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbSektor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYetkiliGorev.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cmbSektor;
        private DevExpress.XtraEditors.TextEdit txtVergiDairesi;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.ComboBoxEdit cmbil;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.MaskedTextBox txtFax;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.MaskedTextBox txtTelefon3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cmbilce;
        private DevExpress.XtraEditors.ComboBoxEdit cmbYetkiliGorev;
        private System.Windows.Forms.MaskedTextBox txtYetkiliTC;
        private System.Windows.Forms.MaskedTextBox txtTelefon2;
        private System.Windows.Forms.MaskedTextBox txtTelefon1;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtYetkili;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btnFirmaEkle;
        private System.Windows.Forms.RichTextBox txtAdres;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}