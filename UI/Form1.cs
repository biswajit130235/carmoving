using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace UI
{
    public partial class Form1 : Form
    {
       Car r = new Car();
        BoLayer bl = new BoLayer();
        Graphics g;
        Char keyPress;
        int x;
        int y;
        int f = 0;
        public Form1()
        {
            InitializeComponent();
            g = carPanel.CreateGraphics();
           // currentInfoLabel.Text = Convert.ToString(bl.getData());
            int x = bl.x;
            int y = bl.y;
            keyPress = 'r';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            info.Text = null;
            //char c = keyPress;
            switch (keyPress)
            {
                case 'u':
                    r.carUp(g);
                    break;
                case 'd':
                    r.carDown(g);
                    break;
                case 'r':
                    r.carRight(g);
                    break;
                case 'l':
                    r.carLeft(g);
                    break;
            }
            if (bl.speedCalculation() != 0 && !String.IsNullOrEmpty(currentInfoLabel.Text))
            {
                timer1.Interval = bl.speedCalculation();
                timer1.Start();
            }
        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        private void speedButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(speedBox.Text))
                MessageBox.Show("Please, enter speed correctly.");
            else
            {
                Car c = new Car();
                c.speed = Convert.ToInt32(speedBox.Text);
                if (bl.saveSpeed(c))
                {
                    info.Text = "Now, Press 'Start'";
                    currentInfoLabel.Text = Convert.ToString(bl.getData());
                }
                else
                {
                    MessageBox.Show("error");
                    info.Text = null;
                }

            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            bl.changeAxes(keyPress);
            carPanel.Location = new Point(bl.x, bl.y);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                keyPress = 'u';
                g.Clear(Color.DarkGray);
                r.carUp(g);
            }
            else if (e.KeyCode == Keys.Down)
            {
                keyPress = 'd';
                g.Clear(Color.DarkGray);
                r.carDown(g);
            }
            else if (e.KeyCode == Keys.Left)
            {
                keyPress = 'l';
                g.Clear(Color.DarkGray);
                r.carLeft(g);
            }
            else if (e.KeyCode == Keys.Right)
            {
                keyPress = 'r';
                g.Clear(Color.DarkGray);
                r.carRight(g);
            }

            
        }

       
        private void speedBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
