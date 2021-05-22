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
            //KURUMSAL FİRMAYA FATURA EKLEME

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
            }
            if (txtFaturaID.Text != "" && cmbAlici.Text == "Kurumsal")
            {
                SqlCommand faturadetayekle = new SqlCommand("insert into TBLFATURADETAY (URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) values (@c1,@c2,@c3,@c4,@c5)", baglan.baglanti());
                faturadetayekle.Parameters.AddWithValue("@c1", txtUrunAd.Text);
                faturadetayekle.Parameters.AddWithValue("@c2", decimal.Parse(txtMiktar.Text));
                faturadetayekle.Parameters.AddWithValue("@c3", decimal.Parse(txtFiyat.Text));
                faturadetayekle.Parameters.AddWithValue("@c4", decimal.Parse(txtTutar.Text));
                faturadetayekle.Parameters.AddWithValue("@c5", txtFaturaID.Text);
                faturadetayekle.ExecuteNonQuery();
                faturadetayekle.ExecuteNonQuery();
                baglan.baglanti().Close();

                //Hareket Tablosuna Ekle
                SqlCommand hareket = new SqlCommand("insert into TBLFIRMAHAREKETLER (URUNID,ADET,FIYAT,TOPLAM,FATURAID,TARIH) values (@a1,a2,a3,a4,a5,a6)", baglan.baglanti());
                hareket.Parameters.AddWithValue("@a1", txtUrunID.Text);
                hareket.Parameters.AddWithValue("@a2", txtMiktar.Text);
                hareket.Parameters.AddWithValue("@a3", txtFiyat.Text);
                hareket.Parameters.AddWithValue("@a4", txtTutar.Text);
                hareket.Parameters.AddWithValue("@a5", txtFaturaID.Text);
                hareket.Parameters.AddWithValue("@a6", txtTarih.Text);
                hareket.ExecuteNonQuery();
                baglan.baglanti().Close();

                StokSayisiAzalt();

                MessageBox.Show(txtFaturaID.Text + " Faturaya Ait Ürün Kaydedildi ", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            //BİREYSEL FİRMAYA FATURA EKLEME
            if (txtFaturaID.Text != "" && cmbMusteriTur.Text == "Bireysel")
            {
                SqlCommand faturadetayekle = new SqlCommand("insert into TBLFATURADETAY (URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) values (@b1,@b2,@b3,@b4,@b5)", baglan.baglanti());
                faturadetayekle.Parameters.AddWithValue("@b1", txtUrunAd.Text);
                faturadetayekle.Parameters.AddWithValue("@b2", decimal.Parse(txtMiktar.Text));
                faturadetayekle.Parameters.AddWithValue("@b3", decimal.Parse(txtFiyat.Text));
                faturadetayekle.Parameters.AddWithValue("@b4", decimal.Parse(txtTutar.Text));
                faturadetayekle.Parameters.AddWithValue("@b5", txtFaturaID.Text);
                faturadetayekle.ExecuteNonQuery();
                faturadetayekle.ExecuteNonQuery();
                baglan.baglanti().Close();


                SqlCommand hareket = new SqlCommand("insert into TBLMUSTERIHAREKETLER (URUNID,ADET,FIYAT,TOPLAM,FATURAID,TARIH) values (@d1,d2,d3,d4,d5,d6)", baglan.baglanti());
                hareket.Parameters.AddWithValue("@d1", txtUrunID.Text);
                hareket.Parameters.AddWithValue("@d2", txtMiktar.Text);
                hareket.Parameters.AddWithValue("@d3", txtFiyat.Text);
                hareket.Parameters.AddWithValue("@d4", txtTutar.Text);
                hareket.Parameters.AddWithValue("@d5", txtFaturaID.Text);
                hareket.Parameters.AddWithValue("@d6", txtTarih.Text);

                StokSayisiAzalt();

                MessageBox.Show(txtFaturaID.Text + " Faturaya Ait Ürün Kaydedildi ", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        public void UrunBul()
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

        public void StokSayisiAzalt()
        {
            SqlCommand stokazalt = new SqlCommand("update TBLURUNLER set ADET=ADET-@p1 where ID=@p2", baglan.baglanti());
            stokazalt.Parameters.AddWithValue("@p1", txtMiktar.Value);
            stokazalt.Parameters.AddWithValue("@p2", txtUrunID.Text);
            stokazalt.ExecuteNonQuery();
            baglan.baglanti().Close();
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
    }
}
