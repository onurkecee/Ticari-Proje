﻿using System;
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
    public partial class FrmRehber : Form
    {
        public FrmRehber()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglan = new SqlBaglantisi();

        public void MusteriGetir()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter("select AD,SOYAD,TELEFON,TELEFON2,MAIL from TBLMUSTERILER", baglan.baglanti());
            adap.Fill(dt);
            gridControl1.DataSource = dt;
        }

        public void FirmaGetir()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter("select AD,YETKILIADSOYAD,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX from TBLFIRMALAR", baglan.baglanti());
            adap.Fill(dt);
            gridControl2.DataSource = dt;
        }

        private void FrmRehber_Load(object sender, EventArgs e)
        {
            MusteriGetir();
            FirmaGetir();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmMail frm = new FrmMail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                frm.mail = dr["MAIL"].ToString();
            }
            frm.Show();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            FrmMail frm = new FrmMail();
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {
                frm.mail = dr["MAIL"].ToString();
            }
            frm.Show();
        }
    }
}
