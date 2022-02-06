
namespace Otel_Musteri_Uygulamasi
{
    partial class MusteriBilgileriFormu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriBilgileriFormu));
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.maskedtxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.cmbbxCinsiyet = new System.Windows.Forms.ComboBox();
            this.maskedtxtTC = new System.Windows.Forms.MaskedTextBox();
            this.lblTCNo = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.dtviewMüsteriler = new System.Windows.Forms.DataGridView();
            this.musteriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMusteriID = new System.Windows.Forms.Label();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.grpbxAra = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtviewMüsteriler)).BeginInit();
            this.grpbxAra.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(67, 25);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(39, 23);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Adı:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(41, 61);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(65, 23);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyadı:";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(32, 97);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(74, 23);
            this.lblCinsiyet.TabIndex = 2;
            this.lblCinsiyet.Text = "Cinsiyet:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(398, 61);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(69, 23);
            this.lblTelefon.TabIndex = 3;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(420, 97);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(47, 23);
            this.lblMail.TabIndex = 4;
            this.lblMail.Text = "Mail:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(121, 22);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(229, 30);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(121, 58);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(229, 30);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(507, 94);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(229, 30);
            this.txtMail.TabIndex = 7;
            // 
            // maskedtxtTelefon
            // 
            this.maskedtxtTelefon.Location = new System.Drawing.Point(507, 58);
            this.maskedtxtTelefon.Mask = "(999) 000-0000";
            this.maskedtxtTelefon.Name = "maskedtxtTelefon";
            this.maskedtxtTelefon.Size = new System.Drawing.Size(229, 30);
            this.maskedtxtTelefon.TabIndex = 6;
            // 
            // cmbbxCinsiyet
            // 
            this.cmbbxCinsiyet.FormattingEnabled = true;
            this.cmbbxCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbbxCinsiyet.Location = new System.Drawing.Point(121, 94);
            this.cmbbxCinsiyet.Name = "cmbbxCinsiyet";
            this.cmbbxCinsiyet.Size = new System.Drawing.Size(229, 31);
            this.cmbbxCinsiyet.TabIndex = 3;
            this.cmbbxCinsiyet.Text = "Seçiniz";
            this.cmbbxCinsiyet.Click += new System.EventHandler(this.cmbbxCinsiyet_Click);
            // 
            // maskedtxtTC
            // 
            this.maskedtxtTC.Location = new System.Drawing.Point(508, 22);
            this.maskedtxtTC.Mask = "00000000000";
            this.maskedtxtTC.Name = "maskedtxtTC";
            this.maskedtxtTC.Size = new System.Drawing.Size(229, 30);
            this.maskedtxtTC.TabIndex = 5;
            this.maskedtxtTC.ValidatingType = typeof(int);
            // 
            // lblTCNo
            // 
            this.lblTCNo.AutoSize = true;
            this.lblTCNo.Location = new System.Drawing.Point(399, 25);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(68, 23);
            this.lblTCNo.TabIndex = 10;
            this.lblTCNo.Text = "T.C. No:";
            // 
            // txtAra
            // 
            this.txtAra.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtAra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAra.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAra.Location = new System.Drawing.Point(56, 20);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(229, 23);
            this.txtAra.TabIndex = 8;
            this.txtAra.Text = "Bir İsim Giriniz";
            this.txtAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAra.Click += new System.EventHandler(this.txtAra_Click);
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.Location = new System.Drawing.Point(800, 150);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(196, 57);
            this.btnTemizle.TabIndex = 13;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(800, 86);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(196, 57);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGüncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGüncelle.Location = new System.Drawing.Point(800, 22);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(196, 57);
            this.btnGüncelle.TabIndex = 11;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // dtviewMüsteriler
            // 
            this.dtviewMüsteriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtviewMüsteriler.BackgroundColor = System.Drawing.Color.White;
            this.dtviewMüsteriler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dtviewMüsteriler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtviewMüsteriler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtviewMüsteriler.ColumnHeadersHeight = 35;
            this.dtviewMüsteriler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriIDDataGridViewTextBoxColumn,
            this.tCNoDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn});
            this.dtviewMüsteriler.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtviewMüsteriler.Location = new System.Drawing.Point(-2, 221);
            this.dtviewMüsteriler.Name = "dtviewMüsteriler";
            this.dtviewMüsteriler.RowHeadersVisible = false;
            this.dtviewMüsteriler.RowHeadersWidth = 51;
            this.dtviewMüsteriler.RowTemplate.Height = 24;
            this.dtviewMüsteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtviewMüsteriler.Size = new System.Drawing.Size(1010, 420);
            this.dtviewMüsteriler.TabIndex = 14;
            this.dtviewMüsteriler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtviewMüsteriler_CellDoubleClick);
            // 
            // musteriIDDataGridViewTextBoxColumn
            // 
            this.musteriIDDataGridViewTextBoxColumn.DataPropertyName = "musteriID";
            this.musteriIDDataGridViewTextBoxColumn.FillWeight = 78F;
            this.musteriIDDataGridViewTextBoxColumn.HeaderText = "Müşteri ID";
            this.musteriIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriIDDataGridViewTextBoxColumn.Name = "musteriIDDataGridViewTextBoxColumn";
            this.musteriIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tCNoDataGridViewTextBoxColumn
            // 
            this.tCNoDataGridViewTextBoxColumn.DataPropertyName = "TCNo";
            this.tCNoDataGridViewTextBoxColumn.HeaderText = "T.C. No";
            this.tCNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tCNoDataGridViewTextBoxColumn.Name = "tCNoDataGridViewTextBoxColumn";
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.FillWeight = 80F;
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            this.mailDataGridViewTextBoxColumn.FillWeight = 150F;
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // lblMusteriID
            // 
            this.lblMusteriID.AutoSize = true;
            this.lblMusteriID.Location = new System.Drawing.Point(9, 133);
            this.lblMusteriID.Name = "lblMusteriID";
            this.lblMusteriID.Size = new System.Drawing.Size(94, 23);
            this.lblMusteriID.TabIndex = 29;
            this.lblMusteriID.Text = "Müşteri ID:";
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.Location = new System.Drawing.Point(121, 130);
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.ReadOnly = true;
            this.txtMusteriID.Size = new System.Drawing.Size(229, 30);
            this.txtMusteriID.TabIndex = 4;
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYazdir.BackgroundImage")));
            this.btnYazdir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnYazdir.FlatAppearance.BorderSize = 0;
            this.btnYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazdir.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYazdir.Location = new System.Drawing.Point(621, 145);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(70, 57);
            this.btnYazdir.TabIndex = 10;
            this.btnYazdir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            this.btnYazdir.MouseHover += new System.EventHandler(this.btnYazdir_MouseHover);
            // 
            // btnPreview
            // 
            this.btnPreview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPreview.BackgroundImage")));
            this.btnPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPreview.FlatAppearance.BorderSize = 0;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(545, 145);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(70, 57);
            this.btnPreview.TabIndex = 9;
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            this.btnPreview.MouseHover += new System.EventHandler(this.btnPreview_MouseHover);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // grpbxAra
            // 
            this.grpbxAra.Controls.Add(this.txtAra);
            this.grpbxAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpbxAra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpbxAra.Location = new System.Drawing.Point(59, 166);
            this.grpbxAra.Name = "grpbxAra";
            this.grpbxAra.Size = new System.Drawing.Size(291, 49);
            this.grpbxAra.TabIndex = 30;
            this.grpbxAra.TabStop = false;
            this.grpbxAra.Text = "Ara";
            // 
            // MusteriBilgileriFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1008, 640);
            this.Controls.Add(this.grpbxAra);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.txtMusteriID);
            this.Controls.Add(this.lblMusteriID);
            this.Controls.Add(this.dtviewMüsteriler);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.maskedtxtTC);
            this.Controls.Add(this.lblTCNo);
            this.Controls.Add(this.cmbbxCinsiyet);
            this.Controls.Add(this.maskedtxtTelefon);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "MusteriBilgileriFormu";
            this.Text = "Müşteri Bilgileri";
            this.Load += new System.EventHandler(this.MusteriBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtviewMüsteriler)).EndInit();
            this.grpbxAra.ResumeLayout(false);
            this.grpbxAra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.MaskedTextBox maskedtxtTelefon;
        private System.Windows.Forms.ComboBox cmbbxCinsiyet;
        private System.Windows.Forms.MaskedTextBox maskedtxtTC;
        private System.Windows.Forms.Label lblTCNo;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.DataGridView dtviewMüsteriler;
        private System.Windows.Forms.Label lblMusteriID;
        private System.Windows.Forms.TextBox txtMusteriID;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.GroupBox grpbxAra;
    }
}