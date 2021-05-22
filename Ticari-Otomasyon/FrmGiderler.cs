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
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        public void GiderListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter("select * from TBLGIDERLER", baglan.baglanti());
            adap.Fill(dt);
            gridControl1.DataSource = dt;
            baglan.baglanti().Close();
        }

        public void GiderGuncelle()
        {
            try
            {
                DialogResult uyari = MessageBox.Show(cmbAy.Text + cmbYil.Text + "Tarihli Gideri Gerçekten Değiştirmek İsiyor Musunuz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (uyari == DialogResult.Yes)
                {
                    if (txtDogalgaz.Text != "" && txtElektrik.Text != "" && txtInternet.Text != "" && txtMaaslar.Text != "" && txtSu.Text != "" && cmbAy.Text != "" && cmbYil.Text != "")
                    {
                        SqlCommand guncelle = new SqlCommand("update TBLGIDERLER set AY=@p1, YIL=@p2, ELEKTRIK=@p3, SU=@p4, DOGALGAZ=@p5, INTERNET=@p6, MAASLAR=@p7, EKSTRA=@p8, NOTLAR=@p9 where ID=@p10", baglan.baglanti());
                        guncelle.Parameters.AddWithValue("@p1", cmbAy.Text);
                        guncelle.Parameters.AddWithValue("@p2", cmbYil.Text);
                        guncelle.Parameters.AddWithValue("@p3", Convert.ToDecimal(txtElektrik.Text));
                        guncelle.Parameters.AddWithValue("@p4", Convert.ToDecimal(txtSu.Text));
                        guncelle.Parameters.AddWithValue("@p5", Convert.ToDecimal(txtDogalgaz.Text));
                        guncelle.Parameters.AddWithValue("@p6", Convert.ToDecimal(txtInternet.Text));
                        guncelle.Parameters.AddWithValue("@p7", Convert.ToDecimal(txtMaaslar.Text));
                        guncelle.Parameters.AddWithValue("@p8", Convert.ToDecimal(txtEkstra.Text));
                        guncelle.Parameters.AddWithValue("@p9", txtNotlar.Text);
                        guncelle.Parameters.AddWithValue("@p10", txtID.Text);
                        guncelle.ExecuteNonQuery();
                        baglan.baglanti().Close();
                        MessageBox.Show(cmbAy.Text + cmbYil.Text + " Tarihli Giderler Değiştirildi", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        GiderListesi();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Alanları Doldurunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void GiderSil()
        {
            try
            {
                DialogResult uyari = MessageBox.Show("Gideri Gerçekten Silmek İstiyor Musun ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (uyari == DialogResult.Yes)
                {
                    SqlCommand sil = new SqlCommand("delete from TBLGIDERLER where ID=@p1", baglan.baglanti());
                    sil.Parameters.AddWithValue("@p1", txtID.Text);
                    sil.ExecuteNonQuery();
                    baglan.baglanti().Close();
                    MessageBox.Show(cmbAy.Text + cmbYil.Text + " Tarihli Gider Silindi", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    GiderListesi();
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            GiderListesi();
        }

        private void btnGiderGuncelle_Click(object sender, EventArgs e)
        {
            GiderGuncelle();
        }

        private void btnGiderSil_Click(object sender, EventArgs e)
        {
            GiderSil();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow data = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtDogalgaz.Text = data["DOGALGAZ"].ToString();
            txtEkstra.Text = data["EKSTRA"].ToString();
            txtElektrik.Text = data["ELEKTRIK"].ToString();
            txtID.Text = data["ID"].ToString();
            txtInternet.Text = data["INTERNET"].ToString();
            txtMaaslar.Text = data["MAASLAR"].ToString();
            txtNotlar.Text = data["NOTLAR"].ToString();
            txtSu.Text = data["SU"].ToString();
            cmbAy.Text = data["AY"].ToString();
            cmbYil.Text = data["YIL"].ToString();
        }

        FrmGiderEkle giderekle;
        private void btnGiderEkle_Click(object sender, EventArgs e)
        {
            if (giderekle == null || giderekle.IsDisposed)
            {
                giderekle = new FrmGiderEkle();
                giderekle.Owner = this;
                giderekle.MdiParent = this.ParentForm;
                giderekle.Show();
                this.Close();
            }
            else
            {
                giderekle.Activate();
            }
        }
    }
}
