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
    public partial class FrmGiderEkle : Form
    {
        public FrmGiderEkle()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        public void GiderEkle()
        {
            try
            {
                if (cmbAy.Text != "" && cmbYil.Text != "" && txtElektrik.Text != "" && txtSu.Text != "" && txtDogalgaz.Text != "" && txtInternet.Text != "" && txtMaaslar.Text != "" && txtEkstra.Text != "" && txtNotlar.Text != "")
                {
                    SqlCommand giderekle = new SqlCommand("insert into TBLGIDERLER (AY,YIL,ELEKTRIK,SU,DOGALGAZ,INTERNET,MAASLAR,EKSTRA,NOTLAR) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglan.baglanti());
                    giderekle.Parameters.AddWithValue("@p1", cmbAy.Text);
                    giderekle.Parameters.AddWithValue("@p2", cmbYil.Text);
                    giderekle.Parameters.AddWithValue("@p3", Convert.ToDecimal(txtElektrik.Text));
                    giderekle.Parameters.AddWithValue("@p4", Convert.ToDecimal(txtSu.Text));
                    giderekle.Parameters.AddWithValue("@p5", Convert.ToDecimal(txtDogalgaz.Text));
                    giderekle.Parameters.AddWithValue("@p6", Convert.ToDecimal(txtInternet.Text));
                    giderekle.Parameters.AddWithValue("@p7", Convert.ToDecimal(txtMaaslar.Text));
                    giderekle.Parameters.AddWithValue("@p8", Convert.ToDecimal(txtEkstra.Text));
                    giderekle.Parameters.AddWithValue("@p9", txtNotlar.Text);
                    giderekle.ExecuteNonQuery();
                    baglan.baglanti().Close();
                    MessageBox.Show(cmbAy.Text + cmbYil.Text + " Tarihli Gider Başarıyla Kaydedildi", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void btnGiderEkle_Click(object sender, EventArgs e)
        {
            GiderEkle();
        }
    }
}
