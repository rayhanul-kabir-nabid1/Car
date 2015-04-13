using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ENTITY
{
    public class Car
    {
        
        private int speed= 10;
        private char side='s';
        private double x = 50;
        private double y = 50;
        public int angle = 90;

        Pen bluepen = new Pen(Color.Brown, 3);
        Pen ypen = new Pen(Color.Black, 27);
        Pen ypen2 = new Pen(Color.Brown, 7);
        Pen bpen = new Pen(Color.White, 17);
        
        public void setspeed(int s)
        {
            speed = s;
        }
        public int getspeed()
        {
            return speed;
        }

        public void setX(double a)
        {
            x = a;
        }
        public double getX()
        {
            return x;
        }

        public void setY(double b)
        {
            y = b;
        }
        public double getY()
        {
            return y;
        }

        public void setview(char c)
        {
            side = c;
        }
        public int getview()
        {
            return side;
        }

        

        public void drawCar(Graphics g)
        {
            

            //topfill................
            g.DrawLine(ypen, 43, 70, 97, 70);
            g.DrawLine(ypen2, 45, 81, 95, 83);
            g.DrawLine(ypen2, 45, 59, 95, 57);

            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

            //left side........
            g.DrawLine(new Pen(Color.White, 4), 45, 45, 95, 45);
            g.DrawLine(new Pen(Color.White, 4), 10, 48, 47, 45);
            g.DrawLine(new Pen(Color.White, 4), 93, 45, 135, 48);

            //right side........
            g.DrawLine(new Pen(Color.White, 4), 45, 95, 95, 95);
            g.DrawLine(new Pen(Color.White, 4), 10, 92, 47, 95);
            g.DrawLine(new Pen(Color.White, 4), 93, 95, 135, 92);

            //fornt...............
            g.DrawLine(bluepen, 135, 48, 144, 53);
            g.DrawLine(bluepen, 135, 92, 144, 87);
            g.DrawLine(bpen, 137, 53, 142, 72);
            g.DrawLine(bpen, 137, 87, 142, 68);

            g.DrawLine(new Pen(Color.White, 7), 130, 50, 144, 55);
            g.DrawLine(new Pen(Color.White, 7), 130, 90, 144, 85);
            //back................
            g.DrawLine(bpen, 12, 72, 16, 48);
            g.DrawLine(bpen, 12, 68, 16, 92);

            

            //top.............
            g.DrawLine(bluepen, 45, 55, 95, 53);
            g.DrawLine(bluepen, 93, 53, 115, 47);
            g.DrawLine(bluepen, 45, 55, 25, 47);
            

            g.DrawLine(bluepen, 45, 85, 95, 87);
            g.DrawLine(bluepen, 93, 87, 115, 93);
            g.DrawLine(bluepen, 45, 85, 25, 93);


            //top fornt...............
            g.DrawLine(bluepen, 97, 71, 95, 53);
            g.DrawLine(bluepen,  95, 87, 97, 69);

            g.DrawLine(bpen, 125, 72, 122, 47);
            g.DrawLine(bpen, 122, 93, 125, 68);


            //top back..............
            g.DrawLine(bluepen, 43, 70, 45, 53);
            g.DrawLine(bluepen, 45, 87, 43, 70);

            g.DrawLine(bluepen, 22, 70, 25, 47);
            g.DrawLine(bluepen, 25, 93, 22, 70);

            
            



            //drawing angle...........
            Matrix matrix = new Matrix();
            matrix.Translate(0, 0);
            matrix.RotateAt(360-angle+90, new PointF(80, 80));

            g.Transform = matrix;

            if(angle>=360)
            {
                angle = angle % 360;
            }
            if(angle<0)
            {
                angle = 360 - (-1)*angle;
            }
            
        }




        public void clearcar(Graphics g)
        {
            g.Clear(Color.Black);
        }
    }
}
