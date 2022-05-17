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
    public partial class İstenilen_Testler : Form
    {
        public İstenilen_Testler()
        {
            InitializeComponent();
        }

        private void İstenilen_Testler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneVeritabanıDataSet9.Hasta_Kabul' table. You can move, or remove it, as needed.
            this.hasta_KabulTableAdapter.Fill(this.hastaneVeritabanıDataSet9.Hasta_Kabul);
          

        }

  
      
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void iconPictureBox3_Click_1(object sender, EventArgs e)
        {
            Close();

        }

        private void kayıt_Click_1(object sender, EventArgs e)
        {
            Tahlil_Seç fr = new Tahlil_Seç();



            fr.label5.Text = textBox2.Text;
            Int64 y1 = Convert.ToInt64(textBox2.Text);
            label1.Text = textBox2.Text;

            fr.ShowDialog();
        }
    }
}
