using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monopoly
{
    public class Board
    {
        protected List<player> arr_player = new List<player>();
        protected List<group> arr_group = new List<group>();
        private place[] arr_country;
        public Jail jail = new Jail();
        int num_player=0;
        int index;
        public place[] get_list_country()
        {
            return arr_country;
        }
        public List<group> get_list_group()
        {
            return arr_group;
        }
       public Board()
        {
            arr_country = new place[36];

        }
        public List<player> get_List_players()
        {
            return arr_player;
        }
       public country get_country_with_pos(int pos)
        {
             
            return (country)(arr_country[pos]);

        }
        public  player get_player_at_index(int pos)
        {
            return  arr_player[pos];
        }
        public void set_player_at_pos(player obj,int pos)
        {
            arr_player[pos] = obj;
        }
        public int get_index()
        {
            return index;
        }
        public void set_index(int ss)
        {
             index=ss;
        }
        public void first_initialize(List<player> temp)
        {
            index = 0;
            arr_player = temp;

            arr_country[0] = new go_token();
            arr_country[1] = new country(300,50,120,90, "Purple", "Horgada");
            //water
            arr_country[2] = new water_works();
            arr_country[3] = new country(250, 50, 120, 90, "Purple", "Dakahlia");
            arr_country[4] = new country(250, 50, 120, 90, "Purple", "Red Sea");
            arr_group .Add(new group("Purple",arr_country[1].name, arr_country[3].name, arr_country[4].name));
            //super tax
            arr_country[5] = new Super_tax();
            arr_country[6] = new country(250, 50, 120, 90, "Red", "Monofya");
            arr_country[7] = new station();
            arr_country[8] = new country(250, 50, 120, 90, "Red", "Sharqya");
            arr_group.Add(new group("Red", arr_country[6].name, arr_country[8].name));

            arr_country[9] = new Jail();
            arr_country[10] = new country(300, 50, 120, 90, "Olive", "Aswan");
            //chance
            arr_country[11] = new chance();
            arr_country[12] = new country(250, 50, 120, 90, "Olive", "Luxor");
            arr_group.Add(new group("Olive", arr_country[10].name, arr_country[12].name));
            //electric company
            arr_country[13] = new electric_company();
            arr_country[14] = new country(250, 50, 120, 90, "Orange", "Suez");
            //community chest
            arr_country[15] = new community_chest();
            arr_country[16] = new country(250, 50, 120, 90, "Orange", "Bani Suef");
            arr_country[17] = new country(250, 50, 120, 90, "Orange", "Sohag");     
            arr_group.Add(new group("Orange", arr_country[14].name, arr_country[16].name,arr_country[17].name));
            //free parking
            arr_country[18] = new free_parking();
            arr_country[19] = new country(250, 50, 120, 90, "Black", "Matroh");
            //chance
            arr_country[20] = new chance();
            arr_country[21] = new country(250, 50, 120, 90, "Black", "Marina");
            arr_group.Add(new group("Black", arr_country[19].name, arr_country[21].name));
            //station
            arr_country[22] = new station();
            arr_country[23] = new country(250, 50, 120, 90, "Green", "Domyat");
            //community chest
            arr_country[24] = new community_chest();
            arr_country[25] = new country(250, 50, 120, 90, "Green", "Behera");
            arr_country[26] = new country(250, 50, 120, 90, "Green", "Alex");
            arr_group.Add(new group("Green", arr_country[23].name, arr_country[25].name,arr_country[26].name));

            arr_country[27] = new GoToJail();
            arr_country[28] = new country(250, 50, 120, 90, "Pink", "Fayuom");
            arr_country[29] = new country(250, 50, 120, 90, "Pink", "Port Said");
            arr_country[30] = new chance();
            arr_country[31] = new country(250, 50, 120, 90, "Pink", "Kafr El Shik");
            arr_group.Add(new group("Pink", arr_country[28].name, arr_country[29].name, arr_country[31].name));
            arr_country[32] = new community_chest();
            arr_country[33] = new country(250, 50, 120, 90, "Yellow", "Qenna");
            arr_country[34] = new income_tax();
            arr_country[35] = new country(250, 50, 120, 90, "Yellow", "Aswan");
            arr_group.Add(new group("Yellow", arr_country[33].name, arr_country[35].name));



        }
        public void add_player(player obj)
        {
            arr_player.Add(obj);
        }
        public void set_num_player(int n)
        {
            num_player = n;
        }
        public int get_num_player()
        {
         return   num_player ;
        }
        public int end_turn()// احنا بنادي عليها عشان ناخد التمب اللي هوا رقم اللاعب 
        {
            int temp = 1;
            temp++;
            return (temp % arr_player.Capacity);
        }
    }

}
