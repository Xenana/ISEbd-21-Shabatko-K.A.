using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Potato
    {
        
        private int has_ready = 0;

        private bool have_skin = true;

        private int dirty = 10;

        private int have_parts = 0;

        public bool Have_skin { set { this.have_skin = value; } get { return have_skin; } }

        public int Have_parts
        {
            set { if (value > -1 && value < 11) have_parts = value; }
            get { return have_parts; }
        }

        public int Has_ready { get { return has_ready; } }

        public int Dirty
        {
            set { if (value > -1 && value < 11) dirty = value; }
            get { return dirty; }
        }

        public void GetHeat()
        {
            if (has_ready < 10)
            {
                has_ready += 10;
            }
        }
    }
}
