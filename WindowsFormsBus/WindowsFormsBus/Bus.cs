using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsBus
{
    
    public class Bus : StandartBus
    {
        public Color DopColor { private set; get; }
        public bool Toner { private set; get; }
        public bool Garm { private set; get; }

        public Bus(int maxSpeed, float weight, Color mainColor, Color dopColor, bool toner, bool garm) : base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Toner = toner;
            Garm = garm;
        }

        public Bus(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Toner = Convert.ToBoolean(strs[4]);
                Garm = Convert.ToBoolean(strs[5]);
            }
        }

        public override void DrawBus(Graphics g)
        {
            Brush bus = new SolidBrush(DopColor);
            Brush window = new SolidBrush(Color.Blue);
            if (Toner)
            {
                window = new SolidBrush(Color.Black);
            }

            Brush brush = new SolidBrush(Color.Black);

            base.DrawBus(g);

            if (Garm)
            {
                g.FillRectangle(bus, _startPosX + 88, _startPosY - 6, 50, 30);
                g.FillRectangle(window, _startPosX + 103, _startPosY, 7, 7);
                g.FillRectangle(window, _startPosX + 114, _startPosY, 7, 7);
                g.FillRectangle(window, _startPosX + 125, _startPosY, 7, 7);
                g.FillRectangle(window, _startPosX + 92, _startPosY, 7, 7);
                g.FillEllipse(brush, _startPosX + 113, _startPosY + 15, 15, 15);
                g.FillRectangle(brush, _startPosX + 80, _startPosY - 3, 8, 25);
            }

        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Toner + ";" + Garm;
        }
    }
}
