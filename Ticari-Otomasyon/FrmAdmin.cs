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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        public void GirisYap()
        {
            try
            {
                if (txtKullaniciAd.Text != "" && txtSifre.Text != "")
                {
                    SqlCommand giris = new SqlCommand("select * from TBLADMIN where KULLANICIADI=@p1 and SIFRE=@p2", baglan.baglanti());
                    giris.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
                    giris.Parameters.AddWithValue("@p2", txtSifre.Text);
                    SqlDataReader dr = giris.ExecuteReader();
                    if (dr.Read())
                    {
                        FrmAnasayfa frm = new FrmAnasayfa();
                        frm.kullanici = txtKullaniciAd.Text;
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Kullanıcı Adı ve Şifre", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            GirisYap();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
