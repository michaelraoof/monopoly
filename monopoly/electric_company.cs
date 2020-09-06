using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace monopoly
{
   public class electric_company : place//public inhertance
    {
        public override void propertize(int n, ref Panel x, int pic, ref player obj, ref Board game_obj)
        {
            MessageBox.Show("you are in Electric Company so the bank will take 100 $.");
            obj.set_money(obj.get_money() - 100);
        }
    }
}
