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
    public partial class Hasta_Kabul_Giriş : Form
    {
        public Hasta_Kabul_Giriş()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-FJUELRU; Initial Catalog=HastaneVeritabanı; Integrated Security=True");

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            Close();
            
            GirişSeçenekleri fr1 = new GirişSeçenekleri();
            fr1.Show();
        }

     

        private void kblgrs_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "Select * From Hasta_Kabul_Giriş where Hasta_Kabul_Ad=@kblno AND Hasta_Kabul_Şifre=@sifno ";
                SqlParameter prm1 = new SqlParameter("kblno", kblno.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifno", sifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {      Hide();
                    Hasta_Kabul_Anasayfa fr = new Hasta_Kabul_Anasayfa();
                   
                    fr.ShowDialog();
                    
                    baglanti.Close();
                    
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre boş olamaz.");

                }

            }
            catch (Exception)

            {
                baglanti.Close();
                MessageBox.Show("Kullanıcı adını yada şifreyi yanlış girdiniz.");
            }
        }

      

        private void kblno_Click(object sender, EventArgs e)
        {
            kblno.Clear();
            //pictureBox1.BackgroundImage = Properties.Resources.dok1;
            panel1.ForeColor = Color.FromArgb(143, 185, 241);
            kblno.ForeColor = Color.FromArgb(143, 185, 241);

            panel2.ForeColor = Color.WhiteSmoke;
            kblno.ForeColor = Color.WhiteSmoke;
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
