using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsBus
{
    public class StandartBus : Vehicle
    {
        protected const int busWidth = 100;

        protected const int busHeight = 60;

        public StandartBus(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public StandartBus(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - busWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - busHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public override void DrawBus(Graphics g)
        {
            Brush bus = new SolidBrush(MainColor);
            g.FillRectangle(bus, _startPosX + 10, _startPosY - 6, 70, 30);

            Brush brash = new SolidBrush(Color.Black);
            g.FillEllipse(brash, _startPosX + 63, _startPosY + 15, 15, 15);
            g.FillEllipse(brash, _startPosX + 25, _startPosY + 15, 15, 15);

            Brush window = new SolidBrush(Color.Blue);
            g.FillRectangle(window, _startPosX + 13, _startPosY, 9, 9);
            g.FillRectangle(window, _startPosX + 61, _startPosY, 7, 7);
            g.FillRectangle(window, _startPosX + 70, _startPosY, 7, 7);
            g.FillRectangle(window, _startPosX + 43, _startPosY, 7, 7);
            g.FillRectangle(window, _startPosX + 34, _startPosY, 7, 7);
            g.FillRectangle(window, _startPosX + 25, _startPosY, 7, 7);
            g.FillRectangle(window, _startPosX + 52, _startPosY, 7, 7);
        }

        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }
    }
}

