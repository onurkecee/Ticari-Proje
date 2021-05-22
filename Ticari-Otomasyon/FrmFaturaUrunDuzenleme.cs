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
    public partial class FrmFaturaUrunDuzenleme : Form
    {
        public FrmFaturaUrunDuzenleme()
        {
            InitializeComponent();
        }
        public string urunid;
        SqlBaglantisi baglan = new SqlBaglantisi();

        public void FaturaDetayGetir()
        {
            SqlCommand getir = new SqlCommand("select * from TBLFATURADETAY where FATURAURUNID=@p1", baglan.baglanti());
            getir.Parameters.AddWithValue("@p1", urunid);
            SqlDataReader dr = getir.ExecuteReader();
            while (dr.Read())
            {
                txtFiyat.Text = dr[3].ToString();
                txtMiktar.Text = dr[2].ToString();
                txtTutar.Text = dr[4].ToString();
                txtUrunAd.Text = dr[1].ToString();
            }
        }

        public void FaturaDetayGuncelle()
        {
            SqlCommand guncelle = new SqlCommand("update TBLFATURADETAY set URUNAD=@p1, MIKTAR=@p2, FIYAT=@p3, TUTAR=@p4 where FATURAURUNID=@p5", baglan.baglanti());
            guncelle.Parameters.AddWithValue("@p1", txtUrunAd.Text);
            guncelle.Parameters.AddWithValue("@p2", txtMiktar.Text);
            guncelle.Parameters.AddWithValue("@p3", decimal.Parse(txtFiyat.Text));
            guncelle.Parameters.AddWithValue("@p4", decimal.Parse(txtTutar.Text));
            guncelle.Parameters.AddWithValue("@p5", txtUrunID.Text);
            guncelle.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Fatura Detayı Güncellendi", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        public void FaturaDetaySil()
        {
            SqlCommand sil = new SqlCommand("delete from TBLFATURADETAY where FATURAURUNID=@p1", baglan.baglanti());
            sil.Parameters.AddWithValue("@p1", txtUrunID.Text);
            sil.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Fatura Detay Silindi", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void FrmFaturaUrunDuzenleme_Load(object sender, EventArgs e)
        {
            txtUrunID.Text = urunid;
            FaturaDetayGetir();
        }

        private void txtFiyat_EditValueChanged(object sender, EventArgs e)
        {
            double miktar, tutar, fiyat;
            fiyat = Convert.ToDouble(txtFiyat.Text);
            miktar = Convert.ToDouble(txtMiktar.Text);

            tutar = miktar * fiyat;

            txtTutar.Text = tutar.ToString();
        }

        private void btnFaturaDetayGuncelle_Click(object sender, EventArgs e)
        {
            FaturaDetayGuncelle();
        }

        private void btnFaturaDetaySil_Click(object sender, EventArgs e)
        {
            FaturaDetaySil();
        }
    }
}
