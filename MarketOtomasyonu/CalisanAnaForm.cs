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
    public partial class CalisanAnaForm : DevExpress.XtraEditors.XtraForm
    {
        public CalisanAnaForm()
        {
            InitializeComponent();
        }

        UrunSatısFormu satısFormu;
        private void btnSatışEkranı_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (satısFormu == null || satısFormu.IsDisposed)
            {
                satısFormu = new UrunSatısFormu();
                satısFormu.MdiParent = this;
                satısFormu.Show();
            }
        }

        CalisanIadeFormu calisanIade;
        private void btnIadeEkranı_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (calisanIade == null || calisanIade.IsDisposed)
            {
                calisanIade = new CalisanIadeFormu();
                calisanIade.MdiParent = this;
                calisanIade.Show();
            }
        }
    }
}
