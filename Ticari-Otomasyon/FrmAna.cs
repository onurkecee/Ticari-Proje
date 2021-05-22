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
using System.Xml;

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

        public void DovizKurları()
        {
            XmlDocument xmlVerisi = new XmlDocument();
            xmlVerisi.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

            decimal dolar = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "USD")).InnerText.Replace('.', ','));
            decimal euro = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "EUR")).InnerText.Replace('.', ','));
            decimal sterlin = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "GBP")).InnerText.Replace('.', ','));
            decimal frank = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "CHF")).InnerText.Replace('.', ','));
            decimal ruble = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "RUB")).InnerText.Replace('.', ','));
            decimal yuan = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "CNY")).InnerText.Replace('.', ','));
            decimal dinar = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "KWD")).InnerText.Replace('.', ','));
            decimal kron = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "NOK")).InnerText.Replace('.', ','));


            lblDolar.Text = dolar.ToString();
            lblEuro.Text = euro.ToString();
            lblSterlin.Text = sterlin.ToString();
            lblFrank.Text = frank.ToString();
            lblRuble.Text = ruble.ToString();
            lblYuan.Text = yuan.ToString();
            lblDinar.Text = dinar.ToString();
            lblKron.Text = kron.ToString();
        }

        public void HaberBasliklari()
        {
            XmlTextReader xmloku = new XmlTextReader("https://www.hurriyet.com.tr/rss/anasayfa");
            while (xmloku.Read())
            {
                if (xmloku.Name == "title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }

        }

        private void FrmAna_Load(object sender, EventArgs e)
        {
            AzalanStok();
            Ajanda();
            FirmaHareket();
            Fihrist();
            DovizKurları();
            HaberBasliklari();
        }
    }
}
