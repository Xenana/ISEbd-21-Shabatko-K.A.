﻿using System;
using System.Collections;
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
    public partial class Form2 : Form
    {
        Aerodrome aerodrome;
        public Form2()
        {
            InitializeComponent();
            aerodrome = new Aerodrome(5);
            for (int i = 1; i < 6; i++)
            {
                Levels.Items.Add("Уровень " + i);
            }
            Levels.SelectedIndex = aerodrome.getCurrentLevel;
            Draw();
        }
        ///<summary>
        /// Метод для отрисовки парковки
        ///</summary>
        private void Draw()
        {
            if (Levels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                aerodrome.Draw(gr);
                pictureBox1.Image = bmp;
            }
        }


        private void buttonParkingPlane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var plane = new Plane(100, 4, 1000, dialog.Color);
                int place = aerodrome.PutPlaneInParking(plane);
                Draw();
                MessageBox.Show("Ваше место: " + place);
            }

        }

        private void buttonParkingLightPlane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var plane = new LightPlane(300, 6, 2000, dialog.Color, true, true, dialogDop.Color);
                    int place = aerodrome.PutPlaneInParking(plane);
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
            }

        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            if (Levels.SelectedIndex > -1)
            {
                string level = Levels.Items[Levels.SelectedIndex].ToString();

                if (maskedTextBox1.Text != "")
                {
                    ITransport plane = aerodrome.GetPlaneInParking(Convert.ToInt32(maskedTextBox1.Text));
                    if (plane != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        plane.setPosition(5, 5);
                        plane.drawPlane(gr);
                        pictureBox2.Image = bmp;
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Извинте, на этом месте нет машины");
                    }

                }
            }
        }

        private void Right_Click(object sender, EventArgs e)
        {
            aerodrome.LevelDown();
            Levels.SelectedIndex = aerodrome.getCurrentLevel;
            Draw();
        }

        private void Left_Click(object sender, EventArgs e)
        {
            aerodrome.LevelUp();
            Levels.SelectedIndex = aerodrome.getCurrentLevel;
            Draw();

        }

        private void Levels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

