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
    public partial class LaboratuvarGirişi : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-FJUELRU; Initial Catalog=HastaneVeritabanı; Integrated Security=True");

        public LaboratuvarGirişi()
        {
            InitializeComponent();
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                baglanti.Open();
                string sql = "Select * From Laboratuvar where Laboratuvar_Ad=@labgiriş AND Laboratuvar_Sifre=@sifre ";
                SqlParameter prm1 = new SqlParameter("labgiriş", labgiriş.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifre", sifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Laboratuvar_Anasayfa fr = new Laboratuvar_Anasayfa();

                    Hide();

                    

                    fr.ShowDialog();


                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre boş olamaz.");

                }


            }
            catch (Exception)
            {


                //   MessageBox.Show("Kullanıcı adını yada şifreyi yanlış girdiniz.");

            }


            baglanti.Close();
        }

        

        private void labgiriş_Click(object sender, EventArgs e)
        {
            labgiriş.Clear();
            //pictureBox1.BackgroundImage = Properties.Resources.dok1;
            panel1.ForeColor = Color.FromArgb(143, 185, 241);
            labgiriş.ForeColor = Color.FromArgb(143, 185, 241);

            panel2.ForeColor = Color.WhiteSmoke;
            labgiriş.ForeColor = Color.WhiteSmoke;
        }

        private void sifre_Click(object sender, EventArgs e)
        {
            sifre.Clear();

            panel1.ForeColor = Color.FromArgb(143, 185, 241);
            sifre.ForeColor = Color.FromArgb(143, 185, 241);

            panel2.ForeColor = Color.WhiteSmoke;
            sifre.ForeColor = Color.WhiteSmoke;
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            Close();

            GirişSeçenekleri fr1 = new GirişSeçenekleri();
            fr1.Show();
        }
    }
}
