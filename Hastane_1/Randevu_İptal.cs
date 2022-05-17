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
    public partial class Randevu_İptal : Form
    {
        public Randevu_İptal()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-FJUELRU;Initial Catalog=HastaneVeritabanı;Integrated Security=True");
        DataTable tablo = new DataTable();
        
        private void Randevu_İptal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneVeritabanıDataSet8.Randevu_Al' table. You can move, or remove it, as needed.
            this.randevu_AlTableAdapter.Fill(this.hastaneVeritabanıDataSet8.Randevu_Al);
           
            kayitlari_getir();
          
            

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void verisil(Int64 id)

        {
            string sil = "Delete From Randevu_Al Where hastaid =@id ";
            SqlCommand komut = new SqlCommand(sil, baglanti);
            baglanti.Open();
            komut.Parameters.AddWithValue("@id", id);
            komut.ExecuteNonQuery();
            baglanti.Close();





        }
        public void kayitlari_getir()
        {
            string kayıt = "Select *From Randevu_Al Where  randevu_alınan_doktor=@dok ";
            SqlCommand komut = new SqlCommand(kayıt, baglanti);
            komut.Parameters.AddWithValue("@dok", doktor.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();



        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            string kayıt = "Select *From Randevu_Al Where  randevu_alınan_doktor=@dok ";
            SqlCommand komut = new SqlCommand(kayıt, baglanti);
            komut.Parameters.AddWithValue("@dok", doktor.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        
            baglanti.Close();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows) {
                Int64 id = Convert.ToInt64(drow.Cells[4].Value);
                verisil(id);
                kayitlari_getir();


            }

        }

     
       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hastatc.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            button1.Enabled = true;
            hastatc.Enabled = true;

        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
