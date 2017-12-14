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
    public partial class Form1 : Form
    {
        Color color;
        Color dopColor;
        int maxSpeed;
        int maxCountPass;
        int weight;
        private ITransport inter;

        public Form1()
        {
            InitializeComponent();
            color = Color.White;
            dopColor = Color.Yellow;
            maxSpeed = 300;
            maxCountPass = 6;
            weight = 2000;
            button_color1.BackColor = color;
            button_color2.BackColor = dopColor;

        }
        

        

        private bool checkFields()
        {
            if (!int.TryParse(max_speed.Text, out maxSpeed))
            {
                return false;
            }
            if (!int.TryParse(max_count_pass.Text, out maxCountPass))
            {
                return false;
            }
            if (!int.TryParse(weightt.Text, out weight))
            {
                return false;
            }
            return true;
        }

        

        

        

        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_color1_Click_1(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                color = cd.Color;
                button_color1.BackColor = color;
            }

        }

        private void button_color2_Click_1(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dopColor = cd.Color;
                button_color2.BackColor = dopColor;
            }

        }

        private void plane_Click_1(object sender, EventArgs e)
        {
            if (checkFields())
            {
                inter = new Plane(maxSpeed, maxCountPass, weight, color);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.drawPlane(gr);
                pictureBox1.Image = bmp;
            }

        }

        private void light_plane_Click_1(object sender, EventArgs e)
        {
            inter = new LightPlane(300, 6, 2000, color, true, true, dopColor);
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            inter.drawPlane(gr);
            pictureBox1.Image = bmp;
        }

        private void button_move_Click(object sender, EventArgs e)
        {
            if (inter != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.flyPlane(gr);
                pictureBox1.Image = bmp;
            }
        }
    }
}
