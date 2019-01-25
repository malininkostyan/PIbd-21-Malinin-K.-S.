using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsBus
{
    public partial class FormBus : Form
    {
        private ITransport bus;

        public FormBus()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxBus.Width, pictureBoxBus.Height);
            Graphics gr = Graphics.FromImage(bmp);
            bus.DrawBus(gr);
            pictureBoxBus.Image = bmp;
        }
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            bus = new Bus(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.LightGreen,
            Color.Yellow, false, true);
            bus.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxBus.Width,
            pictureBoxBus.Height);
            Draw();
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "Up":
                    bus.MoveTransport(Direction.Up);
                    break;
                case "Down":
                    bus.MoveTransport(Direction.Down);
                    break;
                case "Left":
                    bus.MoveTransport(Direction.Left);
                    break;
                case "Right":
                    bus.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
        private void buttonCreateStBus_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            bus = new StandartBus(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.LightGreen);
            bus.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxBus.Width,
            pictureBoxBus.Height);
            Draw();
        }
    }
}
