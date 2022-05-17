using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_1
{
    public partial class GirişSeçenekleri : Form
    {
        public GirişSeçenekleri()
        {
            InitializeComponent();
        }

       

       
        private void pictureBox5_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        

        

        

        private void GirişSeçenekleri_Load(object sender, EventArgs e)
        {
         
        }

       
        
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

       

        
       

       

        private void pictureBox3_Click(object sender, EventArgs e)
                   {
           
        }

        

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            Hide();
            doktor_girişi fr1= new doktor_girişi();
            fr1.Show();
        }

        private void bunifuThinButton21_Click_2(object sender, EventArgs e)
        {
            Hide();
           Form1 fr1 = new Form1();
            fr1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
