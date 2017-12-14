using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    public interface ITransport
    {
        void flyPlane(Graphics g);

        void drawPlane(Graphics g);

        void setPosition(int x, int y);

        void loadPassenger(int count);

        int getPassenger();

        void setMainColor(Color color);
    }
}
