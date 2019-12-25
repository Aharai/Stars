using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class Hourly : BaseClass
    {
        double rate = 200; //Почасовая ставка
        public override double Wage()
        {
           resault = 20.8 * 8 * rate;
           return resault;
        }
    }
}
