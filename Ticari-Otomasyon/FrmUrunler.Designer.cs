namespace Ticari_Otomasyon
{
    partial class FrmUrunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtAdet = new System.Windows.Forms.NumericUpDown();
            this.txtUrunID = new DevExpress.XtraEditors.TextEdit();
            this.lblid = new DevExpress.XtraEditors.LabelControl();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnUrunEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txtDetay = new System.Windows.Forms.RichTextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtSatisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtAlisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtModel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtMarka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtYil = new System.Windows.Forms.MaskedTextBox();
            this.txtUrunAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUrunAra = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.radioMarkaArama = new System.Windows.Forms.RadioButton();
            this.radiaModelArama = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplamUrun = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAra.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 61);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1024, 677);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Gray;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtAdet);
            this.groupControl1.Controls.Add(this.txtUrunID);
            this.groupControl1.Controls.Add(this.lblid);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnUrunEkle);
            this.groupControl1.Controls.Add(this.txtDetay);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtSatisFiyat);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtAlisFiyat);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtModel);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtMarka);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtYil);
            this.groupControl1.Controls.Add(this.txtUrunAdi);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1030, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(320, 738);
            this.groupControl1.TabIndex = 1;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(94, 166);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(217, 21);
            this.txtAdet.TabIndex = 5;
            // 
            // txtUrunID
            // 
            this.txtUrunID.Enabled = false;
            this.txtUrunID.Location = new System.Drawing.Point(94, 34);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Size = new System.Drawing.Size(217, 20);
            this.txtUrunID.TabIndex = 0;
            // 
            // lblid
            // 
            this.lblid.Location = new System.Drawing.Point(6, 37);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(15, 13);
            this.lblid.TabIndex = 19;
            this.lblid.Text = "ID:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(113, 366);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(90, 41);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(209, 366);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(90, 41);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunEkle.ImageOptions.Image")));
            this.btnUrunEkle.Location = new System.Drawing.Point(17, 366);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(90, 41);
            this.btnUrunEkle.TabIndex = 9;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // txtDetay
            // 
            this.txtDetay.Location = new System.Drawing.Point(94, 245);
            this.txtDetay.Name = "txtDetay";
            this.txtDetay.Size = new System.Drawing.Size(217, 96);
            this.txtDetay.TabIndex = 8;
            this.txtDetay.Text = "";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(6, 248);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(33, 13);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Detay:";
            // 
            // txtSatisFiyat
            // 
            this.txtSatisFiyat.Location = new System.Drawing.Point(94, 219);
            this.txtSatisFiyat.Name = "txtSatisFiyat";
            this.txtSatisFiyat.Size = new System.Drawing.Size(217, 20);
            this.txtSatisFiyat.TabIndex = 7;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(6, 222);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(54, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Satış Fiyat:";
            // 
            // txtAlisFiyat
            // 
            this.txtAlisFiyat.Location = new System.Drawing.Point(94, 193);
            this.txtAlisFiyat.Name = "txtAlisFiyat";
            this.txtAlisFiyat.Size = new System.Drawing.Size(217, 20);
            this.txtAlisFiyat.TabIndex = 6;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(6, 196);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Alış Fiyat:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(6, 168);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Adet:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 141);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(14, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Yıl:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(94, 112);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(217, 20);
            this.txtModel.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 115);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Model:";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(94, 86);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(217, 20);
            this.txtMarka.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 89);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Marka:";
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(94, 138);
            this.txtYil.Mask = "0000";
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(217, 21);
            this.txtYil.TabIndex = 4;
            this.txtYil.ValidatingType = typeof(int);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(94, 60);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(217, 20);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ürün Adı:";
            // 
            // txtUrunAra
            // 
            this.txtUrunAra.Location = new System.Drawing.Point(197, 22);
            this.txtUrunAra.Name = "txtUrunAra";
            this.txtUrunAra.Size = new System.Drawing.Size(158, 20);
            this.txtUrunAra.TabIndex = 20;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(144, 25);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(47, 13);
            this.labelControl9.TabIndex = 21;
            this.labelControl9.Text = "Ürün Ara:";
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAra.ImageOptions.Image")));
            this.btnAra.Location = new System.Drawing.Point(361, 22);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(53, 20);
            this.btnAra.TabIndex = 22;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // radioMarkaArama
            // 
            this.radioMarkaArama.AutoSize = true;
            this.radioMarkaArama.Location = new System.Drawing.Point(12, 12);
            this.radioMarkaArama.Name = "radioMarkaArama";
            this.radioMarkaArama.Size = new System.Drawing.Size(125, 17);
            this.radioMarkaArama.TabIndex = 23;
            this.radioMarkaArama.TabStop = true;
            this.radioMarkaArama.Text = "Markaya Göre Arama";
            this.radioMarkaArama.UseVisualStyleBackColor = true;
            // 
            // radiaModelArama
            // 
            this.radiaModelArama.AutoSize = true;
            this.radiaModelArama.Location = new System.Drawing.Point(12, 35);
            this.radiaModelArama.Name = "radiaModelArama";
            this.radiaModelArama.Size = new System.Drawing.Size(119, 17);
            this.radiaModelArama.TabIndex = 24;
            this.radiaModelArama.TabStop = true;
            this.radiaModelArama.Text = "Modele Göre Arama";
            this.radiaModelArama.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(858, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Toplam Ürün Sayısı:";
            // 
            // lblToplamUrun
            // 
            this.lblToplamUrun.AutoSize = true;
            this.lblToplamUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamUrun.ForeColor = System.Drawing.Color.Red;
            this.lblToplamUrun.Location = new System.Drawing.Point(978, 9);
            this.lblToplamUrun.Name = "lblToplamUrun";
            this.lblToplamUrun.Size = new System.Drawing.Size(21, 13);
            this.lblToplamUrun.TabIndex = 26;
            this.lblToplamUrun.Text = "00";
            // 
            // FrmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 735);
            this.Controls.Add(this.lblToplamUrun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.radiaModelArama);
            this.Controls.Add(this.txtUrunAra);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.radioMarkaArama);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmUrunler";
            this.Text = "ÜRÜNLER";
            this.Load += new System.EventHandler(this.FrmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAra.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnUrunEkle;
        private System.Windows.Forms.RichTextBox txtDetay;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtSatisFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtAlisFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtModel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtMarka;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtUrunAdi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.TextEdit txtUrunID;
        private DevExpress.XtraEditors.LabelControl lblid;
        private System.Windows.Forms.MaskedTextBox txtYil;
        private System.Windows.Forms.NumericUpDown txtAdet;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.TextEdit txtUrunAra;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.RadioButton radiaModelArama;
        private System.Windows.Forms.RadioButton radioMarkaArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToplamUrun;
    }
}