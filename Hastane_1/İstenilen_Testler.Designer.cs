
namespace Hastane_1
{
    partial class İstenilen_Testler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(İstenilen_Testler));
            this.hasta_KabulTableAdapter = new Hastane_1.HastaneVeritabanıDataSet9TableAdapters.Hasta_KabulTableAdapter();
            this.hastaKabulBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneVeritabanıDataSet9 = new Hastane_1.HastaneVeritabanıDataSet9();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.başMuayene = new System.Windows.Forms.Label();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.seç = new System.Windows.Forms.Button();
            this.kblhastatcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kblhastaadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kblhastasoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kbldogumyeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kblhastaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kblbolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kbldoktorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKabulBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneVeritabanıDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hasta_KabulTableAdapter
            // 
            this.hasta_KabulTableAdapter.ClearBeforeFill = true;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kblhastatcDataGridViewTextBoxColumn,
            this.kblhastaadiDataGridViewTextBoxColumn,
            this.kblhastasoyadiDataGridViewTextBoxColumn,
            this.kbldogumyeriDataGridViewTextBoxColumn,
            this.kblhastaidDataGridViewTextBoxColumn,
            this.kblbolumDataGridViewTextBoxColumn,
            this.kbldoktorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hastaKabulBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(48, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1068, 314);
            this.dataGridView1.TabIndex = 142;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(520, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 140;
            this.label1.Text = "Tahlil ID:";
            // 
            // başMuayene
            // 
            this.başMuayene.AutoSize = true;
            this.başMuayene.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.başMuayene.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.başMuayene.Location = new System.Drawing.Point(456, 34);
            this.başMuayene.Name = "başMuayene";
            this.başMuayene.Size = new System.Drawing.Size(143, 55);
            this.başMuayene.TabIndex = 81;
            this.başMuayene.Text = "Tahlil";
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconPictureBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 37;
            this.iconPictureBox3.Location = new System.Drawing.Point(1093, 21);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(62, 37);
            this.iconPictureBox3.TabIndex = 80;
            this.iconPictureBox3.TabStop = false;
            this.iconPictureBox3.Click += new System.EventHandler(this.iconPictureBox3_Click_1);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.HospitalAlt;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 56;
            this.iconPictureBox2.Location = new System.Drawing.Point(3, 21);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(81, 56);
            this.iconPictureBox2.TabIndex = 36;
            this.iconPictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.başMuayene);
            this.panel4.Controls.Add(this.iconPictureBox3);
            this.panel4.Controls.Add(this.iconPictureBox2);
            this.panel4.Cursor = System.Windows.Forms.Cursors.No;
            this.panel4.Location = new System.Drawing.Point(16, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1158, 98);
            this.panel4.TabIndex = 16;
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
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-1, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1183, 112);
            this.bunifuGradientPanel1.TabIndex = 141;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.label16.Location = new System.Drawing.Point(742, 574);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 16);
            this.label16.TabIndex = 139;
            this.label16.Text = "Hasta TC:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox2.HideSelection = false;
            this.textBox2.Location = new System.Drawing.Point(828, 572);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 29);
            this.textBox2.TabIndex = 138;
            this.textBox2.TabStop = false;
            // 
            // seç
            // 
            this.seç.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(248)))));
            this.seç.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seç.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seç.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.seç.Location = new System.Drawing.Point(1032, 562);
            this.seç.Name = "seç";
            this.seç.Size = new System.Drawing.Size(114, 39);
            this.seç.TabIndex = 137;
            this.seç.Text = "Seç";
            this.seç.UseVisualStyleBackColor = false;
            this.seç.Click += new System.EventHandler(this.kayıt_Click_1);
            // 
            // kblhastatcDataGridViewTextBoxColumn
            // 
            this.kblhastatcDataGridViewTextBoxColumn.DataPropertyName = "kblhasta_tc";
            this.kblhastatcDataGridViewTextBoxColumn.HeaderText = "Hasta Tc";
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
            // kbldogumyeriDataGridViewTextBoxColumn
            // 
            this.kbldogumyeriDataGridViewTextBoxColumn.DataPropertyName = "kbldogum_yeri";
            this.kbldogumyeriDataGridViewTextBoxColumn.HeaderText = "Doğum Yeri";
            this.kbldogumyeriDataGridViewTextBoxColumn.Name = "kbldogumyeriDataGridViewTextBoxColumn";
            this.kbldogumyeriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kblhastaidDataGridViewTextBoxColumn
            // 
            this.kblhastaidDataGridViewTextBoxColumn.DataPropertyName = "kblhasta_id";
            this.kblhastaidDataGridViewTextBoxColumn.HeaderText = "Hasta id";
            this.kblhastaidDataGridViewTextBoxColumn.Name = "kblhastaidDataGridViewTextBoxColumn";
            this.kblhastaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kblbolumDataGridViewTextBoxColumn
            // 
            this.kblbolumDataGridViewTextBoxColumn.DataPropertyName = "kblbolum";
            this.kblbolumDataGridViewTextBoxColumn.HeaderText = "Klinik";
            this.kblbolumDataGridViewTextBoxColumn.Name = "kblbolumDataGridViewTextBoxColumn";
            this.kblbolumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kbldoktorDataGridViewTextBoxColumn
            // 
            this.kbldoktorDataGridViewTextBoxColumn.DataPropertyName = "kbldoktor";
            this.kbldoktorDataGridViewTextBoxColumn.HeaderText = "Doktor";
            this.kbldoktorDataGridViewTextBoxColumn.Name = "kbldoktorDataGridViewTextBoxColumn";
            this.kbldoktorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // İstenilen_Testler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1171, 657);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.seç);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "İstenilen_Testler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İstenilen_Testler";
            this.Load += new System.EventHandler(this.İstenilen_Testler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hastaKabulBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneVeritabanıDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HastaneVeritabanıDataSet9TableAdapters.Hasta_KabulTableAdapter hasta_KabulTableAdapter;
        private System.Windows.Forms.BindingSource hastaKabulBindingSource;
        private HastaneVeritabanıDataSet9 hastaneVeritabanıDataSet9;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label başMuayene;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button seç;
        private System.Windows.Forms.DataGridViewTextBoxColumn kblhastatcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kblhastaadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kblhastasoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kbldogumyeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kblhastaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kblbolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kbldoktorDataGridViewTextBoxColumn;
    }
}