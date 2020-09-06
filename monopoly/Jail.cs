using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace monopoly
{
   public class Jail:place
    {//int to  player

        GoToJail Go_jail=new GoToJail();
        private List<Tuple<player, int>> prisoners=new List<Tuple<player, int>>();
        public override void propertize(int n, ref Panel x, int pic, ref player obj, ref Board game_obj)
        {
            
        }

        public void set_prisoners_with_going_jail(ref player obj)
        {
            obj.set_In_jail_now(true);
            prisoners.Add(new Tuple<player, int>(obj, 0));
            Go_jail.SendToJail(ref obj);
        }
        public void set_prisoners_without_going_jail(player obj)
        {
            obj.set_In_jail_now(true);

            prisoners.Add(new Tuple<player, int>(obj, 0));
        }
        public void get_out_jail(ref player obj, int no_rolled)
        {
            obj.set_In_jail_now(false);
            obj.set_Was_in_jail(true);
            MessageBox.Show("you will get out from jail .");
           // obj.set_position((no_rolled + obj.get_position())%36);
            for (int i = 0; i < prisoners.Count; i++)
            {
                if (prisoners[i].Item1 == obj)
                {
                    prisoners.Remove(prisoners[i]);
                }
            }
        }
        public bool check_if_player_in_this_prison(player obj)
        {for(int i = 0; i < prisoners.Count; i++)
            {
                if (obj.get_name() == prisoners[i].Item1.get_name())
                {
                    return true;
                }
            }
            return false;
            
        }
        public bool Checker_double_get_out_from_jail(ref player check_player, bool doub, int no_rolled)
        {
            if (doub == false)
            {
                for (int i = 0; i < prisoners.Count; i++)
                {
                    if (prisoners[i].Item1 == check_player)
                    {
                        if (prisoners[i].Item2 == 2)
                        {
                            MessageBox.Show("you should pay a fine (50 $).");
                            check_player.set_money(check_player.get_money() - 50);
                             get_out_jail(ref check_player, no_rolled);
                           // prisoners.Remove(prisoners[i]);
                            return true;
                        }
                        else
                        {
                            prisoners[i] = new Tuple<player, int>(prisoners[i].Item1, (prisoners[i].Item2) + 1);
                            return false;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < prisoners.Count; i++)
                {
                    if (prisoners[i].Item1== check_player)
                    {
                        get_out_jail(ref check_player, no_rolled);
                      //  prisoners.Remove(prisoners[i]);
                        return true;
                    }
                }
            }
            return true;

        }

    }
}
