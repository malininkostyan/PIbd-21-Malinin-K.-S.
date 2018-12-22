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
    public partial class FormParking : Form
    {
        MultiLevelParking parking;

        FormBusConfig form;

        private const int countLevel = 5;
        public FormParking()
        {
            InitializeComponent();
            parking = new MultiLevelParking(countLevel, pictureBoxParking.Width, pictureBoxParking.Height);
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
            Draw();
        }
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width,
                pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }
        private void buttonTakeBus_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox.Text != "")
                {
                    var bus = parking[listBoxLevels.SelectedIndex] -
                   Convert.ToInt32(maskedTextBox.Text);
                    if (bus != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakeBus.Width, pictureBoxTakeBus.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        bus.SetPosition(5, 5, pictureBoxTakeBus.Width,
                        pictureBoxTakeBus.Height);
                        bus.DrawBus(gr);
                        pictureBoxTakeBus.Image = bmp;
                    }
                    else
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakeBus.Width,
                       pictureBoxTakeBus.Height);
                        pictureBoxTakeBus.Image = bmp;
                    }
                    Draw();
                }
            }
        }
        
      
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void AddBus(ITransport bus)
        {
            if (bus != null && listBoxLevels.SelectedIndex > -1)
            {
                int place = parking[listBoxLevels.SelectedIndex] + bus;
                if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Автобус не удалось поставить");
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            form = new FormBusConfig();
            form.AddEvent(AddBus);
            form.Show();
        }
    }

}
