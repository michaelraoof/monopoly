using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace monopoly
{
   public class GoToJail:place
    {
        public void SendToJail(ref player obj)
        {
            obj.set_position(9);
           
        }
        public override void propertize(int n, ref Panel x, int pic, ref player obj, ref Board game_obj)
        {
           
        }
    }
}
