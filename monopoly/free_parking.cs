using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace monopoly
{
  public  class free_parking:place
    {
        public override void propertize(int n, ref Panel x, int pic, ref player obj, ref Board game_obj)
        {
            MessageBox.Show("you are in Free parking.");
            
        }
    }
}
