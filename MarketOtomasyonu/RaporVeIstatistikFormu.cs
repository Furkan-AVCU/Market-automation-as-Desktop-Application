using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.LookAndFeel;

namespace MarketOtomasyonu
{
    public partial class RaporVeIstatistikFormu : Form
    {
        public RaporVeIstatistikFormu()
        {
            InitializeComponent();
        }
        MarketOtomasyonDBEntities db = new MarketOtomasyonDBEntities();
        public void Son24SaatSatislar() //Grid Control'e kayıtları çekiyor
        {
            string yıl = DateTime.Today.Year.ToString();
            string ay = DateTime.Today.Month.ToString();
            string gün = DateTime.Today.Day.ToString();
            if (int.Parse(ay) < 10)
            {
                ay = "0" + ay;
            }
            string bugün = yıl +"-"+ ay +"-"+ gün;

            gcSonSatislar.Visible = true;
            gcTarihiGecmis.Visible = false;
            gcStokBiten.Visible = false;
            gcIadeler.Visible = false;

            var satisAl = from x in db.satislar
                          where x.satis_tarihi.ToString().Substring(0, 10) == bugün
                          select new
                          {
                              SatışID=x.satis_id,
                              SatışTarihi=x.satis_tarihi,
                              SatanKullanıcı=x.calisanlar.Kullanici_adi,
                              Ürün=x.urunler.Urun_adi,
                              ÜrünID=x.urun_id,
                              SatışFiyatı=x.satis_fiyat,
                              Adet=x.adet
                          };
            gcSonSatislar.DataSource = satisAl.ToList();
        }
        public void StokBitenUrunCek() //Grid Control'e kayıtları çekiyor
        {
            gcSonSatislar.Visible = false;
            gcTarihiGecmis.Visible = false;
            gcStokBiten.Visible = true;
            gcIadeler.Visible = false;
            var urunAl = from x in db.urunler
                          where x.stok == 0
                          select new
                          {
                              ÜrünID= x.Urun_id,
                              ÜrünAdı= x.Urun_adi,
                              Stok= x.stok,
                              Kategori= x.kategoriler.Kategori_adi,
                              Fiyat = x.fiyat,
                              AlışFiyatı = x.alis_fiyat
                          };
            gcStokBiten.DataSource = urunAl.ToList();
        }

        public void TarihiGecmisUrunCek() //Grid Control'e kayıtları çekiyor
        {
            string yıl = DateTime.Today.Year.ToString();
            string ay = DateTime.Today.Month.ToString();
            string gün = DateTime.Today.Day.ToString();
            if (int.Parse(ay) < 10)
            {
                ay = "0" + ay;
            }

            string bugün = yıl + "-" + ay + "-" + gün;
            DateTime bugun = Convert.ToDateTime(bugün);

            gcTarihiGecmis.Visible = true;
            gcSonSatislar.Visible = false;
            gcStokBiten.Visible = false;
            gcIadeler.Visible = false;

            var urunAl = from x in db.urunler
                         where x.tuketim_tarihi < bugun
                          select new
                          {
                              ÜrünID = x.Urun_id,
                              ÜrünAdı = x.Urun_adi,
                              Adet = x.stok,
                              TüketimTarihi = x.tuketim_tarihi,
                              ÜretimTarihi = x.uretim_tarihi,
                              Fiyat = x.fiyat,
                          };
            gcTarihiGecmis.DataSource = urunAl.ToList();
        }
        private void btnSon24SaatSatis_Click(object sender, EventArgs e)
        {
            Son24SaatSatislar();
        }

        private void RaporVeIstatistikFormu_Load(object sender, EventArgs e)
        {
        }

        private void btnStokBitenUrunler_Click(object sender, EventArgs e)
        {
            StokBitenUrunCek();
        }

        private void btnTarihiGecmisÜrünler_Click(object sender, EventArgs e)
        {
            TarihiGecmisUrunCek();
        }

        private void btnGunlukSatisRaporla_Click(object sender, EventArgs e)
        {
            GunSatislariRapor sonSatislarRapor = new GunSatislariRapor();
            ReportPrintTool printTool = new ReportPrintTool(sonSatislarRapor);
            UserLookAndFeel lookAndFeel = new UserLookAndFeel(this);
            lookAndFeel.UseDefaultLookAndFeel = false;
            lookAndFeel.SkinName = "Office 2016 Colorful";
            printTool.ShowRibbonPreview(lookAndFeel);
        }

        private void btnStokBitenRaporla_Click(object sender, EventArgs e)
        {
            StokBitenlerRapor stokBitenlerRaporu = new StokBitenlerRapor();
            ReportPrintTool printTool = new ReportPrintTool(stokBitenlerRaporu);
            UserLookAndFeel lookAndFeel = new UserLookAndFeel(this);
            lookAndFeel.UseDefaultLookAndFeel = false;
            lookAndFeel.SkinName = "Office 2016 Colorful";
            printTool.ShowRibbonPreview(lookAndFeel);
        }

        private void btnTarihiGecmisRaporla_Click(object sender, EventArgs e)
        {
            TarihiGecmisUrunlerRapor tarihiGecmisler = new TarihiGecmisUrunlerRapor();
            ReportPrintTool printTool = new ReportPrintTool(tarihiGecmisler);
            UserLookAndFeel lookAndFeel = new UserLookAndFeel(this);
            lookAndFeel.UseDefaultLookAndFeel = false;
            lookAndFeel.SkinName = "Office 2016 Colorful";
            printTool.ShowRibbonPreview(lookAndFeel);
        }

        private void btnIadeGoruntule_Click(object sender, EventArgs e)
        {
            IadeleriGoruntule();
        }
        public void IadeleriGoruntule() //Grid Control'e kayıtları çekiyor
        {
            string yıl = DateTime.Today.Year.ToString();
            string ay = DateTime.Today.Month.ToString();
            string gün = DateTime.Today.Day.ToString();
            if (int.Parse(ay) < 10)
            {
                ay = "0" + ay;
            }
            string bugün = yıl + "-" + ay + "-" + gün;

            gcSonSatislar.Visible = false;
            gcTarihiGecmis.Visible = false;
            gcStokBiten.Visible = false;
            gcIadeler.Visible = true;

            var iadeAl = from x in db.iadeler
                          where x.iade_tarih.ToString().Substring(0, 10) == bugün
                          select new
                          {
                              IadeID = x.iade_id,
                              ÜrünID = x.urun_id,
                              Neden = x.neden,
                              ÜrünAdı = x.urunler.Urun_adi,
                              ÜrünFiyatı = x.urunler.fiyat,
                              Adet = x.adet,
                              IadeTarihi = x.iade_tarih,
                              SatanKullanıcı = x.calisanlar.Kullanici_adi,
                          };
            gcIadeler.DataSource = iadeAl.ToList();
        }

        private void btnIadeRaporla_Click(object sender, EventArgs e)
        {
            GunlukIadeRapor gunlukIadeRapor = new GunlukIadeRapor();
            ReportPrintTool printTool = new ReportPrintTool(gunlukIadeRapor);
            UserLookAndFeel lookAndFeel = new UserLookAndFeel(this);
            lookAndFeel.UseDefaultLookAndFeel = false;
            lookAndFeel.SkinName = "Office 2016 Colorful";
            printTool.ShowRibbonPreview(lookAndFeel);
        }

    }
}
