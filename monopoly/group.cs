using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monopoly
{
    public class group
    {
       
        private string color;
        private player owner=new player();
        private List<string> mine_country = new List<string>();
        public List<string> get_list()
        {
            return mine_country;
        }
        public void set_list(List<string> obj)
        {
            mine_country = obj;
        }
        public string get_color()
        {
            return color;
        }
        public player get_owner()
        {
            return owner;
        }
        public void set_color(string temp)
        {
             color=temp;
        }
        public void set_owner(player obj)
        {
             owner=obj;
        }

     public   group( string col, string country1, string country2)
        {
           
            color = col;
            
            mine_country.Add(country1);
            mine_country.Add(country2);
        }
        public group( string col, string country1, string country2, string country3)
        {
           
            color = col;
            
            mine_country.Add(country1);
            mine_country.Add(country2);
            mine_country.Add(country3);
        }
       
         
      

    }
}
