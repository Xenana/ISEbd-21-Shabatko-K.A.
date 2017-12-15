using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class Aerodrome
    {
        ClassArray<ITransport> parking;
        int countPlaces = 20;
        int placeSizeWidth = 210;
        int placeSizeHeight = 80;
        public Aerodrome()
        {
            parking = new ClassArray<ITransport>(countPlaces, null);
        }
        public int PutPlaneInParking(ITransport plane)
        {
            return parking + plane;
        }
        public ITransport GetPlaneInParking(int ticket)
        {
            return parking - ticket;
        }
        public void Draw(Graphics g, int wight, int height)
        {
            DrawMarking(g);
            for (int i = 0; i < countPlaces; i++)
            {
                var plane = parking.getObject(i);
                if (plane != null)
                {
                    plane.setPosition(5 + i / 5 * placeSizeWidth + 5, i % 5 * placeSizeHeight + 35);
                    plane.drawPlane(g);
                }
            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, 0, 0, (countPlaces / 5) * placeSizeWidth, 480);
            for (int i = 0; i < countPlaces / 5; i++)
            {
                for (int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth + 110, j * placeSizeHeight);
                }
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 400);
            }
        }
    }
}
