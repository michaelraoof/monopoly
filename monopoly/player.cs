using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monopoly
{
    public class player:IComparable<player>
    {
        private dice dic = new dice();
        private int position;
        private string name;
        private double money;
        private bool In_jail_now = false;
        private bool Was_in_jail = false;
        private bool first_time_to_roll_done;
        List<country> countrylist = new List<country>();// list of the owned countries which player has
        List<bool> doubl_dice=new List<bool>();
       
        public bool get_first_time_to_roll_done()
        {
          return first_time_to_roll_done;
        }
        public int get_rolld_dice()
        {
            return dic.roll_dice();
        }
        public void set_first_time_to_roll_done(bool tem)
        {
            first_time_to_roll_done = tem;
        }
        public player()
        {
            position = 0;
        }
        public List<country> get_countrylist()
        {
            return countrylist;
        }
        public void set_countrylist(List<country> obj)
        {
             countrylist=obj;
        }
        public void add_country_to_list(country obj)
        {
            countrylist.Add(obj);
        }
        public bool add_double_list_to_go_to_jail(bool temp)
        {
            if (doubl_dice.Count() == 2&&temp==true)
            {
                doubl_dice.Clear();
                return true;
            }
            else
            {
                if (temp == true)
                {
                    doubl_dice.Add(temp);
                }
                else
                {
                    doubl_dice.Clear();
                }
                return false;
            }
        }
       
        public void set_In_jail_now(bool x)
        {
            In_jail_now = x;
        }
        public bool get_In_jail_now()
        {
            return In_jail_now;
        }
        public void set_Was_in_jail(bool x)
        {
            Was_in_jail = x;
        }
        public bool get_Was_in_jail()
        {
            return Was_in_jail;
        }
        public void set_position(int position)
        {
            this.position = position;
        }
        public int get_position()
        {
            return position;
        }
        public void set_name(string name)
        {
            this.name = name;
        }
        public string get_name()
        {
            return name;
        }
        public void set_money(double money)
        {
            this.money = money;
        }
        public double get_money()
        {
            return money;
        }
           /*  public void build_house(List<group> groupp, country mycountry)
        {
            
                for()
                if (mycountry.name)
                    money -= garage_price;
        }*/
        public bool check_if_player_owner_of_the_group(List<group> obj,country plac)
        {
            for(int i = 0; i < obj.Count; i++)
            {
                if (obj[i].get_color() == plac.get_color())
                {

                    if (obj[i].get_owner().get_name() == name)
                    {
                        return true;
                    }
                    
                }
            }
            return false;
        }
        public bool check_if_this_player_is_owener_of_this_country(place obj) {
            for (int i = 0; i < countrylist.Count; i++)
            {
                if (countrylist[i].get_name() == obj.get_name())
                {
                    return true;
                }
            }
            return false;
        }


        public void move(int newposition)
        { position += newposition; }
        public int CompareTo(player obj)
        {
            if (this.position < obj.position)
            {
                return 1;
            }else if(this.position > obj.position)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
    }
}
