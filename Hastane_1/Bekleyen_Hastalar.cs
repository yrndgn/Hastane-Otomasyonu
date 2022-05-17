using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Hastane_1
{
    public partial class Bekleyen_Hastalar : Form
    {
        public Bekleyen_Hastalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-FJUELRU;Initial Catalog=HastaneVeritabanı;Integrated Security=True");
        DataTable tablo = new DataTable();
        private void Bekleyen_Hastalar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneVeritabanıDataSet9.Hasta_Kabul' table. You can move, or remove it, as needed.
            this.hasta_KabulTableAdapter.Fill(this.hastaneVeritabanıDataSet9.Hasta_Kabul);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Hasta_Kabul WHERE kbldoktor like'" + doktor.Text + "'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Muayene fr = new Muayene();


            fr.label2.Text = hasta_ıd.Text;
            Int64 y1 = Convert.ToInt64(hasta_ıd.Text);

            label4.Text = hasta_ıd.Text;

            fr.ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            fr.soyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            fr.dtarih.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            fr.dyer.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            fr.annead.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            fr.babaad.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            fr.kan.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            fr.medeni.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            
            fr.cinsiyet.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            fr.telefon.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            fr.eposta.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();






            fr.ShowDialog();
        }

       

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            hasta_ıd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
