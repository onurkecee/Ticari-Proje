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
    public partial class FrmPersonelDetay : Form
    {
        public FrmPersonelDetay()
        {
            InitializeComponent();
        }

        public string id;

        SqlBaglantisi baglan = new SqlBaglantisi();

        public void PersonelDetayGetir()
        {
            try
            {
                SqlCommand personelgetir = new SqlCommand("select * from TBLPERSONELLER where ID=@p1", baglan.baglanti());
                personelgetir.Parameters.AddWithValue("@p1", lblid.Text);
                SqlDataReader dr = personelgetir.ExecuteReader();
                while (dr.Read())
                {
                    lblAd.Text = dr[1].ToString();
                    lblSoyad.Text = dr[2].ToString();
                    lblTelefon.Text = dr[3].ToString();
                    lblTc.Text = dr[4].ToString();
                    lblMail.Text = dr[5].ToString();
                    lblil.Text = dr[6].ToString();
                    lblilce.Text = dr[7].ToString();
                    txtAdres.Text = dr[8].ToString();
                    lblGorev.Text = dr[9].ToString();
                }
                baglan.baglanti().Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void PersonelKurumsalSatıs()
        {
            SqlCommand kurumsalsatis = new SqlCommand("SELECT URUNAD, TBLFIRMAHAREKETLER.ADET,(TBLPERSONELLER.AD+' '+SOYAD) AS 'PERSONEL', TBLFIRMALAR.AD AS 'FİRMA', FIYAT,TOPLAM,FATURAID,TARIH FROM TBLFIRMAHAREKETLER INNER JOIN TBLURUNLER ON TBLFIRMAHAREKETLER.URUNID=TBLURUNLER.ID INNER JOIN TBLPERSONELLER ON TBLFIRMAHAREKETLER.PERSONEL=TBLPERSONELLER.ID INNER JOIN TBLFIRMALAR ON TBLFIRMAHAREKETLER.FIRMA=TBLFIRMALAR.ID where TBLPERSONELLER.AD=@p1", baglan.baglanti());
            kurumsalsatis.Parameters.AddWithValue("@p1", lblAd.Text);
            SqlDataAdapter adap = new SqlDataAdapter(kurumsalsatis);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            gridKurumsal.DataSource = dt;
            baglan.baglanti().Close();
        }

        public void PersonelBireyselSatis()
        {
            SqlCommand bireyselsatis = new SqlCommand("SELECT URUNAD, TBLMUSTERIHAREKETLER.ADET, (TBLPERSONELLER.AD+' '+TBLPERSONELLER.SOYAD) AS 'PERSONEL', (TBLMUSTERILER.AD+' '+TBLMUSTERILER.SOYAD) AS 'MÜŞTERİ',FIYAT,TOPLAM,TARIH FROM TBLMUSTERIHAREKETLER INNER JOIN TBLURUNLER ON TBLMUSTERIHAREKETLER.URUNID=TBLURUNLER.ID INNER JOIN TBLPERSONELLER ON TBLMUSTERIHAREKETLER.PERSONEL=TBLPERSONELLER.ID INNER JOIN TBLMUSTERILER ON TBLMUSTERIHAREKETLER.MUSTERI=TBLMUSTERILER.ID where TBLPERSONELLER.AD=@p1", baglan.baglanti());
            bireyselsatis.Parameters.AddWithValue("@p1", lblAd.Text);
            SqlDataAdapter adap = new SqlDataAdapter(bireyselsatis);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            gridBireysel.DataSource = dt;
            baglan.baglanti().Close();
        }

        private void FrmPersonelDetay_Load(object sender, EventArgs e)
        {
            lblid.Text = id;
            PersonelDetayGetir();
            PersonelKurumsalSatıs();
            PersonelBireyselSatis();
        }
    }
}
