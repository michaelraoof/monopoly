using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace monopoly
{
  public  abstract class place
    {
        public int position;
        public string name;
        public void set_name(string nam)
        {
            name = nam;
        }
        public void set_position(int pos)
        {
            position = pos;
        }
        public string get_name()
        {
           return name;
        }
        public int get_position()
        {
           return position;
        }
        public abstract void propertize(int n, ref Panel x, int pic, ref player obj, ref Board game_obj);
    }
}
