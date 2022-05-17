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


namespace Hastane_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=YAREN; Initial Catalog=HastaneVeritabanı; Integrated Security=True");
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Hide();
            ŞifremiUnuttum fr1 = new ŞifremiUnuttum();
            fr1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        

        
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {


            KayıtOl fr1 = new KayıtOl();
            fr1.Show();
          
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void hasta_Click_1(object sender, EventArgs e)
        {
            hasta.Clear();
            pictureBox1.BackgroundImage = Properties.Resources.dok1;
            panel1.ForeColor = Color.FromArgb(143, 185, 241);
            hasta.ForeColor = Color.FromArgb(143, 185, 241);

            pictureBox2.BackgroundImage = Properties.Resources.dok2;
            panel2.ForeColor = Color.WhiteSmoke;
            hasta.ForeColor = Color.WhiteSmoke;

        }

        private void giriş_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "Select * From Hasta_Girişi where hasta_tc=@hastatc AND hasta_sifre=@hastasifre ";
                SqlParameter prm1 = new SqlParameter("hastatc", hasta.Text.Trim());
                SqlParameter prm2 = new SqlParameter("hastasifre", sifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Hastaoto fr = new Hastaoto();
                    fr.ShowDialog();

                }


            }
            catch (Exception)
            {
                MessageBox.Show("Kullanıcı adını yada şifreyi yanlış girdiniz.");
            }
            baglanti.Close();
        }

        private void hasta_TextChanged(object sender, EventArgs e)
        {

        }

        private void sifre_Click(object sender, EventArgs e)
        {
            sifre.Clear();
            
            panel1.ForeColor = Color.FromArgb(143, 185, 241);
            sifre.ForeColor = Color.FromArgb(143, 185, 241);

            panel2.ForeColor = Color.WhiteSmoke;
            sifre.ForeColor = Color.WhiteSmoke;
        }
    }
}
