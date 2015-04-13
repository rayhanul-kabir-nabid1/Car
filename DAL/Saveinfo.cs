using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using System.IO;
namespace DAL
{
    public class Saveinfo
    {
        Car c=new Car();

        public void savefile(Car car)
        {
            c = car;
            StreamWriter sw = new StreamWriter("file.txt");
            sw.Write(car.getspeed());
            sw.Close();
        }

        public Car getfile()
        {
            StreamReader sr = new StreamReader("file.txt");
            int s = Convert.ToInt32( sr.Read());
            sr.Close();
            c.setspeed(s);
            return c;
        }
    }
}
