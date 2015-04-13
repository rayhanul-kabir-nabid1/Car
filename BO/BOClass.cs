using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;

namespace BO
{
    
    public class BOClass
    {
        
        Saveinfo savedal = new Saveinfo();
        public void savecar(Car c)
        {
            savedal.savefile(c);
        }

        public Car getcar()
        {
            return savedal.getfile();
        }
        public Car incresespeed(Car c)
        {
            if(c.getview()!='s')
            {
                double x=0;
                double y=0;
                int a = c.angle;
                if(a<0)
                {
                    a = 360-a;
                }
                if(c.getview()=='b')
                {
                    a = a + 180;
                    a = a % 360;
                }
                //set x........................
                if (a <= 90)
                {
                    x =a;
                    x = Convert.ToInt32(c.getspeed() * (x / 90));
                    x += c.getX();

                }
                else if(a<=180)
                {
                    x =a- 90;
                    x = 90 - x;
                    x = Convert.ToInt32(c.getspeed() * (x / 90));
                    x += c.getX();
                }
                else if (a <= 270)
                {
                    x =a-180;
                    x = Convert.ToInt32(c.getspeed() * (x / 90));
                    x = c.getX()-x;
                }
                else
                {
                    x = a - 270;
                    x = 90 - x;
                    x = Convert.ToInt32(c.getspeed() * (x / 90));
                    x = c.getX() - x;
                }


                //set y........................
                if (a <= 90)
                {
                    y =90- a;
                    y = Convert.ToInt32(c.getspeed() * (y / 90));
                    y += c.getY();

                }
                else if (a <= 180)
                {
                    y = a - 90;
                    y = Convert.ToInt32(c.getspeed() * (y / 90));
                    y = c.getY()-y;
                }
                else if (a <= 270)
                {
                    y = a - 180;
                    y = 90 - y;
                    y = Convert.ToInt32(c.getspeed() * (y / 90));
                    y = c.getY() - y;
                }
                else
                {
                    y = a - 270;
                    y = Convert.ToInt32(c.getspeed() * (y / 90));
                    y += c.getY();
                }
                int xl=1, yl=1;

                if (x < 30 || x > 1130) xl = 0;
                if (y < 30 || y > 485) yl = 0;
                if((x>80 && x<1060 ))
                {
                    if (y > 80 && y<430) yl = 0;
                }
                if (y > 80 && y < 430)
                {
                    if ((x > 80 &&  x < 1060)) xl = 0;
                }

                if(xl==0 && yl==0)
                {
                    c.setview('s');
                }
                else if(xl==0)
                {
                    c.setY(Convert.ToInt32(y));
                    
                }
                else if (yl == 0)
                {
                    c.setX(Convert.ToInt32(x));
                }
                else
                {
                    c.setX(Convert.ToInt32(x));
                    c.setY(Convert.ToInt32(y));
                }
            }
            return c;
        }

        public Car moveleft(Car c)
        {
            int a = c.angle;

            if (c.getview() == 'f') a += 5;
            else a = a - 5;
            
            c.angle = a;
            return c;
        }

        public Car moveright(Car c)
        {
            int a = c.angle;

            if (c.getview() == 'f') a = a-5;
            else a = a + 5;
            
            c.angle = a;
            return c;
        }
    }
}
