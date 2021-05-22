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
    public partial class FrmUrunEkle : Form
    {
        public FrmUrunEkle()
        {
            InitializeComponent();
        }
        SqlBaglantisi baglan = new SqlBaglantisi();

        public void UrunKaydet()
        {
            try
            {
                if (txtAdet.Value > 0 && txtAlisFiyat.Text != "" && txtDetay.Text != "" && txtMarka.Text != "" && txtModel.Text != "" && txtSatisFiyat.Text != "" && txtUrunAdi.Text != "" && txtYil.Text != "")
                {
                    SqlCommand kaydet = new SqlCommand("insert into TBLURUNLER (URUNAD,MARKA,MODEL,YIL,ADET,ALISFIYAT,SATISFIYAT,DETAY) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglan.baglanti());
                    kaydet.Parameters.AddWithValue("@p1", txtUrunAdi.Text);
                    kaydet.Parameters.AddWithValue("@p2", txtMarka.Text);
                    kaydet.Parameters.AddWithValue("@p3", txtModel.Text);
                    kaydet.Parameters.AddWithValue("@p4", txtYil.Text);
                    kaydet.Parameters.AddWithValue("@p5", int.Parse((txtAdet.Value).ToString()));
                    kaydet.Parameters.AddWithValue("@p6", decimal.Parse(txtAlisFiyat.Text).ToString());
                    kaydet.Parameters.AddWithValue("@p7", decimal.Parse(txtSatisFiyat.Text).ToString());
                    kaydet.Parameters.AddWithValue("@p8", txtDetay.Text);
                    kaydet.ExecuteNonQuery();
                    baglan.baglanti().Close();
                    MessageBox.Show(txtUrunAdi.Text + " Adlı Ürün Başarıyla Kaydedildi", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen Boş Alanları Doldurunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            UrunKaydet();
        }

        private void FrmUrunEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
