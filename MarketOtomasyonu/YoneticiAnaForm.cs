using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu
{
    public partial class YoneticiAnaForm : DevExpress.XtraEditors.XtraForm
    {
        public YoneticiAnaForm()
        {
            InitializeComponent();
        }

        private void YoneticiAnaForm_Load(object sender, EventArgs e)
        {

        }

        CalisanYonetimFormu calisanYonetimFormu;
        private void btnCalisanYoneticiFormuAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (calisanYonetimFormu == null || calisanYonetimFormu.IsDisposed)
            {
                calisanYonetimFormu = new CalisanYonetimFormu();
                calisanYonetimFormu.MdiParent = this;
                calisanYonetimFormu.Show();
            }
            
        }
        UrunYonetimFormu urunYonetimFormu;
        private void btnUrunYonetimiFormuAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (urunYonetimFormu == null || urunYonetimFormu.IsDisposed)
            {
                urunYonetimFormu = new UrunYonetimFormu();
                urunYonetimFormu.MdiParent = this;
                urunYonetimFormu.Show();
            }
        }
        SatisYonetimFormu satisYonetimFormu;
        private void btnSatisYonetimiFormuAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (satisYonetimFormu == null || satisYonetimFormu.IsDisposed)
            {   
                satisYonetimFormu = new SatisYonetimFormu();
                satisYonetimFormu.MdiParent = this;
                satisYonetimFormu.Show();
            }
        }

        IadeYonetimFormu ıadeYonetim;
        private void btnIadeYonetimFormuAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ıadeYonetim == null || ıadeYonetim.IsDisposed)
            {   
                ıadeYonetim = new IadeYonetimFormu();
                ıadeYonetim.MdiParent = this;
                ıadeYonetim.Show();
            }
        }

        RaporVeIstatistikFormu raporVeIstatistikFormu;
        private void btnRaporVeIstatistikFormuAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (raporVeIstatistikFormu == null || raporVeIstatistikFormu.IsDisposed)
            {   
                raporVeIstatistikFormu = new RaporVeIstatistikFormu();
                raporVeIstatistikFormu.MdiParent = this;
                raporVeIstatistikFormu.Show();
            }
        }

        UrunSatısFormu satısFormu;
        private void btnSatisEkrani_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (satısFormu == null || satısFormu.IsDisposed)
            {
                satısFormu = new UrunSatısFormu();
                satısFormu.MdiParent = this;
                satısFormu.Show();
            }
        }

        
    }
}
