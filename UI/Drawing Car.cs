using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using BO;
using System.Drawing.Drawing2D;

namespace UI
{
    public partial class Drawingcar : Form
    {
        Car car = new Car();
        Road rd = new Road();

        BOClass bo = new BOClass();
        int flag = 0;
        Graphics g = null;
        Graphics ee=null;


        int f = 0;
        public Drawingcar()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            ee = panel3.CreateGraphics();
            
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            car.setview('s');
            rd.drawroad(ee);
        }
        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                
                
                car = bo.moveleft(car);
                
            }
            else if (e.KeyCode == Keys.Right)
            {
                
                
                car = bo.moveright(car);
                
            }

            if (e.KeyCode == Keys.Up)
            {
                car.setview('f');
                
               
            }

            if (e.KeyCode == Keys.Down)
            {
                
                car.setview('b');
            }
            if (e.KeyCode == Keys.Space)
            {
                
                car.setview('s');
            }
        }

        int rr = 0;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if(rr==0)
            {
                car.drawCar(g);
                rr = 1;
            }
            
            
        }
        

        
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if(car.getview()!='s')
            {
                Point p = panel1.Location;
                car = bo.incresespeed(car);
                p.X = Convert.ToInt32( car.getX());
                p.Y = Convert.ToInt32( car.getY());
                panel1.Location = p;
                //label1.Text = p.X + " " + p.Y;
                Pen pp = new Pen(Color.Gray, 10);
                car.clearcar(g);
                rd.drawroad(ee);
                car.drawCar(g);
                
                
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        internal void setspeed(int p)
        {
            car.setspeed(p);
        }
        
        private void Drawingcar_Paint(object sender, PaintEventArgs e)
        {
            rd.drawroad(ee);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            rd.drawroad(ee);
        }
    }
}
