using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        FrmUrunler urunler;
        FrmMusteriler musteri;
        FrmFirmalar firma;
        FrmPersoneller personel;
        FrmRehber rehber;
        FrmGiderler gider;
        FrmBankalar banka;
        FrmFaturalar fatura;
        FrmNotlar not;
        FrmHareketler hareket;
        FrmStoklar stok;
        FrmAyarlar ayarlar;
        FrmKasa kasa;
        FrmAna ana;
        private void btnMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (musteri == null || musteri.IsDisposed)
            {
                musteri = new FrmMusteriler();
                musteri.Owner = this;
                musteri.MdiParent = this;
                musteri.Show();
            }
            else
            {
                musteri.Activate();
            }
        }

        private void btnUrunler_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (urunler == null || urunler.IsDisposed)
            {
                urunler = new FrmUrunler();
                urunler.Owner = this;
                urunler.MdiParent = this;
                urunler.Show();
            }
            else
            {
                urunler.Activate();
            }
        }

        private void btnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (firma == null || firma.IsDisposed)
            {
                firma = new FrmFirmalar();
                firma.Owner = this;
                firma.MdiParent = this;
                firma.Show();
            }
            else
            {
                firma.Activate();
            }
        }

        private void btnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (personel == null || personel.IsDisposed)
            {
                personel = new FrmPersoneller();
                personel.Owner = this;
                personel.MdiParent = this;
                personel.Show();
            }
            else
            {
                personel.Activate();
            }
        }

        private void btnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (rehber == null || rehber.IsDisposed)
            {
                rehber = new FrmRehber();
                rehber.Owner = this;
                rehber.MdiParent = this;
                rehber.Show();
            }
            else
            {
                rehber.Activate();
            }
        }

        private void btnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gider == null || gider.IsDisposed)
            {
                gider = new FrmGiderler();
                gider.Owner = this;
                gider.MdiParent = this;
                gider.Show();
            }
            else
            {
                gider.Activate();
            }
        }

        private void btnBankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (banka == null || banka.IsDisposed)
            {
                banka = new FrmBankalar();
                banka.Owner = this;
                banka.MdiParent = this;
                banka.Show();
            }
            else
            {
                banka.Activate();
            }
        }

        private void btnFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fatura == null || fatura.IsDisposed)
            {
                fatura = new FrmFaturalar();
                fatura.Owner = this;
                fatura.MdiParent = this;
                fatura.Show();
            }
            else
            {
                fatura.Activate();
            }
        }

        private void btnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (not == null || not.IsDisposed)
            {
                not = new FrmNotlar();
                not.Owner = this;
                not.MdiParent = this;
                not.Show();
            }
            else
            {
                not.Activate();
            }
        }

        private void btnHareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (hareket == null || hareket.IsDisposed)
            {
                hareket = new FrmHareketler();
                hareket.Owner = this;
                hareket.MdiParent = this;
                hareket.Show();
            }
            else
            {
                hareket.Activate();
            }
        }

        private void btnStoklar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (stok == null || stok.IsDisposed)
            {
                stok = new FrmStoklar();
                stok.Owner = this;
                stok.MdiParent = this;
                stok.Show();
            }
            else
            {
                stok.Activate();
            }
        }

        private void btnAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ayarlar == null || ayarlar.IsDisposed)
            {
                ayarlar = new FrmAyarlar();
                ayarlar.Owner = this;
                ayarlar.MdiParent = this;
                ayarlar.Show();
            }
            else
            {
                ayarlar.Activate();
            }
        }

        private void btnKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kasa == null || kasa.IsDisposed)
            {
                kasa = new FrmKasa();
                kasa.ad = kullanici;
                kasa.Owner = this;
                kasa.MdiParent = this;
                kasa.Show();
            }
            else
            {
                kasa.Activate();
            }
        }

        public string kullanici;
        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            if (ana == null || ana.IsDisposed)
            {
                ana = new FrmAna();
                ana.Owner = this;
                ana.MdiParent = this;
                ana.Show();
            }
            else
            {
                kasa.Activate();
            }
        }

        private void btnAnasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
