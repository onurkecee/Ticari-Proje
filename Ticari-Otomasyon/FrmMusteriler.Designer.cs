namespace Ticari_Otomasyon
{
    partial class FrmMusteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriler));
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lblid = new DevExpress.XtraEditors.LabelControl();
            this.btnMusteriGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnMusteriSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnMusteriEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbilce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTcKimlik = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefon2 = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtVergiDairesi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
            this.SuspendLayout();
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
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriGuncelle.ImageOptions.Image")));
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(119, 402);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(90, 41);
            this.btnMusteriGuncelle.TabIndex = 13;
            this.btnMusteriGuncelle.Text = "Güncelle";
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click);
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriSil.ImageOptions.Image")));
            this.btnMusteriSil.Location = new System.Drawing.Point(215, 402);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(90, 41);
            this.btnMusteriSil.TabIndex = 14;
            this.btnMusteriSil.Text = "Sil";
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriEkle.ImageOptions.Image")));
            this.btnMusteriEkle.Location = new System.Drawing.Point(9, 402);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(104, 41);
            this.btnMusteriEkle.TabIndex = 11;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(94, 288);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(217, 96);
            this.txtAdres.TabIndex = 10;
            this.txtAdres.Text = "";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(6, 291);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(32, 13);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Adres:";
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollStep = 1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-2, -2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1024, 738);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbilce);
            this.groupControl1.Controls.Add(this.cmbil);
            this.groupControl1.Controls.Add(this.txtTcKimlik);
            this.groupControl1.Controls.Add(this.txtTelefon2);
            this.groupControl1.Controls.Add(this.txtTelefon);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.txtMail);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.lblid);
            this.groupControl1.Controls.Add(this.btnMusteriGuncelle);
            this.groupControl1.Controls.Add(this.btnMusteriSil);
            this.groupControl1.Controls.Add(this.btnMusteriEkle);
            this.groupControl1.Controls.Add(this.txtAdres);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtVergiDairesi);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtSoyad);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtAd);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1028, -2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(320, 738);
            this.groupControl1.TabIndex = 3;
            // 
            // cmbilce
            // 
            this.cmbilce.Location = new System.Drawing.Point(94, 262);
            this.cmbilce.Name = "cmbilce";
            this.cmbilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbilce.Size = new System.Drawing.Size(217, 20);
            this.cmbilce.TabIndex = 9;
            // 
            // cmbil
            // 
            this.cmbil.Location = new System.Drawing.Point(94, 236);
            this.cmbil.Name = "cmbil";
            this.cmbil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbil.Size = new System.Drawing.Size(217, 20);
            this.cmbil.TabIndex = 8;
            this.cmbil.SelectedIndexChanged += new System.EventHandler(this.cmbil_SelectedIndexChanged);
            // 
            // txtTcKimlik
            // 
            this.txtTcKimlik.Location = new System.Drawing.Point(94, 158);
            this.txtTcKimlik.Mask = "00000000000";
            this.txtTcKimlik.Name = "txtTcKimlik";
            this.txtTcKimlik.Size = new System.Drawing.Size(217, 21);
            this.txtTcKimlik.TabIndex = 5;
            this.txtTcKimlik.ValidatingType = typeof(int);
            // 
            // txtTelefon2
            // 
            this.txtTelefon2.Location = new System.Drawing.Point(94, 132);
            this.txtTelefon2.Mask = "(999) 000-0000";
            this.txtTelefon2.Name = "txtTelefon2";
            this.txtTelefon2.Size = new System.Drawing.Size(217, 21);
            this.txtTelefon2.TabIndex = 4;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(94, 106);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(217, 21);
            this.txtTelefon.TabIndex = 3;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(6, 265);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(21, 13);
            this.labelControl13.TabIndex = 30;
            this.labelControl13.Text = "İlçe:";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(6, 239);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(10, 13);
            this.labelControl12.TabIndex = 28;
            this.labelControl12.Text = "İl:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(94, 210);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(217, 20);
            this.txtMail.TabIndex = 7;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(6, 213);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(22, 13);
            this.labelControl11.TabIndex = 26;
            this.labelControl11.Text = "Mail:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(6, 161);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(17, 13);
            this.labelControl10.TabIndex = 24;
            this.labelControl10.Text = "TC:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(6, 135);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(49, 13);
            this.labelControl9.TabIndex = 22;
            this.labelControl9.Text = "Telefon 2:";
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(94, 184);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(217, 20);
            this.txtVergiDairesi.TabIndex = 6;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(6, 187);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(56, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Vergi Daire:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 109);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Telefon:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(94, 80);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(217, 20);
            this.txtSoyad.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Soyad:";
            // 
            // FrmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 735);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmMusteriler";
            this.Text = "MÜŞTERİLER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMusteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl lblid;
        private DevExpress.XtraEditors.SimpleButton btnMusteriGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnMusteriSil;
        private DevExpress.XtraEditors.SimpleButton btnMusteriEkle;
        private System.Windows.Forms.RichTextBox txtAdres;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbilce;
        private DevExpress.XtraEditors.ComboBoxEdit cmbil;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.MaskedTextBox txtTcKimlik;
        private System.Windows.Forms.MaskedTextBox txtTelefon2;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtVergiDairesi;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}