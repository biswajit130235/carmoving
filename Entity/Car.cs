using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Entity
{
    public class Car
    {
        public int speed;
        int f = 0;

         public void carRight(Graphics g)
        {

            Pen p = new Pen(Color.Green, 3);

           
            g.DrawLine(p, 140, 60, 240, 60);

            g.DrawRectangle(p, 140, 80, 40, 20);
            g.DrawRectangle(p, 200, 80, 40, 20);


            g.DrawLine(p, 240, 60, 270, 90);
            g.DrawLine(p, 270, 90, 330, 110);
            g.DrawLine(p, 270, 90, 333, 130);
            g.DrawLine(p, 333, 120, 270, 130);


            g.DrawLine(p, 140, 60, 110, 90);
            g.DrawLine(p, 110, 90, 80, 110);
            g.DrawLine(p, 80, 110, 80, 130);
            g.DrawLine(p, 80, 130, 110, 130);

            g.DrawLine(p, 150, 130, 230, 130);

            g.FillEllipse(Brushes.Green, 112, 120, 35, 35);
            g.FillEllipse(Brushes.Green, 232, 120, 35, 35);

            g.DrawLine(p, 190, 60, 190, 130);



        }
        public void carLeft(Graphics g)
        {
            Pen p = new Pen(Color.Green, 3);

            g.DrawLine(p, 260, 60, 160, 60);


            g.DrawLine(p, 160, 60, 130, 90);
            g.DrawLine(p, 130, 90, 70, 110);
            g.DrawLine(p, 130, 90, 67, 130);
            g.DrawLine(p, 70, 110, 67, 130);
            g.DrawLine(p, 67, 130, 130, 130);

            g.DrawLine(p, 258, 60, 290, 90);
            g.DrawLine(p, 290, 90, 320, 110);
            g.DrawLine(p, 320, 110, 320, 130);


            g.DrawLine(p, 320, 110, 290, 130);


            g.DrawLine(p, 320, 130, 290, 130);

            g.DrawLine(p, 250, 130, 170, 130);

            g.FillEllipse(Brushes.Green, 132, 120, 35, 35);
            g.FillEllipse(Brushes.Green, 252, 120, 35, 35);

            g.DrawLine(p, 210, 60, 210, 130);
            g.DrawLine(p, 290, 90, 130, 90);
        }
        public void carUp(Graphics g)
        {
            Pen p = new Pen(Color.Green, 3);
            

            g.DrawLine(p, 165, 60, 215, 60);
            g.DrawLine(p, 165, 60, 150, 100);
            g.DrawLine(p, 215, 60, 230, 100);

            g.DrawLine(p, 150, 100, 230, 100);
            g.DrawLine(p, 190, 100, 190, 200);
            g.DrawLine(p, 150, 120, 230, 120);
            g.DrawLine(p, 150, 200, 230, 200);
            g.DrawLine(p, 150, 100, 150, 200);
            g.DrawLine(p, 230, 100, 230, 200);

            g.DrawLine(p, 160, 220, 220, 220);
            g.DrawLine(p, 150, 200, 160, 220);
            g.DrawLine(p, 230, 200, 220, 220);
        }

        public void carDown(Graphics g)
        {
            Pen p = new Pen(Color.Green, 3);
          
            g.DrawLine(p, 160, 80, 220, 80);
            g.DrawLine(p, 160, 80, 150, 100);
            g.DrawLine(p, 220, 80, 230, 100);

            g.DrawLine(p, 150, 100, 230, 100);

            g.DrawLine(p, 150, 200, 230, 200);
            g.DrawLine(p, 190, 100, 190, 200);
            g.DrawLine(p, 150, 100, 150, 200);
            g.DrawLine(p, 230, 100, 230, 200);

            g.DrawLine(p, 150, 180, 230, 180);
            g.DrawLine(p, 165, 240, 215, 240);
            g.DrawLine(p, 150, 200, 165, 240);
            g.DrawLine(p, 230, 200, 215, 240);
        }

    }
    }
   


