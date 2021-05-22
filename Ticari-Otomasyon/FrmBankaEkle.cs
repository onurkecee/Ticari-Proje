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
    public partial class FrmBankaEkle : Form
    {
        public FrmBankaEkle()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        public void BankaEkle()
        {
            try
            {
                if (txtFirma.Text != "" && txtHesapNo.Text != "" && txtHesapTuru.Text != "" && txtIban.Text != "" && txtSube.Text != "" && txtTarih.Text != "" && txtTelefon.Text != "" && txtYetkiliKisi.Text != "" && cmbil.Text != "" && cmbilce.Text != "")
                {
                    SqlCommand ekle = new SqlCommand("insert into TBLBANKALAR (BANKAADI,IL,ILCE,SUBE,IBAN,HESAPNO,YETKILI,TELEFON,TARIH,HESAPTURU,FIRMAID) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", baglan.baglanti());
                    ekle.Parameters.AddWithValue("@p1", txtBankaAdi.Text);
                    ekle.Parameters.AddWithValue("@p2", cmbil.Text);
                    ekle.Parameters.AddWithValue("@p3", cmbilce.Text);
                    ekle.Parameters.AddWithValue("@p4", txtSube.Text);
                    ekle.Parameters.AddWithValue("@p5", txtIban.Text);
                    ekle.Parameters.AddWithValue("@p6", txtHesapNo.Text);
                    ekle.Parameters.AddWithValue("@p7", txtYetkiliKisi.Text);
                    ekle.Parameters.AddWithValue("@p8", txtTelefon.Text);
                    ekle.Parameters.AddWithValue("@p9", txtTarih.Text);
                    ekle.Parameters.AddWithValue("@p10", txtHesapTuru.Text);
                    ekle.Parameters.AddWithValue("@p11", txtFirma.EditValue);
                    ekle.ExecuteNonQuery();
                    baglan.baglanti().Close();
                    MessageBox.Show(txtFirma.Text + " Adlı Firmanın Banka Bilgileri Kaydedildi", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        public void FirmaListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter("select ID,AD from TBLFIRMALAR", baglan.baglanti());
            adap.Fill(dt);
            txtFirma.Properties.NullText = "Lütfen Firma Seçiniz.";
            txtFirma.Properties.ValueMember = "ID";
            txtFirma.Properties.DisplayMember = "AD";
            txtFirma.Properties.DataSource = dt;

        }

        private void btnBankaEkle_Click(object sender, EventArgs e)
        {
            BankaEkle();
        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
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

        private void FrmBankaEkle_Load(object sender, EventArgs e)
        {
            SehirListesi();
            FirmaListesi();
        }
    }
}
