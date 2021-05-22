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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        public void UrunListele()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter("select * from TBLURUNLER", baglan.baglanti());
                adap.Fill(dt);
                gridControl1.DataSource = dt;
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void UrunSil()
        {
            try
            {
                DialogResult uyari = MessageBox.Show(txtUrunAdi.Text + " Adlı Ürünü Silmek İstediğinizden Emin misiniz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (uyari == DialogResult.Yes)
                {
                    SqlCommand sil = new SqlCommand("delete from TBLURUNLER where ID=@p1", baglan.baglanti());
                    sil.Parameters.AddWithValue("@p1", txtUrunID.Text);
                    sil.ExecuteNonQuery();
                    baglan.baglanti().Close();
                    MessageBox.Show(txtUrunAdi.Text + " Adlı Ürün Başarıyla Silindi", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UrunListele();
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void UrunGuncelle()
        {
            try
            {
                if (txtUrunAdi.Text != "" && txtMarka.Text != "" && txtModel.Text != "" && txtSatisFiyat.Text != "" && txtAlisFiyat.Text != "" && txtAdet.Value > 0 && txtYil.Text != "")
                {
                    DialogResult uyari = MessageBox.Show(txtUrunAdi.Text + " Adlı Ürün Bilgilerini Değiştirmek İstediğinizden Emin misiniz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (uyari == DialogResult.Yes)
                    {
                        SqlCommand guncelle = new SqlCommand("update TBLURUNLER set URUNAD=@p1, MARKA=@p2, MODEL=@p3, YIL=@p4, ADET=@p5, ALISFIYAT=@p6, SATISFIYAT=@p7, DETAY=@p8 where ID=@p9", baglan.baglanti());
                        guncelle.Parameters.AddWithValue("@p1", txtUrunAdi.Text);
                        guncelle.Parameters.AddWithValue("@p2", txtMarka.Text);
                        guncelle.Parameters.AddWithValue("@p3", txtModel.Text);
                        guncelle.Parameters.AddWithValue("@p4", txtYil.Text);
                        guncelle.Parameters.AddWithValue("@p5", Convert.ToInt32(txtAdet.Text.ToString()));
                        guncelle.Parameters.AddWithValue("@p6", Convert.ToDouble(txtAlisFiyat.Text).ToString());
                        guncelle.Parameters.AddWithValue("@p7", Convert.ToDouble(txtSatisFiyat.Text).ToString());
                        guncelle.Parameters.AddWithValue("@p8", txtDetay.Text);
                        guncelle.Parameters.AddWithValue("@p9", txtUrunID.Text);
                        guncelle.ExecuteNonQuery();
                        baglan.baglanti().Close();
                        MessageBox.Show(txtUrunAdi.Text + " Adlı Ürün Güncellendi", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UrunListele();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Alanları Doldurunuz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            UrunListele();
        }

        FrmUrunEkle urunekle;
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (urunekle == null || urunekle.IsDisposed)
            {
                urunekle = new FrmUrunEkle();
                urunekle.Owner = this;
                urunekle.MdiParent = this.ParentForm;
                urunekle.Show();
                this.Close();
            }
            else
            {
                urunekle.Activate();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            UrunSil();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow data = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtUrunID.Text = data["ID"].ToString();
            txtUrunAdi.Text = data["URUNAD"].ToString();
            txtMarka.Text = data["MARKA"].ToString();
            txtModel.Text = data["MODEL"].ToString();
            txtYil.Text = data["YIL"].ToString();
            txtAdet.Text = data["ADET"].ToString();
            txtAlisFiyat.Text = data["ALISFIYAT"].ToString();
            txtSatisFiyat.Text = data["SATISFIYAT"].ToString();
            txtDetay.Text = data["DETAY"].ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            UrunGuncelle();
        }
    }
}
