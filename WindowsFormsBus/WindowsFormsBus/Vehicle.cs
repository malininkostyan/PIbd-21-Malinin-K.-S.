﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsBus
{
    public abstract class Vehicle : ITransport
    {
        protected float _startPosX;
        protected float _startPosY;
        protected int _pictureWidth;
        protected int _pictureHeight;
        public int MaxSpeed { protected set; get; }
        public float Weight { protected set; get; }
        public Color MainColor { protected set; get; }
        public abstract void DrawBus(Graphics g);
        public abstract void MoveTransport(Direction direction);
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x - 15;
            _startPosY = y + 15;
            _pictureWidth = width;
            _pictureHeight = height;
        }
    }
}