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
    public partial class FrmBankalar : Form
    {
        public FrmBankalar()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        public void BankaListesi()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter("execute BankaBilgileri", baglan.baglanti());
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

        public void FirmaListesi()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter("select ID,AD from TBLFIRMALAR", baglan.baglanti());
                adap.Fill(dt);
                txtFirma.Properties.ValueMember = "ID";
                txtFirma.Properties.DisplayMember = "AD";
                txtFirma.Properties.DataSource = dt;
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        public void BankaSil()
        {
            try
            {
                DialogResult uyari = MessageBox.Show(txtFirma.Text + " Adlı Firmanın " + txtBankaAdi.Text + "  Hesap Bilgilerini Gerçekten Silmek İstiyor Musun ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (uyari == DialogResult.Yes)
                {
                    SqlCommand sil = new SqlCommand("delete from TBLBANKALAR where ID=@p1", baglan.baglanti());
                    sil.Parameters.AddWithValue("@p1", txtID.Text);
                    sil.ExecuteNonQuery();
                    baglan.baglanti().Close();
                    MessageBox.Show(txtFirma.Text + " Adlı Firmanın Banka Bilgisi Silindi", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    BankaListesi();
                    FirmaListesi();
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void BankaGuncelle()
        {
            try
            {
                if (txtFirma.Text != "" && txtHesapNo.Text != "" && txtHesapTuru.Text != "" && txtIban.Text != "" && txtSube.Text != "" && txtTarih.Text != "" && txtTelefon.Text != "" && txtYetkiliKisi.Text != "" && cmbil.Text != "" && cmbilce.Text != "")
                {
                    DialogResult uyari = MessageBox.Show(txtFirma.Text + " Adlı Firma Adlı Banka Bilgilerini Gerçekten Silmek İstiyor Musun", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (uyari == DialogResult.Yes)
                    {
                        SqlCommand guncelle = new SqlCommand("update TBLBANKALAR set BANKAADI=@p1, IL=@p2, ILCE=@p3, SUBE=@p4, IBAN=@p5, HESAPNO=@p6, YETKILI=@p7, TELEFON=@p8, TARIH=@p9, HESAPTURU=@p10, FIRMAID=@p11 where ID=@p12", baglan.baglanti());
                        guncelle.Parameters.AddWithValue("@p1", txtBankaAdi.Text);
                        guncelle.Parameters.AddWithValue("@p2", cmbil.Text);
                        guncelle.Parameters.AddWithValue("@p3", cmbilce.Text);
                        guncelle.Parameters.AddWithValue("@p4", txtSube.Text);
                        guncelle.Parameters.AddWithValue("@p5", txtIban.Text);
                        guncelle.Parameters.AddWithValue("@p6", txtHesapNo.Text);
                        guncelle.Parameters.AddWithValue("@p7", txtYetkiliKisi.Text);
                        guncelle.Parameters.AddWithValue("@p8", txtTelefon.Text);
                        guncelle.Parameters.AddWithValue("@p9", txtTarih.Text);
                        guncelle.Parameters.AddWithValue("@p10", txtHesapTuru.Text);
                        guncelle.Parameters.AddWithValue("@p11", txtFirma.EditValue);
                        guncelle.Parameters.AddWithValue("@p12", txtID.Text);
                        guncelle.ExecuteNonQuery();
                        baglan.baglanti().Close();
                        MessageBox.Show(txtFirma.Text + " Adlı Firmanın Banka Bilgileri Güncelleşti", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        BankaListesi();
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

        private void FrmBankalar_Load(object sender, EventArgs e)
        {
            BankaListesi();
            SehirListesi();
            FirmaListesi();
        }

        FrmBankaEkle bankaekle;
        private void btnBankaEkle_Click(object sender, EventArgs e)
        {
            if (bankaekle == null || bankaekle.IsDisposed)
            {
                bankaekle = new FrmBankaEkle();
                bankaekle.Owner = this;
                bankaekle.MdiParent = this.ParentForm;
                bankaekle.Show();
                this.Close();
            }
            else
            {
                bankaekle.Activate();
            }
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow data = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtBankaAdi.Text = data["BANKAADI"].ToString();
            txtFirma.Text = data["AD"].ToString();
            txtHesapNo.Text = data["HESAPNO"].ToString();
            txtHesapTuru.Text = data["HESAPTURU"].ToString();
            txtIban.Text = data["IBAN"].ToString();
            txtID.Text = data["ID"].ToString();
            txtSube.Text = data["SUBE"].ToString();
            txtTarih.Text = data["TARIH"].ToString();
            txtTelefon.Text = data["TELEFON"].ToString();
            txtYetkiliKisi.Text = data["YETKILI"].ToString();
            cmbil.Text = data["IL"].ToString();
            cmbilce.Text = data["ILCE"].ToString();
        }

        private void btnBankaSil_Click(object sender, EventArgs e)
        {
            BankaSil();
        }

        private void btnBankaGuncelle_Click(object sender, EventArgs e)
        {
            BankaGuncelle();
        }
    }
}
