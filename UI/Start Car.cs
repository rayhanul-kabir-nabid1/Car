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

namespace UI
{
    public partial class Start_Car : Form
    {
        int spd;
        public Start_Car()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Drawingcar dc = new Drawingcar();
            dc.setspeed(Convert.ToInt32(textBox1.Text));
            dc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            spd = Convert.ToInt32(textBox1.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Car c = new Car();
            Graphics g = panel1.CreateGraphics();
            c.drawCar(g);
        }

        private void Start_Car_Load(object sender, EventArgs e)
        {

        }
    }
}
