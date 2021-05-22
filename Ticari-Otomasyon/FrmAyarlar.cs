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
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        public void KullanıcıBilgileriListele()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter("select * from TBLADMIN", baglan.baglanti());
                adap.Fill(dt);
                gridControl1.DataSource = dt;
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void SifreDegistir()
        {
            try
            {
                if (txtKullaniciAdi.Text != "" && txtSifre.Text != "")
                {
                    DialogResult uyari = MessageBox.Show("Şifreyi Gerçekten Değiştirmek İstiyor Musun ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (uyari == DialogResult.Yes)
                    {
                        SqlCommand degistir = new SqlCommand("update TBLADMIN set KULLANICIADI=@p1, SIFRE=@p2 where ID=@p3", baglan.baglanti());
                        degistir.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                        degistir.Parameters.AddWithValue("@p2", txtSifre.Text);
                        degistir.Parameters.AddWithValue("@p3", lblid.Text);
                        degistir.ExecuteNonQuery();
                        baglan.baglanti().Close();
                        KullanıcıBilgileriListele();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Alanları Doldurunuz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void KullaniciEkle()
        {
            try
            {
                SqlCommand tekrar = new SqlCommand("select count(*) from TBLADMIN where KULLANICIADI=@p1", baglan.baglanti());
                tekrar.Parameters.AddWithValue("@p1", txtUser.Text);
                int sonuc = (int)tekrar.ExecuteScalar();
                if (sonuc == 0)
                {
                    if (txtUser.Text != "" && txtPass.Text != "")
                    {
                        SqlCommand ekle = new SqlCommand("insert into TBLADMIN (KULLANICIADI,SIFRE) values (@p1,@p2)", baglan.baglanti());
                        ekle.Parameters.AddWithValue("@p1", txtUser.Text);
                        ekle.Parameters.AddWithValue("@p2", txtPass.Text);
                        ekle.ExecuteNonQuery();
                        baglan.baglanti().Close();
                        KullanıcıBilgileriListele();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Alanları Doldurunuz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Bu Kullanıcı Adı Sistemde Mevcut", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            KullanıcıBilgileriListele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow data = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtKullaniciAdi.Text = data["KULLANICIADI"].ToString();
            txtSifre.Text = data["SIFRE"].ToString();
            lblid.Text = data["ID"].ToString();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            SifreDegistir();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            KullaniciEkle();
        }
    }
}
