namespace Ticari_Otomasyon
{
    partial class FrmFirmalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFirmalar));
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
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
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lblid = new DevExpress.XtraEditors.LabelControl();
            this.btnFirmaGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnFirmaSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnFirmaEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.cmbilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYetkiliGorev.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSektor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbilce
            // 
            this.cmbilce.Location = new System.Drawing.Point(94, 343);
            this.cmbilce.Name = "cmbilce";
            this.cmbilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbilce.Size = new System.Drawing.Size(218, 20);
            this.cmbilce.TabIndex = 12;
            // 
            // cmbYetkiliGorev
            // 
            this.cmbYetkiliGorev.Location = new System.Drawing.Point(94, 132);
            this.cmbYetkiliGorev.Name = "cmbYetkiliGorev";
            this.cmbYetkiliGorev.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbYetkiliGorev.Properties.Items.AddRange(new object[] {
            "Firma Sahibi",
            "Müdür",
            "Muhasebe",
            "İşçi(Çalışan)"});
            this.cmbYetkiliGorev.Size = new System.Drawing.Size(218, 20);
            this.cmbYetkiliGorev.TabIndex = 4;
            // 
            // txtYetkiliTC
            // 
            this.txtYetkiliTC.Location = new System.Drawing.Point(94, 158);
            this.txtYetkiliTC.Mask = "00000000000";
            this.txtYetkiliTC.Name = "txtYetkiliTC";
            this.txtYetkiliTC.Size = new System.Drawing.Size(218, 21);
            this.txtYetkiliTC.TabIndex = 5;
            this.txtYetkiliTC.ValidatingType = typeof(int);
            // 
            // txtTelefon2
            // 
            this.txtTelefon2.Location = new System.Drawing.Point(94, 210);
            this.txtTelefon2.Mask = "(999) 000-0000";
            this.txtTelefon2.Name = "txtTelefon2";
            this.txtTelefon2.Size = new System.Drawing.Size(217, 21);
            this.txtTelefon2.TabIndex = 7;
            // 
            // txtTelefon1
            // 
            this.txtTelefon1.Location = new System.Drawing.Point(94, 184);
            this.txtTelefon1.Mask = "(999) 000-0000";
            this.txtTelefon1.Name = "txtTelefon1";
            this.txtTelefon1.Size = new System.Drawing.Size(217, 21);
            this.txtTelefon1.TabIndex = 6;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(7, 343);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(21, 13);
            this.labelControl13.TabIndex = 30;
            this.labelControl13.Text = "İlçe:";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(7, 135);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(63, 13);
            this.labelControl12.TabIndex = 28;
            this.labelControl12.Text = "Yetkili Görev:";
            // 
            // txtYetkili
            // 
            this.txtYetkili.Location = new System.Drawing.Point(94, 106);
            this.txtYetkili.Name = "txtYetkili";
            this.txtYetkili.Size = new System.Drawing.Size(217, 20);
            this.txtYetkili.TabIndex = 3;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(7, 109);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(31, 13);
            this.labelControl11.TabIndex = 26;
            this.labelControl11.Text = "Yetkili:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(6, 213);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(49, 13);
            this.labelControl9.TabIndex = 22;
            this.labelControl9.Text = "Telefon 2:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbSektor);
            this.groupControl1.Controls.Add(this.txtVergiDairesi);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.cmbil);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.txtFax);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtMail);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtTelefon3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.cmbilce);
            this.groupControl1.Controls.Add(this.cmbYetkiliGorev);
            this.groupControl1.Controls.Add(this.txtYetkiliTC);
            this.groupControl1.Controls.Add(this.txtTelefon2);
            this.groupControl1.Controls.Add(this.txtTelefon1);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.txtYetkili);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.lblid);
            this.groupControl1.Controls.Add(this.btnFirmaGuncelle);
            this.groupControl1.Controls.Add(this.btnFirmaSil);
            this.groupControl1.Controls.Add(this.btnFirmaEkle);
            this.groupControl1.Controls.Add(this.txtAdres);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtAd);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1028, -2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(320, 738);
            this.groupControl1.TabIndex = 0;
            // 
            // cmbSektor
            // 
            this.cmbSektor.Location = new System.Drawing.Point(94, 80);
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
            this.cmbSektor.TabIndex = 2;
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(94, 369);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(217, 20);
            this.txtVergiDairesi.TabIndex = 13;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(7, 372);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(63, 13);
            this.labelControl14.TabIndex = 40;
            this.labelControl14.Text = "Vergi Dairesi:";
            // 
            // cmbil
            // 
            this.cmbil.Location = new System.Drawing.Point(94, 317);
            this.cmbil.Name = "cmbil";
            this.cmbil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbil.Size = new System.Drawing.Size(218, 20);
            this.cmbil.TabIndex = 11;
            this.cmbil.SelectedIndexChanged += new System.EventHandler(this.cmbil_SelectedIndexChanged);
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(7, 320);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(10, 13);
            this.labelControl10.TabIndex = 38;
            this.labelControl10.Text = "İl:";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(94, 290);
            this.txtFax.Mask = "(999) 000-0000";
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(217, 21);
            this.txtFax.TabIndex = 10;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(6, 293);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(22, 13);
            this.labelControl6.TabIndex = 36;
            this.labelControl6.Text = "Fax:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(94, 264);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(217, 20);
            this.txtMail.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(6, 267);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(22, 13);
            this.labelControl5.TabIndex = 33;
            this.labelControl5.Text = "Mail:";
            // 
            // txtTelefon3
            // 
            this.txtTelefon3.Location = new System.Drawing.Point(94, 237);
            this.txtTelefon3.Mask = "(999) 000-0000";
            this.txtTelefon3.Name = "txtTelefon3";
            this.txtTelefon3.Size = new System.Drawing.Size(217, 21);
            this.txtTelefon3.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 240);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 13);
            this.labelControl4.TabIndex = 32;
            this.labelControl4.Text = "Telefon 3:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(94, 28);
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
            // btnFirmaGuncelle
            // 
            this.btnFirmaGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFirmaGuncelle.ImageOptions.Image")));
            this.btnFirmaGuncelle.Location = new System.Drawing.Point(117, 533);
            this.btnFirmaGuncelle.Name = "btnFirmaGuncelle";
            this.btnFirmaGuncelle.Size = new System.Drawing.Size(90, 41);
            this.btnFirmaGuncelle.TabIndex = 16;
            this.btnFirmaGuncelle.Text = "Güncelle";
            this.btnFirmaGuncelle.Click += new System.EventHandler(this.btnFirmaGuncelle_Click);
            // 
            // btnFirmaSil
            // 
            this.btnFirmaSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFirmaSil.ImageOptions.Image")));
            this.btnFirmaSil.Location = new System.Drawing.Point(213, 533);
            this.btnFirmaSil.Name = "btnFirmaSil";
            this.btnFirmaSil.Size = new System.Drawing.Size(90, 41);
            this.btnFirmaSil.TabIndex = 17;
            this.btnFirmaSil.Text = "Sil";
            this.btnFirmaSil.Click += new System.EventHandler(this.btnFirmaSil_Click);
            // 
            // btnFirmaEkle
            // 
            this.btnFirmaEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFirmaEkle.ImageOptions.Image")));
            this.btnFirmaEkle.Location = new System.Drawing.Point(7, 533);
            this.btnFirmaEkle.Name = "btnFirmaEkle";
            this.btnFirmaEkle.Size = new System.Drawing.Size(104, 41);
            this.btnFirmaEkle.TabIndex = 15;
            this.btnFirmaEkle.Text = "Firma Ekle";
            this.btnFirmaEkle.Click += new System.EventHandler(this.btnFirmaEkle_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(94, 395);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(217, 96);
            this.txtAdres.TabIndex = 14;
            this.txtAdres.Text = "";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(6, 395);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(32, 13);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Adres:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(7, 161);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(47, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Yetkili TC:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 184);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Telefon:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Sektör:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(94, 54);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(217, 20);
            this.txtAd.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ad:";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-2, -2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1024, 738);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // 
            // FrmFirmalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 735);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmFirmalar";
            this.Text = "FİRMALAR";
            this.Load += new System.EventHandler(this.FrmFirmalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYetkiliGorev.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYetkili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSektor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl lblid;
        private DevExpress.XtraEditors.SimpleButton btnFirmaGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnFirmaSil;
        private DevExpress.XtraEditors.SimpleButton btnFirmaEkle;
        private System.Windows.Forms.RichTextBox txtAdres;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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
        private DevExpress.XtraEditors.ComboBoxEdit cmbSektor;
    }
}