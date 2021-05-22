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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        public void UrunStokListesi()
        {
            SqlDataAdapter adap = new SqlDataAdapter("select URUNAD, sum(ADET) as 'ADET' from TBLURUNLER group by URUNAD", baglan.baglanti());
            DataTable dt = new DataTable();
            adap.Fill(dt);
            gridControl1.DataSource = dt;
        }

        public void UrunGrafikOlustur()
        {
            SqlCommand komut = new SqlCommand("select URUNAD, sum(ADET) as 'ADET' from TBLURUNLER group by URUNAD", baglan.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
        }

        public void FirmaSehirListesi()
        {
            SqlDataAdapter adap = new SqlDataAdapter("select IL, Count(*) as 'SAYI' from TBLFIRMALAR group by IL", baglan.baglanti());
            DataTable dt = new DataTable();
            adap.Fill(dt);
            gridControl2.DataSource = dt;
        }

        public void FirmaSehirGrafikOlustur()
        {
            SqlCommand komut = new SqlCommand("select IL, Count(*) as 'SAYI' from TBLFIRMALAR group by IL", baglan.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            baglan.baglanti().Close();
        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            UrunStokListesi();
            UrunGrafikOlustur();
            FirmaSehirListesi();
            FirmaSehirGrafikOlustur();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmStokDetay stokdetay = new FrmStokDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                stokdetay.id = dr["URUNAD"].ToString();
            }
            stokdetay.Show();
        }
    }
}
