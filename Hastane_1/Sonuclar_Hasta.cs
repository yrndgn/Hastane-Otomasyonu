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

namespace Hastane_1
{
    public partial class Sonuclar_Hasta : Form
    {
        public Sonuclar_Hasta()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-FJUELRU; Initial Catalog=HastaneVeritabanı; Integrated Security=True");
        DataTable tablo = new DataTable();

        private void Formpanel1_Paint(object sender, PaintEventArgs e)
        {

        }
      
        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Hasta_Kabul WHERE kblhasta_tc like'" + label3.Text + "'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void Sonuclar_Hasta_Load(object sender, EventArgs e)
        {
           
            

        }
        private void veriler(string veri)

        {
            SqlDataAdapter da = new SqlDataAdapter(veri, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];



        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
