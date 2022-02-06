
namespace Otel_Musteri_Uygulamasi
{
    partial class RezervasyonFormu
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
            this.lblBaslangicTarihi = new System.Windows.Forms.Label();
            this.lblSonTarih = new System.Windows.Forms.Label();
            this.dateTimeBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.btnTumKayitlariGetir = new System.Windows.Forms.Button();
            this.dtviewRezervasyonlar = new System.Windows.Forms.DataGridView();
            this.lblUcret = new System.Windows.Forms.Label();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.lblOdaNo = new System.Windows.Forms.Label();
            this.cmbbxOdaNo = new System.Windows.Forms.ComboBox();
            this.lblMusteriID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtviewRezervasyonlar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslangicTarihi
            // 
            this.lblBaslangicTarihi.AutoSize = true;
            this.lblBaslangicTarihi.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaslangicTarihi.Location = new System.Drawing.Point(12, 31);
            this.lblBaslangicTarihi.Name = "lblBaslangicTarihi";
            this.lblBaslangicTarihi.Size = new System.Drawing.Size(151, 23);
            this.lblBaslangicTarihi.TabIndex = 1;
            this.lblBaslangicTarihi.Text = "Başlangıç Tarihi:";
            // 
            // lblSonTarih
            // 
            this.lblSonTarih.AutoSize = true;
            this.lblSonTarih.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonTarih.Location = new System.Drawing.Point(56, 75);
            this.lblSonTarih.Name = "lblSonTarih";
            this.lblSonTarih.Size = new System.Drawing.Size(107, 23);
            this.lblSonTarih.TabIndex = 2;
            this.lblSonTarih.Text = "Bitiş Tarihi:";
            // 
            // dateTimeBaslangic
            // 
            this.dateTimeBaslangic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeBaslangic.Location = new System.Drawing.Point(179, 28);
            this.dateTimeBaslangic.Name = "dateTimeBaslangic";
            this.dateTimeBaslangic.Size = new System.Drawing.Size(250, 27);
            this.dateTimeBaslangic.TabIndex = 1;
            // 
            // dateTimeBitisTarihi
            // 
            this.dateTimeBitisTarihi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeBitisTarihi.Location = new System.Drawing.Point(179, 72);
            this.dateTimeBitisTarihi.Name = "dateTimeBitisTarihi";
            this.dateTimeBitisTarihi.Size = new System.Drawing.Size(250, 27);
            this.dateTimeBitisTarihi.TabIndex = 2;
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFiltrele.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrele.Location = new System.Drawing.Point(879, 12);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(181, 29);
            this.btnFiltrele.TabIndex = 5;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.UseVisualStyleBackColor = false;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // btnTumKayitlariGetir
            // 
            this.btnTumKayitlariGetir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTumKayitlariGetir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTumKayitlariGetir.Location = new System.Drawing.Point(879, 47);
            this.btnTumKayitlariGetir.Name = "btnTumKayitlariGetir";
            this.btnTumKayitlariGetir.Size = new System.Drawing.Size(181, 29);
            this.btnTumKayitlariGetir.TabIndex = 6;
            this.btnTumKayitlariGetir.Text = "Tüm Kayıtları Getir";
            this.btnTumKayitlariGetir.UseVisualStyleBackColor = false;
            this.btnTumKayitlariGetir.Click += new System.EventHandler(this.btnTumKayitlariGetir_Click);
            // 
            // dtviewRezervasyonlar
            // 
            this.dtviewRezervasyonlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtviewRezervasyonlar.BackgroundColor = System.Drawing.Color.White;
            this.dtviewRezervasyonlar.ColumnHeadersHeight = 29;
            this.dtviewRezervasyonlar.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtviewRezervasyonlar.Location = new System.Drawing.Point(-4, 122);
            this.dtviewRezervasyonlar.Name = "dtviewRezervasyonlar";
            this.dtviewRezervasyonlar.RowHeadersVisible = false;
            this.dtviewRezervasyonlar.RowHeadersWidth = 51;
            this.dtviewRezervasyonlar.RowTemplate.Height = 24;
            this.dtviewRezervasyonlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtviewRezervasyonlar.Size = new System.Drawing.Size(1073, 516);
            this.dtviewRezervasyonlar.TabIndex = 8;
            this.dtviewRezervasyonlar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dviewRezervasyonlar_CellDoubleClick);
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUcret.Location = new System.Drawing.Point(540, 75);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(61, 23);
            this.lblUcret.TabIndex = 8;
            this.lblUcret.Text = "Ücret:";
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(628, 76);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(165, 22);
            this.txtUcret.TabIndex = 4;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGüncelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGüncelle.Location = new System.Drawing.Point(879, 82);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(181, 29);
            this.btnGüncelle.TabIndex = 7;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // lblOdaNo
            // 
            this.lblOdaNo.AutoSize = true;
            this.lblOdaNo.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdaNo.Location = new System.Drawing.Point(520, 31);
            this.lblOdaNo.Name = "lblOdaNo";
            this.lblOdaNo.Size = new System.Drawing.Size(81, 23);
            this.lblOdaNo.TabIndex = 11;
            this.lblOdaNo.Text = "Oda No:";
            // 
            // cmbbxOdaNo
            // 
            this.cmbbxOdaNo.FormattingEnabled = true;
            this.cmbbxOdaNo.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "201",
            "202",
            "203",
            "301",
            "302",
            "303",
            "401",
            "402",
            "403"});
            this.cmbbxOdaNo.Location = new System.Drawing.Point(628, 30);
            this.cmbbxOdaNo.Name = "cmbbxOdaNo";
            this.cmbbxOdaNo.Size = new System.Drawing.Size(165, 24);
            this.cmbbxOdaNo.TabIndex = 3;
            // 
            // lblMusteriID
            // 
            this.lblMusteriID.AutoSize = true;
            this.lblMusteriID.Location = new System.Drawing.Point(467, 89);
            this.lblMusteriID.Name = "lblMusteriID";
            this.lblMusteriID.Size = new System.Drawing.Size(0, 17);
            this.lblMusteriID.TabIndex = 13;
            this.lblMusteriID.Visible = false;
            // 
            // RezervasyonFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1067, 634);
            this.Controls.Add(this.lblMusteriID);
            this.Controls.Add(this.cmbbxOdaNo);
            this.Controls.Add(this.lblOdaNo);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.lblUcret);
            this.Controls.Add(this.dtviewRezervasyonlar);
            this.Controls.Add(this.btnTumKayitlariGetir);
            this.Controls.Add(this.btnFiltrele);
            this.Controls.Add(this.dateTimeBitisTarihi);
            this.Controls.Add(this.dateTimeBaslangic);
            this.Controls.Add(this.lblSonTarih);
            this.Controls.Add(this.lblBaslangicTarihi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RezervasyonFormu";
            this.Text = "Rezervasyonlar";
            this.Load += new System.EventHandler(this.RezervasyonFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtviewRezervasyonlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBaslangicTarihi;
        private System.Windows.Forms.Label lblSonTarih;
        private System.Windows.Forms.DateTimePicker dateTimeBaslangic;
        private System.Windows.Forms.DateTimePicker dateTimeBitisTarihi;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.Button btnTumKayitlariGetir;
        private System.Windows.Forms.DataGridView dtviewRezervasyonlar;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label lblOdaNo;
        private System.Windows.Forms.ComboBox cmbbxOdaNo;
        private System.Windows.Forms.Label lblMusteriID;
    }
}