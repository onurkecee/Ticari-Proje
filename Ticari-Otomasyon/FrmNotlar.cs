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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        public void NotListele()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter("select * from TBLNOTLAR", baglan.baglanti());
                adap.Fill(dt);
                gridControl1.DataSource = dt;
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void NotSil()
        {
            try
            {
                DialogResult uyari = MessageBox.Show("Notu Gerçekten Silmek İstiyor Musun ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (uyari == DialogResult.Yes)
                {
                    SqlCommand sil = new SqlCommand("Delete from TBLNOTLAR where NOTID=@p1", baglan.baglanti());
                    sil.Parameters.AddWithValue("@p1", txtID.Text);
                    sil.ExecuteNonQuery();
                    baglan.baglanti().Close();
                    MessageBox.Show("Not Başarıyla Silindi", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    NotListele();
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void NotGuncelle()
        {
            try
            {
                if (txtBaslik.Text != "" && txtHitap.Text != "" && txtNot.Text != "" && txtOlusturan.Text != "" && txtTarih.Text != "")
                {
                    DialogResult uyari = MessageBox.Show("Notu Gerçekten Değiştirmek İstiyor Musun ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (uyari == DialogResult.Yes)
                    {
                        SqlCommand guncelle = new SqlCommand("update TBLNOTLAR set NOTTARIH=@p1, NOTSAAT=@p2, NOTBASLIK=@p3, NOTDETAY=@p4, NOTOLUSTURAN=@p5, NOTHITAP=@p6 where NOTID=@p7", baglan.baglanti());
                        guncelle.Parameters.AddWithValue("@p1", txtTarih.Text);
                        guncelle.Parameters.AddWithValue("@p2", txtSaat.Text);
                        guncelle.Parameters.AddWithValue("@p3", txtBaslik.Text);
                        guncelle.Parameters.AddWithValue("@p4", txtNot.Text);
                        guncelle.Parameters.AddWithValue("@p5", txtOlusturan.Text);
                        guncelle.Parameters.AddWithValue("@p6", txtHitap.Text);
                        guncelle.Parameters.AddWithValue("@p7", txtID.Text);
                        guncelle.ExecuteNonQuery();
                        baglan.baglanti().Close();
                        MessageBox.Show("Not Başarıyla Güncellendi", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        NotListele();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Alanları Doldurunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            NotListele();
        }

        FrmNotEkle notekle;
        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            if (notekle == null || notekle.IsDisposed)
            {
                notekle = new FrmNotEkle();
                notekle.Owner = this;
                notekle.MdiParent = this.ParentForm;
                notekle.Show();
                this.Close();
            }
            else
            {
                notekle.Activate();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow data = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtBaslik.Text = data["NOTBASLIK"].ToString();
            txtHitap.Text = data["NOTHITAP"].ToString();
            txtID.Text = data["NOTID"].ToString();
            txtNot.Text = data["NOTDETAY"].ToString();
            txtOlusturan.Text = data["NOTOLUSTURAN"].ToString();
            txtSaat.Text = data["NOTSAAT"].ToString();
            txtTarih.Text = data["NOTTARIH"].ToString();
        }

        private void btnNotSil_Click(object sender, EventArgs e)
        {
            NotSil();
        }

        private void btnNotGuncelle_Click(object sender, EventArgs e)
        {
            NotGuncelle();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmNotDetay notdetay = new FrmNotDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                notdetay.notid = dr["NOTID"].ToString();
            }
            notdetay.Show();
        }
    }
}
