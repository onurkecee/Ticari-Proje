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
    public partial class FrmPersoneller : Form
    {
        public FrmPersoneller()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        public void PersonelListesi()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter("select * from TBLPERSONELLER", baglan.baglanti());
                adap.Fill(dt);
                gridControl1.DataSource = dt;
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

        public void PersonelSil()
        {
            try
            {
                DialogResult uyari = MessageBox.Show(txtAd.Text + " " + txtSoyad.Text + " Adlı Personeli Gerçekten Silmek İstiyor Musun ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (uyari == DialogResult.Yes)
                {
                    SqlCommand sil = new SqlCommand("delete from TBLPERSONELLER where ID=@p1", baglan.baglanti());
                    sil.Parameters.AddWithValue("@p1", txtID.Text);
                    sil.ExecuteNonQuery();
                    baglan.baglanti().Close();
                    MessageBox.Show(txtAd.Text + " " + txtSoyad.Text + " Adlı Personel Silindi");
                    PersonelListesi();
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        public void PersonelGuncelle()
        {
            if (txtAd.Text != "" && txtAdres.Text != "" && txtSoyad.Text != "" && txtTcKimlik.Text != "" && txtTelefon.Text != "" && cmbil.Text != "" && cmbilce.Text != "" && cmbGorev.Text != "")
            {
                DialogResult uyari = MessageBox.Show(txtAd.Text + " " + txtSoyad.Text + " Adlı Personelin Bilgilerini Gerçekten Değiştimek İstiyor Musun ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (uyari == DialogResult.Yes)
                {
                    SqlCommand guncelle = new SqlCommand("update TBLPERSONELLER set AD=@p1, SOYAD=@p2, TELEFON=@p3, TC=@p4, MAIL=@p5, IL=@p6, ILCE=@p7, ADRES=@p8, GOREV=@p9 where ID=@p10", baglan.baglanti());
                    guncelle.Parameters.AddWithValue("@p1", txtAd.Text);
                    guncelle.Parameters.AddWithValue("@p2", txtSoyad.Text);
                    guncelle.Parameters.AddWithValue("@p3", txtTelefon.Text);
                    guncelle.Parameters.AddWithValue("@p4", txtTcKimlik.Text);
                    guncelle.Parameters.AddWithValue("@p5", txtMail.Text);
                    guncelle.Parameters.AddWithValue("@p6", cmbil.Text);
                    guncelle.Parameters.AddWithValue("@p7", cmbilce.Text);
                    guncelle.Parameters.AddWithValue("@p8", txtAdres.Text);
                    guncelle.Parameters.AddWithValue("@p9", cmbGorev.Text);
                    guncelle.Parameters.AddWithValue("@p10", txtID.Text);
                    guncelle.ExecuteNonQuery();
                    baglan.baglanti().Close();
                    MessageBox.Show(txtAd.Text + " " + txtSoyad.Text + " Adlı Personel Güncellendi");
                    PersonelListesi();
                }

            }
            else
            {
                MessageBox.Show("Lütfen Alanları Doldurunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmPersoneller_Load(object sender, EventArgs e)
        {
            PersonelListesi();
            SehirListesi();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow data = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtAd.Text = data["AD"].ToString();
            txtAdres.Text = data["ADRES"].ToString();
            txtID.Text = data["ID"].ToString();
            txtMail.Text = data["MAIL"].ToString();
            txtSoyad.Text = data["SOYAD"].ToString();
            txtTcKimlik.Text = data["TC"].ToString();
            txtTelefon.Text = data["TELEFON"].ToString();
            cmbGorev.Text = data["GOREV"].ToString();
            cmbil.Text = data["IL"].ToString();
            cmbilce.Text = data["ILCE"].ToString();
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

        FrmPersonelEkle personelekle;
        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            if (personelekle == null || personelekle.IsDisposed)
            {
                personelekle = new FrmPersonelEkle();
                personelekle.Owner = this;
                personelekle.MdiParent = this.ParentForm;
                personelekle.Show();
                this.Close();
            }
            else
            {
                personelekle.Activate();
            }
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            PersonelSil();
        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            PersonelGuncelle();
        }
    }
}
