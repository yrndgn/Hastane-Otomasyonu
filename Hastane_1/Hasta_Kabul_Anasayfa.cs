using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;


namespace Hastane_1
{
    public partial class Hasta_Kabul_Anasayfa : Form
    {
        public Hasta_Kabul_Anasayfa()
        {
            InitializeComponent();
        }

       
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-FJUELRU; Initial Catalog=HastaneVeritabanı; Integrated Security=True");

      


        private void Hasta_Kabul_Anasayfa_Load(object sender, EventArgs e)
        {


            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Bolumler From Randevu_Bolumleri", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                klinik.Items.Add(dr[0]);
            }
            baglanti.Close();

        }

        private void kaydet_Click(object sender, EventArgs e)
        {



            baglanti.Open();

            SqlCommand kmt = new SqlCommand("select *from Hasta_Kabul where kblhasta_tc='" + kbltctext.Text + "'", baglanti);
            SqlDataReader oku = kmt.ExecuteReader();
            if (oku.Read())
            {

                MessageBox.Show("Bu tc kimlik numarasıyla bir hasta kayıtlı1.");
                oku.Close();
                SqlCommand komut = new SqlCommand("select *from Hasta_Kabul where kblhasta_tc='" + kbltctext.Text + "'", baglanti);
                SqlDataReader read = kmt.ExecuteReader();
                while (read.Read())
                {
                    
                    kbladtext.Text = read["kblhasta_adi"].ToString();
                    kbladtext.Enabled = false;

                    kblsoyadtxt.Text = read["kblhasta_soyadi"].ToString();
                    kblsoyadtxt.Enabled = false;

                    kbltarihtxt.Text = read["kbldogum_tarihi"].ToString();
                    kbltarihtxt.Enabled = false;

                    kblyer.Text = read["kbldogum_yeri"].ToString();
                    kblyer.Enabled = false;

                    kblanne.Text = read["kblanne_adi"].ToString();
                    kblanne.Enabled = false;

                    kblbaba.Text = read["kblbaba_adi"].ToString();
                    kblbaba.Enabled = false;

                    kblkan.Text = read["kblkan_grubu"].ToString();
                    kblkan.Enabled = false;

                    kblmedeni.Text = read["kblmedeni_hal"].ToString();
                    kblmedeni.Enabled = false;

                    kblcinsiyet.Text = read["kblcinsiyet"].ToString();
                    kblcinsiyet.Enabled = false;

                    kbltelefon.Text = read["kbltelefon"].ToString();
                    kbltelefon.Enabled = false;

                    kbleposta.Text = read["kble_posta"].ToString();
                    kbleposta.Enabled = false;
                    label14.Text = kbltctext.Text;
                    Int64 y1 = Convert.ToInt64(kbltctext.Text);

                    hastaıdmyn.Text = label14.Text;
                    acilhastatc.Text = label14.Text;

                }
            }


            else
            {

                baglanti.Close();


                baglanti.Open();

                oku.Close();
                SqlCommand ok = new SqlCommand("insert into Hasta_Kabul (kblhasta_tc,kblhasta_adi,kblhasta_soyadi,kbldogum_tarihi,kbldogum_yeri,kblanne_adi,kblbaba_adi,kblkan_grubu,kblmedeni_hal,kblcinsiyet,kbltelefon,kble_posta) values ('" + kbltctext.Text + "','" + kbladtext.Text + "','" + kblsoyadtxt.Text + "','" + kbltarihtxt.Value.ToString("yyyy-MM-dd") + "','" + kblyer.Text + "','" + kblanne.Text + "','" + kblbaba.Text + "','" + kblkan.Text + "','" + kblmedeni.Text + "','" + kblcinsiyet.Text + "','" + kbltelefon.Text + "','" + kbleposta.Text + "')", baglanti);
                ok.ExecuteNonQuery();


                MessageBox.Show("Hasta sisteme kayıt edildi.");
                label14.Text = kbltctext.Text;
                Int64 y1 = Convert.ToInt64(kbltctext.Text);

                hastaıdmyn.Text = label14.Text;
                acilhastatc.Text = label14.Text;


                baglanti.Close();
            }
        }

        private void Muayene_Click(object sender, EventArgs e)
        {
            label14.Text = kbltctext.Text;
            Int64 y1 = Convert.ToInt64(kbltctext.Text);
            hastaıdmyn.Text = label14.Text;
            acilhastatc.Text = label14.Text;
            Doktor.Enabled = true;
            klinik.Enabled = true;
            button1.Enabled = true;




        }

       

        

      
        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            Close();
            GirişSeçenekleri fr1 = new GirişSeçenekleri();
            fr1.Show();

        }

        

        private void klinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doktor.Items.Clear();

            baglanti.Open();


            SqlCommand komut2 = new SqlCommand("Select Doktor_Adı From Bolum_Doktorları where randevubölümleriid=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", klinik.SelectedIndex );

            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                Doktor.Items.Add(dr2[0]);
            }
            baglanti.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            baglanti.Open();
          
                    SqlCommand kom = new SqlCommand("update  Hasta_Kabul set kblbolum='" + klinik.Text + "' where kblhasta_tc ='" + hastaıdmyn.Text + "'", baglanti);
                    SqlCommand kom2 = new SqlCommand("update  Hasta_Kabul set kbldoktor='" + Doktor.Text + "' where kblhasta_tc ='" + hastaıdmyn.Text + "'", baglanti);
                    kom2.ExecuteNonQuery();

                    kom.ExecuteNonQuery();
                   
                    MessageBox.Show("Muayene  alındı.");
              
         
            baglanti.Close();



        }

        private void Acil_Click(object sender, EventArgs e)
        {
            durum.Enabled = true;
            acilklinik.Enabled = true;
            doktoracil.Enabled = true;
            hastasikayeti.Enabled = true;
        }

       
    }
    }
    
    

