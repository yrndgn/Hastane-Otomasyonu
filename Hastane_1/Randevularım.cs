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
    public partial class Randevularım : Form
    {
        public Randevularım()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-FJUELRU;Initial Catalog=HastaneVeritabanı;Integrated Security=True");
        DataTable tablo = new DataTable();
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Randevu_Al WHERE randevu_alınan_doktor like'" + doktor.Text + "'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
           
            baglanti.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Muayene fr = new Muayene();


            fr.label2.Text = hasta.Text;
          Int64 y1 = Convert.ToInt64(hasta.Text);


            baglanti.Open();

            SqlCommand kmt = new SqlCommand("select *from Hasta_Kabul where kblhasta_tc='" + hasta.Text + "'", baglanti);
            SqlDataReader read = kmt.ExecuteReader();
            while (read.Read())
            {
                
                fr.ad.Text = read["kblhasta_adi"].ToString();
                fr.soyad.Text = read["kblhasta_soyadi"].ToString();
                fr.dtarih.Text = read["kbldogum_tarihi"].ToString();
                fr.dyer.Text = read["kbldogum_yeri"].ToString();
                fr.annead.Text = read["kblanne_adi"].ToString();
                fr.babaad.Text = read["kblbaba_adi"].ToString();  
                fr.kan.Text = read["kblkan_grubu"].ToString();
                fr.medeni.Text = read["kblmedeni_hal"].ToString();
                fr.cinsiyet.Text = read["kblcinsiyet"].ToString();
                fr.telefon.Text = read["kbltelefon"].ToString();
                fr.eposta.Text = read["kble_posta"].ToString();
            }
            fr.ShowDialog();
            baglanti.Close();
        }

        
        private void Randevularım_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneVeritabanıDataSet8.Randevu_Al' table. You can move, or remove it, as needed.
            this.randevu_AlTableAdapter.Fill(this.hastaneVeritabanıDataSet8.Randevu_Al);
            kayitlari_getir();
            dok.Text = doktor.Text;
  
        }
        public void kayitlari_getir()
        {
            string kayıt = "Select *From Randevu_Al Where  randevu_alınan_doktor=@dok ";
            SqlCommand komut = new SqlCommand(kayıt, baglanti);
            komut.Parameters.AddWithValue("@dok", doktor.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            baglanti.Close();



        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hasta.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            button1.Enabled = true;
            hasta.Enabled = true;

        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
