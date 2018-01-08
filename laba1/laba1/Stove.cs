﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Stove
    {
        private Pan pan;
        
        public bool State { set; get; }

        public Pan Pan { set { pan = value; } get { return pan; } }

        int count = 0;

        public void Cook()
        {
            if (State && count == 0)
            {
                pan.GetHeat();

            }
        }
    }
}
