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
    public partial class CalisanIadeFormu : Form
    {
        public CalisanIadeFormu()
        {
            InitializeComponent();
        }
        MarketOtomasyonDBEntities db = new MarketOtomasyonDBEntities();
        //GirisForm gf = new GirisForm();
        public void IadeListele() //Grid Control'e kayıtları çekiyor
        {
            var iadeAl = from x in db.iadeler
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
            gridControl1.DataSource = iadeAl.ToList();
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

        private void CalisanIadeFormu_Load(object sender, EventArgs e)
        {
            IadeListele();
            cbUrunCek();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtNeden.Text = gridView1.GetFocusedRowCellValue("Neden").ToString();
            txtAdet.Text = gridView1.GetFocusedRowCellValue("Adet").ToString();
            deIadeTarihi.Text = gridView1.GetFocusedRowCellValue("IadeTarihi").ToString();
            cbUrun.Text = gridView1.GetFocusedRowCellValue("ÜrünAdı").ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtNeden.Text == string.Empty || txtNeden.Text == null || txtAdet.Text == string.Empty || txtAdet.Text == null || deIadeTarihi.Text == string.Empty
                || deIadeTarihi.Text == null || cbUrun.Text == string.Empty || cbUrun.Text == null)
            {
                XtraMessageBox.Show("Lütfen Bilgileri Tam giriniz", "Hata | Hikmet Market Uyarıyor ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var guncellenecekId = int.Parse(gridView1.GetFocusedRowCellValue("IadeID").ToString());
                var eskiAdet = int.Parse(gridView1.GetFocusedRowCellValue("Adet").ToString());
                if (guncellenecekId.ToString() == string.Empty)
                {
                    XtraMessageBox.Show("Güncelleme işleminde hata !", "Hata | Hikmet Market ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var iade = db.iadeler.Find(guncellenecekId);
                    iade.calisan_id = GirisForm.calisanID;
                    iade.urun_id = int.Parse(cbUrun.EditValue.ToString());
                    iade.neden = txtNeden.Text;
                    iade.adet = int.Parse(txtAdet.Text.ToString());
                    iade.iade_tarih = DateTime.Parse(deIadeTarihi.EditValue.ToString());
                    db.SaveChanges();
                    stokGuncelle(guncellenecekId, eskiAdet - int.Parse(txtAdet.Text));
                    XtraMessageBox.Show("Iade Güncellendi !", "Başarılı ! | Hikmet Market ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                IadeListele();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtNeden.Text == string.Empty || txtNeden.Text == null || txtAdet.Text == string.Empty || txtAdet.Text == null || deIadeTarihi.Text == string.Empty
                || deIadeTarihi.Text == null || cbUrun.Text == string.Empty || cbUrun.Text == null)
            {
                XtraMessageBox.Show("Lütfen Bilgileri Tam giriniz", "Hata | Hikmet Market Uyarıyor ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                iadeler iade = new iadeler();
                iade.calisan_id = GirisForm.calisanID;
                iade.urun_id = int.Parse(cbUrun.EditValue.ToString());
                iade.neden = txtNeden.Text;
                iade.adet = int.Parse(txtAdet.Text.ToString());
                iade.iade_tarih = DateTime.Parse(deIadeTarihi.EditValue.ToString());
                db.iadeler.Add(iade);
                db.SaveChanges();
                stokGuncelle(int.Parse(cbUrun.EditValue.ToString()), int.Parse(txtAdet.Text));

                XtraMessageBox.Show("Yeni İade eklendi ! !", "Başarılı | Hikmet Market  ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            IadeListele();
        }
        public void stokGuncelle(int id, int adet)
        {
            var urun = db.urunler.Find(id);
            try
            {
                if(adet != 0) {
                    urun.stok = adet + urun.stok;
                    db.SaveChanges();
                }
                else { }
            }
            catch
            {
                XtraMessageBox.Show("İade Almada hata oluştu ! !", "Hata | Hikmet Market  ! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHepsiniGoruntule_Click(object sender, EventArgs e)
        {
            IadeListele();
        }
    }
}
