using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class WaterTap
    {
        
        public bool State { set; get; }

        
        public void Wash(Potato p)
        {
            if (State)
            {
                p.Dirty = 0;
            }
        }
    }
}
