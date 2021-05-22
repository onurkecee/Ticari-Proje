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
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        public void FaturaListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter("select * from TBLFATURABILGI", baglan.baglanti());
            adap.Fill(dt);
            gridControl1.DataSource = dt;
        }

        public void FaturaSil()
        {
            SqlCommand sil = new SqlCommand("delete from TBLFATURABILGI where FATURABILGIID=@p1", baglan.baglanti());
            sil.Parameters.AddWithValue("@p1", txtID.Text);
            sil.ExecuteNonQuery();
            baglan.baglanti().Close();
            FaturaListele();
            MessageBox.Show("Fatura Başarıyla Silindi", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public void FaturaGuncelle()
        {
            SqlCommand guncelle = new SqlCommand("update TBLFATURABILGI set SERI=@p1, SIRANO=@p2, TARIH=@p3, SAAT=@p4, VERGIDAIRE=@p5, ALICI=@p6, TESLIMEDEN=@p7, TESLIMALAN=@p8 where FATURABILGIID=@p9", baglan.baglanti());
            guncelle.Parameters.AddWithValue("@p1", txtSeriNo.Text);
            guncelle.Parameters.AddWithValue("@p2", txtSiraNo.Text);
            guncelle.Parameters.AddWithValue("@p3", txtTarih.Text);
            guncelle.Parameters.AddWithValue("@p4", txtSaat.Text);
            guncelle.Parameters.AddWithValue("@p5", txtVergiDairesi.Text);
            guncelle.Parameters.AddWithValue("@p6", txtAlici.Text);
            guncelle.Parameters.AddWithValue("@p7", txtTeslimEden.Text);
            guncelle.Parameters.AddWithValue("@p8", txtTeslimAlan.Text);
            guncelle.Parameters.AddWithValue("@p9", txtID.Text);
            guncelle.ExecuteNonQuery();
            baglan.baglanti().Close();
            MessageBox.Show("Fatura Bilgisi Güncellendi");
            FaturaListele();
        }

        public void UrunBul()
        {
            SqlCommand bul = new SqlCommand("select URUNAD,SATISFIYAT from TBLURUNLER where ID=@p1", baglan.baglanti());
            bul.Parameters.AddWithValue("@p1", txtUrunID.Text);
            SqlDataReader dr = bul.ExecuteReader();
            while (dr.Read())
            {
                txtUrunAd.Text = dr[0].ToString();
                txtFiyat.Text = dr[1].ToString();
            }
            baglan.baglanti().Close();
        }

        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            FaturaListele();
        }

        FrmFaturaEkle faturaekle;
        private void btnFaturaEkle_Click(object sender, EventArgs e)
        {
            if (faturaekle == null || faturaekle.IsDisposed)
            {
                faturaekle = new FrmFaturaEkle();
                faturaekle.Owner = this;
                faturaekle.MdiParent = this.ParentForm;
                faturaekle.Show();
                this.Close();
            }
            else
            {
                faturaekle.Activate();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow data = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtID.Text = data["FATURABILGIID"].ToString();
            txtSeriNo.Text = data["SERI"].ToString();
            txtSiraNo.Text = data["SIRANO"].ToString();
            txtTarih.Text = data["TARIH"].ToString();
            txtSaat.Text = data["SAAT"].ToString();
            txtVergiDairesi.Text = data["VERGIDAIRE"].ToString();
            txtAlici.Text = data["ALICI"].ToString();
            txtTeslimAlan.Text = data["TESLIMALAN"].ToString();
            txtTeslimEden.Text = data["TESLIMEDEN"].ToString();
        }

        private void btnFaturaSil_Click(object sender, EventArgs e)
        {
            FaturaSil();
        }

        private void btnFaturaGuncelle_Click(object sender, EventArgs e)
        {
            FaturaGuncelle();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaUrunDetay frm = new FrmFaturaUrunDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                frm.id = dr["FATURABILGIID"].ToString();
            }
            frm.Show();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            UrunBul();
        }
    }
}
