
namespace Otel_Musteri_Uygulamasi
{
    partial class DovizIslemleriFormu
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
            this.groupbxBilgi = new System.Windows.Forms.GroupBox();
            this.groupbxHesaplama = new System.Windows.Forms.GroupBox();
            this.lblDonusumTuru = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.radiobtnDovizdenTL = new System.Windows.Forms.RadioButton();
            this.radiobtnTLdenDoviz = new System.Windows.Forms.RadioButton();
            this.lblDovizSatis = new System.Windows.Forms.Label();
            this.lblDovizAlis = new System.Windows.Forms.Label();
            this.lblSatis = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblAlis = new System.Windows.Forms.Label();
            this.listbxDoviz = new System.Windows.Forms.ListBox();
            this.groupbxBilgi.SuspendLayout();
            this.groupbxHesaplama.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbxBilgi
            // 
            this.groupbxBilgi.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupbxBilgi.Controls.Add(this.groupbxHesaplama);
            this.groupbxBilgi.Controls.Add(this.lblDovizSatis);
            this.groupbxBilgi.Controls.Add(this.lblDovizAlis);
            this.groupbxBilgi.Controls.Add(this.lblSatis);
            this.groupbxBilgi.Controls.Add(this.lblAd);
            this.groupbxBilgi.Controls.Add(this.lblAlis);
            this.groupbxBilgi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupbxBilgi.Location = new System.Drawing.Point(441, 12);
            this.groupbxBilgi.Name = "groupbxBilgi";
            this.groupbxBilgi.Size = new System.Drawing.Size(346, 388);
            this.groupbxBilgi.TabIndex = 4;
            this.groupbxBilgi.TabStop = false;
            this.groupbxBilgi.Text = "Seçilen Döviz Bilgileri";
            // 
            // groupbxHesaplama
            // 
            this.groupbxHesaplama.Controls.Add(this.lblDonusumTuru);
            this.groupbxHesaplama.Controls.Add(this.btnHesapla);
            this.groupbxHesaplama.Controls.Add(this.txtMiktar);
            this.groupbxHesaplama.Controls.Add(this.txtSonuc);
            this.groupbxHesaplama.Controls.Add(this.lblMiktar);
            this.groupbxHesaplama.Controls.Add(this.radiobtnDovizdenTL);
            this.groupbxHesaplama.Controls.Add(this.radiobtnTLdenDoviz);
            this.groupbxHesaplama.Enabled = false;
            this.groupbxHesaplama.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupbxHesaplama.Location = new System.Drawing.Point(11, 150);
            this.groupbxHesaplama.Name = "groupbxHesaplama";
            this.groupbxHesaplama.Size = new System.Drawing.Size(328, 238);
            this.groupbxHesaplama.TabIndex = 15;
            this.groupbxHesaplama.TabStop = false;
            this.groupbxHesaplama.Text = "Hesaplama";
            // 
            // lblDonusumTuru
            // 
            this.lblDonusumTuru.AutoSize = true;
            this.lblDonusumTuru.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDonusumTuru.Location = new System.Drawing.Point(20, 42);
            this.lblDonusumTuru.Name = "lblDonusumTuru";
            this.lblDonusumTuru.Size = new System.Drawing.Size(106, 17);
            this.lblDonusumTuru.TabIndex = 9;
            this.lblDonusumTuru.Text = "Dönüşüm Türü:";
            // 
            // btnHesapla
            // 
            this.btnHesapla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHesapla.Location = new System.Drawing.Point(173, 140);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(140, 32);
            this.btnHesapla.TabIndex = 12;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtMiktar
            // 
            this.txtMiktar.BackColor = System.Drawing.Color.AliceBlue;
            this.txtMiktar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMiktar.Location = new System.Drawing.Point(173, 97);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(140, 22);
            this.txtMiktar.TabIndex = 6;
            // 
            // txtSonuc
            // 
            this.txtSonuc.BackColor = System.Drawing.Color.AliceBlue;
            this.txtSonuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSonuc.Location = new System.Drawing.Point(23, 198);
            this.txtSonuc.MaxLength = 100000;
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.ReadOnly = true;
            this.txtSonuc.Size = new System.Drawing.Size(289, 22);
            this.txtSonuc.TabIndex = 13;
            this.txtSonuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMiktar.Location = new System.Drawing.Point(82, 100);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(50, 17);
            this.lblMiktar.TabIndex = 7;
            this.lblMiktar.Text = "Miktar:";
            // 
            // radiobtnDovizdenTL
            // 
            this.radiobtnDovizdenTL.AutoSize = true;
            this.radiobtnDovizdenTL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radiobtnDovizdenTL.Location = new System.Drawing.Point(172, 26);
            this.radiobtnDovizdenTL.Name = "radiobtnDovizdenTL";
            this.radiobtnDovizdenTL.Size = new System.Drawing.Size(127, 21);
            this.radiobtnDovizdenTL.TabIndex = 10;
            this.radiobtnDovizdenTL.Text = "Dövizden TL\'ye";
            this.radiobtnDovizdenTL.UseVisualStyleBackColor = true;
            // 
            // radiobtnTLdenDoviz
            // 
            this.radiobtnTLdenDoviz.AutoSize = true;
            this.radiobtnTLdenDoviz.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radiobtnTLdenDoviz.Location = new System.Drawing.Point(172, 53);
            this.radiobtnTLdenDoviz.Name = "radiobtnTLdenDoviz";
            this.radiobtnTLdenDoviz.Size = new System.Drawing.Size(120, 21);
            this.radiobtnTLdenDoviz.TabIndex = 11;
            this.radiobtnTLdenDoviz.Text = "TL\'den Dövize";
            this.radiobtnTLdenDoviz.UseVisualStyleBackColor = true;
            // 
            // lblDovizSatis
            // 
            this.lblDovizSatis.AutoSize = true;
            this.lblDovizSatis.Location = new System.Drawing.Point(29, 110);
            this.lblDovizSatis.Name = "lblDovizSatis";
            this.lblDovizSatis.Size = new System.Drawing.Size(82, 17);
            this.lblDovizSatis.TabIndex = 5;
            this.lblDovizSatis.Text = "Döviz Satış:";
            // 
            // lblDovizAlis
            // 
            this.lblDovizAlis.AutoSize = true;
            this.lblDovizAlis.Location = new System.Drawing.Point(29, 70);
            this.lblDovizAlis.Name = "lblDovizAlis";
            this.lblDovizAlis.Size = new System.Drawing.Size(73, 17);
            this.lblDovizAlis.TabIndex = 4;
            this.lblDovizAlis.Text = "Döviz Alış:";
            // 
            // lblSatis
            // 
            this.lblSatis.AutoSize = true;
            this.lblSatis.Location = new System.Drawing.Point(129, 111);
            this.lblSatis.Name = "lblSatis";
            this.lblSatis.Size = new System.Drawing.Size(0, 17);
            this.lblSatis.TabIndex = 3;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(29, 30);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(25, 17);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Ad";
            // 
            // lblAlis
            // 
            this.lblAlis.AutoSize = true;
            this.lblAlis.Location = new System.Drawing.Point(129, 70);
            this.lblAlis.Name = "lblAlis";
            this.lblAlis.Size = new System.Drawing.Size(0, 17);
            this.lblAlis.TabIndex = 2;
            // 
            // listbxDoviz
            // 
            this.listbxDoviz.BackColor = System.Drawing.Color.AliceBlue;
            this.listbxDoviz.FormattingEnabled = true;
            this.listbxDoviz.ItemHeight = 16;
            this.listbxDoviz.Location = new System.Drawing.Point(12, 12);
            this.listbxDoviz.Name = "listbxDoviz";
            this.listbxDoviz.Size = new System.Drawing.Size(401, 388);
            this.listbxDoviz.TabIndex = 0;
            this.listbxDoviz.SelectedIndexChanged += new System.EventHandler(this.listbxDoviz_SelectedIndexChanged);
            // 
            // DovizIslemleriFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.groupbxBilgi);
            this.Controls.Add(this.listbxDoviz);
            this.Name = "DovizIslemleriFormu";
            this.Text = "Döviz İşlemleri";
            this.Load += new System.EventHandler(this.DovizIslemleriFormu_Load);
            this.groupbxBilgi.ResumeLayout(false);
            this.groupbxBilgi.PerformLayout();
            this.groupbxHesaplama.ResumeLayout(false);
            this.groupbxHesaplama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listbxDoviz;
        private System.Windows.Forms.Label lblSatis;
        private System.Windows.Forms.Label lblAlis;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.GroupBox groupbxBilgi;
        private System.Windows.Forms.Label lblDovizSatis;
        private System.Windows.Forms.Label lblDovizAlis;
        private System.Windows.Forms.Label lblDonusumTuru;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.RadioButton radiobtnTLdenDoviz;
        private System.Windows.Forms.RadioButton radiobtnDovizdenTL;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.GroupBox groupbxHesaplama;
    }
}