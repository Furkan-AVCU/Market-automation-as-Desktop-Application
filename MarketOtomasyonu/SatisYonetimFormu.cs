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
    public partial class SatisYonetimFormu : Form
    {
        public SatisYonetimFormu()
        {
            InitializeComponent();
        }
        MarketOtomasyonDBEntities db = new MarketOtomasyonDBEntities();
        public void SatisListele() //Grid Control'e kayıtları çekiyor
        {
            var satisAl = from x in db.satislar
                          select new
                          {
                              SatışID= x.satis_id,
                              ÜrünID = x.urun_id,
                              ÜrünAdı = x.urunler.Urun_adi,
                              SatışFiyatı = x.satis_fiyat,
                              Adet = x.adet,
                              SatışTarihi = x.satis_tarihi,
                              SatanKullanıcı = x.calisanlar.Kullanici_adi,
                            };
            gridControl1.DataSource = satisAl.ToList();
        }

        private void cbCalisanCek() //ComboBox'a VERİLERİ ÇEKİYOR
        {
            var CalisanKaAl = (from x in db.calisanlar
                               select new
                               {
                                   KullanıcıAdı = x.Kullanici_adi,
                                   ÇalışanAdı = x.Calisan_adi,
                                   ID = x.Calisan_id
                               }).ToList();

            cbCalisan.Properties.ValueMember = "ID";
            cbCalisan.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("KullanıcıAdı"));
            cbCalisan.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ÇalışanAdı"));
            cbCalisan.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID"));
            cbCalisan.Properties.DisplayMember = "KullanıcıAdı";
            cbCalisan.Properties.DataSource = CalisanKaAl;
        }

        private void cbUrunCek() //ComboBox'a VERİLERİ ÇEKİYOR
        {
            var UrunAl = (from x in db.urunler
                               select new
                               {
                                   ÜrünAdı = x.Urun_adi,
                                   Kategori = x.kategoriler.Kategori_adi,
                                   ID = x.Urun_id
                               }).ToList();

            cbUrun.Properties.ValueMember = "ID";
            cbUrun.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ÜrünAdı"));
            cbUrun.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kategori"));
            cbUrun.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID"));
            cbUrun.Properties.DisplayMember = "ÜrünAdı";
            cbUrun.Properties.DataSource = UrunAl;
        }

        private void SatisYonetimFormu_Load(object sender, EventArgs e)
        {
            SatisListele();
            cbCalisanCek();
            cbUrunCek();
        }

        private void btnHepsiniGoruntule_Click(object sender, EventArgs e)
        {
            SatisListele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtAdi.Text = gridView1.GetFocusedRowCellValue("ÜrünAdı").ToString();
            txtSatisFiyat.Text = gridView1.GetFocusedRowCellValue("SatışFiyatı").ToString();
            txtAdet.Text = gridView1.GetFocusedRowCellValue("Adet").ToString();
            deSatisTarihi.Text = gridView1.GetFocusedRowCellValue("SatışTarihi").ToString();
            cbCalisan.Text = gridView1.GetFocusedRowCellValue("SatanKullanıcı").ToString();
            cbUrun.Text = gridView1.GetFocusedRowCellValue("ÜrünAdı").ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var silinecekId = int.Parse(gridView1.GetFocusedRowCellValue("SatışID").ToString());
            var eskiAdet = int.Parse(gridView1.GetFocusedRowCellValue("Adet").ToString());
            if (silinecekId.ToString() == string.Empty)
            {
                XtraMessageBox.Show("Silme işleminde hata !", "Hata | Hikmet Market ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var silinecekSatiş = (from x in db.satislar
                                     where x.satis_id == silinecekId
                                     select x).FirstOrDefault();
                db.satislar.Remove(silinecekSatiş);
                db.SaveChanges();
                stokGuncelle(silinecekId, eskiAdet);
                XtraMessageBox.Show("Satış Silindi !", "Başarılı | Hikmet Market ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            SatisListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text == string.Empty || txtAdi.Text == null || txtAdet.Text == string.Empty || txtAdet.Text == null || txtSatisFiyat.Text == string.Empty || txtSatisFiyat.Text == null || deSatisTarihi.Text == string.Empty
                || deSatisTarihi.Text == null || cbCalisan.Text == string.Empty || cbCalisan.Text == null || cbUrun.Text == string.Empty || cbUrun.Text == null)
            {
                XtraMessageBox.Show("Lütfen Bilgileri Tam giriniz", "Hata | Hikmet Market Uyarıyor ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var guncellenecekId = int.Parse(gridView1.GetFocusedRowCellValue("SatışID").ToString());
                var eskiAdet = int.Parse(gridView1.GetFocusedRowCellValue("Adet").ToString());
                if (guncellenecekId.ToString() == string.Empty)
                {
                    XtraMessageBox.Show("Güncelleme işleminde hata !", "Hata | Hikmet Market ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var satis = db.satislar.Find(guncellenecekId);
                    satis.calisan_id = int.Parse(cbCalisan.EditValue.ToString());
                    satis.urun_id = int.Parse(cbUrun.EditValue.ToString());
                    satis.satis_fiyat = float.Parse(txtSatisFiyat.Text.ToString());
                    satis.adet = int.Parse(txtAdet.Text.ToString());
                    satis.satis_tarihi = DateTime.Parse(deSatisTarihi.EditValue.ToString());
                    stokGuncelle(guncellenecekId, eskiAdet - int.Parse(txtAdet.Text.ToString()));
                    db.SaveChanges();
                    XtraMessageBox.Show("Satış Güncellendi !", "Başarılı ! | Hikmet Market ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                SatisListele();
            }
        }

        public void stokGuncelle(int id,int adet)
        {
            var urun = db.urunler.Find(id);
            urun.stok = adet + urun.stok;
            db.SaveChanges();
        }

        private void txtSatisFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 44 && txtSatisFiyat.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    }
    
}
