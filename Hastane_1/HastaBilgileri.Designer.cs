namespace Hastane_1
{
    partial class HastaBilgileri
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.tanı = new System.Windows.Forms.TextBox();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.epos = new System.Windows.Forms.TextBox();
            this.baba = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.TextBox();
            this.anne = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hastalıklar = new System.Windows.Forms.TextBox();
            this.tele = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dyer = new System.Windows.Forms.TextBox();
            this.tck = new System.Windows.Forms.TextBox();
            this.kangrubu = new System.Windows.Forms.TextBox();
            this.med = new System.Windows.Forms.TextBox();
            this.cin = new System.Windows.Forms.TextBox();
            this.Ara = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hasta_tc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasta_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasta_soyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogum_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogum_yeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anne_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baba_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kan_grubu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medeni_hal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e_posta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tani_dk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaGirişiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneVeritabanıDataSet = new Hastane_1.HastaneVeritabanıDataSet();
            this.hasta_GirişiTableAdapter = new Hastane_1.HastaneVeritabanıDataSetTableAdapters.Hasta_GirişiTableAdapter();
            this.Kaydet = new System.Windows.Forms.Button();
            this.Güncelle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaGirişiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneVeritabanıDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label10.Location = new System.Drawing.Point(48, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 79;
            this.label10.Text = "Baba Adı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label9.Location = new System.Drawing.Point(48, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 78;
            this.label9.Text = "Telefon:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label8.Location = new System.Drawing.Point(48, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 77;
            this.label8.Text = "Cinsiyet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label7.Location = new System.Drawing.Point(46, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 76;
            this.label7.Text = "E-Posta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label6.Location = new System.Drawing.Point(48, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 75;
            this.label6.Text = "Anne Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label5.Location = new System.Drawing.Point(48, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 74;
            this.label5.Text = "Hasta Adı:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label4.Location = new System.Drawing.Point(46, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 73;
            this.label4.Text = "Hasta Soyadı:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label3.Location = new System.Drawing.Point(48, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 72;
            this.label3.Text = "Doğum Tarihi:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(48, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 70;
            this.label1.Text = "TC Kimlik No:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.tanı);
            this.panel1.Location = new System.Drawing.Point(419, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 195);
            this.panel1.TabIndex = 80;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label14.Location = new System.Drawing.Point(30, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 16);
            this.label14.TabIndex = 105;
            this.label14.Text = "TANI:";
            // 
            // tanı
            // 
            this.tanı.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tanı.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tanı.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanı.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tanı.HideSelection = false;
            this.tanı.Location = new System.Drawing.Point(33, 41);
            this.tanı.Multiline = true;
            this.tanı.Name = "tanı";
            this.tanı.Size = new System.Drawing.Size(277, 146);
            this.tanı.TabIndex = 104;
            this.tanı.TabStop = false;
            this.tanı.Text = "Soyad";
            this.tanı.TextChanged += new System.EventHandler(this.tanı_TextChanged);
            // 
            // tarih
            // 
            this.tarih.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarih.Checked = false;
            this.tarih.Enabled = false;
            this.tarih.Location = new System.Drawing.Point(178, 143);
            this.tarih.MaxDate = new System.DateTime(2021, 1, 11, 0, 0, 0, 0);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(197, 20);
            this.tarih.TabIndex = 91;
            this.tarih.Value = new System.DateTime(2021, 1, 11, 0, 0, 0, 0);
            this.tarih.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // epos
            // 
            this.epos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.epos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.epos.Enabled = false;
            this.epos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.epos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.epos.HideSelection = false;
            this.epos.Location = new System.Drawing.Point(178, 418);
            this.epos.Multiline = true;
            this.epos.Name = "epos";
            this.epos.Size = new System.Drawing.Size(197, 23);
            this.epos.TabIndex = 89;
            this.epos.TabStop = false;
            this.epos.Text = "E-posta";
            this.epos.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // baba
            // 
            this.baba.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.baba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baba.Enabled = false;
            this.baba.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baba.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.baba.HideSelection = false;
            this.baba.Location = new System.Drawing.Point(178, 247);
            this.baba.Multiline = true;
            this.baba.Name = "baba";
            this.baba.Size = new System.Drawing.Size(197, 23);
            this.baba.TabIndex = 86;
            this.baba.TabStop = false;
            this.baba.Text = "Baba Adı";
            this.baba.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // ad
            // 
            this.ad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ad.Enabled = false;
            this.ad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ad.HideSelection = false;
            this.ad.Location = new System.Drawing.Point(178, 77);
            this.ad.Multiline = true;
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(197, 23);
            this.ad.TabIndex = 85;
            this.ad.TabStop = false;
            this.ad.Text = "Ad";
            this.ad.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // soyad
            // 
            this.soyad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.soyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.soyad.Enabled = false;
            this.soyad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soyad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.soyad.HideSelection = false;
            this.soyad.Location = new System.Drawing.Point(178, 111);
            this.soyad.Multiline = true;
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(197, 23);
            this.soyad.TabIndex = 84;
            this.soyad.TabStop = false;
            this.soyad.Text = "Soyad";
            this.soyad.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // anne
            // 
            this.anne.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.anne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.anne.Enabled = false;
            this.anne.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anne.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.anne.HideSelection = false;
            this.anne.Location = new System.Drawing.Point(178, 214);
            this.anne.Multiline = true;
            this.anne.Name = "anne";
            this.anne.Size = new System.Drawing.Size(197, 23);
            this.anne.TabIndex = 83;
            this.anne.TabStop = false;
            this.anne.Text = "Anne Adı";
            this.anne.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label12.Location = new System.Drawing.Point(48, 281);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 16);
            this.label12.TabIndex = 93;
            this.label12.Text = "Kan Grubu:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label13.Location = new System.Drawing.Point(46, 314);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 16);
            this.label13.TabIndex = 95;
            this.label13.Text = "Medeni Durum:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label11.Location = new System.Drawing.Point(30, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 16);
            this.label11.TabIndex = 102;
            this.label11.Text = "KRONİK HASTALIKLAR:";
            this.label11.Click += new System.EventHandler(this.label11_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.hastalıklar);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(419, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 195);
            this.panel2.TabIndex = 101;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // hastalıklar
            // 
            this.hastalıklar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hastalıklar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hastalıklar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hastalıklar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hastalıklar.HideSelection = false;
            this.hastalıklar.Location = new System.Drawing.Point(33, 35);
            this.hastalıklar.Multiline = true;
            this.hastalıklar.Name = "hastalıklar";
            this.hastalıklar.Size = new System.Drawing.Size(277, 138);
            this.hastalıklar.TabIndex = 103;
            this.hastalıklar.TabStop = false;
            this.hastalıklar.Text = "Soyad";
            // 
            // tele
            // 
            this.tele.Enabled = false;
            this.tele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tele.Location = new System.Drawing.Point(178, 379);
            this.tele.Mask = "(999) 000-0000";
            this.tele.Name = "tele";
            this.tele.Size = new System.Drawing.Size(197, 26);
            this.tele.TabIndex = 103;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label15.Location = new System.Drawing.Point(48, 176);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 16);
            this.label15.TabIndex = 104;
            this.label15.Text = "Doğum Yeri:";
            // 
            // dyer
            // 
            this.dyer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dyer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dyer.Enabled = false;
            this.dyer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dyer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dyer.HideSelection = false;
            this.dyer.Location = new System.Drawing.Point(178, 176);
            this.dyer.Multiline = true;
            this.dyer.Name = "dyer";
            this.dyer.Size = new System.Drawing.Size(197, 23);
            this.dyer.TabIndex = 105;
            this.dyer.TabStop = false;
            this.dyer.Text = "Doğum Yeri";
            // 
            // tck
            // 
            this.tck.Location = new System.Drawing.Point(178, 42);
            this.tck.Name = "tck";
            this.tck.Size = new System.Drawing.Size(197, 20);
            this.tck.TabIndex = 108;
            this.tck.TextChanged += new System.EventHandler(this.tck_TextChanged);
            // 
            // kangrubu
            // 
            this.kangrubu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kangrubu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kangrubu.Enabled = false;
            this.kangrubu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kangrubu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kangrubu.HideSelection = false;
            this.kangrubu.Location = new System.Drawing.Point(178, 281);
            this.kangrubu.Multiline = true;
            this.kangrubu.Name = "kangrubu";
            this.kangrubu.Size = new System.Drawing.Size(197, 23);
            this.kangrubu.TabIndex = 112;
            this.kangrubu.TabStop = false;
            this.kangrubu.Text = "Kan Grubu";
            // 
            // med
            // 
            this.med.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.med.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.med.Enabled = false;
            this.med.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.med.HideSelection = false;
            this.med.Location = new System.Drawing.Point(178, 315);
            this.med.Multiline = true;
            this.med.Name = "med";
            this.med.Size = new System.Drawing.Size(197, 23);
            this.med.TabIndex = 113;
            this.med.TabStop = false;
            this.med.Text = "Medeni Hal";
            // 
            // cin
            // 
            this.cin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cin.Enabled = false;
            this.cin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cin.HideSelection = false;
            this.cin.Location = new System.Drawing.Point(178, 350);
            this.cin.Multiline = true;
            this.cin.Name = "cin";
            this.cin.Size = new System.Drawing.Size(197, 23);
            this.cin.TabIndex = 114;
            this.cin.TabStop = false;
            this.cin.Text = "Cinsiyet";
            // 
            // Ara
            // 
            this.Ara.BackColor = System.Drawing.Color.Transparent;
            this.Ara.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.Ara.IconColor = System.Drawing.Color.Black;
            this.Ara.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Ara.IconSize = 20;
            this.Ara.Location = new System.Drawing.Point(381, 42);
            this.Ara.Name = "Ara";
            this.Ara.Size = new System.Drawing.Size(41, 28);
            this.Ara.TabIndex = 115;
            this.Ara.UseVisualStyleBackColor = false;
            this.Ara.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hasta_tc,
            this.hasta_adi,
            this.hasta_soyadi,
            this.dogum_tarihi,
            this.dogum_yeri,
            this.anne_adi,
            this.baba_adi,
            this.kan_grubu,
            this.cinsiyetDataGridViewTextBoxColumn,
            this.medeni_hal,
            this.telefon,
            this.e_posta,
            this.tani_dk});
            this.dataGridView1.DataSource = this.hastaGirişiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 561);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(785, 127);
            this.dataGridView1.TabIndex = 116;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // hasta_tc
            // 
            this.hasta_tc.DataPropertyName = "hasta_tc";
            this.hasta_tc.HeaderText = "TC";
            this.hasta_tc.Name = "hasta_tc";
            // 
            // hasta_adi
            // 
            this.hasta_adi.DataPropertyName = "hasta_adi";
            this.hasta_adi.HeaderText = "Hasta Adı";
            this.hasta_adi.Name = "hasta_adi";
            // 
            // hasta_soyadi
            // 
            this.hasta_soyadi.DataPropertyName = "hasta_soyadi";
            this.hasta_soyadi.HeaderText = "Hasta Soyadı";
            this.hasta_soyadi.Name = "hasta_soyadi";
            // 
            // dogum_tarihi
            // 
            this.dogum_tarihi.DataPropertyName = "dogum_tarihi";
            this.dogum_tarihi.HeaderText = "Doğum Tarihi";
            this.dogum_tarihi.Name = "dogum_tarihi";
            // 
            // dogum_yeri
            // 
            this.dogum_yeri.DataPropertyName = "dogum_yeri";
            this.dogum_yeri.HeaderText = "Doğum Yeri";
            this.dogum_yeri.Name = "dogum_yeri";
            // 
            // anne_adi
            // 
            this.anne_adi.DataPropertyName = "anne_adi";
            this.anne_adi.HeaderText = "Anne Adı";
            this.anne_adi.Name = "anne_adi";
            // 
            // baba_adi
            // 
            this.baba_adi.DataPropertyName = "baba_adi";
            this.baba_adi.HeaderText = "Baba Adı";
            this.baba_adi.Name = "baba_adi";
            // 
            // kan_grubu
            // 
            this.kan_grubu.DataPropertyName = "kan_grubu";
            this.kan_grubu.HeaderText = "Kan Grubu";
            this.kan_grubu.Name = "kan_grubu";
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            // 
            // medeni_hal
            // 
            this.medeni_hal.DataPropertyName = "medeni_hal";
            this.medeni_hal.HeaderText = "Medeni Hal";
            this.medeni_hal.Name = "medeni_hal";
            // 
            // telefon
            // 
            this.telefon.DataPropertyName = "telefon";
            this.telefon.HeaderText = "Telefon";
            this.telefon.Name = "telefon";
            // 
            // e_posta
            // 
            this.e_posta.DataPropertyName = "e_posta";
            this.e_posta.HeaderText = "E-posta";
            this.e_posta.Name = "e_posta";
            // 
            // tani_dk
            // 
            this.tani_dk.DataPropertyName = "tani_dk";
            this.tani_dk.HeaderText = "Tanı";
            this.tani_dk.Name = "tani_dk";
            // 
            // hastaGirişiBindingSource
            // 
            this.hastaGirişiBindingSource.DataMember = "Hasta_Girişi";
            this.hastaGirişiBindingSource.DataSource = this.hastaneVeritabanıDataSet;
            // 
            // hastaneVeritabanıDataSet
            // 
            this.hastaneVeritabanıDataSet.DataSetName = "HastaneVeritabanıDataSet";
            this.hastaneVeritabanıDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hasta_GirişiTableAdapter
            // 
            this.hasta_GirişiTableAdapter.ClearBeforeFill = true;
            // 
            // Kaydet
            // 
            this.Kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.Kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kaydet.ForeColor = System.Drawing.Color.White;
            this.Kaydet.Location = new System.Drawing.Point(663, 487);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(93, 47);
            this.Kaydet.TabIndex = 117;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = false;
            // 
            // Güncelle
            // 
            this.Güncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.Güncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Güncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Güncelle.ForeColor = System.Drawing.Color.White;
            this.Güncelle.Location = new System.Drawing.Point(564, 487);
            this.Güncelle.Name = "Güncelle";
            this.Güncelle.Size = new System.Drawing.Size(93, 47);
            this.Güncelle.TabIndex = 118;
            this.Güncelle.Text = "Güncelle";
            this.Güncelle.UseVisualStyleBackColor = false;
            // 
            // HastaBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(804, 694);
            this.Controls.Add(this.Güncelle);
            this.Controls.Add(this.Kaydet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Ara);
            this.Controls.Add(this.cin);
            this.Controls.Add(this.med);
            this.Controls.Add(this.kangrubu);
            this.Controls.Add(this.tck);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dyer);
            this.Controls.Add(this.tele);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.epos);
            this.Controls.Add(this.baba);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.anne);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HastaBilgileri";
            this.Text = "HastaBilgileri";
            this.Load += new System.EventHandler(this.HastaBilgileri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaGirişiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneVeritabanıDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.TextBox epos;
        private System.Windows.Forms.TextBox baba;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.TextBox anne;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tanı;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox hastalıklar;
        private System.Windows.Forms.MaskedTextBox tele;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox dyer;
        private System.Windows.Forms.TextBox tck;
        private System.Windows.Forms.TextBox kangrubu;
        private System.Windows.Forms.TextBox med;
        private System.Windows.Forms.TextBox cin;
        private FontAwesome.Sharp.IconButton Ara;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HastaneVeritabanıDataSet hastaneVeritabanıDataSet;
        private System.Windows.Forms.BindingSource hastaGirişiBindingSource;
        private HastaneVeritabanıDataSetTableAdapters.Hasta_GirişiTableAdapter hasta_GirişiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasta_tc;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasta_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasta_soyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogum_tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogum_yeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn anne_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn baba_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kan_grubu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medeni_hal;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn e_posta;
        private System.Windows.Forms.DataGridViewTextBoxColumn tani_dk;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.Button Güncelle;
    }
}