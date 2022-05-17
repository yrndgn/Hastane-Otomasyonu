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
    public partial class HastaRandevularımİptal : Form
    {
        public HastaRandevularımİptal()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-FJUELRU;Initial Catalog=HastaneVeritabanı;Integrated Security=True");
        DataTable tablo = new DataTable();
        public int kayıt = 0;
        private void verisil(string id)

        {
            string sil = "Delete From Randevu_Al Where randevu_alınan_doktor =@id ";
            SqlCommand komut = new SqlCommand(sil, baglanti);
            baglanti.Open();
            komut.Parameters.AddWithValue("@id", id);
            komut.ExecuteNonQuery();
            baglanti.Close();





        }
       public void kayitlari_getir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Hasta_Kabul WHERE kblhasta_tc like'" + hastatc.Text + "'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();



        }

        private void HastaRandevularımİptal_Load(object sender, EventArgs e)
        {
                kayitlari_getir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kayıt = "Select *From Randevu_Al Where  hasta_tc2=@hasta ";
            SqlCommand komut = new SqlCommand(kayıt, baglanti);
            komut.Parameters.AddWithValue("@hasta", hasta.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            hasta.Enabled = true;
            sil.Enabled = true;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                 string id = Convert.ToString(drow.Cells[1].Value);
                verisil(id);

                string kayıt = "Select *From Randevu_Al Where  randevu_alınan_doktor=@hasta ";
                SqlCommand komut = new SqlCommand(kayıt, baglanti);
                komut.Parameters.AddWithValue("@hasta", hasta.Text);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }

        }

      

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hastatc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }
    }
}
