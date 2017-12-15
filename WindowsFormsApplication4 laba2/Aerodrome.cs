﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class Aerodrome
    {
       
        List<ClassArray<ITransport>> parkingStages;
        int countPlaces = 20;
        int placeSizeWidth = 210;
        int placeSizeHeight = 80;
        int currentLevel;
        public int getCurrentLevel { get { return currentLevel; } }
        public Aerodrome(int countStages)
        {
            parkingStages = new List<ClassArray<ITransport>>(countStages);
            for (int i = 0; i < countStages; i++)
            {
                parkingStages.Add(new ClassArray<ITransport>(countStages, null));
            }

        }
        public void LevelUp()
        {
            if (currentLevel + 1 < parkingStages.Count)
            {
                currentLevel++;
            }
        }
        public void LevelDown()
        {
            if (currentLevel > 0)
            {
                currentLevel--;
            }
        }
        public int PutPlaneInParking(ITransport plane)
        {
            return parkingStages[currentLevel]+plane;
        }
        public ITransport GetPlaneInParking (int ticket)
        {
            return parkingStages[currentLevel] - ticket;
        }
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i=0; i<countPlaces; i++)
            {
                var plane = parkingStages[currentLevel][i];
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
            g.DrawString("L" + (currentLevel + 1), new Font("Arial", 30), new SolidBrush(Color.Blue),
                (countPlaces / 5) * placeSizeWidth - 70, 420);
            g.DrawRectangle(pen, 0, 0, (countPlaces / 5) * placeSizeWidth, 480);
            for (int i=0;i<countPlaces/5; i++)
            {
                for (int j=0; j<6; ++j)
                {
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth + 110, j * placeSizeHeight);
                    if (j < 5)
                    {
                        g.DrawString((i * 5 + j + 1).ToString(), new Font("Arial", 30), new SolidBrush(Color.Blue), i * placeSizeWidth + 30, j * placeSizeHeight + 20);
                    }
                }
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 400);
            }
        }
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("CountLeveles:" + parkingStages.Count + Environment.NewLine);
                    fs.Write(info, 0, info.Length);
                    foreach (var level in parkingStages)
                    {
                        info = new UTF8Encoding(true).GetBytes("Level" + Environment.NewLine);
                        fs.Write(info, 0, info.Length);
                        for (int i = 0; i < countPlaces; i++)
                        {
                            var plane = level[i];
                            if (plane != null)
                            {
                                if (plane.GetType().Name == "Plane")
                                {
                                    info = new UTF8Encoding(true).GetBytes("Plane:");
                                    fs.Write(info, 0, info.Length);
                                }
                                if (plane.GetType().Name == "LightPlane")
                                {
                                    info = new UTF8Encoding(true).GetBytes("LightPlane:");
                                    fs.Write(info, 0, info.Length);
                                }
                                info = new UTF8Encoding(true).GetBytes(plane.getInfo() + Environment.NewLine);
                                fs.Write(info, 0, info.Length);
                            }
                        }
                    }
                }
            }
            return true;
        }
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                string s = "";
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (bs.Read(b, 0, b.Length) > 0)
                    {
                        s += temp.GetString(b);
                    }
                }
                s = s.Replace("\r", "");
                var strs = s.Split('\n');
                if (strs[0].Contains("CountLeveles"))
                {
                    int count = Convert.ToInt32(strs[0].Split(':')[1]);
                    if (parkingStages != null)
                    {
                        parkingStages.Clear();
                    }
                    parkingStages = new List<ClassArray<ITransport>>(count);
                }
                else
                {
                    return false;
                }
                int counter = -1;
                for (int i = 0; i < strs.Length; ++i)
                {
                    if (strs[i] == "Level")
                    {
                        counter++;
                        parkingStages.Add(new ClassArray<ITransport>(countPlaces, null));
                    }
                    else if (strs[i].Split(':')[0] == "Plane")
                    {
                        ITransport plane = new Plane(strs[i].Split(':')[1]);
                        int number = parkingStages[counter] + plane;
                        if (number == -1)
                        {
                            return false;
                        }
                    }
                    else if (strs[i].Split(':')[0] == "LightPlane")
                    {
                        ITransport plane = new LightPlane(strs[i].Split(':')[1]);
                        int number = parkingStages[counter] + plane;
                        if (number == -1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
