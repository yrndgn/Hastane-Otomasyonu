
namespace Hastane_1
{
    partial class Bekleyen_Hastalar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bekleyen_Hastalar));
            this.dok = new System.Windows.Forms.Label();
            this.Formpanel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hastaKabulBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneVeritabanıDataSet9 = new Hastane_1.HastaneVeritabanıDataSet9();
            this.button2 = new System.Windows.Forms.Button();
            this.doktor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.hasta_ıd = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hastaKabulBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hasta_KabulTableAdapter = new Hastane_1.HastaneVeritabanıDataSet9TableAdapters.Hasta_KabulTableAdapter();
            this.kblhastatcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kblhastaadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kblhastasoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kbldogum_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kbldogum_yeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kblanne_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kblbaba_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kblkan_grubu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kblmedeni_hal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kblcinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kbltelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kble_posta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formpanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKabulBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneVeritabanıDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKabulBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dok
            // 
            this.dok.AutoSize = true;
            this.dok.BackColor = System.Drawing.Color.Transparent;
            this.dok.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dok.ForeColor = System.Drawing.Color.Transparent;
            this.dok.Location = new System.Drawing.Point(591, 539);
            this.dok.Name = "dok";
            this.dok.Size = new System.Drawing.Size(67, 16);
            this.dok.TabIndex = 131;
            this.dok.Text = "Hasta Tc:";
            // 
            // Formpanel1
            // 
            this.Formpanel1.AutoScroll = true;
            this.Formpanel1.BackColor = System.Drawing.Color.White;
            this.Formpanel1.Controls.Add(this.dataGridView1);
            this.Formpanel1.Controls.Add(this.button2);
            this.Formpanel1.Controls.Add(this.dok);
            this.Formpanel1.Controls.Add(this.doktor);
            this.Formpanel1.Controls.Add(this.label4);
            this.Formpanel1.Controls.Add(this.label3);
            this.Formpanel1.Controls.Add(this.button1);
            this.Formpanel1.Controls.Add(this.hasta_ıd);
            this.Formpanel1.Controls.Add(this.iconPictureBox1);
            this.Formpanel1.Controls.Add(this.bunifuGradientPanel1);
            this.Formpanel1.Controls.Add(this.label1);
            this.Formpanel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Formpanel1.Location = new System.Drawing.Point(0, 0);
            this.Formpanel1.Name = "Formpanel1";
            this.Formpanel1.Size = new System.Drawing.Size(1160, 704);
            this.Formpanel1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kblhastatcDataGridViewTextBoxColumn,
            this.kblhastaadiDataGridViewTextBoxColumn,
            this.kblhastasoyadiDataGridViewTextBoxColumn,
            this.kbldogum_tarihi,
            this.kbldogum_yeri,
            this.kblanne_adi,
            this.kblbaba_adi,
            this.kblkan_grubu,
            this.kblmedeni_hal,
            this.kblcinsiyet,
            this.kbltelefon,
            this.kble_posta});
            this.dataGridView1.DataSource = this.hastaKabulBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1136, 391);
            this.dataGridView1.TabIndex = 140;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // hastaKabulBindingSource1
            // 
            this.hastaKabulBindingSource1.DataMember = "Hasta_Kabul";
            this.hastaKabulBindingSource1.DataSource = this.hastaneVeritabanıDataSet9;
            // 
            // hastaneVeritabanıDataSet9
            // 
            this.hastaneVeritabanıDataSet9.DataSetName = "HastaneVeritabanıDataSet9";
            this.hastaneVeritabanıDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(248)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button2.Location = new System.Drawing.Point(938, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 33);
            this.button2.TabIndex = 132;
            this.button2.Text = "Hastaları Göster";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // doktor
            // 
            this.doktor.BackColor = System.Drawing.Color.White;
            this.doktor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.doktor.Enabled = false;
            this.doktor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doktor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.doktor.HideSelection = false;
            this.doktor.Location = new System.Drawing.Point(964, 110);
            this.doktor.Multiline = true;
            this.doktor.Name = "doktor";
            this.doktor.Size = new System.Drawing.Size(197, 22);
            this.doktor.TabIndex = 130;
            this.doktor.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(560, 626);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 129;
            this.label4.Text = "Hasta Tc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label3.Location = new System.Drawing.Point(759, 616);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 128;
            this.label3.Text = "Hasta Tc:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(248)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button1.Location = new System.Drawing.Point(1049, 603);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 39);
            this.button1.TabIndex = 127;
            this.button1.Text = "Hasta Seç";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hasta_ıd
            // 
            this.hasta_ıd.BackColor = System.Drawing.Color.White;
            this.hasta_ıd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hasta_ıd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasta_ıd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hasta_ıd.HideSelection = false;
            this.hasta_ıd.Location = new System.Drawing.Point(832, 614);
            this.hasta_ıd.Multiline = true;
            this.hasta_ıd.Name = "hasta_ıd";
            this.hasta_ıd.Size = new System.Drawing.Size(197, 22);
            this.hasta_ıd.TabIndex = 126;
            this.hasta_ıd.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 39;
            this.iconPictureBox1.Location = new System.Drawing.Point(17, 602);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(42, 39);
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.AutoScroll = true;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.panel4);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(171)))), ((int)(((byte)(238)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(185)))), ((int)(((byte)(241)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(199)))), ((int)(((byte)(244)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(2, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1156, 104);
            this.bunifuGradientPanel1.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.iconPictureBox3);
            this.panel4.Controls.Add(this.iconPictureBox2);
            this.panel4.Cursor = System.Windows.Forms.Cursors.No;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1156, 88);
            this.panel4.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(380, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 55);
            this.label2.TabIndex = 81;
            this.label2.Text = "Bekleyen Hastalar";
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconPictureBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 37;
            this.iconPictureBox3.Location = new System.Drawing.Point(1084, 8);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(62, 37);
            this.iconPictureBox3.TabIndex = 80;
            this.iconPictureBox3.TabStop = false;
            this.iconPictureBox3.Click += new System.EventHandler(this.iconPictureBox3_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.HospitalAlt;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 56;
            this.iconPictureBox2.Location = new System.Drawing.Point(5, 8);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(81, 56);
            this.iconPictureBox2.TabIndex = 36;
            this.iconPictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(47, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 0;
            // 
            // hastaKabulBindingSource
            // 
            this.hastaKabulBindingSource.DataMember = "Hasta_Kabul";
            this.hastaKabulBindingSource.DataSource = this.hastaneVeritabanıDataSet9;
            // 
            // hasta_KabulTableAdapter
            // 
            this.hasta_KabulTableAdapter.ClearBeforeFill = true;
            // 
            // kblhastatcDataGridViewTextBoxColumn
            // 
            this.kblhastatcDataGridViewTextBoxColumn.DataPropertyName = "kblhasta_tc";
            this.kblhastatcDataGridViewTextBoxColumn.HeaderText = "Hasta TC";
            this.kblhastatcDataGridViewTextBoxColumn.Name = "kblhastatcDataGridViewTextBoxColumn";
            this.kblhastatcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kblhastaadiDataGridViewTextBoxColumn
            // 
            this.kblhastaadiDataGridViewTextBoxColumn.DataPropertyName = "kblhasta_adi";
            this.kblhastaadiDataGridViewTextBoxColumn.HeaderText = "Hasta Adı";
            this.kblhastaadiDataGridViewTextBoxColumn.Name = "kblhastaadiDataGridViewTextBoxColumn";
            this.kblhastaadiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kblhastasoyadiDataGridViewTextBoxColumn
            // 
            this.kblhastasoyadiDataGridViewTextBoxColumn.DataPropertyName = "kblhasta_soyadi";
            this.kblhastasoyadiDataGridViewTextBoxColumn.HeaderText = "Hasta Soyadı";
            this.kblhastasoyadiDataGridViewTextBoxColumn.Name = "kblhastasoyadiDataGridViewTextBoxColumn";
            this.kblhastasoyadiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kbldogum_tarihi
            // 
            this.kbldogum_tarihi.DataPropertyName = "kbldogum_tarihi";
            this.kbldogum_tarihi.HeaderText = "Doğum Tarihi";
            this.kbldogum_tarihi.Name = "kbldogum_tarihi";
            this.kbldogum_tarihi.ReadOnly = true;
            // 
            // kbldogum_yeri
            // 
            this.kbldogum_yeri.DataPropertyName = "kbldogum_yeri";
            this.kbldogum_yeri.HeaderText = "Doğum Yeri";
            this.kbldogum_yeri.Name = "kbldogum_yeri";
            this.kbldogum_yeri.ReadOnly = true;
            // 
            // kblanne_adi
            // 
            this.kblanne_adi.DataPropertyName = "kblanne_adi";
            this.kblanne_adi.HeaderText = "Anne Adı";
            this.kblanne_adi.Name = "kblanne_adi";
            this.kblanne_adi.ReadOnly = true;
            // 
            // kblbaba_adi
            // 
            this.kblbaba_adi.DataPropertyName = "kblbaba_adi";
            this.kblbaba_adi.HeaderText = "Baba Adı";
            this.kblbaba_adi.Name = "kblbaba_adi";
            this.kblbaba_adi.ReadOnly = true;
            // 
            // kblkan_grubu
            // 
            this.kblkan_grubu.DataPropertyName = "kblkan_grubu";
            this.kblkan_grubu.HeaderText = "Kan Grubu";
            this.kblkan_grubu.Name = "kblkan_grubu";
            this.kblkan_grubu.ReadOnly = true;
            // 
            // kblmedeni_hal
            // 
            this.kblmedeni_hal.DataPropertyName = "kblmedeni_hal";
            this.kblmedeni_hal.HeaderText = "Medeni_hal";
            this.kblmedeni_hal.Name = "kblmedeni_hal";
            this.kblmedeni_hal.ReadOnly = true;
            // 
            // kblcinsiyet
            // 
            this.kblcinsiyet.DataPropertyName = "kblcinsiyet";
            this.kblcinsiyet.HeaderText = "Cinsiyet";
            this.kblcinsiyet.Name = "kblcinsiyet";
            this.kblcinsiyet.ReadOnly = true;
            // 
            // kbltelefon
            // 
            this.kbltelefon.DataPropertyName = "kbltelefon";
            this.kbltelefon.HeaderText = "Telefon";
            this.kbltelefon.Name = "kbltelefon";
            this.kbltelefon.ReadOnly = true;
            // 
            // kble_posta
            // 
            this.kble_posta.DataPropertyName = "kble_posta";
            this.kble_posta.HeaderText = "E-posta";
            this.kble_posta.Name = "kble_posta";
            this.kble_posta.ReadOnly = true;
            // 
            // Bekleyen_Hastalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 689);
            this.Controls.Add(this.Formpanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bekleyen_Hastalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bekleyen_Hastalar";
            this.Load += new System.EventHandler(this.Bekleyen_Hastalar_Load);
            this.Formpanel1.ResumeLayout(false);
            this.Formpanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKabulBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneVeritabanıDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKabulBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        public System.Windows.Forms.Label dok;
        private System.Windows.Forms.Panel Formpanel1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox doktor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox hasta_ıd;
        private System.Windows.Forms.Label label1;
        private HastaneVeritabanıDataSet9 hastaneVeritabanıDataSet9;
        private System.Windows.Forms.BindingSource hastaKabulBindingSource;
        private HastaneVeritabanıDataSet9TableAdapters.Hasta_KabulTableAdapter hasta_KabulTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hastaKabulBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kblhastatcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kblhastaadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kblhastasoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kbldogum_tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kbldogum_yeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn kblanne_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kblbaba_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kblkan_grubu;
        private System.Windows.Forms.DataGridViewTextBoxColumn kblmedeni_hal;
        private System.Windows.Forms.DataGridViewTextBoxColumn kblcinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn kbltelefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn kble_posta;
    }
}