namespace Ticari_Otomasyon
{
    partial class FrmFaturalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturalar));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtFaturaID = new DevExpress.XtraEditors.TextEdit();
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            this.txtFiyat = new DevExpress.XtraEditors.TextEdit();
            this.txtMiktar = new System.Windows.Forms.NumericUpDown();
            this.txtUrunAd = new DevExpress.XtraEditors.TextEdit();
            this.txtTeslimAlan = new DevExpress.XtraEditors.TextEdit();
            this.txtTeslimEden = new DevExpress.XtraEditors.TextEdit();
            this.txtAlici = new DevExpress.XtraEditors.TextEdit();
            this.txtVergiDairesi = new DevExpress.XtraEditors.TextEdit();
            this.txtSaat = new System.Windows.Forms.MaskedTextBox();
            this.txtTarih = new DevExpress.XtraEditors.DateEdit();
            this.txtSiraNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtUrunID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lblid = new DevExpress.XtraEditors.LabelControl();
            this.btnFaturaGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnFaturaSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnFaturaEkle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnBul = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeslimAlan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeslimEden.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiraNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollStep = 1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-2, -2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1024, 738);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(7, 420);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(30, 13);
            this.labelControl14.TabIndex = 40;
            this.labelControl14.Text = "Tutar:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(7, 366);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(33, 13);
            this.labelControl10.TabIndex = 38;
            this.labelControl10.Text = "Miktar:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnBul);
            this.groupControl1.Controls.Add(this.labelControl15);
            this.groupControl1.Controls.Add(this.txtFaturaID);
            this.groupControl1.Controls.Add(this.txtTutar);
            this.groupControl1.Controls.Add(this.txtFiyat);
            this.groupControl1.Controls.Add(this.txtMiktar);
            this.groupControl1.Controls.Add(this.txtUrunAd);
            this.groupControl1.Controls.Add(this.txtTeslimAlan);
            this.groupControl1.Controls.Add(this.txtTeslimEden);
            this.groupControl1.Controls.Add(this.txtAlici);
            this.groupControl1.Controls.Add(this.txtVergiDairesi);
            this.groupControl1.Controls.Add(this.txtSaat);
            this.groupControl1.Controls.Add(this.txtTarih);
            this.groupControl1.Controls.Add(this.txtSiraNo);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtUrunID);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.lblid);
            this.groupControl1.Controls.Add(this.btnFaturaGuncelle);
            this.groupControl1.Controls.Add(this.btnFaturaSil);
            this.groupControl1.Controls.Add(this.btnFaturaEkle);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtSeriNo);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1028, -2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(320, 738);
            this.groupControl1.TabIndex = 5;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl15.Appearance.Options.UseForeColor = true;
            this.labelControl15.Location = new System.Drawing.Point(81, 277);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(98, 13);
            this.labelControl15.TabIndex = 53;
            this.labelControl15.Text = "FATURA DETAYLARI";
            // 
            // txtFaturaID
            // 
            this.txtFaturaID.Enabled = false;
            this.txtFaturaID.Location = new System.Drawing.Point(81, 447);
            this.txtFaturaID.Name = "txtFaturaID";
            this.txtFaturaID.Size = new System.Drawing.Size(217, 20);
            this.txtFaturaID.TabIndex = 14;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(81, 417);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(217, 20);
            this.txtTutar.TabIndex = 13;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(81, 391);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(217, 20);
            this.txtFiyat.TabIndex = 12;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(81, 364);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(217, 21);
            this.txtMiktar.TabIndex = 11;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(81, 336);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(217, 20);
            this.txtUrunAd.TabIndex = 10;
            // 
            // txtTeslimAlan
            // 
            this.txtTeslimAlan.Location = new System.Drawing.Point(81, 237);
            this.txtTeslimAlan.Name = "txtTeslimAlan";
            this.txtTeslimAlan.Size = new System.Drawing.Size(217, 20);
            this.txtTeslimAlan.TabIndex = 8;
            // 
            // txtTeslimEden
            // 
            this.txtTeslimEden.Location = new System.Drawing.Point(82, 210);
            this.txtTeslimEden.Name = "txtTeslimEden";
            this.txtTeslimEden.Size = new System.Drawing.Size(217, 20);
            this.txtTeslimEden.TabIndex = 7;
            // 
            // txtAlici
            // 
            this.txtAlici.Location = new System.Drawing.Point(81, 181);
            this.txtAlici.Name = "txtAlici";
            this.txtAlici.Size = new System.Drawing.Size(217, 20);
            this.txtAlici.TabIndex = 6;
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(81, 158);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(217, 20);
            this.txtVergiDairesi.TabIndex = 5;
            // 
            // txtSaat
            // 
            this.txtSaat.Location = new System.Drawing.Point(82, 132);
            this.txtSaat.Mask = "00:00";
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.Size = new System.Drawing.Size(216, 21);
            this.txtSaat.TabIndex = 4;
            this.txtSaat.ValidatingType = typeof(System.DateTime);
            // 
            // txtTarih
            // 
            this.txtTarih.EditValue = null;
            this.txtTarih.Location = new System.Drawing.Point(81, 106);
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
            this.txtSiraNo.Location = new System.Drawing.Point(81, 80);
            this.txtSiraNo.Name = "txtSiraNo";
            this.txtSiraNo.Size = new System.Drawing.Size(218, 20);
            this.txtSiraNo.TabIndex = 2;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(6, 339);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 13);
            this.labelControl6.TabIndex = 36;
            this.labelControl6.Text = "Ürün Adı:";
            // 
            // txtUrunID
            // 
            this.txtUrunID.Location = new System.Drawing.Point(81, 310);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Size = new System.Drawing.Size(162, 20);
            this.txtUrunID.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(6, 313);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 13);
            this.labelControl5.TabIndex = 33;
            this.labelControl5.Text = "Ürün ID:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 240);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(38, 13);
            this.labelControl4.TabIndex = 32;
            this.labelControl4.Text = "T. Alan:";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(7, 394);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(28, 13);
            this.labelControl13.TabIndex = 30;
            this.labelControl13.Text = "Fiyat:";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(7, 135);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(26, 13);
            this.labelControl12.TabIndex = 28;
            this.labelControl12.Text = "Saat:";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(7, 109);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(28, 13);
            this.labelControl11.TabIndex = 26;
            this.labelControl11.Text = "Tarih:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(6, 213);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(41, 13);
            this.labelControl9.TabIndex = 22;
            this.labelControl9.Text = "T. Eden:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(81, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(217, 20);
            this.txtID.TabIndex = 0;
            // 
            // lblid
            // 
            this.lblid.Location = new System.Drawing.Point(6, 31);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(15, 13);
            this.lblid.TabIndex = 19;
            this.lblid.Text = "ID:";
            // 
            // btnFaturaGuncelle
            // 
            this.btnFaturaGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFaturaGuncelle.ImageOptions.Image")));
            this.btnFaturaGuncelle.Location = new System.Drawing.Point(117, 502);
            this.btnFaturaGuncelle.Name = "btnFaturaGuncelle";
            this.btnFaturaGuncelle.Size = new System.Drawing.Size(90, 41);
            this.btnFaturaGuncelle.TabIndex = 16;
            this.btnFaturaGuncelle.Text = "Güncelle";
            this.btnFaturaGuncelle.Click += new System.EventHandler(this.btnFaturaGuncelle_Click);
            // 
            // btnFaturaSil
            // 
            this.btnFaturaSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFaturaSil.ImageOptions.Image")));
            this.btnFaturaSil.Location = new System.Drawing.Point(213, 502);
            this.btnFaturaSil.Name = "btnFaturaSil";
            this.btnFaturaSil.Size = new System.Drawing.Size(90, 41);
            this.btnFaturaSil.TabIndex = 17;
            this.btnFaturaSil.Text = "Sil";
            this.btnFaturaSil.Click += new System.EventHandler(this.btnFaturaSil_Click);
            // 
            // btnFaturaEkle
            // 
            this.btnFaturaEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFaturaEkle.ImageOptions.Image")));
            this.btnFaturaEkle.Location = new System.Drawing.Point(7, 502);
            this.btnFaturaEkle.Name = "btnFaturaEkle";
            this.btnFaturaEkle.Size = new System.Drawing.Size(104, 41);
            this.btnFaturaEkle.TabIndex = 15;
            this.btnFaturaEkle.Text = "Fatura Ekle";
            this.btnFaturaEkle.Click += new System.EventHandler(this.btnFaturaEkle_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(6, 450);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(50, 13);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Fatura ID:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(7, 161);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(56, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Vergi Daire:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 184);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(22, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Alıcı:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Sıra No:";
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.Location = new System.Drawing.Point(81, 54);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(217, 20);
            this.txtSeriNo.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(22, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Seri:";
            // 
            // btnBul
            // 
            this.btnBul.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnBul.Location = new System.Drawing.Point(249, 310);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(49, 20);
            this.btnBul.TabIndex = 54;
            this.btnBul.Text = "Bul";
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // FrmFaturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 735);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmFaturalar";
            this.Text = "FATURALAR";
            this.Load += new System.EventHandler(this.FrmFaturalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeslimAlan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeslimEden.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiraNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeriNo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.TextEdit txtFaturaID;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.TextEdit txtFiyat;
        private System.Windows.Forms.NumericUpDown txtMiktar;
        private DevExpress.XtraEditors.TextEdit txtUrunAd;
        private DevExpress.XtraEditors.TextEdit txtTeslimAlan;
        private DevExpress.XtraEditors.TextEdit txtTeslimEden;
        private DevExpress.XtraEditors.TextEdit txtAlici;
        private DevExpress.XtraEditors.TextEdit txtVergiDairesi;
        private System.Windows.Forms.MaskedTextBox txtSaat;
        private DevExpress.XtraEditors.DateEdit txtTarih;
        private DevExpress.XtraEditors.TextEdit txtSiraNo;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtUrunID;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl lblid;
        private DevExpress.XtraEditors.SimpleButton btnFaturaGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnFaturaSil;
        private DevExpress.XtraEditors.SimpleButton btnFaturaEkle;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSeriNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnBul;
    }
}