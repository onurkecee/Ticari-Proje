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
    public partial class FrmStokDetay : Form
    {
        public FrmStokDetay()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();
        public string id;

        private void FrmStokDetay_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter("select MARKA,MODEL,YIL,ADET,ALISFIYAT,SATISFIYAT,DETAY from TBLURUNLER where URUNAD='" + id + "'", baglan.baglanti());
                adap.Fill(dt);
                gridControl1.DataSource = dt;
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
