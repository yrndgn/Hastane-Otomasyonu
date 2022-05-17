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
    public partial class Tahlil_Sonuçları : Form
    {
        public Tahlil_Sonuçları()
        {
            InitializeComponent();
        }

        private void Tahlil_Sonuçları_Load(object sender, EventArgs e)
        {
           
            veriler("select* from Hasta_Kabul");

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-FJUELRU;Initial Catalog=HastaneVeritabanı;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Hasta_Kabul WHERE kblhasta_tc like'" + tc.Text + "'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
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

      

      

        private void button4_Click(object sender, EventArgs e)
        {

            baglanti.Open();

            SqlCommand ek2 = new SqlCommand("update  Hasta_Kabul set kbltani='" + tanı.Text  + "' where kblhasta_tc ='" + tc.Text + "'", baglanti);
            SqlCommand ek = new SqlCommand("update  Hasta_Kabul set kblrecete='" + recete.Text + "' where kblhasta_tc ='" + tc.Text + "'", baglanti);
            ek.ExecuteNonQuery();
            MessageBox.Show("Gönderildi.");


            ek2.ExecuteNonQuery();
            veriler("select* from Hasta_Kabul");
            baglanti.Close();

        }

      
    }
}
