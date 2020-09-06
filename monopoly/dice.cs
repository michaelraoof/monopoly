using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monopoly
{
    public class dice
    {
        private int d1;
        static Random s = new Random();//static make good randomisation
        public int roll_dice()
        {
            d1 = s.Next(1, 7);
            return d1;
        }
    }
}
