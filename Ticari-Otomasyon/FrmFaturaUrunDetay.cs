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
    public partial class FrmFaturaUrunDetay : Form
    {
        public FrmFaturaUrunDetay()
        {
            InitializeComponent();
        }
        public string id;
        SqlBaglantisi baglan = new SqlBaglantisi();

        public void FaturaDetayListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter("select * from TBLFATURADETAY where FATURAID='" + id + "'", baglan.baglanti());
            adap.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void FrmFaturaUrunDetay_Load(object sender, EventArgs e)
        {
            FaturaDetayListele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaUrunDuzenleme frm = new FrmFaturaUrunDuzenleme();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                frm.urunid = dr["FATURAURUNID"].ToString();
            }
            frm.Show();
        }
    }
}
