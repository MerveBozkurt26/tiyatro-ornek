namespace tiyatro_ornek
{
    partial class Form1
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
            this.dgvTiyatro = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblSahne = new System.Windows.Forms.Label();
            this.chkMuzikal = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cmbAd = new System.Windows.Forms.ComboBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.cmbSahne = new System.Windows.Forms.ComboBox();
            this.nduSure = new System.Windows.Forms.NumericUpDown();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiyatro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nduSure)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTiyatro
            // 
            this.dgvTiyatro.AllowUserToAddRows = false;
            this.dgvTiyatro.AllowUserToDeleteRows = false;
            this.dgvTiyatro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvTiyatro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiyatro.Location = new System.Drawing.Point(0, 331);
            this.dgvTiyatro.Name = "dgvTiyatro";
            this.dgvTiyatro.ReadOnly = true;
            this.dgvTiyatro.Size = new System.Drawing.Size(669, 233);
            this.dgvTiyatro.TabIndex = 0;
            this.dgvTiyatro.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTiyatro_CellEnter);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.Location = new System.Drawing.Point(13, 13);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 16);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(13, 45);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(69, 16);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "Oyun Adı";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(13, 117);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(41, 16);
            this.lblFiyat.TabIndex = 3;
            this.lblFiyat.Text = "Fiyat";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.Location = new System.Drawing.Point(12, 151);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(39, 16);
            this.lblSure.TabIndex = 4;
            this.lblSure.Text = "Süre";
            // 
            // lblSahne
            // 
            this.lblSahne.AutoSize = true;
            this.lblSahne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSahne.Location = new System.Drawing.Point(13, 181);
            this.lblSahne.Name = "lblSahne";
            this.lblSahne.Size = new System.Drawing.Size(51, 16);
            this.lblSahne.TabIndex = 5;
            this.lblSahne.Text = "Sahne";
            // 
            // chkMuzikal
            // 
            this.chkMuzikal.AutoSize = true;
            this.chkMuzikal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkMuzikal.Location = new System.Drawing.Point(14, 246);
            this.chkMuzikal.Name = "chkMuzikal";
            this.chkMuzikal.Size = new System.Drawing.Size(78, 20);
            this.chkMuzikal.TabIndex = 6;
            this.chkMuzikal.Text = "Müzikal";
            this.chkMuzikal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tarih ve Saat";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(130, 83);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpTarih.TabIndex = 8;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(39, 13);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 9;
            // 
            // cmbAd
            // 
            this.cmbAd.FormattingEnabled = true;
            this.cmbAd.Location = new System.Drawing.Point(98, 40);
            this.cmbAd.Name = "cmbAd";
            this.cmbAd.Size = new System.Drawing.Size(121, 21);
            this.cmbAd.TabIndex = 10;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(61, 117);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtFiyat.TabIndex = 12;
            // 
            // cmbSahne
            // 
            this.cmbSahne.FormattingEnabled = true;
            this.cmbSahne.Location = new System.Drawing.Point(70, 180);
            this.cmbSahne.Name = "cmbSahne";
            this.cmbSahne.Size = new System.Drawing.Size(121, 21);
            this.cmbSahne.TabIndex = 13;
            // 
            // nduSure
            // 
            this.nduSure.Location = new System.Drawing.Point(70, 151);
            this.nduSure.Name = "nduSure";
            this.nduSure.Size = new System.Drawing.Size(120, 20);
            this.nduSure.TabIndex = 14;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Blue;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Image = global::tiyatro_ornek.Properties.Resources._002_diskette;
            this.btnKaydet.Location = new System.Drawing.Point(211, 151);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(119, 69);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Image = global::tiyatro_ornek.Properties.Resources._003_bin;
            this.btnSil.Location = new System.Drawing.Point(351, 152);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(124, 69);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Image = global::tiyatro_ornek.Properties.Resources._001_refresh;
            this.btnGuncelle.Location = new System.Drawing.Point(493, 151);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(124, 69);
            this.btnGuncelle.TabIndex = 17;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(663, 564);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.nduSure);
            this.Controls.Add(this.cmbSahne);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.cmbAd);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkMuzikal);
            this.Controls.Add(this.lblSahne);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dgvTiyatro);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiyatro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nduSure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTiyatro;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblSahne;
        private System.Windows.Forms.CheckBox chkMuzikal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbAd;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.ComboBox cmbSahne;
        private System.Windows.Forms.NumericUpDown nduSure;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
    }
}
