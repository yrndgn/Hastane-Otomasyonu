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
    public partial class Muayene : Form
    {
        public Muayene()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-FJUELRU;Initial Catalog=HastaneVeritabanı;Integrated Security=True");

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Muayene_Load(object sender, EventArgs e)
        {
            tc.Text = label2.Text;
            Int64 y1 = Convert.ToInt64(label2.Text);

           /* baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Hasta_Kabul WHERE kblhasta_tc like'" + tc.Text + "'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            baglanti.Close();*/
        }
      
      
        private void veriler(string veri)

        {
            SqlDataAdapter da = new SqlDataAdapter(veri, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            



        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = testler.Text;

        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kom = new SqlCommand("update  Hasta_Kabul set kbltahlil='" + textBox4.Text + "' where kblhasta_tc ='" + tc.Text + "'", baglanti);

            kom.ExecuteNonQuery();

            MessageBox.Show("Test başarıyla gönderildi.");
            baglanti.Close();

        }

        private void kayıt_Click(object sender, EventArgs e)
        {
            testler.Enabled = true;
            button1.Enabled = true;
            textBox4.Enabled = true;
            button3.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tanı.Enabled = true;
            recete.Enabled = true;
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand ek2 = new SqlCommand("update  Hasta_Kabul set kbltani='" + tanı.Text + "' where kblhasta_tc ='" + tc.Text + "'", baglanti);
            SqlCommand ek = new SqlCommand("update  Hasta_Kabul set kblrecete='" + recete.Text + "' where kblhasta_tc ='" + tc.Text + "'", baglanti);
            
            ek.ExecuteNonQuery();
            ek2.ExecuteNonQuery();
            MessageBox.Show("Kaydedildi.");

            baglanti.Close();
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
