
namespace Hastane_1
{
    partial class Randevu_İptal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Randevu_İptal));
            this.Formpanel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.randevuAlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneVeritabanıDataSet8 = new Hastane_1.HastaneVeritabanıDataSet8();
            this.label4 = new System.Windows.Forms.Label();
            this.doktor = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.hastatc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.randevu_AlTableAdapter = new Hastane_1.HastaneVeritabanıDataSet8TableAdapters.Randevu_AlTableAdapter();
            this.randevualınanbölümDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevualınandoktorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevutarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevusaatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastatc2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formpanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuAlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneVeritabanıDataSet8)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Formpanel1
            // 
            this.Formpanel1.AutoScroll = true;
            this.Formpanel1.BackColor = System.Drawing.Color.White;
            this.Formpanel1.Controls.Add(this.dataGridView1);
            this.Formpanel1.Controls.Add(this.label4);
            this.Formpanel1.Controls.Add(this.doktor);
            this.Formpanel1.Controls.Add(this.button2);
            this.Formpanel1.Controls.Add(this.label3);
            this.Formpanel1.Controls.Add(this.hastatc);
            this.Formpanel1.Controls.Add(this.button1);
            this.Formpanel1.Controls.Add(this.bunifuGradientPanel1);
            this.Formpanel1.Controls.Add(this.label1);
            this.Formpanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Formpanel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Formpanel1.Location = new System.Drawing.Point(0, 0);
            this.Formpanel1.Name = "Formpanel1";
            this.Formpanel1.Size = new System.Drawing.Size(1158, 690);
            this.Formpanel1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.randevualınanbölümDataGridViewTextBoxColumn,
            this.randevualınandoktorDataGridViewTextBoxColumn,
            this.randevutarihiDataGridViewTextBoxColumn,
            this.randevusaatiDataGridViewTextBoxColumn,
            this.hastaid,
            this.hastatc2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.randevuAlBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(14, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1136, 391);
            this.dataGridView1.TabIndex = 145;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // randevuAlBindingSource
            // 
            this.randevuAlBindingSource.DataMember = "Randevu_Al";
            this.randevuAlBindingSource.DataSource = this.hastaneVeritabanıDataSet8;
            // 
            // hastaneVeritabanıDataSet8
            // 
            this.hastaneVeritabanıDataSet8.DataSetName = "HastaneVeritabanıDataSet8";
            this.hastaneVeritabanıDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(560, 562);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 144;
            this.label4.Text = "Hasta Tc:";
            // 
            // doktor
            // 
            this.doktor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.doktor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.doktor.Enabled = false;
            this.doktor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doktor.ForeColor = System.Drawing.Color.Black;
            this.doktor.HideSelection = false;
            this.doktor.Location = new System.Drawing.Point(958, 108);
            this.doktor.Multiline = true;
            this.doktor.Name = "doktor";
            this.doktor.Size = new System.Drawing.Size(197, 22);
            this.doktor.TabIndex = 141;
            this.doktor.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(248)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button2.Location = new System.Drawing.Point(965, 525);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 31);
            this.button2.TabIndex = 142;
            this.button2.Text = "Randevuları Göster";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label3.Location = new System.Drawing.Point(752, 612);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 140;
            this.label3.Text = "Hasta Tc:";
            // 
            // hastatc
            // 
            this.hastatc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hastatc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hastatc.Enabled = false;
            this.hastatc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hastatc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hastatc.HideSelection = false;
            this.hastatc.Location = new System.Drawing.Point(825, 610);
            this.hastatc.Multiline = true;
            this.hastatc.Name = "hastatc";
            this.hastatc.Size = new System.Drawing.Size(197, 23);
            this.hastatc.TabIndex = 138;
            this.hastatc.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(248)))));
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button1.Location = new System.Drawing.Point(1028, 599);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 40);
            this.button1.TabIndex = 127;
            this.button1.Text = "Randevu İptal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1158, 88);
            this.panel4.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(427, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 55);
            this.label2.TabIndex = 81;
            this.label2.Text = "Randevu İptal";
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
            this.iconPictureBox2.Location = new System.Drawing.Point(14, 7);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(81, 57);
            this.iconPictureBox2.TabIndex = 36;
            this.iconPictureBox2.TabStop = false;
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
            // randevu_AlTableAdapter
            // 
            this.randevu_AlTableAdapter.ClearBeforeFill = true;
            // 
            // randevualınanbölümDataGridViewTextBoxColumn
            // 
            this.randevualınanbölümDataGridViewTextBoxColumn.DataPropertyName = "randevu_alınan_bölüm";
            this.randevualınanbölümDataGridViewTextBoxColumn.HeaderText = "Klinik";
            this.randevualınanbölümDataGridViewTextBoxColumn.Name = "randevualınanbölümDataGridViewTextBoxColumn";
            // 
            // randevualınandoktorDataGridViewTextBoxColumn
            // 
            this.randevualınandoktorDataGridViewTextBoxColumn.DataPropertyName = "randevu_alınan_doktor";
            this.randevualınandoktorDataGridViewTextBoxColumn.HeaderText = "Doktor";
            this.randevualınandoktorDataGridViewTextBoxColumn.Name = "randevualınandoktorDataGridViewTextBoxColumn";
            // 
            // randevutarihiDataGridViewTextBoxColumn
            // 
            this.randevutarihiDataGridViewTextBoxColumn.DataPropertyName = "randevu_tarihi";
            this.randevutarihiDataGridViewTextBoxColumn.HeaderText = "Randevu Tarihi";
            this.randevutarihiDataGridViewTextBoxColumn.Name = "randevutarihiDataGridViewTextBoxColumn";
            // 
            // randevusaatiDataGridViewTextBoxColumn
            // 
            this.randevusaatiDataGridViewTextBoxColumn.DataPropertyName = "randevu_saati";
            this.randevusaatiDataGridViewTextBoxColumn.HeaderText = "Randevu Saati";
            this.randevusaatiDataGridViewTextBoxColumn.Name = "randevusaatiDataGridViewTextBoxColumn";
            // 
            // hastaid
            // 
            this.hastaid.DataPropertyName = "hastaid";
            this.hastaid.HeaderText = "Hasta id";
            this.hastaid.Name = "hastaid";
            this.hastaid.ReadOnly = true;
            // 
            // hastatc2DataGridViewTextBoxColumn
            // 
            this.hastatc2DataGridViewTextBoxColumn.DataPropertyName = "hasta_tc2";
            this.hastatc2DataGridViewTextBoxColumn.HeaderText = "Hasta Tc";
            this.hastatc2DataGridViewTextBoxColumn.Name = "hastatc2DataGridViewTextBoxColumn";
            // 
            // Randevu_İptal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 690);
            this.Controls.Add(this.Formpanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Randevu_İptal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu_İptal";
            this.Load += new System.EventHandler(this.Randevu_İptal_Load);
            this.Formpanel1.ResumeLayout(false);
            this.Formpanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuAlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneVeritabanıDataSet8)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Formpanel1;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox doktor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hastatc;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label label4;
        private HastaneVeritabanıDataSet8 hastaneVeritabanıDataSet8;
        private System.Windows.Forms.BindingSource randevuAlBindingSource;
        private HastaneVeritabanıDataSet8TableAdapters.Randevu_AlTableAdapter randevu_AlTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevualınanbölümDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevualınandoktorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevutarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevusaatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastatc2DataGridViewTextBoxColumn;
    }
}