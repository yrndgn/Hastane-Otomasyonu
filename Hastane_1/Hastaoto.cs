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
    public partial class Hastaoto : Form
    {
        public Hastaoto()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void hastabut_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formgetir(Form frm)
        {
            panel6.Controls.Clear();
            frm.MdiParent = this;
            panel6.Controls.Add(frm);
            frm.Show();

        }

        private void hastabut_Click_1(object sender, EventArgs e)
        {
            RandevuAl frm = new RandevuAl();
            formgetir(frm);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Formpanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Hastaoto_Load(object sender, EventArgs e)
        {
            
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
