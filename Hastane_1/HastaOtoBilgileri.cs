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
using FontAwesome.Sharp;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Hastane_1
{
    public partial class HastaOtoBilgileri : Form
    {
        public HastaOtoBilgileri()
        {
            InitializeComponent();
        }

        private void kayıt_Click(object sender, EventArgs e)
        {
            baglanti.Open();





            SqlCommand kmt = new SqlCommand("select *from Hasta_Kabul where kblhasta_tc='" + tc.Text + "'", baglanti);
            SqlDataReader read = kmt.ExecuteReader();


            while (read.Read())
            {


                ad.Text = read["kblhasta_adi"].ToString();

                soyad.Text = read["kblhasta_soyadi"].ToString();

                dtarih.Text = read["kbldogum_tarihi"].ToString();

                dyer.Text = read["kbldogum_yeri"].ToString();

                annead.Text = read["kblanne_adi"].ToString();

                babaad.Text = read["kblbaba_adi"].ToString();

                kan.Text = read["kblkan_grubu"].ToString();

                medeni.Text = read["kblmedeni_hal"].ToString();

                cinsiyet.Text = read["kblcinsiyet"].ToString();

                telefon.Text = read["kbltelefon"].ToString();

                eposta.Text = read["kble_posta"].ToString();

                şifre.Text = read["hasta_sifre"].ToString();





            }

            baglanti.Close();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-FJUELRU; Initial Catalog=HastaneVeritabanı; Integrated Security=True");

        private void HastaOtoBilgileri_Load(object sender, EventArgs e)
        {


          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
          
            SqlCommand ok2 = new SqlCommand("update Hasta_Giriş  set hasta_sifre = '" + şifre.Text + "' where hasta_tc = '" + tc.Text + "'", baglanti);

            ok2.ExecuteNonQuery();
            MessageBox.Show("Bilgiler güncellendi.");

            baglanti.Close();
        }
    }
}
