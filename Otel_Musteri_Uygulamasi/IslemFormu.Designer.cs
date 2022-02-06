
namespace Otel_Musteri_Uygulamasi
{
    partial class islemKayitFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(islemKayitFormu));
            this.listbxGecmis = new System.Windows.Forms.ListBox();
            this.btnHataGecmisi = new System.Windows.Forms.Button();
            this.btnislemGecmisi = new System.Windows.Forms.Button();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnitalic = new System.Windows.Forms.Button();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listbxGecmis
            // 
            this.listbxGecmis.FormattingEnabled = true;
            this.listbxGecmis.ItemHeight = 16;
            this.listbxGecmis.Location = new System.Drawing.Point(-1, 115);
            this.listbxGecmis.Name = "listbxGecmis";
            this.listbxGecmis.Size = new System.Drawing.Size(809, 388);
            this.listbxGecmis.TabIndex = 6;
            // 
            // btnHataGecmisi
            // 
            this.btnHataGecmisi.Location = new System.Drawing.Point(12, 38);
            this.btnHataGecmisi.Name = "btnHataGecmisi";
            this.btnHataGecmisi.Size = new System.Drawing.Size(277, 52);
            this.btnHataGecmisi.TabIndex = 1;
            this.btnHataGecmisi.Text = "Hata Geçmişini Görüntüle";
            this.btnHataGecmisi.UseVisualStyleBackColor = true;
            this.btnHataGecmisi.Click += new System.EventHandler(this.btnHataGecmisi_Click);
            // 
            // btnislemGecmisi
            // 
            this.btnislemGecmisi.Location = new System.Drawing.Point(511, 38);
            this.btnislemGecmisi.Name = "btnislemGecmisi";
            this.btnislemGecmisi.Size = new System.Drawing.Size(277, 52);
            this.btnislemGecmisi.TabIndex = 2;
            this.btnislemGecmisi.Text = "İşlem Geçmişini Görüntüle";
            this.btnislemGecmisi.UseVisualStyleBackColor = true;
            this.btnislemGecmisi.Click += new System.EventHandler(this.btnislemGecmisi_Click);
            // 
            // btnBold
            // 
            this.btnBold.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBold.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBold.BackgroundImage")));
            this.btnBold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBold.Location = new System.Drawing.Point(295, 38);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(52, 52);
            this.btnBold.TabIndex = 3;
            this.btnBold.UseVisualStyleBackColor = false;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnitalic
            // 
            this.btnitalic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnitalic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnitalic.BackgroundImage")));
            this.btnitalic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnitalic.Location = new System.Drawing.Point(453, 38);
            this.btnitalic.Name = "btnitalic";
            this.btnitalic.Size = new System.Drawing.Size(52, 52);
            this.btnitalic.TabIndex = 5;
            this.btnitalic.UseVisualStyleBackColor = false;
            this.btnitalic.Click += new System.EventHandler(this.btnitalic_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUnderline.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUnderline.BackgroundImage")));
            this.btnUnderline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUnderline.Location = new System.Drawing.Point(373, 38);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(52, 52);
            this.btnUnderline.TabIndex = 4;
            this.btnUnderline.UseVisualStyleBackColor = false;
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // islemKayitFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(805, 503);
            this.Controls.Add(this.btnUnderline);
            this.Controls.Add(this.btnitalic);
            this.Controls.Add(this.btnBold);
            this.Controls.Add(this.btnislemGecmisi);
            this.Controls.Add(this.btnHataGecmisi);
            this.Controls.Add(this.listbxGecmis);
            this.Name = "islemKayitFormu";
            this.Text = "İşlem Kayıtları";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHataGecmisi;
        private System.Windows.Forms.ListBox listbxGecmis;
        private System.Windows.Forms.Button btnislemGecmisi;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnitalic;
        private System.Windows.Forms.Button btnUnderline;
    }
}