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
    public partial class FrmAna : Form
    {
        public FrmAna()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        public void AzalanStok()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter("select URUNAD, sum(ADET) as 'ADET' from TBLURUNLER group by URUNAD having sum(ADET)<=50 order by sum(ADET)", baglan.baglanti());
            adap.Fill(dt);
            gridStok.DataSource = dt;
        }

        public void Ajanda()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter("select TOP 5 NOTTARIH, NOTBASLIK, NOTDETAY from TBLNOTLAR order by NOTID desc", baglan.baglanti());
            adap.Fill(dt);
            gridAjanda.DataSource = dt;
        }

        public void FirmaHareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter("execute ANASAYFAHAREKET", baglan.baglanti());
            adap.Fill(dt);
            gridHareket.DataSource = dt;
        }

        public void Fihrist()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter("select AD, TELEFON1 from TBLFIRMALAR", baglan.baglanti());
            adap.Fill(dt);
            gridFirma.DataSource = dt;
            
        }

        private void FrmAna_Load(object sender, EventArgs e)
        {
            AzalanStok();
            Ajanda();
            FirmaHareket();
            Fihrist();
        }
    }
}
