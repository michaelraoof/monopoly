using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace monopoly
{
    class chance : place//public inhertance
    {
        public override void propertize(int n, ref Panel x, int pic, ref player obj, ref Board game_obj)

        {
           

            //write this function as a friend one  

            // Loading community chest pictures 
            if (pic == 1)
            {//here.............................................
                x.BackgroundImage = Image.FromFile(@"chance\ch1.jpg");
                // player.money -= 20;   
                
                obj.set_money(obj.get_money() - 150);

            }
            else if (pic == 2)
            {
                obj.set_money(obj.get_money() - 150);
                x.BackgroundImage = Image.FromFile(@"chance\ch2.jpg");
                // player.money-= 50;     
            }
            else if (pic == 3)
            {
                obj.set_money(obj.get_money() + 50);
                x.BackgroundImage = Image.FromFile(@"chance\ch3.jpg");
                // player.money -= 50;     
            }
            else if (pic == 4)
            {
                x.BackgroundImage = Image.FromFile(@"chance\ch4.jpg");
                //call go_to_jail  function; 
                MessageBox.Show("you sent to jail by  chance .");
                game_obj.jail.set_prisoners_with_going_jail(ref obj);
            }
            else if (pic == 5)
            {
                obj.set_money(obj.get_money() - 12);
                x.BackgroundImage = Image.FromFile(@"chance\ch5.jpg");
                // player.money -= 100;     

            }
            else if (pic == 6)
            {
                
                //here
                x.BackgroundImage = Image.FromFile(@"chance\ch6.jpg");
                // player.money-= 100;     
                obj.set_money(obj.get_money() + 50);
            }


        }
    }
}
