using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace monopoly
{
   public class country : place//public inhertance
    {
        //private bool this_is_group;
        private double cost;
        private double rent;
        private string color;
        private bool available;
        private double over_cost;
        private double over_rent;
        private bool build_hotel;
        private string owner;
        public bool get_build_hotel()
        {
            return build_hotel;
        }
        public bool get_available()
        {
            return available;
        }
        
        public country()
        {
            cost = 0;
            rent = 0;
            color = "white";
            build_hotel = false;
            available = false;
        }
        public country(double cos,double ren,double over_cos,double over_ren,string colo,string nam)
        {
           // owner.set_name();
            build_hotel = false;
            name = nam;
            cost = cos;
            rent = ren;
            over_rent = over_ren;
           over_cost = over_cos;
            color = colo;
            available = false;
        }
        public void set_cost(double cost)
        {
            this.cost = cost;
        }
        public double get_cost()
        {
            return cost;
        }
        public void set_rent(double rent)
        {
            this.rent = rent;
        }
        public double get_rent()
        {
            return rent;
        }
        public void set_over_cost(double over_cost)
        {
            this.over_cost = over_cost;
        }
        public double get_over_cost()
        {
            return over_cost;
        }
        public void set_over_rent(double over_rent)
        {
            this.over_rent = over_rent;
        }
        public double get_over_rent()
        {
            return over_rent;
        }
        public void set_color(string color)
        {
            this.color = color;
        }
        public string get_color()
        {
            return color;
        }
        public void set_availble(bool available)
        {
            this.available = available;
        }
        public void set_build_hotel(bool build_hotel)
        {
            this.build_hotel = build_hotel;
        }
        


        public void set_owner( string own)
        {
            owner = own;
          
        }
        public string get_owner()
        {
           return owner ;
        }
        public override void propertize(int n, ref Panel x, int pic, ref player obj, ref Board game_obj)
        {
            //Console.Write("this is ");
            //Console.WriteLine(name);
            if (n == 1)//PLAYER is the owner of country &you want sell land
            {
                available = false;
            }
            else if (n == 2)//PLAYER is the owner of country &you want sell hotel
            {
                build_hotel = false;
            }
            else if(n==3)//PLAYER is Not the owner of country &you want buy land
            {
                available = true;

            }
            else if (n == 4)//PLAYER is Not the owner of country &you want buy hotel
            {
                build_hotel = true;

            }
                //Console.Write("you can buy this country and its cost= " );
                //Console.WriteLine(cost);
           
                //Console.Write("this country is not valid and you have to pay a tax for it that = ");
                //Console.WriteLine(rent);
            
        }
    }
}
