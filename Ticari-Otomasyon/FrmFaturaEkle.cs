using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Ticari_Otomasyon
{
    public partial class FrmFaturaEkle : Form
    {
        public FrmFaturaEkle()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        public void FaturaEkle()
        {
            try
            {
                if (txtFaturaID.Text == "")
                {
                    SqlCommand faturaekle = new SqlCommand("insert into TBLFATURABILGI (SERI,SIRANO,TARIH,SAAT,VERGIDAIRE,ALICI,TESLIMEDEN,TESLIMALAN) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglan.baglanti());
                    faturaekle.Parameters.AddWithValue("@p1", txtSeriNo.Text);
                    faturaekle.Parameters.AddWithValue("@p2", txtSiraNo.Text);
                    faturaekle.Parameters.AddWithValue("@p3", txtTarih.Text);
                    faturaekle.Parameters.AddWithValue("@p4", txtSaat.Text);
                    faturaekle.Parameters.AddWithValue("@p5", txtVergiDairesi.Text);
                    faturaekle.Parameters.AddWithValue("@p6", cmbAlici.Text);
                    faturaekle.Parameters.AddWithValue("@p7", txtTeslimEden.Text);
                    faturaekle.Parameters.AddWithValue("@p8", txtTeslimAlan.Text);
                    faturaekle.ExecuteNonQuery();
                    baglan.baglanti().Close();
                    MessageBox.Show(txtSeriNo.Text + txtSiraNo.Text + " Numaralı Fatura Kaydedildi", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    groupControl1.Visible = true;

                    SqlCommand faturaid = new SqlCommand("select FATURABILGIID from TBLFATURABILGI order by FATURABILGIID desc", baglan.baglanti());
                    SqlDataReader dr = faturaid.ExecuteReader();
                    if (dr.Read())
                    {
                        txtFaturaID.Text = dr[0].ToString();
                    }
                    baglan.baglanti().Close();
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void UrunBul()
        {
            try
            {
                SqlCommand bul = new SqlCommand("select URUNAD,SATISFIYAT from TBLURUNLER where ID=@p1", baglan.baglanti());
                bul.Parameters.AddWithValue("@p1", txtUrunID.Text);
                SqlDataReader dr = bul.ExecuteReader();
                while (dr.Read())
                {
                    txtUrunAd.Text = dr[0].ToString();
                    txtFiyat.Text = dr[1].ToString();
                }
                baglan.baglanti().Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void StokSayisiAzalt()
        {
            try
            {
                SqlCommand stokazalt = new SqlCommand("update TBLURUNLER set ADET=ADET-@p1 where ID=@p2", baglan.baglanti());
                stokazalt.Parameters.AddWithValue("@p1", txtMiktar.Value);
                stokazalt.Parameters.AddWithValue("@p2", txtUrunID.Text);
                stokazalt.ExecuteNonQuery();
                baglan.baglanti().Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnFaturaEkle_Click(object sender, EventArgs e)
        {
            FaturaEkle();
        }

        private void txtFiyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            UrunBul();
        }

        private void txtMiktar_ValueChanged(object sender, EventArgs e)
        {
            //if (txtMiktar.Value < 0)
            //{
            //    double miktar, tutar, fiyat;
            //    fiyat = Convert.ToDouble(txtFiyat.Text);
            //    miktar = Convert.ToDouble(txtMiktar.Text);

            //    tutar = miktar * fiyat;

            //    txtTutar.Text = tutar.ToString();
            //}

            //double miktar = 0, tutar = 0, fiyat = 0;
            //miktar = Convert.ToDouble(txtMiktar.Value);
            //fiyat = Convert.ToDouble(txtFiyat.Text);

            //tutar = miktar * fiyat;
            //txtTutar.Text = tutar.ToString();
        }

        private void FrmFaturaEkle_Load(object sender, EventArgs e)
        {
            txtMiktar.Value = 1;
            txtFiyat.Text = "0";
        }

        private void cmbMusteriTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAlici.Items.Clear();
            if (cmbMusteriTur.Text == "Kurumsal")
            {
                SqlCommand firma = new SqlCommand("select * from TBLFIRMALAR", baglan.baglanti());
                SqlDataReader dr = firma.ExecuteReader();
                while (dr.Read())
                {
                    cmbAlici.Items.Add(dr["AD"]).ToString();
                }
                baglan.baglanti().Close();

            }
            if (cmbMusteriTur.Text == "Bireysel")
            {
                SqlCommand bireysel = new SqlCommand("select * from TBLMUSTERILER", baglan.baglanti());
                SqlDataReader dr = bireysel.ExecuteReader();
                while (dr.Read())
                {
                    cmbAlici.Items.Add(dr["AD"].ToString() + " " + dr["SOYAD"].ToString());
                }
                baglan.baglanti().Close();
            }
        }

        private void FrmFaturaDetayEkle_Click(object sender, EventArgs e)
        {
            if (txtFaturaID.Text != "" && cmbAlici.Text == "Kurumsal")
            {
                SqlCommand kurumsalfaturadetayekle = new SqlCommand("insert into TBLFATURADETAY (URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) values (@c1,@c2,@c3,@c4,@c5)", baglan.baglanti());
                kurumsalfaturadetayekle.Parameters.AddWithValue("@c1", txtUrunAd.Text);
                kurumsalfaturadetayekle.Parameters.AddWithValue("@c2", decimal.Parse(txtMiktar.Text));
                kurumsalfaturadetayekle.Parameters.AddWithValue("@c3", decimal.Parse(txtFiyat.Text));
                kurumsalfaturadetayekle.Parameters.AddWithValue("@c4", decimal.Parse(txtTutar.Text));
                kurumsalfaturadetayekle.Parameters.AddWithValue("@c5", txtFaturaID.Text);
                kurumsalfaturadetayekle.ExecuteNonQuery();
                baglan.baglanti().Close();

                //Hareket Tablosuna Ekle
                SqlCommand kurumsalhareket = new SqlCommand("insert into TBLFIRMAHAREKETLER (URUNID,ADET,FIYAT,TOPLAM,FATURAID,TARIH) values (@a1,a2,a3,a4,a5,a6)", baglan.baglanti());
                kurumsalhareket.Parameters.AddWithValue("@a1", txtUrunID.Text);
                kurumsalhareket.Parameters.AddWithValue("@a2", txtMiktar.Text);
                kurumsalhareket.Parameters.AddWithValue("@a3", txtFiyat.Text);
                kurumsalhareket.Parameters.AddWithValue("@a4", txtTutar.Text);
                kurumsalhareket.Parameters.AddWithValue("@a5", txtFaturaID.Text);
                kurumsalhareket.Parameters.AddWithValue("@a6", txtTarih.Text);
                kurumsalhareket.ExecuteNonQuery();
                baglan.baglanti().Close();

                StokSayisiAzalt();

                MessageBox.Show(txtFaturaID.Text + " Faturaya Ait Ürün Kaydedildi ", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (txtFaturaID.Text != "" && cmbMusteriTur.Text == "Bireysel")
            {
                SqlCommand bireyselfaturadetayekle = new SqlCommand("insert into TBLFATURADETAY (URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) values (@b1,@b2,@b3,@b4,@b5)", baglan.baglanti());
                bireyselfaturadetayekle.Parameters.AddWithValue("@b1", txtUrunAd.Text);
                bireyselfaturadetayekle.Parameters.AddWithValue("@b2", decimal.Parse(txtMiktar.Text));
                bireyselfaturadetayekle.Parameters.AddWithValue("@b3", decimal.Parse(txtFiyat.Text));
                bireyselfaturadetayekle.Parameters.AddWithValue("@b4", decimal.Parse(txtTutar.Text));
                bireyselfaturadetayekle.Parameters.AddWithValue("@b5", txtFaturaID.Text);
                bireyselfaturadetayekle.ExecuteNonQuery();
                baglan.baglanti().Close();


                SqlCommand bireyselhareket = new SqlCommand("insert into TBLMUSTERIHAREKETLER (URUNID,ADET,FIYAT,TOPLAM,FATURAID,TARIH) values (@d1,d2,d3,d4,d5,d6)", baglan.baglanti());
                bireyselhareket.Parameters.AddWithValue("@d1", txtUrunID.Text);
                bireyselhareket.Parameters.AddWithValue("@d2", txtMiktar.Text);
                bireyselhareket.Parameters.AddWithValue("@d3", txtFiyat.Text);
                bireyselhareket.Parameters.AddWithValue("@d4", txtTutar.Text);
                bireyselhareket.Parameters.AddWithValue("@d5", txtFaturaID.Text);
                bireyselhareket.Parameters.AddWithValue("@d6", txtTarih.Text);
                bireyselfaturadetayekle.ExecuteNonQuery();
                baglan.baglanti().Close();

                StokSayisiAzalt();

                MessageBox.Show(txtFaturaID.Text + " Faturaya Ait Ürün Kaydedildi ", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
