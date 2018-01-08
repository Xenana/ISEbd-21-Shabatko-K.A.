using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Knife
    {
        public void Clean(Potato p)
        {
            if (p.Have_skin)
            {
                p.Have_skin = false;
            }
        }

        public void Slice(Potato p)
        {
            p.Have_parts = 10;
        }
    }
}
