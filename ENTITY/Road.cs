using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace ENTITY
{
    public class Road
    {
        Pen p = new Pen(Color.Green, 15);

        public void drawroad(Graphics g)
        {
            g.DrawLine(p, 20, 20, 1300, 20);
            g.DrawLine(p, 250, 250, 1050, 250);

            g.DrawLine(p, 20, 660, 1300, 660);
            g.DrawLine(p, 250, 430, 1050, 430);

            g.DrawLine(new Pen(Color.Green, 140), 270, 340, 1030, 340);

            g.DrawLine(p, 20, 20, 20, 660);
            g.DrawLine(p, 1300, 660, 1300, 20);

            g.DrawLine(p, 250, 250, 250, 430);
            //g.DrawLine(p, 525, 460, 525, 220);

            //g.DrawLine(p, 750, 220, 750, 460);
            g.DrawLine(p, 1050 ,430, 1050, 250);
        }
    }
}
