
namespace Hastane_1
{
    partial class Tahlil_Seç
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tahlil_Seç));
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Formpanel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kblhastatcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kblhastaadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kblhastasoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kblhastaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kbltahlilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kblbolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kbldoktorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kbltahlilsonucuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaKabulBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneVeritabanıDataSet9 = new Hastane_1.HastaneVeritabanıDataSet9();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dtarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.hasta_KabulTableAdapter = new Hastane_1.HastaneVeritabanıDataSet9TableAdapters.Hasta_KabulTableAdapter();
            this.Formpanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKabulBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneVeritabanıDataSet9)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label20.Location = new System.Drawing.Point(826, 140);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 16);
            this.label20.TabIndex = 141;
            this.label20.Text = "Testler:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label19.Location = new System.Drawing.Point(12, 151);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 16);
            this.label19.TabIndex = 140;
            this.label19.Text = "Hasta TC";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label18.Location = new System.Drawing.Point(853, 191);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 16);
            this.label18.TabIndex = 139;
            this.label18.Text = "Tarih:";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox6.HideSelection = false;
            this.textBox6.Location = new System.Drawing.Point(912, 266);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(211, 181);
            this.textBox6.TabIndex = 137;
            this.textBox6.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox3.HideSelection = false;
            this.textBox3.Location = new System.Drawing.Point(95, 149);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(147, 24);
            this.textBox3.TabIndex = 134;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "TC Kimlik No";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(248)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button4.Location = new System.Drawing.Point(920, 477);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(203, 31);
            this.button4.TabIndex = 132;
            this.button4.Text = "Gönder";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(248)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button3.Location = new System.Drawing.Point(678, 446);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 28);
            this.button3.TabIndex = 131;
            this.button3.Text = "Seç";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(44, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 0;
            // 
            // Formpanel1
            // 
            this.Formpanel1.AutoScroll = true;
            this.Formpanel1.BackColor = System.Drawing.Color.White;
            this.Formpanel1.Controls.Add(this.dataGridView1);
            this.Formpanel1.Controls.Add(this.label5);
            this.Formpanel1.Controls.Add(this.textBox2);
            this.Formpanel1.Controls.Add(this.dtarih);
            this.Formpanel1.Controls.Add(this.label3);
            this.Formpanel1.Controls.Add(this.label20);
            this.Formpanel1.Controls.Add(this.label19);
            this.Formpanel1.Controls.Add(this.label18);
            this.Formpanel1.Controls.Add(this.textBox6);
            this.Formpanel1.Controls.Add(this.textBox3);
            this.Formpanel1.Controls.Add(this.button4);
            this.Formpanel1.Controls.Add(this.button3);
            this.Formpanel1.Controls.Add(this.bunifuGradientPanel1);
            this.Formpanel1.Controls.Add(this.label1);
            this.Formpanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Formpanel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Formpanel1.Location = new System.Drawing.Point(0, -3);
            this.Formpanel1.Name = "Formpanel1";
            this.Formpanel1.Size = new System.Drawing.Size(1160, 679);
            this.Formpanel1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kblhastatcDataGridViewTextBoxColumn,
            this.kblhastaadiDataGridViewTextBoxColumn,
            this.kblhastasoyadiDataGridViewTextBoxColumn,
            this.kblhastaidDataGridViewTextBoxColumn,
            this.kbltahlilDataGridViewTextBoxColumn,
            this.kblbolumDataGridViewTextBoxColumn,
            this.kbldoktorDataGridViewTextBoxColumn,
            this.kbltahlilsonucuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hastaKabulBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(15, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(789, 181);
            this.dataGridView1.TabIndex = 150;
            // 
            // kblhastatcDataGridViewTextBoxColumn
            // 
            this.kblhastatcDataGridViewTextBoxColumn.DataPropertyName = "kblhasta_tc";
            this.kblhastatcDataGridViewTextBoxColumn.HeaderText = "Hasta Tc";
            this.kblhastatcDataGridViewTextBoxColumn.Name = "kblhastatcDataGridViewTextBoxColumn";
            // 
            // kblhastaadiDataGridViewTextBoxColumn
            // 
            this.kblhastaadiDataGridViewTextBoxColumn.DataPropertyName = "kblhasta_adi";
            this.kblhastaadiDataGridViewTextBoxColumn.HeaderText = "Hasta Adı";
            this.kblhastaadiDataGridViewTextBoxColumn.Name = "kblhastaadiDataGridViewTextBoxColumn";
            // 
            // kblhastasoyadiDataGridViewTextBoxColumn
            // 
            this.kblhastasoyadiDataGridViewTextBoxColumn.DataPropertyName = "kblhasta_soyadi";
            this.kblhastasoyadiDataGridViewTextBoxColumn.HeaderText = "Hasta Soyadı";
            this.kblhastasoyadiDataGridViewTextBoxColumn.Name = "kblhastasoyadiDataGridViewTextBoxColumn";
            // 
            // kblhastaidDataGridViewTextBoxColumn
            // 
            this.kblhastaidDataGridViewTextBoxColumn.DataPropertyName = "kblhasta_id";
            this.kblhastaidDataGridViewTextBoxColumn.HeaderText = "Hasta id";
            this.kblhastaidDataGridViewTextBoxColumn.Name = "kblhastaidDataGridViewTextBoxColumn";
            this.kblhastaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kbltahlilDataGridViewTextBoxColumn
            // 
            this.kbltahlilDataGridViewTextBoxColumn.DataPropertyName = "kbltahlil";
            this.kbltahlilDataGridViewTextBoxColumn.HeaderText = "İstenen Tahlil";
            this.kbltahlilDataGridViewTextBoxColumn.Name = "kbltahlilDataGridViewTextBoxColumn";
            // 
            // kblbolumDataGridViewTextBoxColumn
            // 
            this.kblbolumDataGridViewTextBoxColumn.DataPropertyName = "kblbolum";
            this.kblbolumDataGridViewTextBoxColumn.HeaderText = "Klinik";
            this.kblbolumDataGridViewTextBoxColumn.Name = "kblbolumDataGridViewTextBoxColumn";
            // 
            // kbldoktorDataGridViewTextBoxColumn
            // 
            this.kbldoktorDataGridViewTextBoxColumn.DataPropertyName = "kbldoktor";
            this.kbldoktorDataGridViewTextBoxColumn.HeaderText = "Doktor";
            this.kbldoktorDataGridViewTextBoxColumn.Name = "kbldoktorDataGridViewTextBoxColumn";
            // 
            // kbltahlilsonucuDataGridViewTextBoxColumn
            // 
            this.kbltahlilsonucuDataGridViewTextBoxColumn.DataPropertyName = "kbltahlilsonucu";
            this.kbltahlilsonucuDataGridViewTextBoxColumn.HeaderText = "Tahlil Sonucu";
            this.kbltahlilsonucuDataGridViewTextBoxColumn.Name = "kbltahlilsonucuDataGridViewTextBoxColumn";
            // 
            // hastaKabulBindingSource
            // 
            this.hastaKabulBindingSource.DataMember = "Hasta_Kabul";
            this.hastaKabulBindingSource.DataSource = this.hastaneVeritabanıDataSet9;
            // 
            // hastaneVeritabanıDataSet9
            // 
            this.hastaneVeritabanıDataSet9.DataSetName = "HastaneVeritabanıDataSet9";
            this.hastaneVeritabanıDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(364, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 149;
            this.label5.Text = "Tahlil ID";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox2.HideSelection = false;
            this.textBox2.Location = new System.Drawing.Point(912, 138);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 29);
            this.textBox2.TabIndex = 148;
            this.textBox2.TabStop = false;
            // 
            // dtarih
            // 
            this.dtarih.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtarih.Checked = false;
            this.dtarih.Location = new System.Drawing.Point(912, 187);
            this.dtarih.Name = "dtarih";
            this.dtarih.Size = new System.Drawing.Size(211, 20);
            this.dtarih.TabIndex = 147;
            this.dtarih.Value = new System.DateTime(2021, 1, 9, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label3.Location = new System.Drawing.Point(810, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 144;
            this.label3.Text = "Test Sonucu:";
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
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1158, 102);
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
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1158, 102);
            this.panel4.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(464, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 55);
            this.label2.TabIndex = 81;
            this.label2.Text = "Tahlil";
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconPictureBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 38;
            this.iconPictureBox3.Location = new System.Drawing.Point(1093, 7);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(62, 38);
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
            this.iconPictureBox2.IconSize = 57;
            this.iconPictureBox2.Location = new System.Drawing.Point(12, 15);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(81, 57);
            this.iconPictureBox2.TabIndex = 36;
            this.iconPictureBox2.TabStop = false;
            // 
            // hasta_KabulTableAdapter
            // 
            this.hasta_KabulTableAdapter.ClearBeforeFill = true;
            // 
            // Tahlil_Seç
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 676);
            this.Controls.Add(this.Formpanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tahlil_Seç";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tahlil_Seç";
            this.Load += new System.EventHandler(this.Tahlil_Seç_Load);
            this.Formpanel1.ResumeLayout(false);
            this.Formpanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKabulBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneVeritabanıDataSet9)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Formpanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dtarih;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HastaneVeritabanıDataSet9 hastaneVeritabanıDataSet9;
        private System.Windows.Forms.BindingSource hastaKabulBindingSource;
        private HastaneVeritabanıDataSet9TableAdapters.Hasta_KabulTableAdapter hasta_KabulTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kblhastatcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kblhastaadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kblhastasoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kblhastaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kbltahlilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kblbolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kbldoktorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kbltahlilsonucuDataGridViewTextBoxColumn;
    }
}