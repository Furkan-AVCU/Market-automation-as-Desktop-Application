using DevExpress.XtraEditors;
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
    public partial class UrunSatısFormu : Form
    {
        public UrunSatısFormu()
        {
            InitializeComponent();
        }
        //GirisForm gf = new GirisForm();
        MarketOtomasyonDBEntities db = new MarketOtomasyonDBEntities();
        float ToplamTutar = 0;
        public void UrunListele() //Grid Control'e kayıtları çekiyor
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

            var urunlerAl = from x in db.urunler
                            where x.stok>0 && x.tuketim_tarihi >=bugun
                            select new
                            {
                                ÜrünID = x.Urun_id,
                                Ad = x.Urun_adi,
                                Fiyat = x.fiyat,
                                Stok = x.stok,
                                AlışFiyatı = x.alis_fiyat,
                                Kategori = x.kategoriler.Kategori_adi,
                                ÜretimTarihi = x.uretim_tarihi,
                                TüketimTarihi = x.tuketim_tarihi,

                            };
            gridControl1.DataSource = urunlerAl.ToList();
        }

        private void UrunSatısFormu_Load(object sender, EventArgs e)
        {
            UrunListele();
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            int kacUrun = lbcUrunID.ItemCount;
            if (kacUrun == 0)
            {
                XtraMessageBox.Show("Sepet Boşken Satış Yapamazsınız ! ", "Hata ! | Hikmet Market Uyarıyor ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
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
                for (int i = 0; i < kacUrun; i++)
                {
                    int satanID = GirisForm.calisanID;
                    int urunID = int.Parse(lbcUrunID.GetItem(i).ToString());
                    float satisFiyat = float.Parse(lbcFiyat.GetItem(i).ToString());
                    int adet = int.Parse(lbcAdet.GetItem(i).ToString());
                    satisYap(satanID, urunID, satisFiyat, bugun, adet);
                }
                UrunListele();
                temizle();
                btnSatisYap.Refresh();
                XtraMessageBox.Show("Satış Başarılı !", " Başarılı ! | Hikmet Market Seviniyor !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void satisYap(int calisanID,int urunID,float satisFiyat,DateTime satisTarihi,int adet)
        {
            satislar satis = new satislar();
            satis.calisan_id = GirisForm.calisanID;
            satis.urun_id = urunID;
            satis.satis_fiyat = satisFiyat;
            satis.satis_tarihi = satisTarihi;
            satis.adet = adet;
            db.satislar.Add(satis);
            db.SaveChanges();
            stokGuncelle(urunID, adet);
        }
        public void stokGuncelle(int id, int adet)
        {
            var urun = db.urunler.Find(id);
            urun.stok = urun.stok-adet;
            db.SaveChanges();
        }

        private void btnUrunAra_Click(object sender, EventArgs e)
        {
            if (txtAranacakUrunAdi.Text == string.Empty || txtAranacakUrunAdi.Text == null)
            {
                XtraMessageBox.Show("Lütfen Ürün Adı Giriniz !", "Hata ! | Hikmet Market Uyarıyor ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
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

                var urunAl = from x in db.urunler
                             where x.stok > 0 && x.tuketim_tarihi >= bugun && x.Urun_adi.Contains(txtAranacakUrunAdi.Text.ToString()) && x.Urun_adi.StartsWith(txtAranacakUrunAdi.Text.Substring(0, txtAranacakUrunAdi.Text.Length))
                             select new
                             {
                                 ÜrünID = x.Urun_id,
                                 Ad = x.Urun_adi,
                                 Fiyat = x.fiyat,
                                 Stok = x.stok,
                                 AlışFiyatı = x.alis_fiyat,
                                 Kategori = x.kategoriler.Kategori_adi,
                                 ÜretimTarihi = x.uretim_tarihi,
                                 TüketimTarihi = x.tuketim_tarihi,

                             };
                if (urunAl.ToList() == null || urunAl.Count() == 0)
                {
                    XtraMessageBox.Show("Aranan Ürün Bulunamadı !", "Hata ! | Hikmet Market Uyarıyor ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { gridControl1.DataSource = urunAl.ToList(); }

            }
        }

        private void btnHepsiniGoruntule_Click(object sender, EventArgs e)
        {
            UrunListele();
        }

        

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            cbAdet.Properties.Items.Clear();
            cbAdet.Text = "";
            string maxAdetString = gridView1.GetFocusedRowCellValue("Stok").ToString();
            int maxAdet = int.Parse(maxAdetString);
            for (int i = 1; i <= maxAdet; i++)
            {
                cbAdet.Properties.Items.Add(i);
            }
        }

        private void cbAdet_Properties_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (cbAdet.Text == string.Empty || cbAdet.Text == null)
            {
                XtraMessageBox.Show("Lütfen Ürün Adedi Seçiniz ! ", "Hata | Hikmet Market Uyarıyor ! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string adetFiyatString=gridView1.GetFocusedRowCellValue("Fiyat").ToString();
                    float adetFiyat = float.Parse(adetFiyatString);
                    int adet = int.Parse(cbAdet.Text);
                    float Fiyat = adetFiyat * adet;//listbox'a eklenecek olan fiyat
                    ToplamTutar += Fiyat; //Sepet Tutarı
                    lblToplamTutar.Text = ToplamTutar.ToString();

                    lbcFiyat.Items.Add(Fiyat); //Listbox'a Fiyat Ekleme
                    lbcUrunID.Items.Add(gridView1.GetFocusedRowCellValue("ÜrünID").ToString());
                    lbcUrunAdi.Items.Add(gridView1.GetFocusedRowCellValue("Ad").ToString());
                    lbcKategoriAdi.Items.Add(gridView1.GetFocusedRowCellValue("Kategori").ToString());
                    lbcAdet.Items.Add(cbAdet.Text);
                }
                catch
                {
                    XtraMessageBox.Show("Sepete Ürün Ekleme'de Hata oluştu ! ", "Hata | Hikmet Market Uyarıyor ! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }
        public void temizle()
        {
            lbcAdet.Items.Clear();
            lbcFiyat.Items.Clear();
            lbcKategoriAdi.Items.Clear();
            lbcUrunAdi.Items.Clear();
            lbcUrunID.Items.Clear();
            lblToplamTutar.Text = "";
        }
    }
}
