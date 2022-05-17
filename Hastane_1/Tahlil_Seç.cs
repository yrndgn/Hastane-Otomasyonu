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
    public partial class Tahlil_Seç : Form
    {
        public Tahlil_Seç()
        {
            InitializeComponent();
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            Close();

            
            
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-FJUELRU;Initial Catalog=HastaneVeritabanı;Integrated Security=True");

        private void Tahlil_Seç_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneVeritabanıDataSet9.Hasta_Kabul' table. You can move, or remove it, as needed.
            this.hasta_KabulTableAdapter.Fill(this.hastaneVeritabanıDataSet9.Hasta_Kabul);
           
            
            textBox3.Text = label5.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Hasta_Kabul WHERE kblhasta_tc like'" + textBox3.Text + "'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglanti.Close();

        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand kom = new SqlCommand("update  Hasta_Kabul set kbltahlilsonucu='" + textBox6.Text + "' where kblhasta_tc ='" + textBox3.Text + "'", baglanti);

            kom.ExecuteNonQuery();


            MessageBox.Show("Tahlil sonuçları gönderildi.");
            textBox3.Text = label5.Text;
            
            SqlCommand komut = new SqlCommand("SELECT * FROM Hasta_Kabul WHERE kblhasta_tc like'" + textBox3.Text + "'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglanti.Close();
        }
    }
}
