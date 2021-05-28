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
using DevExpress.Charts;

namespace Ticari_Otomasyon
{
    public partial class FrmKasa : Form
    {
        public FrmKasa()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        public void FirmaHareketGetir()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter("execute FIRMAHAREKETLER", baglan.baglanti());
                adap.Fill(dt);
                FirmaGrid.DataSource = dt;
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void MusteriHareketGetir()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter("execute MUSTERIHAREKETLER", baglan.baglanti());
                adap.Fill(dt);
                MusteriGrid.DataSource = dt;
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void ToplamTutar()
        {
            try
            {
                SqlCommand komut = new SqlCommand("select sum(TUTAR) from TBLFATURADETAY", baglan.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    lblToplamTutar.Text = dr[0].ToString() + " ₺";
                }
                baglan.baglanti().Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void SonOdemeler()
        {
            try
            {
                SqlCommand odeme = new SqlCommand("select (ELEKTRIK+SU+DOGALGAZ+INTERNET+EKSTRA) from TBLGIDERLER order by ID asc", baglan.baglanti());
                SqlDataReader dr = odeme.ExecuteReader();
                if (dr.Read())
                {
                    lblOdemeler.Text = dr[0].ToString() + " ₺";
                }
                baglan.baglanti().Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void SonOdenenPersonelMaaslari()
        {
            try
            {
                SqlCommand maas = new SqlCommand("select MAASLAR from TBLGIDERLER order by ID asc", baglan.baglanti());
                SqlDataReader dr = maas.ExecuteReader();
                if (dr.Read())
                {
                    lblPersonelMaas.Text = dr[0].ToString() + " ₺";
                }
                baglan.baglanti().Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void ToplamMusteri()
        {
            try
            {
                SqlCommand musteri = new SqlCommand("select count(*) from TBLMUSTERILER", baglan.baglanti());
                SqlDataReader dr = musteri.ExecuteReader();
                if (dr.Read())
                {
                    lblToplamMusteri.Text = dr[0].ToString();
                }
                baglan.baglanti().Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void ToplamFirma()
        {
            try
            {
                SqlCommand firma = new SqlCommand("select count(*) from TBLFIRMALAR", baglan.baglanti());
                SqlDataReader dr = firma.ExecuteReader();
                if (dr.Read())
                {
                    lblToplamFirma.Text = dr[0].ToString();
                }
                baglan.baglanti().Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void ToplamPersonel()
        {
            try
            {
                SqlCommand personel = new SqlCommand("select count(*) from TBLPERSONELLER", baglan.baglanti());
                SqlDataReader dr = personel.ExecuteReader();
                if (dr.Read())
                {
                    lblToplamPersonel.Text = dr[0].ToString();
                }
                baglan.baglanti().Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void ToplamStok()
        {
            try
            {
                SqlCommand stok = new SqlCommand("select sum(ADET) from TBLURUNLER", baglan.baglanti());
                SqlDataReader dr = stok.ExecuteReader();
                if (dr.Read())
                {
                    lblStokSayisi.Text = dr[0].ToString();
                }
                baglan.baglanti().Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void ElektrikGrafigi()
        {
            try
            {
                SqlCommand elek = new SqlCommand("select top 4 AY, ELEKTRIK from TBLGIDERLER order by ID asc", baglan.baglanti());
                SqlDataReader dr = elek.ExecuteReader();
                while (dr.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
                }
                baglan.baglanti().Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void SuGrafigi()
        {
            try
            {
                SqlCommand su = new SqlCommand("select top 4 AY, SU from TBLGIDERLER order by ID asc", baglan.baglanti());
                SqlDataReader dr = su.ExecuteReader();
                while (dr.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));
                }
                baglan.baglanti().Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void ElektrikGridDoldur()
        {
            try
            {
                SqlDataAdapter adap = new SqlDataAdapter("select top 4 AY, YIL, ELEKTRIK from TBLGIDERLER order by ID asc", baglan.baglanti());
                DataTable dt = new DataTable();
                adap.Fill(dt);
                gridCikis1.DataSource = dt;
                baglan.baglanti().Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void SuGridDoldur()
        {
            try
            {
                SqlDataAdapter adap = new SqlDataAdapter("select top 4 AY, YIL, SU from TBLGIDERLER order by ID asc", baglan.baglanti());
                DataTable dt = new DataTable();
                adap.Fill(dt);
                gridCikis2.DataSource = dt;
                baglan.baglanti().Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public string ad;
        private void FrmKasa_Load(object sender, EventArgs e)
        {
            lblAktifKullanici.Text = ad;

            FirmaHareketGetir();
            MusteriHareketGetir();
            ToplamTutar();
            SonOdemeler();
            SonOdenenPersonelMaaslari();
            ToplamMusteri();
            ToplamFirma();
            ToplamPersonel();
            ToplamStok();
            ElektrikGrafigi();
            SuGrafigi();
            ElektrikGridDoldur();
            SuGridDoldur();
        }
    }
}
