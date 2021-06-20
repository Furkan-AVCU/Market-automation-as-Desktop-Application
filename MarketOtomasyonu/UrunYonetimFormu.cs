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

namespace MarketOtomasyonu
{
    public partial class UrunYonetimFormu : Form
    {
        public UrunYonetimFormu()
        {
            InitializeComponent();
        }
        MarketOtomasyonDBEntities db = new MarketOtomasyonDBEntities();
        private void txtAlisFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 44 && txtAlisFiyat.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 44 && txtFiyat.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void txtStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        public void UrunListele() //Grid Control'e kayıtları çekiyor
        {
            var urunlerAl = from x in db.urunler
                                select new
                                {
                                    ÜrünID = x.Urun_id,
                                    Ad = x.Urun_adi,
                                    Fiyat = x.fiyat,
                                    Stok = x.stok,
                                    AlışFiyatı=x.alis_fiyat,
                                    Kategori = x.kategoriler.Kategori_adi,
                                    ÜretimTarihi = x.uretim_tarihi,
                                    TüketimTarihi = x.tuketim_tarihi,

                                };
            gridControl1.DataSource = urunlerAl.ToList();
        }

        private void btnHepsiniGoruntule_Click(object sender, EventArgs e)
        {
            UrunListele();
        }

        private void UrunYonetimFormu_Load(object sender, EventArgs e)
        {
            UrunListele();
            cbKategoriCek();
        }
        private void cbKategoriCek() //ComboBox'a VERİLERİ ÇEKİYOR
        {
            var KategoriAl = (from x in db.kategoriler
                         select new
                         {
                             Kategori=x.Kategori_adi,
                             ID=x.Kategori_id
                         }).ToList();

            cbKategori.Properties.ValueMember = "ID";
            cbKategori.Properties.DisplayMember = "Kategori";
            cbKategori.Properties.DataSource = KategoriAl;
        }

        private bool KategoriVarMi(string kategori) //ZATEN BÖYLE BİR KATEGORİ VAR MI KONTROLÜ YAPIYOR
        {
            bool varmi = false;
            var kategoriAra = (from x in db.kategoriler
                          where x.Kategori_adi.ToString() == kategori
                          select x).FirstOrDefault();
            if (kategoriAra == null)//YOKSA
            {
                varmi = false;
                return varmi;
            }
            else//VARSA
            {
                varmi = true;
                return varmi;
            }
        }

