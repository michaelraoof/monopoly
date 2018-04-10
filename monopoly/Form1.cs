using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monopoly
{
    public partial class Form1 : Form
    {
        private int x;
        private int y;

        public Form1()
        {
            InitializeComponent();
            x = 23;
            y = 32;   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
           
        
        }
    
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text="";
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel20_Paint_1(object sender, PaintEventArgs e)
        {
     
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel29_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel33_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel36_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel26_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel32_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = comboBox1.SelectedItem.ToString();
            List<int>l=new List<int>();
            l.Add(2);l.Add(3);
            //listBox1.Items.Clear();
            listBox1.DataSource=l;
            //listBox1.Items.Add("ahmed");

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       // static Random s = new Random();//static make good randomisation
        private void button4_Click(object sender, EventArgs e)
        {

            //   int x = s.Next(1, 7);
            // int z = s.Next(1, 7);
            dice dic=new dice();

            int x = dic.roll_dice();
            int z = dic.roll_dice();


            //loading dice pictures//////////
            if (x == 6) 
                panel37.BackgroundImage = Image.FromFile(@"C: \Users\Ahmed Ismail\Documents\Visual Studio 2015\Projects\monopoly\monopoly\dice(6).png");
            if (x == 5)
                panel37.BackgroundImage = Image.FromFile(@"C: \Users\Ahmed Ismail\Documents\Visual Studio 2015\Projects\monopoly\monopoly\dice(5).png");
            if (x == 4)
                panel37.BackgroundImage = Image.FromFile(@"C: \Users\Ahmed Ismail\Documents\Visual Studio 2015\Projects\monopoly\monopoly\dice(4).png");
            if (x == 3)
                panel37.BackgroundImage = Image.FromFile(@"C: \Users\Ahmed Ismail\Documents\Visual Studio 2015\Projects\monopoly\monopoly\dice(3).png");
            if (x == 2)
                panel37.BackgroundImage = Image.FromFile(@"C: \Users\Ahmed Ismail\Documents\Visual Studio 2015\Projects\monopoly\monopoly\dice(2).png");
            if (x == 1)
                panel37.BackgroundImage = Image.FromFile(@"C: \Users\Ahmed Ismail\Documents\Visual Studio 2015\Projects\monopoly\monopoly\dice(1).png");
            if (z == 6)
                panel38.BackgroundImage = Image.FromFile(@"C: \Users\Ahmed Ismail\Documents\Visual Studio 2015\Projects\monopoly\monopoly\dice(6).png");
            if (z == 5)
                panel38.BackgroundImage = Image.FromFile(@"C: \Users\Ahmed Ismail\Documents\Visual Studio 2015\Projects\monopoly\monopoly\dice(5).png");
            if (z == 4)
                panel38.BackgroundImage = Image.FromFile(@"C: \Users\Ahmed Ismail\Documents\Visual Studio 2015\Projects\monopoly\monopoly\dice(4).png");
            if (z == 3)
                panel38.BackgroundImage = Image.FromFile(@"C: \Users\Ahmed Ismail\Documents\Visual Studio 2015\Projects\monopoly\monopoly\dice(3).png");
            if (z == 2)
                panel38.BackgroundImage = Image.FromFile(@"C: \Users\Ahmed Ismail\Documents\Visual Studio 2015\Projects\monopoly\monopoly\dice(2).png");
            if (z == 1)
                panel38.BackgroundImage = Image.FromFile(@"C: \Users\Ahmed Ismail\Documents\Visual Studio 2015\Projects\monopoly\monopoly\dice(1).png");
          
        }

        private void panel37_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel38_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void panel19_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(x, y);
        }
        private void Form1_Paint(object sender, EventArgs e)
        {

        }
     
        private void pictureBox2_PreviewKeyDown(object sender, EventArgs e)
        {

        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        static Random R = new Random();//static make good randomisation
        private void panel35_Paint(object sender, PaintEventArgs e)
        {

            int pic2 = R.Next(1, 7); 
           
            //loading chance pictures
            if (pic2 == 1) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\chance\ch1.jpg");
            else if (pic2 == 2) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\chance\ch2.jpg");
            else if (pic2 == 3) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\chance\ch3.jpg");
            else if (pic2 == 4) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\chance\ch4.jpg");
            else if (pic2 == 5) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\chance\ch5.jpg");
            else if (pic2 == 6) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\chance\ch6.jpg");


        }
        private void button6_Click(object sender, EventArgs e)
        {
            panel53.Visible = false;
        }

        private void panel53_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Click(object sender, EventArgs e)
        {
            int pic2 = R.Next(1, 7);
            //loading chance pictures
            if (pic2 == 1) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\chance\ch1.jpg");
            else if (pic2 == 2) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\chance\ch2.jpg");
            else if (pic2 == 3) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\chance\ch3.jpg");
            else if (pic2 == 4) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\chance\ch4.jpg");
            else if (pic2 == 5) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\chance\ch5.jpg");
            else if (pic2 == 6) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\chance\ch6.jpg");

            panel53.Visible = true;

        }

        private void panel29_Paint_1(object sender, PaintEventArgs e)
        {
        }


        private void panel44_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel41_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void panel29_Click_1(object sender, EventArgs e)
        {
            int pic2 = R.Next(1, 7);
            //loading chance pictures
            if (pic2 == 1) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\chance\ch1.jpg");
            else if (pic2 == 2) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\chance\ch2.jpg");
            else if (pic2 == 3) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\chance\ch3.jpg");
            else if (pic2 == 4) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\chance\ch4.jpg");
            else if (pic2 == 5) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\chance\ch5.jpg");
            else if (pic2 == 6) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\chance\ch6.jpg");

            panel53.Visible = true;
        }

        private void panel41_Click(object sender, EventArgs e)
        {
            int pic2 = R.Next(1, 7);
            //loading chance pictures
            if (pic2 == 1) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\chance\ch1.jpg");
            else if (pic2 == 2) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\chance\ch2.jpg");
            else if (pic2 == 3) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\chance\ch3.jpg");
            else if (pic2 == 4) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\chance\ch4.jpg");
            else if (pic2 == 5) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\chance\ch5.jpg");
            else if (pic2 == 6) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\chance\ch6.jpg");

            panel53.Visible = true;
        }

        private void panel35_Click(object sender, EventArgs e)
        {
            int pic = R.Next(1, 7);
            // Loading community chest pictures 
            if (pic == 1) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\commuinty\c1.jpg");
            else if (pic == 2) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\commuinty\c2.jpg");
            else if (pic == 3) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\commuinty\c3.jpg");
            else if (pic == 4) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\commuinty\c4.jpg");
            else if (pic == 5) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\commuinty\c5.jpg");
            else if (pic == 6) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\commuinty\c6.jpg");

            panel53.Visible = true;
        }

        private void panel47_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            int pic = R.Next(1, 7);
            // Loading community chest pictures 
            if (pic == 1) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\commuinty\c1.jpg");
            else if (pic == 2) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\commuinty\c2.jpg");
            else if (pic == 3) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\commuinty\c3.jpg");
            else if (pic == 4) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\commuinty\c4.jpg");
            else if (pic == 5) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\commuinty\c5.jpg");
            else if (pic == 6) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\commuinty\c6.jpg");

            panel53.Visible = true;
        }

        private void panel47_Click(object sender, EventArgs e)
        {
            int pic = R.Next(1, 7);
            // Loading community chest pictures 
            if (pic == 1) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\commuinty\c1.jpg");
            else if (pic == 2) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\commuinty\c2.jpg");
            else if (pic == 3) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\commuinty\c3.jpg");
            else if (pic == 4) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\commuinty\c4.jpg");
            else if (pic == 5) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\commuinty\c5.jpg");
            else if (pic == 6) panel53.BackgroundImage = Image.FromFile(@"C:\Users\Ahmed Ismail\Downloads\commuinty\c6.jpg");

            panel53.Visible = true;
        }
        //timer to make the picturebox move 
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            x -= 5;
            //y += 5;

            pictureBox2.Location = new Point(x, y);
            // pictureBox2.BringToFront();
            //panel19.SendToBack();
            Invalidate();
        }
       
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {}

        private void panel51_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
    //public class country
    //{ }
    public class dice
    {
        private int d1, d2;
        static Random s = new Random();//static make good randomisation
        public int roll_dice()
        {
            d1 = s.Next(1, 7);
            return d1;
        }
    }

    //public class player
    //{
    //    int position;
    //    string name;
    //    int money;
    //    country[] arr;

    //    public void sell_land()
    //    { money += contry_price; }
    //    public void sell_house()
    //    { money += contry_price; }
    //    public void trade()
    //    { }
    //    public void build()
    //    { money -= contry_price; }
    //    public void move(int position)
    //    { }
    //}
}
