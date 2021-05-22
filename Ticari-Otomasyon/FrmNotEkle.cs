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
    public partial class FrmNotEkle : Form
    {
        public FrmNotEkle()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        public void NotEkle()
        {
            SqlCommand ekle = new SqlCommand("insert into TBLNOTLAR (NOTTARIH,NOTSAAT,NOTBASLIK,NOTDETAY,NOTOLUSTURAN,NOTHITAP) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglan.baglanti());
            ekle.Parameters.AddWithValue("@p1", txtTarih.Text);
            ekle.Parameters.AddWithValue("@p2", txtSaat.Text);
            ekle.Parameters.AddWithValue("@p3", txtBaslik.Text);
            ekle.Parameters.AddWithValue("@p4", txtNot.Text);
            ekle.Parameters.AddWithValue("@p5", txtOlusturan.Text);
            ekle.Parameters.AddWithValue("@p6", txtHitap.Text);
            ekle.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Not Başarıyla Kaydedildi", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            NotEkle();
        }

        private void FrmNotEkle_Load(object sender, EventArgs e)
        {
            txtSaat.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
