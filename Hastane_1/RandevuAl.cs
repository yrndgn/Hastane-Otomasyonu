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
    public partial class RandevuAl : Form
    {
        public RandevuAl()
        {
            InitializeComponent();

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=YAREN; Initial Catalog=HastaneVeritabanı; Integrated Security=True");


        private void RandevuAl_Load(object sender, EventArgs e)
        {
            DataSet daset = new DataSet();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Randevu_Bolumleri ",baglanti);
            adtr.Fill(daset,"Randevu_Bolumleri");
            Bölüm.DisplayMember = "Bölüm_Adları";
            Bölüm.DataSource = daset.Tables["Randevu_Bolumleri"];


        }

        private void button9_Click(object sender, EventArgs e)
        {
            saat.Text = "11:10";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            saat.Text = "10:45";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            saat.Text = "11:00";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saat.Text = "09:00";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saat.Text = "09:15";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saat.Text = "09:45";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saat.Text = "09:30";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            saat.Text = "10:00";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            saat.Text = "10:15" +
                "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            saat.Text = "10:30";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            saat.Text = "11:30";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            saat.Text = "11:45";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            saat.Text = "12:00";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            saat.Text = "13:15";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            saat.Text = "13:30";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            saat.Text = "13:45";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            saat.Text = "14:00";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            saat.Text = "14:15";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            saat.Text = "14:30";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            saat.Text = "14:45";
        }

        private void tc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button21_Click(object sender, EventArgs e)
        {


        }

        private void Bolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet daset = new DataSet();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Bolum_Doktorları where Bolum_Adları= '"+Bölüm.Text+"'", baglanti);
            adtr.Fill(daset, "Bolum_Doktorları");
            doktor.DisplayMember = "Doktor_Adı";
            doktor.DataSource = daset.Tables["Bolum_Doktorları"];
        }

        private void tarih_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
    

