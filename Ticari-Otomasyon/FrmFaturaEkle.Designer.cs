namespace Ticari_Otomasyon
{
    partial class FrmFaturaEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaEkle));
            this.txtFaturaID = new DevExpress.XtraEditors.TextEdit();
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            this.txtFiyat = new DevExpress.XtraEditors.TextEdit();
            this.txtMiktar = new System.Windows.Forms.NumericUpDown();
            this.txtUrunAd = new DevExpress.XtraEditors.TextEdit();
            this.txtTeslimAlan = new DevExpress.XtraEditors.TextEdit();
            this.txtTeslimEden = new DevExpress.XtraEditors.TextEdit();
            this.txtVergiDairesi = new DevExpress.XtraEditors.TextEdit();
            this.txtSaat = new System.Windows.Forms.MaskedTextBox();
            this.txtTarih = new DevExpress.XtraEditors.DateEdit();
            this.txtSiraNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtUrunID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFaturaEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnBul = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.cmbMusteriTur = new System.Windows.Forms.ComboBox();
            this.cmbAlici = new System.Windows.Forms.ComboBox();
            this.FrmFaturaDetayEkle = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeslimAlan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeslimEden.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiraNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFaturaID
            // 
            this.txtFaturaID.Enabled = false;
            this.txtFaturaID.Location = new System.Drawing.Point(138, 183);
            this.txtFaturaID.Name = "txtFaturaID";
            this.txtFaturaID.Size = new System.Drawing.Size(217, 20);
            this.txtFaturaID.TabIndex = 5;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(138, 153);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(217, 20);
            this.txtTutar.TabIndex = 4;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(138, 127);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(217, 20);
            this.txtFiyat.TabIndex = 3;
            this.txtFiyat.TextChanged += new System.EventHandler(this.txtFiyat_TextChanged);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(138, 100);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(217, 21);
            this.txtMiktar.TabIndex = 2;
            this.txtMiktar.ValueChanged += new System.EventHandler(this.txtMiktar_ValueChanged);
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(138, 72);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(217, 20);
            this.txtUrunAd.TabIndex = 1;
            // 
            // txtTeslimAlan
            // 
            this.txtTeslimAlan.Location = new System.Drawing.Point(171, 213);
            this.txtTeslimAlan.Name = "txtTeslimAlan";
            this.txtTeslimAlan.Size = new System.Drawing.Size(217, 20);
            this.txtTeslimAlan.TabIndex = 8;
            // 
            // txtTeslimEden
            // 
            this.txtTeslimEden.Location = new System.Drawing.Point(171, 186);
            this.txtTeslimEden.Name = "txtTeslimEden";
            this.txtTeslimEden.Size = new System.Drawing.Size(218, 20);
            this.txtTeslimEden.TabIndex = 7;
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(171, 129);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(218, 20);
            this.txtVergiDairesi.TabIndex = 5;
            // 
            // txtSaat
            // 
            this.txtSaat.Location = new System.Drawing.Point(172, 103);
            this.txtSaat.Mask = "00:00";
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.Size = new System.Drawing.Size(217, 20);
            this.txtSaat.TabIndex = 4;
            this.txtSaat.ValidatingType = typeof(System.DateTime);
            // 
            // txtTarih
            // 
            this.txtTarih.EditValue = null;
            this.txtTarih.Location = new System.Drawing.Point(171, 77);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Size = new System.Drawing.Size(218, 20);
            this.txtTarih.TabIndex = 3;
            // 
            // txtSiraNo
            // 
            this.txtSiraNo.Location = new System.Drawing.Point(250, 24);
            this.txtSiraNo.Name = "txtSiraNo";
            this.txtSiraNo.Size = new System.Drawing.Size(140, 20);
            this.txtSiraNo.TabIndex = 1;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(64, 156);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(30, 13);
            this.labelControl14.TabIndex = 74;
            this.labelControl14.Text = "Tutar:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(64, 102);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(33, 13);
            this.labelControl10.TabIndex = 73;
            this.labelControl10.Text = "Miktar:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(63, 75);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 13);
            this.labelControl6.TabIndex = 72;
            this.labelControl6.Text = "Ürün Adı:";
            // 
            // txtUrunID
            // 
            this.txtUrunID.Location = new System.Drawing.Point(138, 46);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Size = new System.Drawing.Size(162, 20);
            this.txtUrunID.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(63, 49);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 13);
            this.labelControl5.TabIndex = 71;
            this.labelControl5.Text = "Ürün ID:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(96, 216);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(38, 13);
            this.labelControl4.TabIndex = 70;
            this.labelControl4.Text = "T. Alan:";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(64, 130);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(28, 13);
            this.labelControl13.TabIndex = 69;
            this.labelControl13.Text = "Fiyat:";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(97, 106);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(26, 13);
            this.labelControl12.TabIndex = 68;
            this.labelControl12.Text = "Saat:";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(97, 80);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(28, 13);
            this.labelControl11.TabIndex = 67;
            this.labelControl11.Text = "Tarih:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(96, 189);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(41, 13);
            this.labelControl9.TabIndex = 66;
            this.labelControl9.Text = "T. Eden:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(63, 186);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(50, 13);
            this.labelControl8.TabIndex = 61;
            this.labelControl8.Text = "Fatura ID:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(97, 132);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(56, 13);
            this.labelControl7.TabIndex = 60;
            this.labelControl7.Text = "Vergi Daire:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(96, 160);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(22, 13);
            this.labelControl3.TabIndex = 58;
            this.labelControl3.Text = "Alıcı:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(206, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 13);
            this.labelControl2.TabIndex = 57;
            this.labelControl2.Text = "Sıra No:";
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.Location = new System.Drawing.Point(171, 24);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(29, 20);
            this.txtSeriNo.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(96, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(22, 13);
            this.labelControl1.TabIndex = 54;
            this.labelControl1.Text = "Seri:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ticari_Otomasyon.Properties.Resources.fatura;
            this.pictureBox1.Location = new System.Drawing.Point(600, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // btnFaturaEkle
            // 
            this.btnFaturaEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFaturaEkle.ImageOptions.Image")));
            this.btnFaturaEkle.Location = new System.Drawing.Point(194, 239);
            this.btnFaturaEkle.Name = "btnFaturaEkle";
            this.btnFaturaEkle.Size = new System.Drawing.Size(141, 41);
            this.btnFaturaEkle.TabIndex = 9;
            this.btnFaturaEkle.Text = "Fatura Ekle";
            this.btnFaturaEkle.Click += new System.EventHandler(this.btnFaturaEkle_Click);
            // 
            // btnBul
            // 
            this.btnBul.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBul.ImageOptions.Image")));
            this.btnBul.Location = new System.Drawing.Point(306, 46);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(49, 20);
            this.btnBul.TabIndex = 89;
            this.btnBul.Text = "Bul";
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(96, 53);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(64, 13);
            this.labelControl16.TabIndex = 91;
            this.labelControl16.Text = "Müşteri Türü:";
            // 
            // cmbMusteriTur
            // 
            this.cmbMusteriTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusteriTur.FormattingEnabled = true;
            this.cmbMusteriTur.Items.AddRange(new object[] {
            "Bireysel",
            "Kurumsal"});
            this.cmbMusteriTur.Location = new System.Drawing.Point(171, 50);
            this.cmbMusteriTur.Name = "cmbMusteriTur";
            this.cmbMusteriTur.Size = new System.Drawing.Size(218, 21);
            this.cmbMusteriTur.TabIndex = 2;
            this.cmbMusteriTur.SelectedIndexChanged += new System.EventHandler(this.cmbMusteriTur_SelectedIndexChanged);
            // 
            // cmbAlici
            // 
            this.cmbAlici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlici.FormattingEnabled = true;
            this.cmbAlici.Location = new System.Drawing.Point(170, 157);
            this.cmbAlici.Name = "cmbAlici";
            this.cmbAlici.Size = new System.Drawing.Size(219, 21);
            this.cmbAlici.TabIndex = 6;
            // 
            // FrmFaturaDetayEkle
            // 
            this.FrmFaturaDetayEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.FrmFaturaDetayEkle.Location = new System.Drawing.Point(159, 227);
            this.FrmFaturaDetayEkle.Name = "FrmFaturaDetayEkle";
            this.FrmFaturaDetayEkle.Size = new System.Drawing.Size(141, 41);
            this.FrmFaturaDetayEkle.TabIndex = 6;
            this.FrmFaturaDetayEkle.Text = "Fatura Detay Ekle";
            this.FrmFaturaDetayEkle.Click += new System.EventHandler(this.FrmFaturaDetayEkle_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtUrunID);
            this.groupControl1.Controls.Add(this.FrmFaturaDetayEkle);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.btnBul);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.txtFaturaID);
            this.groupControl1.Controls.Add(this.txtUrunAd);
            this.groupControl1.Controls.Add(this.txtTutar);
            this.groupControl1.Controls.Add(this.txtMiktar);
            this.groupControl1.Controls.Add(this.txtFiyat);
            this.groupControl1.Location = new System.Drawing.Point(36, 286);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(426, 295);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "FATURA DETAY";
            this.groupControl1.Visible = false;
            // 
            // FrmFaturaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 735);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.cmbAlici);
            this.Controls.Add(this.cmbMusteriTur);
            this.Controls.Add(this.labelControl16);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTeslimAlan);
            this.Controls.Add(this.txtTeslimEden);
            this.Controls.Add(this.txtVergiDairesi);
            this.Controls.Add(this.txtSaat);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.txtSiraNo);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.btnFaturaEkle);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtSeriNo);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmFaturaEkle";
            this.Text = "FATURA EKLE";
            this.Load += new System.EventHandler(this.FrmFaturaEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeslimAlan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeslimEden.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiraNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtFaturaID;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.TextEdit txtFiyat;
        private System.Windows.Forms.NumericUpDown txtMiktar;
        private DevExpress.XtraEditors.TextEdit txtUrunAd;
        private DevExpress.XtraEditors.TextEdit txtTeslimAlan;
        private DevExpress.XtraEditors.TextEdit txtTeslimEden;
        private DevExpress.XtraEditors.TextEdit txtVergiDairesi;
        private System.Windows.Forms.MaskedTextBox txtSaat;
        private DevExpress.XtraEditors.DateEdit txtTarih;
        private DevExpress.XtraEditors.TextEdit txtSiraNo;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtUrunID;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btnFaturaEkle;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSeriNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btnBul;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private System.Windows.Forms.ComboBox cmbMusteriTur;
        private System.Windows.Forms.ComboBox cmbAlici;
        private DevExpress.XtraEditors.SimpleButton FrmFaturaDetayEkle;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}