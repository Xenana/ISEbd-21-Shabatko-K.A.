using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    public class LightPlane : Plane, IComparable<LightPlane>, IEquatable<Plane>
    {
        public int CompareTo(LightPlane other)
        {
            var res = (this is Plane).CompareTo(other is Plane);
            if (res != 0)
            {
                return res;
            }
            if (Strips != other.Strips)
            {
                return Strips.CompareTo(other.Strips);
            }
            if (Engines != other.Engines)
            {
                return Engines.CompareTo(other.Engines);
            }
            if (dopColor != other.dopColor)
            {
                dopColor.Name.CompareTo(other.dopColor.Name);
            }
            if (ColorBody != other.ColorBody)
            {
                ColorBody.Name.CompareTo(other.ColorBody.Name);
            }
            return 0;
        }
        public bool Equals(LightPlane other)
        {
            var res = (this is Plane).Equals(other is Plane);
            if (!res)
            {
                return res;
            }
            if (Strips != other.Strips)
            {
                return false;
            }
            if (Engines != other.Engines)
            {
                return false;
            }
            if (dopColor != other.dopColor)
            {
                return false;
            }
            if (ColorBody != other.ColorBody)
            {
                return false;
            }
            return true;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            LightPlane planeObj = obj as LightPlane;
            if (planeObj == null)
            {
                return false;
            }
            else
            {
                return Equals(planeObj);
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
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
        public LightPlane(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                MaxCountPassengers = Convert.ToInt32(strs[1]);
                Weight = Convert.ToInt32(strs[2]);
                ColorBody = Color.FromName(strs[3]);
                Strips = Convert.ToBoolean(strs[4]);
                Engines = Convert.ToBoolean(strs[5]);
                dopColor = Color.FromName(strs[6]);
            }
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
                g.DrawRectangle(pen, startPosX + 85, startPosY - 15, 20, 10);
                Brush br = new SolidBrush(ColorBody);
                g.FillEllipse(br, startPosX, startPosY, 100, 20);
                Brush strips = new SolidBrush(dopColor);
                g.FillRectangle(strips, startPosX + 30, startPosY - 10, 20, 10);
                g.FillRectangle(strips, startPosX + 30, startPosY + 20, 20, 10);
                g.FillRectangle(strips, startPosX + 85, startPosY - 15, 20, 10);

            }
            if (Engines)
            {
                Brush engines = new SolidBrush(dopColor);
                g.FillEllipse(engines, startPosX + 30, startPosY - 10, 20, 10);
                g.FillEllipse(engines, startPosX + 30, startPosY + 20, 20, 10);
                
            }
            base.drawPlanee(g);
            
        }
        public void setDopColor(Color color)
        {
            dopColor = color;
        }
        public override string getInfo()
        {
            return MaxSpeed + ";" + MaxCountPassengers + ";" + Weight + ";" + ColorBody.Name + ";" + Strips + ";" + Engines + ";" + dopColor.Name;
        }
    }
}
