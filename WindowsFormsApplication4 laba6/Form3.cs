using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form3 : Form
    {
        ITransport plane = null;
        public ITransport getPlane { get { return plane; } }
        private void DrawPlane()
        {
            if (plane != null)
            {
                Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                Graphics gr = Graphics.FromImage(bmp);
                plane.setPosition(15, 45);
                plane.drawPlane(gr);
                pictureBox2.Image = bmp;
            }
        }
        private event myDel eventAddPlane;
        public void AddEvent(myDel ev)
        {
            if (eventAddPlane == null)
            {
                eventAddPlane = new myDel(ev);
            }
            else
            {
                eventAddPlane += ev;
            }
        }
        public Form3()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }


        private void labelPlane_MouseDown(object sender, MouseEventArgs e)
        {
            labelPlane.DoDragDrop(labelPlane.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelPlane_Click(object sender, EventArgs e)
        {

        }

        private void panelPlane_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Самолет":
                    plane = new Plane(100, 4, 1000, Color.White);
                    break;
                case "Легкий самолет":
                    plane = new LightPlane(300, 6, 2000, Color.White, true, true, Color.Black);
                    break;
            }
            DrawPlane();
        }

        private void panelPlane_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void BaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void BaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (plane != null)
            {
                plane.setMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawPlane();
            }
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
            DragDropEffects.Move | DragDropEffects.Copy);
        }


        private void Add_Click(object sender, EventArgs e)
        {
            if (eventAddPlane != null)
            {
                eventAddPlane(plane);
            }
            Close();
        }

        private void labelLightPlane_MouseDown(object sender, MouseEventArgs e)
        {
            labelLightPlane.DoDragDrop(labelLightPlane.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void DopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (plane != null)
            {
                if (plane is LightPlane)
                {
                    (plane as LightPlane).setDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawPlane();

                }
            }
        }

        private void labelLightPlane_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}