        private void btnYeniKategoriEkle_Click(object sender, EventArgs e)
        {
            if (txtYeniKategori.Text == string.Empty || txtYeniKategori.Text == null)
            {
                XtraMessageBox.Show("Lütfen Yeni Kategori Adını Boş Bırakmayınız.", "Hata | Hikmet Market Uyarıyor ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (KategoriVarMi(txtYeniKategori.Text)) //ZATEN BÖYLE BİR KATEGORİ VARSA
            {
                XtraMessageBox.Show("Bu Kategori Zaten Kayıtlı !", "Hata | Hikmet Market Uyarıyor ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                kategoriler kategori = new kategoriler();
                kategori.Kategori_adi = txtYeniKategori.Text;
                if (kategori != null)
                {
                    db.kategoriler.Add(kategori);
                    db.SaveChanges();
                    txtYeniKategori.Text = "";
                    XtraMessageBox.Show("Yeni Kategori Ekleme Başarılı !", "Başarılı ! | Hikmet Market ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Yeni Kategori eklemede sorun yaşandı !", "Hata | Hikmet Market Uyarıyor ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            cbKategoriCek();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text == string.Empty || txtAdi.Text == null || txtAlisFiyat.Text == string.Empty || txtAlisFiyat.Text == null || txtFiyat.Text == string.Empty || txtFiyat.Text == null || txtStok.Text == string.Empty
                || txtStok.Text == null || deTuketim.Text == string.Empty || deTuketim.Text == null || deUretim.Text == string.Empty ||deUretim.Text==null)
            {
                XtraMessageBox.Show("Lütfen Bilgileri Tam giriniz", "Hata | Hikmet Market Uyarıyor ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                urunler urun = new urunler();
                urun.Urun_adi = txtAdi.Text;
                urun.fiyat = float.Parse(txtFiyat.Text.ToString());
                urun.alis_fiyat = float.Parse(txtAlisFiyat.Text.ToString());
                urun.stok = int.Parse(txtStok.Text.ToString());
                urun.tuketim_tarihi = DateTime.Parse(deTuketim.EditValue.ToString());
                urun.uretim_tarihi = DateTime.Parse(deUretim.EditValue.ToString());
                urun.Kategori_id = int.Parse(cbKategori.EditValue.ToString());
                db.urunler.Add(urun);
                db.SaveChanges();

                XtraMessageBox.Show("Yeni Ürün eklendi ! !", "Büyüyoruz | Hikmet Market ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            UrunListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Dikkat ! Bu Ürünü silerseniz bu ürün ile ilgili bütün kayıtları silmiş olursunuz ! Ürünü silmek istediğinizden emin misiniz ?", "Emin misin ? | Hikmet Market Uyarıyor ! ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.No)
            {
                var silinecekId = int.Parse(gridView1.GetFocusedRowCellValue("ÜrünID").ToString());
                if (silinecekId.ToString() == string.Empty)
                {
                    XtraMessageBox.Show("Silme işleminde hata !", "Hata | Hikmet Market ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var silinecekUrun = (from x in db.urunler
                                         where x.Urun_id == silinecekId
                                         select x).FirstOrDefault();
                    db.urunler.Remove(silinecekUrun);
                    db.SaveChanges();
                    XtraMessageBox.Show("Ürün Silindi !", "Başarılı | Hikmet Market ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                UrunListele();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtAdi.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            txtFiyat.Text = gridView1.GetFocusedRowCellValue("Fiyat").ToString();
            txtAlisFiyat.Text = gridView1.GetFocusedRowCellValue("AlışFiyatı").ToString();
            txtStok.Text = gridView1.GetFocusedRowCellValue("Stok").ToString();
            deTuketim.Text = gridView1.GetFocusedRowCellValue("TüketimTarihi").ToString();
            deUretim.Text = gridView1.GetFocusedRowCellValue("ÜretimTarihi").ToString();
            cbKategori.Text = gridView1.GetFocusedRowCellValue("Kategori").ToString();
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text == string.Empty || txtAdi.Text == null || txtAlisFiyat.Text == string.Empty || txtAlisFiyat.Text == null || txtFiyat.Text == string.Empty || txtFiyat.Text == null || txtStok.Text == string.Empty
                || txtStok.Text == null || deTuketim.Text == string.Empty || deTuketim.Text == null || deUretim.Text == string.Empty || deUretim.Text == null||cbKategori.Text==string.Empty||cbKategori.Text==null)
            {
                XtraMessageBox.Show("Lütfen Bilgileri Tam giriniz", "Hata | Hikmet Market Uyarıyor ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var guncellenecekId = int.Parse(gridView1.GetFocusedRowCellValue("ÜrünID").ToString());
                if (guncellenecekId.ToString() == string.Empty)
                {
                    XtraMessageBox.Show("Güncelleme işleminde hata !", "Hata | Hikmet Market ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var urun = db.urunler.Find(guncellenecekId);
                    urun.Urun_adi = txtAdi.Text;
                    urun.fiyat = float.Parse(txtFiyat.Text.ToString());
                    urun.alis_fiyat = float.Parse(txtAlisFiyat.Text.ToString());
                    urun.stok = int.Parse(txtStok.Text.ToString());
                    urun.tuketim_tarihi = DateTime.Parse(deTuketim.EditValue.ToString());
                    urun.uretim_tarihi = DateTime.Parse(deUretim.EditValue.ToString());
                    urun.Kategori_id = int.Parse(cbKategori.EditValue.ToString());
                    db.SaveChanges();
                    XtraMessageBox.Show("Ürün Güncellendi !", "Başarılı ! | Hikmet Market ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                UrunListele();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtAranacakUrunAdi.Text == string.Empty || txtAranacakUrunAdi.Text == null)
            {
                XtraMessageBox.Show("Lütfen Boş Kutucuk Bırakmayınız !", "Hata ! | Hikmet Market Uyarıyor ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                var urunAl = from x in db.urunler
                                    where x.Urun_adi.Contains(txtAranacakUrunAdi.Text.ToString())&& x.Urun_adi.StartsWith(txtAranacakUrunAdi.Text.Substring(0,txtAranacakUrunAdi.Text.Length))
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
    }
}
