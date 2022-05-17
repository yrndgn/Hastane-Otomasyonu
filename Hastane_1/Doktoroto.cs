using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Hastane_1
{   
    public partial class Doktoroto : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        
        public Doktoroto()
        {   
            InitializeComponent();
            this.IsMdiContainer = true;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size= new Size(7, 46);
            hastapanel.Controls.Add(leftBorderBtn);
            tasarım();

            

        }


        


    private void Aktifbuton(object senderBtn, Color renk)
        {
            if (senderBtn != null)
            {
                Dsblbuton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(34, 36, 49);
                currentBtn.ForeColor = renk;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = renk;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //sol border buton
                leftBorderBtn.BackColor = renk;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

            }
        }
       
        private void Dsblbuton()
        {
            if (currentBtn != null)
            {

                currentBtn.BackColor = Color.FromArgb(34, 36, 49);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
               
               
            }
        }
        private void tasarım() {
            hastapanel.Visible = false;
        }

        private void gizlemenu() {
            if (hastapanel.Visible == true)
                hastapanel.Visible = false;
            
        
        }
        private void göstermenu(Panel menu)
        { if (menu.Visible == false)
            {
                gizlemenu();
                menu.Visible = true;
            }
            else
                menu.Visible = false;
        }

        private void Doktoroto_Load(object sender, EventArgs e)
        {
           
        }

        

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Reset();
        }


        private void Reset()
        {
            Dsblbuton();
            leftBorderBtn.Visible = false;
            
        }
       

        private void Formpanel4_Paint(object sender, PaintEventArgs e)
        {
        }
        
       
        private void homeicon_Click(object sender, EventArgs e)
        {
            
        }

       

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {
           
        }


        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GirişSeçenekleri fr1 = new GirişSeçenekleri();
            fr1.ShowDialog();
        }


        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void labelhome_Click(object sender, EventArgs e)
        {

        }

        private void homeicon_Click_1(object sender, EventArgs e)
        {
           
            
        }

        private void hastabut_Click(object sender, EventArgs e)
        {

            göstermenu(hastapanel);
        }
        private void formgetir(Form frm)
        {
            panel6.Controls.Clear();
            frm.MdiParent = this;
            panel6.Controls.Add(frm);
            frm.Show();

        }





        private void bunifuFlatButton1_Click_2(object sender, EventArgs e)
        {
            HastaBilgileri frm = new HastaBilgileri();
            formgetir(frm);
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {

            Sonuçlar frm = new Sonuçlar();
            formgetir(frm);
        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            DoktorAnasayfa frm = new DoktorAnasayfa();
            formgetir(frm);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Laboratuvar frm = new Laboratuvar();
            formgetir(frm);
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void doktor_adı_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
