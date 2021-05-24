using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        public void MusteriListesi()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter("select * from TBLMUSTERILER", baglan.baglanti());
                adap.Fill(dt);
                gridControl1.DataSource = dt;
            }
            catch (Exception)
            {

                MessageBox.Show("Müşteri Listeleme Hatası", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void MusteriSil()
        {
            try
            {
                DialogResult uyari = MessageBox.Show(txtAd.Text + " Adlı Müşteriyi Gerçekten Silmek İstiyor Musun ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (uyari == DialogResult.Yes)
                {
                    SqlCommand sil = new SqlCommand("delete from TBLMUSTERILER where ID=@p1", baglan.baglanti());
                    sil.Parameters.AddWithValue("@p1", txtID.Text);
                    sil.ExecuteNonQuery();
                    baglan.baglanti().Close();
                    MessageBox.Show(txtAd.Text + " Adlı Müsteri Silindi", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    MusteriListesi();
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void MusteriGuncelle()
        {
            try
            {
                if (txtAd.Text != "" && txtMail.Text != "" && txtSoyad.Text != "" && txtTcKimlik.Text != "" && txtTelefon.Text != "" && txtMail.Text != "" && txtVergiDairesi.Text != "")
                {
                    DialogResult uyari = MessageBox.Show(txtAd.Text + " Adlı Müşterinin Bilgilerini Gerçekten Değiştirmek İstiyor Musun ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (uyari == DialogResult.Yes)
                    {
                        SqlCommand guncelle = new SqlCommand("update TBLMUSTERILER set AD=@p1, SOYAD=@p2, TELEFON=@p3, TELEFON2=@p4, TC=@p5, MAIL=@p6, IL=@p7, ILCE=@p8, ADRES=@p9, VERGIDAIRE=@p10 where ID=@p11", baglan.baglanti());
                        guncelle.Parameters.AddWithValue("@p1", txtAd.Text);
                        guncelle.Parameters.AddWithValue("@p2", txtSoyad.Text);
                        guncelle.Parameters.AddWithValue("@p3", txtTelefon.Text);
                        guncelle.Parameters.AddWithValue("@p4", txtTelefon2.Text);
                        guncelle.Parameters.AddWithValue("@p5", txtTcKimlik.Text);
                        guncelle.Parameters.AddWithValue("@p6", txtMail.Text);
                        guncelle.Parameters.AddWithValue("@p7", cmbil.Text);
                        guncelle.Parameters.AddWithValue("@p8", cmbilce.Text);
                        guncelle.Parameters.AddWithValue("@p9", txtAdres.Text);
                        guncelle.Parameters.AddWithValue("@p10", txtVergiDairesi.Text);
                        guncelle.Parameters.AddWithValue("@p11", txtID.Text);
                        guncelle.ExecuteNonQuery();
                        baglan.baglanti().Close();
                        MessageBox.Show(txtAd.Text + " Adlı Musterinin Bilgileri Güncellendi");
                        MusteriListesi();
                    }
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

        public void MusteriAra()
        {
            if (radioAdArama.Checked == true)
            {
                try
                {
                    SqlCommand isimarama = new SqlCommand("select * from TBLMUSTERILER where AD like '%" + txtMusteriAra.Text + "%'", baglan.baglanti());
                    SqlDataAdapter adap = new SqlDataAdapter(isimarama);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
                    gridControl1.DataSource = dt;
                    baglan.baglanti().Close();
                }
                catch (SqlException ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
            if (radioTcArama.Checked == true)
            {
                try
                {
                    SqlCommand tcarama = new SqlCommand("select * from TBLMUSTERILER where TC like '%" + txtMusteriAra.Text + "%'", baglan.baglanti());
                    SqlDataAdapter adap = new SqlDataAdapter(tcarama);
                    DataTable dt = new DataTable();
                    adap.Fill(dt);
                    gridControl1.DataSource = dt;
                    baglan.baglanti().Close();
                }
                catch (SqlException ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }

        public void ToplamMusteriSayisi()
        {
            int toplam = gridView1.RowCount;
            lblToplamMusteri.Text = toplam.ToString();
        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            MusteriListesi();
            SehirListesi();
            ToplamMusteriSayisi();
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

        FrmMusteriEkle musteriekle;
        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            if (musteriekle == null || musteriekle.IsDisposed)
            {
                musteriekle = new FrmMusteriEkle();
                musteriekle.Owner = this;
                musteriekle.MdiParent = this.ParentForm;
                musteriekle.Show();
                this.Close();
            }
            else
            {
                musteriekle.Activate();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow data = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                txtID.Text = data["ID"].ToString();
                txtAd.Text = data["AD"].ToString();
                txtSoyad.Text = data["SOYAD"].ToString();
                txtTelefon.Text = data["TELEFON"].ToString();
                txtTelefon2.Text = data["TELEFON2"].ToString();
                txtTcKimlik.Text = data["TC"].ToString();
                txtMail.Text = data["MAIL"].ToString();
                cmbil.Text = data["IL"].ToString();
                cmbilce.Text = data["ILCE"].ToString();
                txtAdres.Text = data["ADRES"].ToString();
                txtVergiDairesi.Text = data["VERGIDAIRE"].ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Böyle Müşteri Yok");
            }

        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            MusteriSil();
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            MusteriGuncelle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            MusteriAra();
        }
    }
}
