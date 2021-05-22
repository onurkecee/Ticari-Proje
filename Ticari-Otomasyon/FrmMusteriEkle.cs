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
    public partial class FrmMusteriEkle : Form
    {
        public FrmMusteriEkle()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        public void MusteriEkle()
        {
            try
            {
                if (txtAd.Text != "" && txtMail.Text != "" && txtSoyad.Text != "" && txtTcKimlik.Text != "" && txtTelefon.Text != "" && txtMail.Text != "" && txtVergiDairesi.Text != "")
                {
                    SqlCommand musteri = new SqlCommand("insert into TBLMUSTERILER (AD,SOYAD,TELEFON,TELEFON2,TC,MAIL,IL,ILCE,ADRES,VERGIDAIRE) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", baglan.baglanti());
                    musteri.Parameters.AddWithValue("@p1", txtAd.Text);
                    musteri.Parameters.AddWithValue("@p2", txtSoyad.Text);
                    musteri.Parameters.AddWithValue("@p3", txtTelefon.Text);
                    musteri.Parameters.AddWithValue("@p4", txtTelefon2.Text);
                    musteri.Parameters.AddWithValue("@p5", txtTcKimlik.Text);
                    musteri.Parameters.AddWithValue("@p6", txtMail.Text);
                    musteri.Parameters.AddWithValue("@p7", cmbil.Text);
                    musteri.Parameters.AddWithValue("@p8", cmbilce.Text);
                    musteri.Parameters.AddWithValue("@p9", txtAdres.Text);
                    musteri.Parameters.AddWithValue("@p10", txtVergiDairesi.Text);
                    musteri.ExecuteNonQuery();
                    baglan.baglanti().Close();
                    MessageBox.Show(txtAd.Text + "Adlı Müşteri Kaydedildi", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Lütfen Alanları Doldurunuz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle();
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

        private void FrmMusteriEkle_Load(object sender, EventArgs e)
        {
            SehirListesi();
        }
    }
}
