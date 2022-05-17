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
    public partial class HastaBilgileri : Form
    {
        public HastaBilgileri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=Yaren;Initial Catalog=HastaneVeritabanı;Integrated Security=True");
        DataTable tablo = new DataTable();
        private void HastaBilgileri_Load(object sender, EventArgs e)
        {
               veriler("select* from Hasta_Girişi");


          
        }

        /* void listele()
         {
            tablo.Clear();
            baglanti.Open();

              SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM Hasta_Girişi", baglanti);
               adtr.Fill(tablo);
             dataGridView1.DataSource = tablo;
            baglanti.Close();


              
          }*/

        
        private void veriler(string veri)

        {
            SqlDataAdapter da = new SqlDataAdapter(veri , baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];



        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
           
        {   

        }


        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void hastaAra_Click(object sender, EventArgs e)
        {
            

        }

       

        private void tck_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void tanı_TextChanged(object sender, EventArgs e)
        {

        }

        private void med_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Güncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();


                    
            SqlCommand ek2 = new SqlCommand("update  Hasta_Girişi set hasta_adi='" + ad.Text + "',  hasta_soyadi='" + soyad.Text + "', dogum_tarihi ='" + tarih.Value.ToString("yyyy-MM-dd") + "' ,  dogum_yeri='" + dyer.Text + "' ,  anne_adi='" + anne.Text + "' ,baba_adi='"+baba.Text+"',kan_grubu='"+kangrubu.Text+"',medeni_hal='"+med.Text+"',cinsiyet='"+cin.Text+"',e_posta='"+epos.Text+"' ,tani_dk='"+tanı.Text+"' where hasta_tc ='"+tck.Text+"'", baglanti);
            ek2.ExecuteNonQuery();
            veriler("select* from Hasta_Girişi");       
            baglanti.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Hasta_Girişi WHERE hasta_tc like'" + tck.Text + "'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

     
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            soyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tarih.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dyer.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            anne.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            baba.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            kangrubu.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            med.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            cin.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            tele.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            epos.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
        }
    }
}
