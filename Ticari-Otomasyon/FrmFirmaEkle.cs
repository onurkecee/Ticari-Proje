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
    public partial class FrmFirmaEkle : Form
    {
        public FrmFirmaEkle()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        public void FirmaEkle()
        {
            try
            {
                if (txtAd.Text != "" && txtAdres.Text != "" && txtMail.Text != "" && txtTelefon1.Text != "" && txtVergiDairesi.Text != "" && txtYetkili.Text != "" && txtYetkiliTC.Text != "" && cmbil.Text != "" && cmbilce.Text != "" && cmbSektor.Text != "" && cmbYetkiliGorev.Text != "")
                {
                    SqlCommand firma = new SqlCommand("insert into TBLFIRMALAR (AD,SEKTOR,YETKILIADSOYAD,YETKILITC,YETKILISTATU,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX,IL,ILCE,VERGIDAIRESI,ADRES) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14)", baglan.baglanti());
                    firma.Parameters.AddWithValue("@p1", txtAd.Text);
                    firma.Parameters.AddWithValue("@p2", cmbSektor.Text);
                    firma.Parameters.AddWithValue("@p3", txtYetkili.Text);
                    firma.Parameters.AddWithValue("@p4", txtYetkiliTC.Text);
                    firma.Parameters.AddWithValue("@p5", cmbYetkiliGorev.Text);
                    firma.Parameters.AddWithValue("@p6", txtTelefon1.Text);
                    firma.Parameters.AddWithValue("@p7", txtTelefon2.Text);
                    firma.Parameters.AddWithValue("@p8", txtTelefon3.Text);
                    firma.Parameters.AddWithValue("@p9", txtMail.Text);
                    firma.Parameters.AddWithValue("@p10", txtFax.Text);
                    firma.Parameters.AddWithValue("@p11", cmbil.Text);
                    firma.Parameters.AddWithValue("@p12", cmbilce.Text);
                    firma.Parameters.AddWithValue("@p13", txtVergiDairesi.Text);
                    firma.Parameters.AddWithValue("@p14", txtAdres.Text);
                    firma.ExecuteNonQuery();
                    baglan.baglanti().Close();
                    MessageBox.Show(txtAd.Text + " Adlı Firma Başarıyla Kaydedildi", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen Alanları Doldurunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void SehirListesi()
        {
            try
            {
                SqlCommand sehir = new SqlCommand("select SEHIR from TBLILLER", baglan.baglanti());
                SqlDataReader dr = sehir.ExecuteReader();
                while (dr.Read())
                {
                    cmbil.Properties.Items.Add(dr[0]);
                }
                baglan.baglanti().Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnFirmaEkle_Click(object sender, EventArgs e)
        {
            FirmaEkle();
        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbilce.Properties.Items.Clear();
                SqlCommand ilce = new SqlCommand("select ILCE from TBLILCELER where SEHIR=@p1", baglan.baglanti());
                ilce.Parameters.AddWithValue("@p1", cmbil.SelectedIndex + 1);
                SqlDataReader dr = ilce.ExecuteReader();
                while (dr.Read())
                {
                    cmbilce.Properties.Items.Add(dr[0]);
                }
                baglan.baglanti().Close();

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FrmFirmaEkle_Load(object sender, EventArgs e)
        {
            SehirListesi();
        }
    }
}
