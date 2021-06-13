
namespace MarketOtomasyonu
{
    partial class YoneticiAnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiAnaForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnCalisanYoneticiFormuAc = new DevExpress.XtraBars.BarButtonItem();
            this.btnUrunYonetimiFormuAc = new DevExpress.XtraBars.BarButtonItem();
            this.btnSatisYonetimiFormuAc = new DevExpress.XtraBars.BarButtonItem();
            this.btnIadeYonetimFormuAc = new DevExpress.XtraBars.BarButtonItem();
            this.btnRaporVeIstatistikFormuAc = new DevExpress.XtraBars.BarButtonItem();
            this.btnSatisEkrani = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ribbonControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Orange;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnCalisanYoneticiFormuAc,
            this.btnUrunYonetimiFormuAc,
            this.btnSatisYonetimiFormuAc,
            this.btnIadeYonetimFormuAc,
            this.btnRaporVeIstatistikFormuAc,
            this.btnSatisEkrani});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbonControl1.Size = new System.Drawing.Size(978, 146);
            // 
            // btnCalisanYoneticiFormuAc
            // 
            this.btnCalisanYoneticiFormuAc.Caption = "Çalışan Yönetimi Paneli";
            this.btnCalisanYoneticiFormuAc.Id = 1;
            this.btnCalisanYoneticiFormuAc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCalisanYoneticiFormuAc.ImageOptions.SvgImage")));
            this.btnCalisanYoneticiFormuAc.Name = "btnCalisanYoneticiFormuAc";
            this.btnCalisanYoneticiFormuAc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnCalisanYoneticiFormuAc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCalisanYoneticiFormuAc_ItemClick);
            // 
            // btnUrunYonetimiFormuAc
            // 
            this.btnUrunYonetimiFormuAc.Caption = "Ürün Yönetimi Paneli";
            this.btnUrunYonetimiFormuAc.Id = 2;
            this.btnUrunYonetimiFormuAc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUrunYonetimiFormuAc.ImageOptions.SvgImage")));
            this.btnUrunYonetimiFormuAc.Name = "btnUrunYonetimiFormuAc";
            this.btnUrunYonetimiFormuAc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrunYonetimiFormuAc_ItemClick);
            // 
            // btnSatisYonetimiFormuAc
            // 
            this.btnSatisYonetimiFormuAc.Caption = "Satış Yönetimi Paneli";
            this.btnSatisYonetimiFormuAc.Id = 3;
            this.btnSatisYonetimiFormuAc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSatisYonetimiFormuAc.ImageOptions.SvgImage")));
            this.btnSatisYonetimiFormuAc.Name = "btnSatisYonetimiFormuAc";
            this.btnSatisYonetimiFormuAc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSatisYonetimiFormuAc_ItemClick);
            // 
            // btnIadeYonetimFormuAc
            // 
            this.btnIadeYonetimFormuAc.Caption = "İade Yönetimi Paneli";
            this.btnIadeYonetimFormuAc.Id = 4;
            this.btnIadeYonetimFormuAc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnIadeYonetimFormuAc.ImageOptions.SvgImage")));
            this.btnIadeYonetimFormuAc.Name = "btnIadeYonetimFormuAc";
            this.btnIadeYonetimFormuAc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIadeYonetimFormuAc_ItemClick);
            // 
            // btnRaporVeIstatistikFormuAc
            // 
            this.btnRaporVeIstatistikFormuAc.Caption = "Rapor ve İstatistik ";
            this.btnRaporVeIstatistikFormuAc.Id = 5;
            this.btnRaporVeIstatistikFormuAc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRaporVeIstatistikFormuAc.ImageOptions.SvgImage")));
            this.btnRaporVeIstatistikFormuAc.Name = "btnRaporVeIstatistikFormuAc";
            this.btnRaporVeIstatistikFormuAc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnRaporVeIstatistikFormuAc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRaporVeIstatistikFormuAc_ItemClick);
            // 
            // btnSatisEkrani
            // 
            this.btnSatisEkrani.Caption = "Satış Ekranı";
            this.btnSatisEkrani.Id = 6;
            this.btnSatisEkrani.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSatisEkrani.ImageOptions.SvgImage")));
            this.btnSatisEkrani.Name = "btnSatisEkrani";
            this.btnSatisEkrani.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSatisEkrani_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ana Sayfa";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCalisanYoneticiFormuAc);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUrunYonetimiFormuAc);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSatisYonetimiFormuAc);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnIadeYonetimFormuAc);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Yönetim Panelleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPageGroup2.ImageOptions.SvgImage")));
            this.ribbonPageGroup2.ItemLinks.Add(this.btnRaporVeIstatistikFormuAc);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Rapor Ve İstatistikler";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ImageOptions.Image = global::MarketOtomasyonu.Properties.Resources.markettttt1;
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSatisEkrani);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "                                                       ";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // simpleButton1
            // 
            this.simpleButton1.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.simpleButton1.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton1.BackgroundImage = global::MarketOtomasyonu.Properties.Resources.orange;
            this.simpleButton1.Enabled = false;
            this.simpleButton1.Location = new System.Drawing.Point(153, 1);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(825, 53);
            this.simpleButton1.TabIndex = 3;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.BackgroundImage = global::MarketOtomasyonu.Properties.Resources.orange;
            this.simpleButton2.Enabled = false;
            this.simpleButton2.Location = new System.Drawing.Point(29, 0);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(949, 26);
            this.simpleButton2.TabIndex = 4;
            // 
            // YoneticiAnaForm
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 626);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Image = global::MarketOtomasyonu.Properties.Resources.markettttt1;
            this.IsMdiContainer = true;
            this.Name = "YoneticiAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HİKMET MARKET | Yönetici Ana Sayfası";
            this.Load += new System.EventHandler(this.YoneticiAnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnCalisanYoneticiFormuAc;
        private DevExpress.XtraBars.BarButtonItem btnUrunYonetimiFormuAc;
        private DevExpress.XtraBars.BarButtonItem btnSatisYonetimiFormuAc;
        private DevExpress.XtraBars.BarButtonItem btnIadeYonetimFormuAc;
        private DevExpress.XtraBars.BarButtonItem btnRaporVeIstatistikFormuAc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnSatisEkrani;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}