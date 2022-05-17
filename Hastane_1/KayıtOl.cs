using System;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;

namespace Hastane_1
{//Data Source=Yaren;Initial Catalog=HastaneVeritabanı;Integrated Security=True
    public partial class KayıtOl : Form
    {
        public KayıtOl()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=YAREN; Initial Catalog=HastaneVeritabanı; Integrated Security=True");

       
        

       

        private void tc_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           

        }
        
       
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tc_Click(object sender, EventArgs e)
        {
            tc.Clear();

           
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            ad.Clear();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            soyad.Clear();

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            annead.Clear();

        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            babaad.Clear();
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            dyer.Clear();
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            telefon.Clear();
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            eposta.Clear();
        }

       

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }


  
        private void şifre_Click(object sender, EventArgs e)
        {
            şifre.Clear();
        }

        private void tekrarşifre_Click(object sender, EventArgs e)
        {
            tekrarşifre.Clear();
        }

        private void textBox10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            if (şifre.Text == tekrarşifre.Text)
             {
               baglanti.Open();
                string user;
                string pass;
                user = tc.Text;
                pass = şifre.Text;

                SqlCommand komut = new SqlCommand("select *from  Hasta_Girişi where hasta_tc ='" + tc.Text + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();


                if (oku.Read())
                {
                    MessageBox.Show("Bu tc kimlik numarasıyla bir hasta kayıtlı.");
                }
                else
                {

                    SqlCommand ok = new SqlCommand("insert into Hasta_Girişi (hasta_tc,hasta_adi,hasta_soyadi,dogum_tarihi,dogum_yeri,anne_adi,baba_adi,kan_grubu,medeni_hal,cinsiyet,telefon,e_posta,hasta_sifre) values ('" + tc.Text + "','" + ad.Text + "','" + soyad.Text + "','" + dtarih.Value.ToString("yyyy-MM-dd") + "','" + dyer.Text + "','" + annead.Text + "','" + babaad.Text + "','" + kan.Text + "','" + medeni.Text + "','" + cinsiyet.Text + "','" + telefon.Text + "','" + eposta.Text + "','"+şifre.Text+"')", baglanti);
                    ok.ExecuteNonQuery();

                    MessageBox.Show("kayıt oldunuz"); 
                    
                    /*tc.Clear();
                    ad.Clear();
                    soyad.Clear();
                    
                    dyer.Clear();
                    annead.Clear();
                    babaad.Clear();
                    telefon.Clear();
                    eposta.Clear();
                    şifre.Clear();*/

                    



                 }
             }
             else { MessageBox.Show("Şifreler uyuşmuyor", "Hata"); }

                 baglanti.Close();




        }
         

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void KayıtOl_Load(object sender, EventArgs e)
        {
         

        }
    }
    }

