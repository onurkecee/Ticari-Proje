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
    public partial class FrmNotDetay : Form
    {
        public FrmNotDetay()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();
        public string notid;

        public void NotDetayListele()
        {
            SqlCommand notdetay = new SqlCommand("select * from TBLNOTLAR where NOTID=@p1", baglan.baglanti());
            notdetay.Parameters.AddWithValue("@p1", notid);
            SqlDataReader dr = notdetay.ExecuteReader();
            while (dr.Read())
            {
                txtTarih.Text = dr[1].ToString();
                txtSaat.Text = dr[2].ToString();
                txtBaslik.Text = dr[3].ToString();
                txtNot.Text = dr[4].ToString();
                txtOlusturan.Text = dr[5].ToString();
                txtHitap.Text = dr[6].ToString();
            }
        }

        private void FrmNotDetay_Load(object sender, EventArgs e)
        {
            lblid.Text = notid;
            NotDetayListele();
        }
    }
}
