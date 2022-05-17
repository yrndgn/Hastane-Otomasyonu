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
    public partial class doktor_girişi : Form
    {
        public doktor_girişi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=YAREN; Initial Catalog=HastaneVeritabanı; Integrated Security=True");

        private void doktor_girişi_Load(object sender, EventArgs e)
        {



        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "Select * From Doktor_Giris where doktor_no=@dokno AND doktor_sifre=@sifno ";
                SqlParameter prm1 = new SqlParameter("dokno", doktorno.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifno", sifrem.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Doktoroto fr = new Doktoroto();
                    fr.ShowDialog();
                    baglanti.Close();

                }


            }
            catch (Exception)
            {
                MessageBox.Show("Kullanıcı adını yada şifreyi yanlış girdiniz.");
            }
        }


        
        private void doktoradı_TextChanged(object sender, EventArgs e)
        {

        }

        private void doktoradı_Click(object sender, EventArgs e)
        {
            doktorno.Clear();
            panel1.ForeColor = Color.FromArgb(143, 185, 241);
            doktorno.ForeColor = Color.FromArgb(143, 185, 241);
           
            panel2.ForeColor = Color.WhiteSmoke;
            doktorno.ForeColor = Color.WhiteSmoke;

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            sifrem.Clear();
            
            panel1.ForeColor = Color.FromArgb(143, 185, 241);
            sifrem.ForeColor = Color.FromArgb(143, 185, 241);

            panel2.ForeColor = Color.WhiteSmoke;
            sifrem.ForeColor = Color.WhiteSmoke;

        }

        private void Şifre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    }

