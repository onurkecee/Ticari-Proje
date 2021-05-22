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
    public partial class FrmUrunDetay : Form
    {
        public FrmUrunDetay()
        {
            InitializeComponent();
        }
        public string id;

        SqlBaglantisi baglan = new SqlBaglantisi();

        public void UrunDetayGetir()
        {
            try
            {
                SqlCommand urungetir = new SqlCommand("select * from TBLURUNLER where ID=@p1", baglan.baglanti());
                urungetir.Parameters.AddWithValue("@p1", lblid.Text);
                SqlDataReader dr = urungetir.ExecuteReader();
                while (dr.Read())
                {
                    lblUrunAd.Text = dr[1].ToString();
                    lblMarka.Text = dr[2].ToString();
                    lblModel.Text = dr[3].ToString();
                    lblYil.Text = dr[4].ToString();
                    lblAdet.Text = dr[5].ToString();
                    lblAlisFiyat.Text = dr[6].ToString();
                    lblSatisFiyat.Text = dr[7].ToString();
                    txtDetay.Text = dr[8].ToString();
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void FrmUrunDetay_Load(object sender, EventArgs e)
        {
            lblid.Text = id;

            UrunDetayGetir();
        }
    }
}
