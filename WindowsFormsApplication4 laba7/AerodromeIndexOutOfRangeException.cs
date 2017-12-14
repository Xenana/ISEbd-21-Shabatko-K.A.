using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class AerodromeIndexOutOfRangeException : Exception
    {
        public AerodromeIndexOutOfRangeException():
            base("На парковке нет самолета по такому месту") { }
    }
}
