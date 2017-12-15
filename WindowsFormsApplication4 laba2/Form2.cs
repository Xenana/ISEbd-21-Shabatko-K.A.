using NLog;
using System;
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
        Form3 form;
        private Logger log;
        public Form2()
        {
            InitializeComponent();
            log = LogManager.GetCurrentClassLogger();
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
                log.Info("Припаркован самолет");
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
                    log.Info("Припаркован легкий самолет");
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
                    try
                    {
                        ITransport plane = aerodrome.GetPlaneInParking(Convert.ToInt32(maskedTextBox1.Text));
                        Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        plane.setPosition(15, 40);
                        plane.drawPlane(gr);
                        pictureBox2.Image = bmp;
                        log.Info("Самолет забрали");
                        Draw();
                    }
                    catch (AerodromeIndexOutOfRangeException ex)
                    {
                        MessageBox.Show(ex.Message, "Неверный номер", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Общая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void Right_Click(object sender, EventArgs e)
        {
            aerodrome.LevelUp();
            Levels.SelectedIndex = aerodrome.getCurrentLevel;
            log.Info("Переход на уровень выше Текущий уровень: " + aerodrome.getCurrentLevel);
            Draw();
        }

        private void Left_Click(object sender, EventArgs e)
        {
            aerodrome.LevelDown();
            Levels.SelectedIndex = aerodrome.getCurrentLevel;
            log.Info("Переход на уровень ниже Текущий уровень: " + aerodrome.getCurrentLevel);
            Draw();
        }

        private void Levels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form = new Form3();
            form.AddEvent(AddCar);
            form.Show();
            log.Info("Открытие формы");


        }
        private void AddCar(ITransport plane)
        {
            if (plane != null)
            {
                try
                {
                    int place = aerodrome.PutPlaneInParking(plane);
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
                catch(AerodromeOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка переполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Общая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                log.Info("Попытка сохранения");
            {
                if (aerodrome.SaveData(saveFileDialog1.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    log.Info("Файл сохранен");
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    log.Info("Файл не сохранен");
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                log.Info("Попытка загрузки");
            {
                if (aerodrome.LoadData(openFileDialog1.FileName))
                {
                    MessageBox.Show("Загрузили", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    log.Info("Файл загружен");
                }
                else
                {
                    MessageBox.Show("Не загрузили", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    log.Info("Файл не загружен");
                }
                Draw();
            }
        }
    }
}

