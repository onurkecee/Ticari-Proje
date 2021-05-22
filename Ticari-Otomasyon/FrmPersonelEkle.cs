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
    public partial class FrmPersonelEkle : Form
    {
        public FrmPersonelEkle()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        public void PersonelEkle()
        {
            try
            {
                if (txtAd.Text != "" && txtAdres.Text != "" && txtSoyad.Text != "" && txtTcKimlik.Text != "" && txtTelefon.Text != "" && cmbil.Text != "" && cmbilce.Text != "" && cmbGorev.Text != "")
                {
                    SqlCommand personel = new SqlCommand("insert into TBLPERSONELLER (AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,ADRES,GOREV) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglan.baglanti());
                    personel.Parameters.AddWithValue("@p1", txtAd.Text);
                    personel.Parameters.AddWithValue("@p2", txtSoyad.Text);
                    personel.Parameters.AddWithValue("@p3", txtTelefon.Text);
                    personel.Parameters.AddWithValue("@p4", txtTcKimlik.Text);
                    personel.Parameters.AddWithValue("@p5", txtMail.Text);
                    personel.Parameters.AddWithValue("@p6", cmbil.Text);
                    personel.Parameters.AddWithValue("@p7", cmbilce.Text);
                    personel.Parameters.AddWithValue("@p8", txtAdres.Text);
                    personel.Parameters.AddWithValue("@p9", cmbGorev.Text);
                    personel.ExecuteNonQuery();
                    baglan.baglanti().Close();
                    MessageBox.Show(txtAd.Text + " " + txtSoyad.Text + " Adlı Personel Kaydedildi", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Lütfen Alanları Doldurunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            PersonelEkle();
        }

        private void FrmPersonelEkle_Load(object sender, EventArgs e)
        {
            SehirListesi();
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
    }
}
