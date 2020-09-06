using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace monopoly
{
    public class community_chest : place//public inhertance
    {
        public override void propertize(int n, ref Panel x, int pic, ref player obj, ref Board game_obj)

        {


            //write this function as a friend one  

            // Loading community chest pictures 
            if (pic == 1)
            {
                x.BackgroundImage = Image.FromFile(@"commuinty\c1.jpg");
                // player.money -= 20;   
                obj.set_money(obj.get_money() - 20);

            }
            else if (pic == 2)
            {
                obj.set_money(obj.get_money() - 50);
                x.BackgroundImage = Image.FromFile(@"commuinty\c2.jpg");
                // player.money-= 50;     
            }
            else if (pic == 3)
            {
                obj.set_money(obj.get_money() - 50);
                x.BackgroundImage = Image.FromFile(@"commuinty\c3.jpg");
                // player.money -= 50;     
            }
            else if (pic == 4)
            {
                x.BackgroundImage = Image.FromFile(@"commuinty\c4.jpg");
                // player.money -= 25; 
                obj.set_money(obj.get_money() - 25);
            }
            else if (pic == 5)
            {
                obj.set_money(obj.get_money() - 100);
                x.BackgroundImage = Image.FromFile(@"commuinty\c5.jpg");
                // player.money -= 100;     

            }
            else if (pic == 6)
            {
                x.BackgroundImage = Image.FromFile(@"commuinty\c6.jpg");
                // player.money-= 100;     
                obj.set_money(obj.get_money() - 100);
            }
            else if (pic == 7)
            {
                x.BackgroundImage = Image.FromFile(@"commuinty\c7.jpg");
                //call go_to_jail  function;
                MessageBox.Show("you will sent to jail because of commuinty chest.");
                game_obj.jail.set_prisoners_with_going_jail(ref obj);

            }

        }
    }
}
