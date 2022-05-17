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
    public partial class Laboratuvar_Anasayfa : Form
    {
        public Laboratuvar_Anasayfa()
        {
            InitializeComponent();
        }

        

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
          
            İstenilen_Testler fr = new İstenilen_Testler();



            fr.ShowDialog();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Close();
            GirişSeçenekleri fr = new  GirişSeçenekleri();
            fr.ShowDialog();
        }
    }
}
