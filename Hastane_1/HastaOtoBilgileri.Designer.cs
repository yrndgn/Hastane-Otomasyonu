
namespace Hastane_1
{
    partial class HastaOtoBilgileri
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
            this.kan = new System.Windows.Forms.ComboBox();
            this.medeni = new System.Windows.Forms.ComboBox();
            this.telefon = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tc = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.TextBox();
            this.annead = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.soyad = new System.Windows.Forms.TextBox();
            this.dyer = new System.Windows.Forms.TextBox();
            this.cinsiyet = new System.Windows.Forms.ComboBox();
            this.eposta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtarih = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.babaad = new System.Windows.Forms.TextBox();
            this.kayıt = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.şifre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kan
            // 
            this.kan.Enabled = false;
            this.kan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kan.FormattingEnabled = true;
            this.kan.Items.AddRange(new object[] {
            "0 Rh+",
            "0 Rh-",
            "AB Rh+",
            "AB Rh-",
            "A Rh+",
            "A Rh-",
            "B Rh+",
            "B Rh-"});
            this.kan.Location = new System.Drawing.Point(228, 278);
            this.kan.Name = "kan";
            this.kan.Size = new System.Drawing.Size(197, 21);
            this.kan.TabIndex = 123;
            // 
            // medeni
            // 
            this.medeni.Enabled = false;
            this.medeni.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.medeni.FormattingEnabled = true;
            this.medeni.Items.AddRange(new object[] {
            "Bekar",
            "Evli"});
            this.medeni.Location = new System.Drawing.Point(228, 305);
            this.medeni.Name = "medeni";
            this.medeni.Size = new System.Drawing.Size(197, 21);
            this.medeni.TabIndex = 122;
            // 
            // telefon
            // 
            this.telefon.Enabled = false;
            this.telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.telefon.Location = new System.Drawing.Point(228, 359);
            this.telefon.Mask = "(999) 000-0000";
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(197, 26);
            this.telefon.TabIndex = 119;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label14.Location = new System.Drawing.Point(109, 306);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 16);
            this.label14.TabIndex = 121;
            this.label14.Text = "Medeni Durum:";
            // 
            // tc
            // 
            this.tc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tc.Enabled = false;
            this.tc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tc.HideSelection = false;
            this.tc.Location = new System.Drawing.Point(228, 57);
            this.tc.Multiline = true;
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(197, 23);
            this.tc.TabIndex = 100;
            this.tc.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label15.Location = new System.Drawing.Point(109, 279);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 16);
            this.label15.TabIndex = 120;
            this.label15.Text = "Kan Grubu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(109, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 101;
            this.label1.Text = "TC Kimlik No:";
            // 
            // ad
            // 
            this.ad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ad.Enabled = false;
            this.ad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ad.HideSelection = false;
            this.ad.Location = new System.Drawing.Point(228, 90);
            this.ad.Multiline = true;
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(197, 23);
            this.ad.TabIndex = 107;
            this.ad.TabStop = false;
            // 
            // annead
            // 
            this.annead.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.annead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.annead.Enabled = false;
            this.annead.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annead.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.annead.HideSelection = false;
            this.annead.Location = new System.Drawing.Point(228, 220);
            this.annead.Multiline = true;
            this.annead.Name = "annead";
            this.annead.Size = new System.Drawing.Size(197, 23);
            this.annead.TabIndex = 102;
            this.annead.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label2.Location = new System.Drawing.Point(109, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 103;
            this.label2.Text = "Doğum Yeri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label3.Location = new System.Drawing.Point(109, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 104;
            this.label3.Text = "Doğum Tarihi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label8.Location = new System.Drawing.Point(109, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 113;
            this.label8.Text = "Cinsiyet:";
            // 
            // soyad
            // 
            this.soyad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.soyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.soyad.Enabled = false;
            this.soyad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soyad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.soyad.HideSelection = false;
            this.soyad.Location = new System.Drawing.Point(228, 119);
            this.soyad.Multiline = true;
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(197, 23);
            this.soyad.TabIndex = 105;
            this.soyad.TabStop = false;
            // 
            // dyer
            // 
            this.dyer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dyer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dyer.Enabled = false;
            this.dyer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dyer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dyer.HideSelection = false;
            this.dyer.Location = new System.Drawing.Point(228, 191);
            this.dyer.Multiline = true;
            this.dyer.Name = "dyer";
            this.dyer.Size = new System.Drawing.Size(197, 23);
            this.dyer.TabIndex = 112;
            this.dyer.TabStop = false;
            // 
            // cinsiyet
            // 
            this.cinsiyet.Enabled = false;
            this.cinsiyet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cinsiyet.FormattingEnabled = true;
            this.cinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cinsiyet.Location = new System.Drawing.Point(228, 332);
            this.cinsiyet.Name = "cinsiyet";
            this.cinsiyet.Size = new System.Drawing.Size(197, 21);
            this.cinsiyet.TabIndex = 118;
            // 
            // eposta
            // 
            this.eposta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eposta.Enabled = false;
            this.eposta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eposta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eposta.HideSelection = false;
            this.eposta.Location = new System.Drawing.Point(228, 391);
            this.eposta.Multiline = true;
            this.eposta.Name = "eposta";
            this.eposta.Size = new System.Drawing.Size(197, 23);
            this.eposta.TabIndex = 114;
            this.eposta.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label4.Location = new System.Drawing.Point(109, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 106;
            this.label4.Text = "Soyad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label7.Location = new System.Drawing.Point(109, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 111;
            this.label7.Text = "E-Posta:";
            // 
            // dtarih
            // 
            this.dtarih.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtarih.Checked = false;
            this.dtarih.Enabled = false;
            this.dtarih.Location = new System.Drawing.Point(228, 158);
            this.dtarih.Name = "dtarih";
            this.dtarih.Size = new System.Drawing.Size(197, 20);
            this.dtarih.TabIndex = 117;
            this.dtarih.Value = new System.DateTime(2021, 1, 9, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label9.Location = new System.Drawing.Point(112, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 115;
            this.label9.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label5.Location = new System.Drawing.Point(109, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 108;
            this.label5.Text = "Ad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label10.Location = new System.Drawing.Point(109, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 116;
            this.label10.Text = "Baba Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label6.Location = new System.Drawing.Point(109, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 110;
            this.label6.Text = "Anne Adı:";
            // 
            // babaad
            // 
            this.babaad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.babaad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.babaad.Enabled = false;
            this.babaad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.babaad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.babaad.HideSelection = false;
            this.babaad.Location = new System.Drawing.Point(228, 249);
            this.babaad.Multiline = true;
            this.babaad.Name = "babaad";
            this.babaad.Size = new System.Drawing.Size(197, 23);
            this.babaad.TabIndex = 109;
            this.babaad.TabStop = false;
            // 
            // kayıt
            // 
            this.kayıt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(248)))));
            this.kayıt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayıt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.kayıt.Location = new System.Drawing.Point(440, 57);
            this.kayıt.Name = "kayıt";
            this.kayıt.Size = new System.Drawing.Size(120, 32);
            this.kayıt.TabIndex = 124;
            this.kayıt.Text = "Bilgilerim";
            this.kayıt.UseVisualStyleBackColor = false;
            this.kayıt.Click += new System.EventHandler(this.kayıt_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label12.Location = new System.Drawing.Point(112, 422);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 126;
            this.label12.Text = "Şifre:";
            // 
            // şifre
            // 
            this.şifre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.şifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.şifre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.şifre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.şifre.HideSelection = false;
            this.şifre.Location = new System.Drawing.Point(228, 420);
            this.şifre.Multiline = true;
            this.şifre.Name = "şifre";
            this.şifre.PasswordChar = '*';
            this.şifre.Size = new System.Drawing.Size(197, 23);
            this.şifre.TabIndex = 125;
            this.şifre.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(248)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button1.Location = new System.Drawing.Point(311, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 35);
            this.button1.TabIndex = 129;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HastaOtoBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(589, 581);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.şifre);
            this.Controls.Add(this.kayıt);
            this.Controls.Add(this.kan);
            this.Controls.Add(this.medeni);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.annead);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.dyer);
            this.Controls.Add(this.cinsiyet);
            this.Controls.Add(this.eposta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtarih);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.babaad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HastaOtoBilgileri";
            this.Text = "HastaOtoBilgileri";
            this.Load += new System.EventHandler(this.HastaOtoBilgileri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button kayıt;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox kan;
        public System.Windows.Forms.ComboBox medeni;
        public System.Windows.Forms.MaskedTextBox telefon;
        public System.Windows.Forms.TextBox tc;
        public System.Windows.Forms.TextBox ad;
        public System.Windows.Forms.TextBox annead;
        public System.Windows.Forms.TextBox soyad;
        public System.Windows.Forms.TextBox dyer;
        public System.Windows.Forms.ComboBox cinsiyet;
        public System.Windows.Forms.TextBox eposta;
        public System.Windows.Forms.DateTimePicker dtarih;
        public System.Windows.Forms.TextBox babaad;
        public System.Windows.Forms.TextBox şifre;
        private System.Windows.Forms.Button button1;
    }
}