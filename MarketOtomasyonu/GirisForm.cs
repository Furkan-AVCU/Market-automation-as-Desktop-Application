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
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }
        public static string kullaniciAdi;
        public static int calisanID; 
        CalisanAnaForm calisanAnaForm = new CalisanAnaForm();
        YoneticiAnaForm yoneticiAnaForm = new YoneticiAnaForm();
            MarketOtomasyonDBEntities db = new MarketOtomasyonDBEntities();
            private void btnGiris_Click(object sender, EventArgs e)
            {
                if(tebKullaniciadi.Text==string.Empty || tebParola.Text == string.Empty)
                {
                    XtraMessageBox.Show("Lütfen kullanıcı adı veya şifreyi boş bırakmayınız.", "Hata | Hikmet Market Uyarıyor ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    calisanlar kullaniciAdiAra = db.calisanlar.Where(x => x.Kullanici_adi == tebKullaniciadi.Text).FirstOrDefault();
                    if(kullaniciAdiAra !=null)
                    {
                        calisanlar calisanAra = db.calisanlar.Where(x => x.Kullanici_adi == tebKullaniciadi.Text && x.Parola == tebParola.Text).FirstOrDefault();
                        if (calisanAra != null)
                        {
                        calisanID = calisanAra.Calisan_id;
                        kullaniciAdi = calisanAra.Kullanici_adi;
                            if (calisanAra.roller.Rol_adi == "Yönetici")
                                {
                                yoneticiAnaForm.Show();
                                this.Hide();
                                }
                            else
                                {
                                calisanAnaForm.Show();
                                this.Hide();
                                }
                        }
                        else
                        {
                            XtraMessageBox.Show("Parolayı doğru girdiğinizden emin olun !", "Hata | Hikmet Market Uyarıyor ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else 
                    {
                        XtraMessageBox.Show("Kullanıcı adını doğru girdiğinizden emin olun !", "Hata | Hikmet Market Uyarıyor ! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                
                }
            }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GirisForm_Load(object sender, EventArgs e)
        {

        }
    }
}
