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
    public partial class CalisanYonetimFormu : Form
    {
        public CalisanYonetimFormu()
        {
            InitializeComponent();
            
        }
        MarketOtomasyonDBEntities db = new MarketOtomasyonDBEntities();
        private void MarketYonetimFormu_Load(object sender, EventArgs e)
        {
            CalisanListele();
            cbRolCek();
        }
        public void CalisanListele() //Grid Control'e kayıtları çekiyor
        {
            var calisanlariAl = from x in db.calisanlar
                                select new
                                {
                                    ÇalışanID=x.Calisan_id,
                                    Ad=x.Calisan_adi,
                                    Soyad=x.Calisan_soyadi,
                                    TC=x.Calisan_tc,
                                    KullanıcıAdı=x.Kullanici_adi,
                                    Parola = x.Parola,
                                    Rol = x.roller.Rol_adi,
                                    
                                };
            gridControl1.DataSource = calisanlariAl.ToList();
        }

        private void btnYeniRolEkle_Click(object sender, EventArgs e)
        {
            if (txtYeniRol.Text == string.Empty || txtYeniRol.Text == null)
            {
                XtraMessageBox.Show("Lütfen Yeni Rol Adını Boş Bırakmayınız.", "Hata | Hikmet Market Uyarıyor ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (RolVarMi(txtYeniRol.Text)) //ZATEN BÖYLE BİR ROL VARSA
            {
                XtraMessageBox.Show("Bu Rol Zaten Kayıtlı !", "Hata | Hikmet Market Uyarıyor ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                roller rol = new roller();
                rol.Rol_adi = txtYeniRol.Text;
                if (rol != null)
                {
                    db.roller.Add(rol);
                    db.SaveChanges();
                    txtYeniRol.Text = "";
                    XtraMessageBox.Show("Yeni Rol Ekleme Başarılı !", "Başarılı ! | Hikmet Market ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Yeni rol eklemede sorun yaşandı !", "Hata | Hikmet Market Uyarıyor ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            cbRolCek();
        }

        private void cbRolCek() //ComboBox'a VERİLERİ ÇEKİYOR
        {
            var rolAl = (from x in db.roller
                         select new
                         {
                             x.Rol_adi,
                             x.Rol_id
                         }).ToList();

            cbRol.Properties.ValueMember = "Rol_id";
            cbRol.Properties.DisplayMember = "Rol_adi";
            cbRol.Properties.DataSource = rolAl;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(txtAdi.Text == string.Empty || txtAdi.Text == null||txtSoyad.Text == string.Empty || txtSoyad.Text == null ||txtTc.Text == string.Empty || txtTc.Text == null||txtKullaniciAdi.Text == string.Empty
                || txtKullaniciAdi.Text == null||txtParola.Text == string.Empty || txtParola.Text == null||cbRol.Properties.DisplayMember.ToString()==string.Empty)
            {
                    XtraMessageBox.Show("Lütfen Bilgileri Tam giriniz", "Hata | Hikmet Market Uyarıyor ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if (txtTc.Text.Length<11)
            {
                XtraMessageBox.Show("Lütfen TC numarasını 11 Hane olarak girin !", "Hata | Hikmet Market Uyarıyor ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                else if (TcVarMi(txtTc.Text) && KullaniciAdiVarMi(txtKullaniciAdi.Text)) // AYNI TC ve kullanıcı adıKULLANILMIŞ MI SORGUSU
                {
                    XtraMessageBox.Show("Bu Tc ve Kullanıcı adı Zaten Kayıtlı !", "Hata | Hikmet Market Uyarıyor ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    calisanlar calisan = new calisanlar();
                    calisan.Calisan_adi = txtAdi.Text;
                    calisan.Calisan_soyadi = txtSoyad.Text;
                    calisan.Calisan_tc = txtTc.Text;
                    calisan.Kullanici_adi = txtKullaniciAdi.Text;
                    calisan.Parola = txtParola.Text;
                    calisan.Rol_id = int.Parse(cbRol.EditValue.ToString());
                    db.calisanlar.Add(calisan);
                    db.SaveChanges();

                    XtraMessageBox.Show("Yeni Çalışan eklendi ! !", "Büyüyoruz | Hikmet Market Seviniyor ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            CalisanListele();
        }


        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtAdi.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            txtSoyad.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
            txtTc.Text = gridView1.GetFocusedRowCellValue("TC").ToString();
            txtKullaniciAdi.Text = gridView1.GetFocusedRowCellValue("KullanıcıAdı").ToString();
            txtParola.Text = gridView1.GetFocusedRowCellValue("Parola").ToString();
            cbRol.Text = gridView1.GetFocusedRowCellValue("Rol").ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Dikkat ! Çalışanı silerseniz bu çalışanın yaptığı bütün işlemleri silmiş olursunuz ! Çalışanı silmek istediğinizden emin misiniz ?", "Emin misin ? | Hikmet Market Uyarıyor ! ", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) != DialogResult.No) {
                var silinecekId = int.Parse(gridView1.GetFocusedRowCellValue("ÇalışanID").ToString());
                if (silinecekId.ToString() == string.Empty)
                {
                    XtraMessageBox.Show("Silme işleminde hata !", "Hata | Hikmet Market ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var silinecekCalisan = (from x in db.calisanlar
                                            where x.Calisan_id == silinecekId
                                            select x).FirstOrDefault();
                    db.calisanlar.Remove(silinecekCalisan);
                    db.SaveChanges();
                    CalisanListele();
                    XtraMessageBox.Show("Çalışan Silindi !", "Küçüldük | Hikmet Market ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text == string.Empty || txtAdi.Text == null || txtSoyad.Text == string.Empty || txtSoyad.Text == null || txtTc.Text == string.Empty || txtTc.Text == null || txtKullaniciAdi.Text == string.Empty
                || txtKullaniciAdi.Text == null || txtParola.Text == string.Empty || txtParola.Text == null || cbRol.Properties.DisplayMember.ToString() == string.Empty)
            {
                XtraMessageBox.Show("Lütfen Bilgileri Tam giriniz", "Hata | Hikmet Market Uyarıyor ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtTc.Text.Length < 11)
            {
                XtraMessageBox.Show("Lütfen TC numarasını 11 Hane olarak girin !", "Hata | Hikmet Market Uyarıyor ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var guncellenecekId = int.Parse(gridView1.GetFocusedRowCellValue("ÇalışanID").ToString());
                if (guncellenecekId.ToString() == string.Empty)
                {
                    XtraMessageBox.Show("Güncelleme işleminde hata !", "Hata | Hikmet Market ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string eskiTc = gridView1.GetFocusedRowCellValue("TC").ToString();
                    var calisan = db.calisanlar.Find(guncellenecekId);
                    if (eskiTc==txtTc.Text)
                    {
                        calisan.Calisan_adi = txtAdi.Text;
                        calisan.Calisan_soyadi = txtSoyad.Text;
                        calisan.Calisan_tc = txtTc.Text;
                        calisan.Kullanici_adi = txtKullaniciAdi.Text;
                        calisan.Parola = txtParola.Text;
                        calisan.Rol_id = int.Parse(cbRol.EditValue.ToString());
                        db.SaveChanges();
                        XtraMessageBox.Show("Çalışan Güncellendi !", "Başarılı ! | Hikmet Market ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        try {
                            var calisanTc = from x in db.calisanlar
                                            where x.Calisan_tc == txtTc.Text
                                            select x;
                            if (calisanTc.ToList() == null || calisanTc.Count() == 0)
                            {
                                calisan.Calisan_adi = txtAdi.Text;
                                calisan.Calisan_soyadi = txtSoyad.Text;
                                calisan.Calisan_tc = txtTc.Text;
                                calisan.Kullanici_adi = txtKullaniciAdi.Text;
                                calisan.Parola = txtParola.Text;
                                calisan.Rol_id = int.Parse(cbRol.EditValue.ToString());
                                db.SaveChanges();
                                XtraMessageBox.Show("Çalışan Güncellendi !", "Başarılı ! | Hikmet Market ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                XtraMessageBox.Show("Bu Tc Zaten Kayıtlı !", "Hata | Hikmet Market Uyarıyor ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch
                        {
                            XtraMessageBox.Show("Güncelleme işleminde hata !", "Hata | Hikmet Market ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                CalisanListele();
            }
        }
        private bool TcVarMi(string tc) //ZATEN TC KAYITLI MI KONTROLÜ
        {
            bool varmi = false;
            //string varOlanTc= gridView1.GetFocusedRowCellValue("TC").ToString();
            var tcAra = (from x in db.calisanlar
                         where x.Calisan_tc.ToString() == tc
                         select x).FirstOrDefault();
            if (tcAra == null)//YOKSA
            {
                    varmi = false;
                    return varmi; 
            }
            else
            {
                varmi = true;
                return varmi;
            }
        }

        private bool KullaniciAdiVarMi(string kullaniciadi) //AYNI KULLANICI ADI VAR MI
        {
            bool varmi = false;
            //string varOlanKa = gridView1.GetFocusedRowCellValue("KullanıcıAdı").ToString();
            var kaAra = (from x in db.calisanlar
                         where x.Kullanici_adi.ToString() == kullaniciadi
                         select x).FirstOrDefault();
            if (kaAra == null)//YOKSA
            {
                    varmi = false;
                    return varmi;
            }
            else //VARSA
            {
                varmi = true;
                return varmi;
            }
        }

        private bool RolVarMi(string rol) //ZATEN BÖYLE BİR ROL VAR MI KONTROLÜ YAPIYOR
        {
            bool varmi = false;
            var rolAra = (from x in db.roller
                          where x.Rol_adi.ToString() == rol
                          select x).FirstOrDefault();
            if (rolAra == null)//YOKSA
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

        private void btnCalisanlarinHepsiniGoster_Click(object sender, EventArgs e)
        {
            CalisanListele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtAranacakMetin.Text == string.Empty || txtAranacakMetin.Text == null)
            {
                XtraMessageBox.Show("Lütfen Boş Kutucuk Bırakmayınız !", "Hata ! | Hikmet Market Uyarıyor ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                 
                        var calisanlariAl = from x in db.calisanlar
                                            where x.Calisan_tc.Contains(txtAranacakMetin.Text.ToString()) && x.Calisan_tc.StartsWith(txtAranacakMetin.Text.Substring(0, txtAranacakMetin.Text.Length))
                                            select new
                                            {
                                                ÇalışanID = x.Calisan_id,
                                                Ad = x.Calisan_adi,
                                                Soyad = x.Calisan_soyadi,
                                                TC = x.Calisan_tc,
                                                KullanıcıAdı = x.Kullanici_adi,
                                                Parola = x.Parola,
                                                Rol = x.roller.Rol_adi,

                                            };
                    if (calisanlariAl.ToList()==null||calisanlariAl.Count()==0)
                    {
                        XtraMessageBox.Show("Aranan Çalışan Bulunamadı !", "Hata ! | Hikmet Market Uyarıyor ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else { gridControl1.DataSource = calisanlariAl.ToList(); }
                
            }
        }
    }
}
