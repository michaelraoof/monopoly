using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace monopoly
{

    public partial class Form1 : Form
    {
            private int x;
        private int y;
        public int first_dice;
        public int second_dice;
      
        Board game=new Board() ;
        player play = new player();
        private Queue<int> que = new Queue<int> { };
        List<Tuple<int, int>> location_country = new List<Tuple<int, int>>();
        FileStream fs = new FileStream("locations.txt", FileMode.Open, FileAccess.Read);
        int counter_of_players = 0;

        ListViewItem view_list;

        List<player> map = new List<player>();
        public Form1()
        {
            InitializeComponent();
            x = 647;
            y = 544;
            textBox2.Visible = true;
           
            StreamReader sr = new StreamReader(fs);
            for (int i = 0; i < 36; i++)
            {
             
                location_country.Add(new Tuple<int, int>(int.Parse(sr.ReadLine()), int.Parse(sr.ReadLine())));
            }
            sr.Close();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button9.Visible = false;
            name_player.Visible = false;
            panel54.Visible = false;
            listView1.Visible = false;
            panel55.Visible = false;
            label22.Visible = false;
            button10.Visible = false;
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //hotel
            panel1.Visible = true;
            label14.Text = "Enter hotel Name:";
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
            panel1.Visible = true;
            label14.Text = "Enter land Name:";
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
           /* string s = comboBox1.SelectedItem.ToString();
            List<int> l = new List<int>();
            l.Add(2); l.Add(3);
            //listBox1.Items.Clear();
            listBox1.DataSource = l;
            //listBox1.Items.Add("ahmed");*/

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
            listBox1.Items.Clear();
            btn_roll_dice.Enabled = false;
            btn_end_turn.Enabled = true;

            play = game.get_player_at_index(game.get_index());

            first_dice = play.get_rolld_dice();
            //game.get_list_country()[play.get_position()].propertize(3, ref panel1, 0, ref play, ref game);
            second_dice = play.get_rolld_dice();



            // 

            
            if ((play.get_position() + first_dice + second_dice) >= 36 && play.get_first_time_to_roll_done() == false)
            {

                btn_leave.Enabled = true;
                play.set_first_time_to_roll_done(true);
                if (play.get_Was_in_jail() == false)
                {
                    play.set_money(play.get_money() + 200);
                    MessageBox.Show("you have earned 200$.");
                }
                else if (play.get_Was_in_jail() == true)
                {
                    play.set_Was_in_jail(false);
                }
            }
            else if ((play.get_position() + first_dice + second_dice) >= 36 && play.get_first_time_to_roll_done() == true)
            {
                if (play.get_Was_in_jail() == false)
                {
                    play.set_money(play.get_money() + 200);
                    MessageBox.Show("you have earned 200$.");
                }
                else if (play.get_Was_in_jail() == true)
                {
                    play.set_Was_in_jail(false);
                }
            }
            if (play.get_In_jail_now() == true)
            {
                if (second_dice == first_dice)
                {
                    game.jail.Checker_double_get_out_from_jail(ref play, true, first_dice + second_dice);
                   
                }
                else
                {
                    game.jail.Checker_double_get_out_from_jail(ref play, false, first_dice + second_dice);
                }
            }
             if (play.get_In_jail_now() == false)
            {
                if (second_dice == first_dice)
                {
                    if (play.add_double_list_to_go_to_jail(true) == true)
                    {
                        game.jail.set_prisoners_with_going_jail(ref play);
                        MessageBox.Show("you will send to jail As you played three doubles. ");

                    }
                }
                else
                {
                    play.add_double_list_to_go_to_jail(false);
                }
            }
            if (play.get_In_jail_now() == false)
            {
                play.set_position((play.get_position() + first_dice + second_dice) % 36);

               
            }
                btn_leave.Visible = true;
                //country


                if ((game.get_list_country()[play.get_position()]).GetType() == typeof(Jail))
                {
                    if (play.get_In_jail_now() == false)
                    {
                        listBox1.Items.Add("you are in jail  ");
                        //game.get_list_country()[play.get_position()].propertize(3, ref panel1, 0, ref play, ref game);
                      
                       // game.jail.set_prisoners_with_going_jail(ref play);
                        btn_sell_hotel.Enabled = true;
                        btn_sell_land.Enabled = true;
                        btn_leave.Enabled = true;
                        btn_end_turn.Enabled = true;
                    }

                }
                else if ((game.get_list_country()[play.get_position()]).GetType() == typeof(station))
                {

                game.get_list_country()[play.get_position()].propertize(3, ref panel1, 0, ref play, ref game);
                btn_sell_hotel.Enabled = true;
                btn_sell_land.Enabled = true;
                btn_leave.Enabled = true;
                btn_end_turn.Enabled = true;
                
                }
                else if ((game.get_list_country()[play.get_position()]).GetType() == typeof(income_tax))
                {
                    game.get_list_country()[play.get_position()].propertize(3, ref panel1, 0, ref play, ref game);
                    btn_sell_hotel.Enabled = true;
                    btn_sell_land.Enabled = true;
                    btn_leave.Enabled = true;
                    btn_end_turn.Enabled = true;
                }
                else if ((game.get_list_country()[play.get_position()]).GetType() == typeof(water_works))
                {
                    game.get_list_country()[play.get_position()].propertize(3, ref panel1, 0, ref play, ref game);
                    btn_sell_hotel.Enabled = true;
                    btn_sell_land.Enabled = true;
                    btn_leave.Enabled = true;
                    btn_end_turn.Enabled = true;
                }
                else if ((game.get_list_country()[play.get_position()]).GetType() == typeof(go_token))
                {
                    game.get_list_country()[play.get_position()].propertize(3, ref panel1, 0, ref play, ref game);
                    btn_sell_hotel.Enabled = true;
                    btn_sell_land.Enabled = true;
                    btn_leave.Enabled = true;
                    btn_end_turn.Enabled = true;
                }
                else if ((game.get_list_country()[play.get_position()]).GetType() == typeof(GoToJail))
                {
                //game.get_list_country()[play.get_position()].propertize(3, ref panel1, 0, ref play, ref game);
                game.jail.set_prisoners_with_going_jail(ref play);

                    MessageBox.Show(" you will go to jail by go to jail token. ");
                    btn_sell_hotel.Enabled = true;
                    btn_sell_land.Enabled = true;
                    btn_leave.Enabled = true;
                    btn_end_turn.Enabled = true;
                    
                }
                else if ((game.get_list_country()[play.get_position()]).GetType() == typeof(community_chest))
                {
                    int pic2 = R.Next(1, 7);
                    game.get_list_country()[play.get_position()].propertize(3, ref panel53, pic2, ref play, ref game);
                    btn_sell_hotel.Enabled = true;
                    btn_sell_land.Enabled = true;
                    btn_leave.Enabled = true;
                    btn_end_turn.Enabled = true;
                    panel53.Visible = true;
                }
                
                else if ((game.get_list_country()[play.get_position()]).GetType() == typeof(chance))
                {
                    int pic2 = R.Next(1, 7);
                    game.get_list_country()[play.get_position()].propertize(3, ref panel53, pic2, ref play, ref game);
                    btn_sell_hotel.Enabled = true;
                    btn_sell_land.Enabled = true;
                    btn_leave.Enabled = true;
                    btn_end_turn.Enabled = true;
                    panel53.Visible = true;
                }
                else if ((game.get_list_country()[play.get_position()]).GetType() == typeof(electric_company))
                {
                    game.get_list_country()[play.get_position()].propertize(3, ref panel1, 0, ref play, ref game);
                    btn_sell_hotel.Enabled = true;
                    btn_sell_land.Enabled = true;
                    btn_leave.Enabled = true;
                    btn_end_turn.Enabled = true;
                }
                else if ((game.get_list_country()[play.get_position()]).GetType() == typeof(Super_tax))
                {
                    game.get_list_country()[play.get_position()].propertize(3, ref panel1, 0, ref play, ref game);
                    btn_sell_hotel.Enabled = true;
                    btn_sell_land.Enabled = true;
                    btn_leave.Enabled = true;
                    btn_end_turn.Enabled = true;
                }
            listBox1.Items.Add("Player Name:     " + play.get_name());
            listBox1.Items.Add("Player Money:    " + play.get_money());
            listBox1.Items.Add("Player Country:  ");
            if (play.get_countrylist().Count == 0)
            {
                listBox1.Items.Add("You dont have countries.");
            }
            for (int i = 0; i < play.get_countrylist().Count; i++)
            {
                listBox1.Items.Add("you have " + play.get_countrylist()[i].get_name() + "and it`s price is " + play.get_countrylist()[i].get_cost() + "$.");
                if (play.get_countrylist()[i].get_build_hotel() == true)
                {
                    listBox1.Items.Add("you have an hotel on this country and its price " + play.get_countrylist()[i].get_over_cost());

                }

            }
            if ((game.get_list_country()[play.get_position()]).GetType() == typeof(country))
                {//this player is owner

                    listBox1.Items.Add("..................................................");
                    listBox1.Items.Add("this token is called  " + game.get_country_with_pos(play.get_position()).get_name());
                    listBox1.Items.Add("It costs  " + game.get_country_with_pos(play.get_position()).get_cost() + "    and its rent =" + game.get_country_with_pos(play.get_position()).get_rent());
                    listBox1.Items.Add("The hotel costs " + game.get_country_with_pos(play.get_position()).get_over_cost() + "    and its hotel rent =" + game.get_country_with_pos(play.get_position()).get_over_rent());

                }
                if ( play.get_first_time_to_roll_done() == true&& (game.get_list_country()[play.get_position()]).GetType() == typeof(country))
                {
                   
                    //this player is owner
                  //  MessageBox.Show("hahahaahah");
                        btn_sell_hotel.Enabled = true;
                        btn_sell_land.Enabled = true;
                        if (play.check_if_this_player_is_owener_of_this_country(game.get_country_with_pos(play.get_position())) == true)
                {
                  //  MessageBox.Show("0000000000000000000");

                    btn_rent.Enabled = false;
                            //check_if_player_owner_of_the_group
                            if (play.check_if_player_owner_of_the_group(game.get_list_group(), (game.get_country_with_pos(play.get_position()))) == true)
                    {
                       
                        if (game.get_country_with_pos(play.get_position()).get_build_hotel() == false)
                                {
                                    btn_buy_hotel.Enabled = true;
                           
                        }

                            }
                        }
                        else
                        {//rent


                   
                    if (game.get_country_with_pos(play.get_position()).get_available() == false)
                    {
                      
                        btn_buy_land.Enabled = true;
                            }
                            else
                    {
                        btn_sell_hotel.Enabled = true;
                        btn_sell_land.Enabled = true;
                        btn_rent.Enabled = true;
                        btn_end_turn.Enabled = false;
                        btn_buy_hotel.Enabled = false;
                        btn_buy_land.Enabled = false;
                            }

                        }

                    
                }
                //check if the player is the owner of this coutry

                /*  (n == 1)//PLAYER is the owner of country &you want sell land  
                (n == 2)//PLAYER is the owner of country &you want sell hotel
                (n == 3)//PLAYER is Not the owner of country &you want buy land
                (n == 4)//PLAYER is Not the owner of country &you want buy hotel*/








                //loading dice pictures//////////
               
            
            if (first_dice == 6)
                pic_dice_1.BackgroundImage = Image.FromFile(@"dices\dice(6).png");
            if (first_dice == 5)
                pic_dice_1.BackgroundImage = Image.FromFile(@"dices\dice(5).png");
            if (first_dice == 4)
                pic_dice_1.BackgroundImage = Image.FromFile(@"dices\dice(4).png");
            if (first_dice == 3)
                pic_dice_1.BackgroundImage = Image.FromFile(@"dices\dice(3).png");
            if (first_dice == 2)
                pic_dice_1.BackgroundImage = Image.FromFile(@"dices\dice(2).png");
            if (first_dice == 1)
                pic_dice_1.BackgroundImage = Image.FromFile(@"dices\dice(1).png");
            if (second_dice == 6)
                pic_dice_2.BackgroundImage = Image.FromFile(@"dices\dice(6).png");
            if (second_dice == 5)
                pic_dice_2.BackgroundImage = Image.FromFile(@"dices\dice(5).png");
            if (second_dice == 4)
                pic_dice_2.BackgroundImage = Image.FromFile(@"dices\dice(4).png");
            if (second_dice == 3)
                pic_dice_2.BackgroundImage = Image.FromFile(@"dices\dice(3).png");
            if (second_dice == 2)
                pic_dice_2.BackgroundImage = Image.FromFile(@"dices\dice(2).png");
            if (second_dice == 1)
                pic_dice_2.BackgroundImage = Image.FromFile(@"dices\dice(1).png");


                if (game.get_index() == 0)
                {
                    pictureBox1.Location = new Point(location_country[play.get_position()].Item1, location_country[play.get_position()].Item2);

                }
                else if (game.get_index() == 1)
                {
                    pictureBox2.Location = new Point(location_country[play.get_position()].Item1, location_country[play.get_position()].Item2);

                }
                else if (game.get_index() == 2)
                {
                    pictureBox3.Location = new Point(location_country[play.get_position()].Item1, location_country[play.get_position()].Item2);

                }
                else if (game.get_index() == 3)
                {
                    pictureBox4.Location = new Point(location_country[play.get_position()].Item1, location_country[play.get_position()].Item2);

                }
                else if (game.get_index() == 4)
                {
                    pictureBox5.Location = new Point(location_country[play.get_position()].Item1, location_country[play.get_position()].Item2);

                }
                else if (game.get_index() == 5)
                {
                    pictureBox6.Location = new Point(location_country[play.get_position()].Item1, location_country[play.get_position()].Item2);

                }
                else if (game.get_index() == 6)
                {
                    pictureBox7.Location = new Point(location_country[play.get_position()].Item1, location_country[play.get_position()].Item2);

                }
                else if (game.get_index() == 7)
                {
                    pictureBox8.Location = new Point(location_country[play.get_position()].Item1, location_country[play.get_position()].Item2);

                }
            
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
        { }
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

       /* private void panel11_Click(object sender, EventArgs e)
        {
            int pic2 = R.Next(1, 7);
            //loading chance pictures
                 if (pic2 == 1) panel53.BackgroundImage = Image.FromFile(@"chance\ch1.jpg");
            else if (pic2 == 2) panel53.BackgroundImage = Image.FromFile(@"chance\ch2.jpg");
            else if (pic2 == 3) panel53.BackgroundImage = Image.FromFile(@"chance\ch3.jpg");
            else if (pic2 == 4) panel53.BackgroundImage = Image.FromFile(@"chance\ch4.jpg");
            else if (pic2 == 5) panel53.BackgroundImage = Image.FromFile(@"chance\ch5.jpg");
            else if (pic2 == 6) panel53.BackgroundImage = Image.FromFile(@"chance\ch6.jpg");

            panel53.Visible = true;

        }*/

        private void panel29_Paint_1(object sender, PaintEventArgs e)
        {
        }


        private void panel44_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel41_Paint(object sender, PaintEventArgs e)
        {

        }
       /* private void panel29_Click_1(object sender, EventArgs e)
        {
            panel11_Click(sender, e);
        }

        private void panel41_Click(object sender, EventArgs e)
        {
            panel11_Click(sender, e);
        }
        */
        public void panel35_Click(object sender, EventArgs e)
        {
            
            int pic = R.Next(1, 7);
            // Loading community chest pictures 
                 if (pic == 1) panel53.BackgroundImage = Image.FromFile(@"commuinty\c1.jpg");
            else if (pic == 2) panel53.BackgroundImage = Image.FromFile(@"commuinty\c2.jpg");
            else if (pic == 3) panel53.BackgroundImage = Image.FromFile(@"commuinty\c3.jpg");
            else if (pic == 4) panel53.BackgroundImage = Image.FromFile(@"commuinty\c4.jpg");
            else if (pic == 5) panel53.BackgroundImage = Image.FromFile(@"commuinty\c5.jpg");
            else if (pic == 6) panel53.BackgroundImage = Image.FromFile(@"commuinty\c6.jpg");

            panel53.Visible = true;
        }

        private void panel47_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Click(object sender, EventArgs e)
        {
            panel35_Click(sender, e);
        }

        private void panel47_Click(object sender, EventArgs e)
        {
            panel35_Click(sender, e);
        }
        //timer to make the picturebox move 
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
            Invalidate();


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        { }

        private void panel51_Paint(object sender, PaintEventArgs e)
        {

        }

        private void monobly_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("the num of player must be more than 1");
            }


            else
            {

               

               

                if ((Convert.ToInt32(textBox2.Text) >= 2) && (Convert.ToInt32(textBox2.Text) <= 8))
                {


                    game.set_num_player(Convert.ToInt32(textBox2.Text));

                    // num.arr_player[1].position = 7;
                    //num.arr_player[1].pos();

                    counter_of_players = Convert.ToInt32(textBox2.Text);

                    button9.Visible = true;
                    name_player.Visible = true;
                    panel54.Visible = true;
                    panel55.Visible = true;
                    listView1.Visible = true;
                    label22.Visible = true;
                                       lable2222.Visible = false;
                    button7.Visible = false;
                    textBox2.Visible = false;


                }
                else
                {
                    MessageBox.Show("the num of player must be more than or equal 2 and less than or equal 8");
                }

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            

               

                string name = name_player.Text;



                if (name_player.Text == "")
                {
                    MessageBox.Show("u must fill that text ");
                }
                else
                {

                player p = new player();

                
                counter_of_players--;
                    dice d = new dice();

                    int a = d.roll_dice();
                    int b = d.roll_dice();

                    int sum = a + b;


                   
                p.set_name(name);
                p.set_position(sum);
               // 
                map.Add(p);
                if (a == 6)
                        panel54.BackgroundImage = Image.FromFile(@"dices\dice(6).png");
                    else if (a == 5)
                        panel54.BackgroundImage = Image.FromFile(@"dices\dice(5).png");
                    else if (a == 4)
                        panel54.BackgroundImage = Image.FromFile(@"dices\dice(4).png");
                    else if (a == 3)
                        panel54.BackgroundImage = Image.FromFile(@"dices\dice(3).png");
                    else if (a == 2)
                        panel54.BackgroundImage = Image.FromFile(@"dices\dice(2).png");
                    else if (a == 1)
                        panel54.BackgroundImage = Image.FromFile(@"dices\dice(1).png");


                    if (b == 6)
                        panel55.BackgroundImage = Image.FromFile(@"dices\dice(6).png");
                    else if (b == 5)
                        panel55.BackgroundImage = Image.FromFile(@"dices\dice(5).png");
                    else if (b == 4)
                        panel55.BackgroundImage = Image.FromFile(@"dices\dice(4).png");
                    else if (b == 3)
                        panel55.BackgroundImage = Image.FromFile(@"dices\dice(3).png");
                    else if (b == 2)
                        panel55.BackgroundImage = Image.FromFile(@"dices\dice(2).png");
                    else if (b == 1)
                        panel55.BackgroundImage = Image.FromFile(@"dices\dice(1).png");
                    view_list = new ListViewItem(name_player.Text);
                    view_list.SubItems.Add(sum.ToString());

                    listView1.Items.Add(view_list);


                }

                name_player.Text = "";



                if (counter_of_players == 0)
                {

                map.Sort();
                for(int i = 0; i < map.Count; i++)
                {
                    map[i].set_position(0);
                    map[i].set_money(1200);
                    map[i].set_first_time_to_roll_done(false);
                    map[i].set_In_jail_now(false);
                    map[i].set_Was_in_jail(false);

                }
                game.first_initialize(map);
                if (map.Count == 2)
                {
                    pictureBox1.Location = new Point(x, y);
                    pictureBox2.Location = new Point(x, y);
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                }
                else if (map.Count == 3)
                {
                    pictureBox1.Location = new Point(x, y);
                    pictureBox2.Location = new Point(x, y);
                    pictureBox3.Location = new Point(x, y);
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;

                }
                else if (map.Count == 4)
                {
                    pictureBox1.Location = new Point(x, y);
                    pictureBox2.Location = new Point(x, y);
                    pictureBox3.Location = new Point(x, y);
                    pictureBox4.Location = new Point(x, y);
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;

                }
                else if (map.Count == 5)
                {
                    pictureBox1.Location = new Point(x, y);
                    pictureBox2.Location = new Point(x, y);
                    pictureBox3.Location = new Point(x, y);
                    pictureBox4.Location = new Point(x, y);
                    pictureBox5.Location = new Point(x, y);
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                }
                else if (map.Count == 6)
                {
                    pictureBox1.Location = new Point(x, y);
                    pictureBox2.Location = new Point(x, y);
                    pictureBox3.Location = new Point(x, y);
                    pictureBox4.Location = new Point(x, y);
                    pictureBox5.Location = new Point(x, y);
                    pictureBox6.Location = new Point(x, y);
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;

                }
                else if (map.Count == 7)
                {
                    pictureBox1.Location = new Point(x, y);
                    pictureBox2.Location = new Point(x, y);
                    pictureBox3.Location = new Point(x, y);
                    pictureBox4.Location = new Point(x, y);
                    pictureBox5.Location = new Point(x, y);
                    pictureBox6.Location = new Point(x, y);
                    pictureBox7.Location = new Point(x, y);
                    pictureBox8.Visible = false;
                }
                else if (map.Count == 8)
                {
                    pictureBox1.Location = new Point(x, y);
                    pictureBox2.Location = new Point(x, y);
                    pictureBox3.Location = new Point(x, y);
                    pictureBox4.Location = new Point(x, y);
                    pictureBox5.Location = new Point(x, y);
                    pictureBox6.Location = new Point(x, y);
                    pictureBox7.Location = new Point(x, y);
                    pictureBox8.Location = new Point(x, y);
                }
                button10.Visible = true;
                label22.Visible = false;
                name_player.Visible = false;
                button9.Visible = false;
                panel54.Visible = false;
                panel55.Visible = false;
                

            }
            
        }

        private void place_31_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label21_Click_1(object sender, EventArgs e)
        {

        }

        private void place_1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel52.Visible = false;
            btn_sell_hotel.Enabled = false;
            btn_sell_land.Enabled = false;
            btn_buy_land.Enabled = false;
            btn_buy_hotel.Enabled = false;
            btn_leave.Enabled = true;
            btn_rent.Enabled = false;
            btn_roll_dice.Enabled = true;
            btn_end_turn.Enabled = false;
            panel1.Visible = false;
        }

        private void panel52_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_rent_Click(object sender, EventArgs e)
        {
            if (game.get_country_with_pos(play.get_position()).get_build_hotel() == true)
            {
                if (play.get_money() >= (game.get_country_with_pos(play.get_position()).get_over_rent()+ game.get_country_with_pos(play.get_position()).get_rent()))
                {
                    play.set_money(play.get_money() - game.get_country_with_pos(play.get_position()).get_over_rent()- game.get_country_with_pos(play.get_position()).get_rent());
                    btn_leave.Enabled = true;
                    btn_end_turn.Enabled = true;

                }
                else
                {
                    MessageBox.Show("you dont have money sell anything or leave the game.");
                    btn_leave.Enabled = true;
                    btn_sell_hotel.Enabled = true;
                    btn_sell_land.Enabled = true;
                   
                }

            }
            else
            {
                if (play.get_money() >= game.get_country_with_pos(play.get_position()).get_rent())
                {
                    play.set_money(play.get_money() - game.get_country_with_pos(play.get_position()).get_over_rent());
                    btn_leave.Enabled = true;
                    btn_end_turn.Enabled = true;
                }
                else
                {
                    btn_sell_hotel.Enabled = true;
                    btn_sell_land.Enabled = true;
                    MessageBox.Show("you dont have money sell anything  U OWNE or leave the game.");
                    btn_leave.Enabled = true;
                }
            }
           
        }

        private void btn_buy_hotel_Click(object sender, EventArgs e)
        {
            int i;
            int xx = new int();
            for (i = 0; i < game.get_list_group().Count; i++)
            {
                if (game.get_list_group()[i].get_color() == game.get_country_with_pos(play.get_position()).get_color())
                {
                    xx = i;
                  
                }
            }
            if (play.check_if_player_owner_of_the_group(game.get_list_group(), game.get_country_with_pos(play.get_position())) == true)
            {
               
                if (game.get_country_with_pos(play.get_position()).get_build_hotel() == false)
                {
                    if (play.get_money() >= game.get_country_with_pos(play.get_position()).get_over_cost())
                    {

                        game.get_country_with_pos(play.get_position()).propertize(4,ref panel1,  0, ref play,ref  game);

                        play.set_money(play.get_money() - game.get_country_with_pos(play.get_position()).get_over_cost());
                        game.set_player_at_pos(play, game.get_index());

                        game.get_list_group()[xx].set_owner(play);
                        btn_end_turn.Visible = true;
                        btn_leave.Enabled = true;

                        btn_sell_hotel.Enabled = true;
                        btn_sell_land.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("you dont have enough money  .");

                        btn_leave.Enabled = true;
                        btn_end_turn.Enabled = true;
                        btn_sell_hotel.Enabled = true;
                        btn_sell_land.Enabled = true;
                    }

                }
                else
                {
                    MessageBox.Show("you can not add this hotel another time .");
                }
            }
            else
            {
                MessageBox.Show("you are not the owner of this group."); 
            }
           
        }

        private void btn_buy_land_Click(object sender, EventArgs e)
        {
             if (game.get_country_with_pos(play.get_position()).get_available() == false)
                {
                    if (play.get_money() >= game.get_country_with_pos(play.get_position()).get_cost())
                    {
                    List<bool> temp = new List<bool>();

                    play.add_country_to_list(game.get_country_with_pos(play.get_position()));
                        play.set_money(play.get_money() - game.get_country_with_pos(play.get_position()).get_cost());
                        game.get_country_with_pos(play.get_position()).propertize(3, ref panel1, 0, ref play, ref game);
                        game.set_player_at_pos(play, game.get_index());
                        game.get_country_with_pos(play.get_position()).set_owner( play.get_name());
                    for(int i = 0; i < game.get_list_group().Count; i++)
                    {
                        if (game.get_list_group()[i].get_color() == game.get_country_with_pos(play.get_position()).get_color())
                        {
                            for(int gr_count=0; gr_count < game.get_list_group()[i].get_list().Count; gr_count++)
                            {
                                for(int player_count = 0; player_count < play.get_countrylist().Count; player_count++)
                                {
                                    if(game.get_list_group()[i].get_list()[gr_count]== play.get_countrylist()[player_count].get_name())
                                    {
                                        temp.Add(true);
                                        break;
                                    }
                                }
                            }
                            if(temp.Count== game.get_list_group()[i].get_list().Count)
                            {
                                game.get_list_group()[i].set_owner(play);
                            }
                        }
                    }
                        btn_buy_hotel.Enabled = true;
                    btn_buy_land.Enabled = false;
                    }
                    else
                {
                    btn_buy_land.Enabled = false;
                    MessageBox.Show("you dont have money  .");
                        btn_leave.Enabled = true;
                        btn_end_turn.Enabled = true;
                        btn_sell_hotel.Enabled = true;
                        btn_sell_land.Enabled = true;
                    }
                }
             else if(game.get_country_with_pos(play.get_position()).get_available() == true)
            {
                int o = 0;
                for(int i=0;i< play.get_countrylist().Count; i++)
                {
                    if (game.get_list_country()[play.get_position()].get_name() == play.get_countrylist()[i].get_name())
                    {
                        o = 1;
                    }
                }
                if (o == 1)
                {
                    MessageBox.Show("you are the owner of this country .");

                }
                else
                {
                    MessageBox.Show("you should pay rent to this country.");
                    btn_rent.Enabled = true;
                    btn_sell_hotel.Enabled = true;
                    btn_sell_land.Enabled = true;
                }
            }
              
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            int k = -1;
            if (textBox1.Text != ""&&label14.Text== "Enter hotel Name:")
            {
                
                for (int i = 0; i < 36; i++)
                {
                    if (game.get_list_country()[i].get_name() == textBox1.Text)
                    {
                        k = i;
                        if (game.get_country_with_pos(i).get_owner() == play.get_name())
                        {
                            game.get_country_with_pos(play.get_position()).set_build_hotel(false);
                            play.set_money(play.get_money() + game.get_country_with_pos(play.get_position()).get_over_cost());
                            play.get_countrylist().Remove(play.get_countrylist()[i]);
                            panel14.Visible = false;
                        }
                        else
                        {
                            panel14.Visible = false;
                            MessageBox.Show("you are not the owner   .");
                        }
                    }
                }
                if (k == -1)
                {
                    MessageBox.Show("there is not country with this name .");
                }
            }
            else if(textBox1.Text != "" && label14.Text == "Enter land Name:")
            {
                for (int i = 0; i < 36; i++)
                {
                    if (game.get_list_country()[i].get_name() == textBox1.Text)
                    {
                        k = i;
                        if (game.get_country_with_pos(i).get_owner() == play.get_name())
                        {
                            game.get_country_with_pos(play.get_position()).set_availble(false);

                            play.set_money(play.get_money() + game.get_country_with_pos(play.get_position()).get_over_cost());
                            for(int j=0;j< play.get_countrylist().Count; j++)
                            {
                                if(play.get_countrylist()[j].get_name()== textBox1.Text)
                                {
                                    play.get_countrylist().Remove(play.get_countrylist()[j]);
                                   
                                }
                            }
                            game.get_country_with_pos(play.get_position()).set_owner("");
                            panel14.Visible = false;
                        }
                        else
                        {
                            panel14.Visible = false;
                            MessageBox.Show("you are not the owner   .");
                        }
                    }
                }
                if (k == -1)
                {
                    MessageBox.Show("there is not country with this name .");
                }

            }
            else{
                MessageBox.Show("error!!!");
            }
        }

        private void btn_leave_Click(object sender, EventArgs e)
        {
            if (game.get_num_player() == 2)
            {
                
                game.get_List_players().Remove(game.get_List_players()[game.get_index()]);
               MessageBox.Show("the winner is  "+ game.get_List_players()[0].get_name());
                btn_buy_hotel.Enabled = false;
                btn_buy_land.Enabled = false;
                btn_end_turn.Enabled = false;

                btn_rent.Enabled = false;

                btn_sell_hotel.Enabled = false;
                btn_sell_land.Enabled = false;
                btn_leave.Enabled = false;
                btn_roll_dice.Enabled = false;

            }
            else
            {
                game.get_List_players().Remove(game.get_List_players()[game.get_index()]);
                game.set_num_player(game.get_num_player() - 1);
                btn_buy_hotel.Enabled = false;
                btn_buy_land.Enabled = false;
                btn_end_turn.Enabled = true;

                btn_rent.Enabled = false;

                btn_sell_hotel.Enabled = false;
                btn_sell_land.Enabled = false;
                btn_leave.Enabled = false;
                btn_roll_dice.Enabled = false;
            }
        }

        private void btn_end_turn_Click(object sender, EventArgs e)
        {
            game.get_List_players()[game.get_index()] = play;
            panel53.Visible = false ;
            game.set_index((game.get_index() + 1) % game.get_num_player());
            btn_buy_hotel.Enabled = false;
            btn_buy_land.Enabled = false;
            btn_end_turn.Enabled = false;
           
            btn_rent.Enabled = false;
           
            btn_sell_hotel.Enabled = false;
            btn_sell_land.Enabled = false;
            btn_leave.Enabled = true;
            btn_roll_dice.Enabled = true;
           if(play.get_money() < 0)
            {
                MessageBox.Show("you should sell any thing or leave the game .");
                btn_roll_dice.Enabled = false;
                btn_sell_hotel.Enabled = true;
                btn_sell_land.Enabled = true;
                btn_end_turn.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel53.Visible = false;
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }

}
