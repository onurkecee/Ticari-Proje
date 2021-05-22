namespace Ticari_Otomasyon
{
    partial class FrmFaturaUrunDuzenleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaUrunDuzenleme));
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            this.txtFiyat = new DevExpress.XtraEditors.TextEdit();
            this.txtMiktar = new System.Windows.Forms.NumericUpDown();
            this.txtUrunAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtUrunID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.btnFaturaDetayGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnFaturaDetaySil = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTutar
            // 
            this.txtTutar.Enabled = false;
            this.txtTutar.Location = new System.Drawing.Point(147, 151);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(217, 20);
            this.txtTutar.TabIndex = 4;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(147, 125);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(217, 20);
            this.txtFiyat.TabIndex = 3;
            this.txtFiyat.EditValueChanged += new System.EventHandler(this.txtFiyat_EditValueChanged);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(147, 98);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(217, 20);
            this.txtMiktar.TabIndex = 2;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(147, 70);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(217, 20);
            this.txtUrunAd.TabIndex = 1;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(73, 154);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(30, 13);
            this.labelControl14.TabIndex = 55;
            this.labelControl14.Text = "Tutar:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(73, 100);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(33, 13);
            this.labelControl10.TabIndex = 54;
            this.labelControl10.Text = "Miktar:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(72, 73);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 13);
            this.labelControl6.TabIndex = 53;
            this.labelControl6.Text = "Ürün Adı:";
            // 
            // txtUrunID
            // 
            this.txtUrunID.Enabled = false;
            this.txtUrunID.Location = new System.Drawing.Point(147, 44);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Size = new System.Drawing.Size(217, 20);
            this.txtUrunID.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(72, 47);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 13);
            this.labelControl5.TabIndex = 52;
            this.labelControl5.Text = "Ürün ID:";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(73, 128);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(28, 13);
            this.labelControl13.TabIndex = 51;
            this.labelControl13.Text = "Fiyat:";
            // 
            // btnFaturaDetayGuncelle
            // 
            this.btnFaturaDetayGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFaturaDetayGuncelle.ImageOptions.Image")));
            this.btnFaturaDetayGuncelle.Location = new System.Drawing.Point(159, 216);
            this.btnFaturaDetayGuncelle.Name = "btnFaturaDetayGuncelle";
            this.btnFaturaDetayGuncelle.Size = new System.Drawing.Size(90, 41);
            this.btnFaturaDetayGuncelle.TabIndex = 6;
            this.btnFaturaDetayGuncelle.Text = "Güncelle";
            this.btnFaturaDetayGuncelle.Click += new System.EventHandler(this.btnFaturaDetayGuncelle_Click);
            // 
            // btnFaturaDetaySil
            // 
            this.btnFaturaDetaySil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFaturaDetaySil.ImageOptions.Image")));
            this.btnFaturaDetaySil.Location = new System.Drawing.Point(255, 216);
            this.btnFaturaDetaySil.Name = "btnFaturaDetaySil";
            this.btnFaturaDetaySil.Size = new System.Drawing.Size(90, 41);
            this.btnFaturaDetaySil.TabIndex = 7;
            this.btnFaturaDetaySil.Text = "Sil";
            this.btnFaturaDetaySil.Click += new System.EventHandler(this.btnFaturaDetaySil_Click);
            // 
            // FrmFaturaUrunDuzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(476, 322);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtUrunID);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.btnFaturaDetayGuncelle);
            this.Controls.Add(this.btnFaturaDetaySil);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFaturaUrunDuzenleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FATURA ÜRÜN DÜZENLEME";
            this.Load += new System.EventHandler(this.FrmFaturaUrunDuzenleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.TextEdit txtFiyat;
        private System.Windows.Forms.NumericUpDown txtMiktar;
        private DevExpress.XtraEditors.TextEdit txtUrunAd;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtUrunID;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.SimpleButton btnFaturaDetayGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnFaturaDetaySil;
    }
}