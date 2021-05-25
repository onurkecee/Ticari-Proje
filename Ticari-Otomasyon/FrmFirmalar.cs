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
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        public void FirmaListesi()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter("select * from TBLFIRMALAR", baglan.baglanti());
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

        public void FirmaSil()
        {
            try
            {
                DialogResult uyari = MessageBox.Show(txtAd.Text + " Adlı Firmayı Gerçekten Silmek İstiyor Musunuz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (uyari == DialogResult.Yes)
                {
                    SqlCommand sil = new SqlCommand("delete from TBLFIRMALAR where ID=@p1", baglan.baglanti());
                    sil.Parameters.AddWithValue("@p1", txtID.Text);
                    sil.ExecuteNonQuery();
                    baglan.baglanti().Close();
                    MessageBox.Show(txtAd.Text + "Adlı Firma Silindi", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FirmaListesi();
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void FirmaGuncelle()
        {
            try
            {
                if (txtAd.Text != "" && txtAdres.Text != "" && txtMail.Text != "" && txtTelefon1.Text != "" && txtVergiDairesi.Text != "" && txtYetkili.Text != "" && txtYetkiliTC.Text != "" && cmbil.Text != "" && cmbilce.Text != "" && cmbSektor.Text != "" && cmbYetkiliGorev.Text != "")
                {
                    DialogResult uyari = MessageBox.Show(txtAd.Text + " Adlı Firmanın Bilgilerini Gerçekten Değiştirmek İstiyor Musun ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (uyari == DialogResult.Yes)
                    {
                        SqlCommand guncelle = new SqlCommand("update TBLFIRMALAR set AD=@p1, SEKTOR=@p2, YETKILIADSOYAD=@p3, YETKILITC=@p4, YETKILISTATU=@p5, TELEFON1=@p6, TELEFON2=@p7, TELEFON3=@p8, MAIL=@p9, FAX=@p10, IL=@p11, ILCE=@p12, VERGIDAIRESI=@p13, ADRES=@p14 where ID=@p15", baglan.baglanti());
                        guncelle.Parameters.AddWithValue("@p1", txtAd.Text);
                        guncelle.Parameters.AddWithValue("@p2", cmbSektor.Text);
                        guncelle.Parameters.AddWithValue("@p3", txtYetkili.Text);
                        guncelle.Parameters.AddWithValue("@p4", txtYetkiliTC.Text);
                        guncelle.Parameters.AddWithValue("@p5", cmbYetkiliGorev.Text);
                        guncelle.Parameters.AddWithValue("@p6", txtTelefon1.Text);
                        guncelle.Parameters.AddWithValue("@p7", txtTelefon2.Text);
                        guncelle.Parameters.AddWithValue("@p8", txtTelefon3.Text);
                        guncelle.Parameters.AddWithValue("@p9", txtMail.Text);
                        guncelle.Parameters.AddWithValue("@p10", txtFax.Text);
                        guncelle.Parameters.AddWithValue("@p11", cmbil.Text);
                        guncelle.Parameters.AddWithValue("@p12", cmbilce.Text);
                        guncelle.Parameters.AddWithValue("@p13", txtVergiDairesi.Text);
                        guncelle.Parameters.AddWithValue("@p14", txtAdres.Text);
                        guncelle.Parameters.AddWithValue("@p15", txtID.Text);
                        guncelle.ExecuteNonQuery();
                        baglan.baglanti().Close();
                        MessageBox.Show(txtAd.Text + "Adlı Firma Bilgileri Güncellendi", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FirmaListesi();
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

        public void FirmaAra()
        {
            if (radioFirmaArama.Checked == true)
            {
                try
                {
                    SqlDataAdapter adap = new SqlDataAdapter("select * from TBLFIRMALAR where AD like '%" + txtFirmaAra.Text + "%'", baglan.baglanti());
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
            if (radioSektorArama.Checked == true)
            {
                try
                {
                    SqlDataAdapter adap = new SqlDataAdapter("select * from TBLFIRMALAR where SEKTOR like '%" + txtFirmaAra.Text + "'", baglan.baglanti());
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

        public void ToplamFirmaSayisi()
        {
            int toplam = gridView1.RowCount;
            lblToplamFirma.Text = toplam.ToString();
        }

        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            FirmaListesi();
            SehirListesi();
            ToplamFirmaSayisi();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                DataRow data = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                txtAd.Text = data["AD"].ToString();
                txtAdres.Text = data["ADRES"].ToString();
                txtFax.Text = data["FAX"].ToString();
                txtID.Text = data["ID"].ToString();
                txtMail.Text = data["MAIL"].ToString();
                txtTelefon1.Text = data["TELEFON1"].ToString();
                txtTelefon2.Text = data["TELEFON2"].ToString();
                txtTelefon3.Text = data["TELEFON3"].ToString();
                txtVergiDairesi.Text = data["VERGIDAIRESI"].ToString();
                txtYetkili.Text = data["YETKILIADSOYAD"].ToString();
                txtYetkiliTC.Text = data["YETKILITC"].ToString();
                cmbil.Text = data["IL"].ToString();
                cmbilce.Text = data["ILCE"].ToString();
                cmbSektor.Text = data["SEKTOR"].ToString();
                cmbYetkiliGorev.Text = data["YETKILISTATU"].ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Böyle Bir Firma Yok");
            }

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

        FrmFirmaEkle firmaekle;
        private void btnFirmaEkle_Click(object sender, EventArgs e)
        {
            if (firmaekle == null || firmaekle.IsDisposed)
            {
                firmaekle = new FrmFirmaEkle();
                firmaekle.Owner = this;
                firmaekle.MdiParent = this.ParentForm;
                firmaekle.Show();
                this.Close();
            }
            else
            {
                firmaekle.Activate();
            }
        }

        private void btnFirmaSil_Click(object sender, EventArgs e)
        {
            FirmaSil();
        }

        private void btnFirmaGuncelle_Click(object sender, EventArgs e)
        {
            FirmaGuncelle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            FirmaAra();
        }
    }
}
