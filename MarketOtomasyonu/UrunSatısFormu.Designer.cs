
namespace MarketOtomasyonu
{
    partial class UrunSatısFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunSatısFormu));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnSepeteEkle = new DevExpress.XtraEditors.SimpleButton();
            this.cbAdet = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnHepsiniGoruntule = new DevExpress.XtraEditors.SimpleButton();
            this.btnUrunAra = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtAranacakUrunAdi = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lbcFiyat = new DevExpress.XtraEditors.ListBoxControl();
            this.lbcKategoriAdi = new DevExpress.XtraEditors.ListBoxControl();
            this.lbcAdet = new DevExpress.XtraEditors.ListBoxControl();
            this.lbcUrunAdi = new DevExpress.XtraEditors.ListBoxControl();
            this.lbcUrunID = new DevExpress.XtraEditors.ListBoxControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.lblToplamTutar = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnSatisYap = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAdet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAranacakUrunAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbcFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbcKategoriAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbcAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbcUrunAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbcUrunID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(314, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(648, 263);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSepeteEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSepeteEkle.Appearance.Options.UseBackColor = true;
            this.btnSepeteEkle.Appearance.Options.UseFont = true;
            this.btnSepeteEkle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSepeteEkle.ImageOptions.SvgImage")));
            this.btnSepeteEkle.Location = new System.Drawing.Point(155, 67);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(117, 39);
            this.btnSepeteEkle.TabIndex = 2;
            this.btnSepeteEkle.Text = "SEPETE EKLE";
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // cbAdet
            // 
            this.cbAdet.Location = new System.Drawing.Point(91, 32);
            this.cbAdet.Name = "cbAdet";
            this.cbAdet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbAdet.Properties.Appearance.Options.UseFont = true;
            this.cbAdet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbAdet.Properties.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAdet_Properties_KeyPress);
            this.cbAdet.Size = new System.Drawing.Size(181, 26);
            this.cbAdet.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(22, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 19);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "ADET :";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.btnHepsiniGoruntule);
            this.groupControl1.Controls.Add(this.btnUrunAra);
            this.groupControl1.Controls.Add(this.groupControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtAranacakUrunAdi);
            this.groupControl1.Location = new System.Drawing.Point(16, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(288, 263);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "ÜRÜN ARAMA VE ADET BİLGİSİ";
            // 
            // btnHepsiniGoruntule
            // 
            this.btnHepsiniGoruntule.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHepsiniGoruntule.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnHepsiniGoruntule.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnHepsiniGoruntule.Appearance.Options.UseBackColor = true;
            this.btnHepsiniGoruntule.Appearance.Options.UseFont = true;
            this.btnHepsiniGoruntule.Appearance.Options.UseForeColor = true;
            this.btnHepsiniGoruntule.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHepsiniGoruntule.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHepsiniGoruntule.AppearancePressed.Options.UseBackColor = true;
            this.btnHepsiniGoruntule.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHepsiniGoruntule.ImageOptions.SvgImage")));
            this.btnHepsiniGoruntule.Location = new System.Drawing.Point(20, 93);
            this.btnHepsiniGoruntule.Name = "btnHepsiniGoruntule";
            this.btnHepsiniGoruntule.Size = new System.Drawing.Size(117, 40);
            this.btnHepsiniGoruntule.TabIndex = 15;
            this.btnHepsiniGoruntule.Text = "HEPSİNİ GETİR";
            this.btnHepsiniGoruntule.Click += new System.EventHandler(this.btnHepsiniGoruntule_Click);
            // 
            // btnUrunAra
            // 
            this.btnUrunAra.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUrunAra.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnUrunAra.Appearance.Options.UseBackColor = true;
            this.btnUrunAra.Appearance.Options.UseFont = true;
            this.btnUrunAra.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUrunAra.ImageOptions.SvgImage")));
            this.btnUrunAra.Location = new System.Drawing.Point(155, 95);
            this.btnUrunAra.Name = "btnUrunAra";
            this.btnUrunAra.Size = new System.Drawing.Size(117, 38);
            this.btnUrunAra.TabIndex = 7;
            this.btnUrunAra.Text = "ÜRÜN ARA";
            this.btnUrunAra.Click += new System.EventHandler(this.btnUrunAra_Click);
            // 
            // groupControl4
            // 
            this.groupControl4.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupControl4.Appearance.Options.UseBorderColor = true;
            this.groupControl4.Controls.Add(this.groupControl5);
            this.groupControl4.Location = new System.Drawing.Point(0, 138);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(292, 135);
            this.groupControl4.TabIndex = 0;
            // 
            // groupControl5
            // 
            this.groupControl5.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupControl5.Appearance.Options.UseBorderColor = true;
            this.groupControl5.Controls.Add(this.simpleButton1);
            this.groupControl5.Controls.Add(this.cbAdet);
            this.groupControl5.Controls.Add(this.labelControl1);
            this.groupControl5.Controls.Add(this.btnSepeteEkle);
            this.groupControl5.Location = new System.Drawing.Point(0, 11);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(292, 119);
            this.groupControl5.TabIndex = 1;
            this.groupControl5.Text = "ADET BİLGİSİ";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(22, 67);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(117, 39);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "SEPETİ SİL";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(22, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(134, 19);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Aranacak Ürün Adı";
            // 
            // txtAranacakUrunAdi
            // 
            this.txtAranacakUrunAdi.Location = new System.Drawing.Point(20, 61);
            this.txtAranacakUrunAdi.Name = "txtAranacakUrunAdi";
            this.txtAranacakUrunAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAranacakUrunAdi.Properties.Appearance.Options.UseFont = true;
            this.txtAranacakUrunAdi.Size = new System.Drawing.Size(252, 26);
            this.txtAranacakUrunAdi.TabIndex = 5;
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupControl2.Appearance.Options.UseBorderColor = true;
            this.groupControl2.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl2.CaptionImageOptions.SvgImage")));
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.lbcFiyat);
            this.groupControl2.Controls.Add(this.lbcKategoriAdi);
            this.groupControl2.Controls.Add(this.lbcAdet);
            this.groupControl2.Controls.Add(this.lbcUrunAdi);
            this.groupControl2.Controls.Add(this.lbcUrunID);
            this.groupControl2.Location = new System.Drawing.Point(16, 281);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(746, 159);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "SEPET";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(58, 33);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(625, 16);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Ürün ID                       Ürün Adı                          Adet             " +
    "             Kategori                          Fiyat";
            // 
            // lbcFiyat
            // 
            this.lbcFiyat.Appearance.BackColor = System.Drawing.Color.PapayaWhip;
            this.lbcFiyat.Appearance.Options.UseBackColor = true;
            this.lbcFiyat.Appearance.Options.UseTextOptions = true;
            this.lbcFiyat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcFiyat.AppearanceDisabled.Options.UseTextOptions = true;
            this.lbcFiyat.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcFiyat.Location = new System.Drawing.Point(602, 49);
            this.lbcFiyat.Name = "lbcFiyat";
            this.lbcFiyat.Size = new System.Drawing.Size(132, 105);
            this.lbcFiyat.TabIndex = 4;
            // 
            // lbcKategoriAdi
            // 
            this.lbcKategoriAdi.Appearance.BackColor = System.Drawing.Color.PapayaWhip;
            this.lbcKategoriAdi.Appearance.Options.UseBackColor = true;
            this.lbcKategoriAdi.Appearance.Options.UseTextOptions = true;
            this.lbcKategoriAdi.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcKategoriAdi.Location = new System.Drawing.Point(455, 49);
            this.lbcKategoriAdi.Name = "lbcKategoriAdi";
            this.lbcKategoriAdi.Size = new System.Drawing.Size(132, 105);
            this.lbcKategoriAdi.TabIndex = 3;
            // 
            // lbcAdet
            // 
            this.lbcAdet.Appearance.BackColor = System.Drawing.Color.PapayaWhip;
            this.lbcAdet.Appearance.Options.UseBackColor = true;
            this.lbcAdet.Appearance.Options.UseTextOptions = true;
            this.lbcAdet.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcAdet.Location = new System.Drawing.Point(307, 49);
            this.lbcAdet.Name = "lbcAdet";
            this.lbcAdet.Size = new System.Drawing.Size(132, 105);
            this.lbcAdet.TabIndex = 2;
            // 
            // lbcUrunAdi
            // 
            this.lbcUrunAdi.Appearance.BackColor = System.Drawing.Color.PapayaWhip;
            this.lbcUrunAdi.Appearance.Options.UseBackColor = true;
            this.lbcUrunAdi.Location = new System.Drawing.Point(160, 49);
            this.lbcUrunAdi.Name = "lbcUrunAdi";
            this.lbcUrunAdi.Size = new System.Drawing.Size(132, 105);
            this.lbcUrunAdi.TabIndex = 1;
            // 
            // lbcUrunID
            // 
            this.lbcUrunID.Appearance.BackColor = System.Drawing.Color.PapayaWhip;
            this.lbcUrunID.Appearance.Options.UseBackColor = true;
            this.lbcUrunID.Appearance.Options.UseTextOptions = true;
            this.lbcUrunID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcUrunID.Location = new System.Drawing.Point(15, 49);
            this.lbcUrunID.Name = "lbcUrunID";
            this.lbcUrunID.Size = new System.Drawing.Size(132, 105);
            this.lbcUrunID.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupControl3.Appearance.Options.UseBorderColor = true;
            this.groupControl3.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl3.CaptionImageOptions.SvgImage")));
            this.groupControl3.Controls.Add(this.lblToplamTutar);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.btnSatisYap);
            this.groupControl3.Location = new System.Drawing.Point(780, 281);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(182, 159);
            this.groupControl3.TabIndex = 7;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.Appearance.Font = new System.Drawing.Font("Tahoma", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblToplamTutar.Appearance.Options.UseFont = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(102, 49);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(0, 18);
            this.lblToplamTutar.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.5F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(37, 49);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 18);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "TUTAR :";
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSatisYap.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSatisYap.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSatisYap.Appearance.Options.UseBackColor = true;
            this.btnSatisYap.Appearance.Options.UseFont = true;
            this.btnSatisYap.Appearance.Options.UseForeColor = true;
            this.btnSatisYap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSatisYap.ImageOptions.SvgImage")));
            this.btnSatisYap.Location = new System.Drawing.Point(37, 98);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(130, 47);
            this.btnSatisYap.TabIndex = 1;
            this.btnSatisYap.Text = "SATIŞ YAP";
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // UrunSatısFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(974, 447);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UrunSatısFormu";
            this.Text = "Ürün Satışı Ekranı";
            this.Load += new System.EventHandler(this.UrunSatısFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAdet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAranacakUrunAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbcFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbcKategoriAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbcAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbcUrunAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbcUrunID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnSepeteEkle;
        private DevExpress.XtraEditors.ComboBoxEdit cbAdet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtAranacakUrunAdi;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnSatisYap;
        private DevExpress.XtraEditors.SimpleButton btnUrunAra;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.SimpleButton btnHepsiniGoruntule;
        private DevExpress.XtraEditors.ListBoxControl lbcUrunID;
        private DevExpress.XtraEditors.ListBoxControl lbcFiyat;
        private DevExpress.XtraEditors.ListBoxControl lbcKategoriAdi;
        private DevExpress.XtraEditors.ListBoxControl lbcAdet;
        private DevExpress.XtraEditors.ListBoxControl lbcUrunAdi;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl lblToplamTutar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}