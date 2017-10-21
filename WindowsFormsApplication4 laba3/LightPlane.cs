using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class LightPlane : Plane
    {
        private bool Strips;
        private bool Engines;
        private Color dopColor;
        public LightPlane(int maxSpeed, int maxCountPassenger, int weight, Color color,
            bool Strips, bool Engines, Color dopColor) :
            base(maxSpeed, maxCountPassenger, weight, color)
        {
            this.Strips = Strips;
            this.Engines = Engines;
            this.dopColor = dopColor;
        }
        protected override void drawPlanee(Graphics g)
        {
            if (Strips)
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
                g.DrawRectangle(pen, startPosX + 30, startPosY - 10, 20, 10);
                g.DrawRectangle(pen, startPosX + 30, startPosY + 20, 20, 10);

                Brush br = new SolidBrush(ColorBody);
                g.FillEllipse(br, startPosX, startPosY, 100, 20);
                Brush strips = new SolidBrush(dopColor);

                g.FillEllipse(strips, startPosX + 30, startPosY - 10, 20, 10);
                g.FillEllipse(strips, startPosX + 30, startPosY + 20, 20, 10);

            }
            if (Engines)
            {
                Pen pen = new Pen(Color.Black);
                Brush engines = new SolidBrush(dopColor);
                g.DrawRectangle(pen, startPosX + 85, startPosY - 15, 20, 10);
                g.FillRectangle(engines, startPosX + 85, startPosY - 15, 20, 10);
            }
            base.drawPlanee(g);

        }
    }
}
