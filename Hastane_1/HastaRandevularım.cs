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
    public partial class HastaRandevularım : Form
    {
        public HastaRandevularım()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-FJUELRU;Initial Catalog=HastaneVeritabanı;Integrated Security=True");
        DataTable tablo = new DataTable();

        private void HastaRandevularım_Load(object sender, EventArgs e)
        {
          
            }

        private void button1_Click(object sender, EventArgs e)
        {
            string kayıt = "Select *From Randevu_Al Where  hasta_tc2=@hasta ";
            SqlCommand komut = new SqlCommand(kayıt, baglanti);
            komut.Parameters.AddWithValue("@hasta", hastatc.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }

