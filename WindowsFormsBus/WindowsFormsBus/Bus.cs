using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsBus
{
    
    public class Bus
    {
        protected float _startPosX;

        protected float _startPosY;

        protected int _pictureWidth;

        protected int _pictureHeight;

        private const int busWidth = 140;

        private const int busHeight = 25;

        public int MaxSpeed { protected set; get; }

        public float Weight { protected set; get; }

        public Color MainColor { protected set; get; }

        public Color DopColor { private set; get; }

        public bool Toner { private set; get; }

        public bool Garm { private set; get; }

        public Bus(int maxSpeed, float weight, Color mainColor, Color dopColor, bool toner, bool garm)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Toner = toner;
            Garm = garm;
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void MoveTransport(Direction direction)
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

        public void DrawBus(Graphics g)
        {
            Brush bus = new SolidBrush(MainColor);
            g.FillRectangle(bus, _startPosX + 10, _startPosY - 6, 70, 30);

            Brush brush = new SolidBrush(Color.Black);
            g.FillEllipse(brush, _startPosX + 63, _startPosY + 15, 15, 15);
            g.FillRectangle(brush, _startPosX + 13, _startPosY, 8, 8);
            g.FillEllipse(brush, _startPosX + 25, _startPosY + 15, 15, 15);

            Brush window = new SolidBrush(Color.Blue);
            g.FillRectangle(window, _startPosX + 62, _startPosY, 7, 7);
            g.FillRectangle(window, _startPosX + 72, _startPosY, 7, 7);
            g.FillRectangle(window, _startPosX + 43, _startPosY, 7, 7);
            g.FillRectangle(window, _startPosX + 33, _startPosY, 7, 7);
            g.FillRectangle(window, _startPosX + 23, _startPosY, 7, 7);
            g.FillRectangle(window, _startPosX + 52, _startPosY, 7, 7);

            if (Toner)
            {
                window = new SolidBrush(Color.Black);
            }

            if (Garm)
            {
                Brush garm = new SolidBrush(DopColor);
                g.FillRectangle(garm, _startPosX + 88, _startPosY - 6, 50, 30);
                g.FillRectangle(window, _startPosX + 103, _startPosY, 7, 7);
                g.FillRectangle(window, _startPosX + 114, _startPosY, 7, 7);
                g.FillRectangle(window, _startPosX + 125, _startPosY, 7, 7);
                g.FillRectangle(window, _startPosX + 92, _startPosY, 7, 7);
                g.FillEllipse(brush, _startPosX + 113, _startPosY + 15, 15, 15);
                g.FillRectangle(brush, _startPosX + 80, _startPosY - 3, 8, 25);
            }
        }
    }
}
