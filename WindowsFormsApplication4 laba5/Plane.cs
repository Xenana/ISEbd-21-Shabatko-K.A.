using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    public class Plane : AirTransport
    {
        public override int MaxSpeed
        {
            get
            {
                return base.MaxSpeed;
            }
            protected set
            {
                if (value > 0 && value < 400)
                {
                    base.MaxSpeed = value;
                }
                else
                {
                    base.MaxSpeed = 300;
                }
            }
        }
        public override int MaxCountPassengers
        {
            get
            {
                return base.MaxCountPassengers;
            }

            protected set
            {
                if (value > 0 && value < 7)
                {
                    base.MaxCountPassengers = value;
                }
                else
                {
                    base.MaxCountPassengers = 6;
                }
            }
        }
        public override double Weight
        {
            get
            {
                return base.Weight;
            }
            protected set
            {
                if (value > 1500 && value < 2150)
                {
                    base.Weight = value;
                }
                else
                {
                    base.Weight = 2000;
                }
            }
        }
        public Plane(int maxSpeed, int maxCountPassengers, int weight, Color color)
        {
            this.MaxSpeed = maxSpeed;
            this.MaxCountPassengers = maxCountPassengers;
            this.ColorBody = color;
            this.Weight = weight;
            this.countPassengers = 0;
            Random rand = new Random();
            startPosX = rand.Next(10, 200);
            startPosY = rand.Next(10, 200);
        }
        public override void flyPlane(Graphics g)
        {
            startPosX -=
                (MaxSpeed * 50 / (float)Weight) /
                    (countPassengers == 0 ? 1 : countPassengers);
            drawPlane(g);
        }
        public override void drawPlane(Graphics g)
        {
            drawPlanee(g);
        }
        protected virtual void drawPlanee(Graphics g)
        {

            Pen pen = new Pen(Color.Black);
            g.DrawEllipse(pen, startPosX, startPosY, 100, 20);
            g.DrawLine(pen, startPosX + 25, startPosY, startPosX + 50, startPosY - 25);
            g.DrawLine(pen, startPosX + 50, startPosY - 25, startPosX + 50, startPosY);
            g.DrawLine(pen, startPosX + 25, startPosY + 10, startPosX + 40, startPosY + 25);
            g.DrawLine(pen, startPosX + 40, startPosY + 25, startPosX + 50, startPosY + 10);
            g.DrawLine(pen, startPosX + 75, startPosY, startPosX + 90, startPosY - 25);
            g.DrawLine(pen, startPosX + 90, startPosY - 25, startPosX + 110, startPosY - 25);
            g.DrawLine(pen, startPosX + 110, startPosY - 25, startPosX + 90, startPosY);


            Brush br = new SolidBrush(ColorBody);
            g.FillEllipse(br, startPosX, startPosY, 100, 20);
        }
    }
}
