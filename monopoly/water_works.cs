using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace monopoly
{
  public  class water_works : place//public inhertance
    {
        public override void propertize(int n, ref Panel x, int pic, ref player obj, ref Board game_obj)
        {
            MessageBox.Show("you are in water works so the bank will take 125 $.");
            obj.set_money(obj.get_money() - 125);
        }
    }
}
