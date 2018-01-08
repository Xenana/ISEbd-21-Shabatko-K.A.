using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Oil
    {
        public bool State { set; get; }

        private int temperature = 0;

        public int Temperature { get { return temperature; } }

        public void GetHeat()
        {
            if (temperature < 100)
            {
                temperature++;
            }
        }

        public Oil GetOil()
        {
            if (State)
            {
                return new Oil();
            }
            else
            {
                return null;
            }
        }
    }
}
