using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        Random r = new Random();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer timerbut = new System.Windows.Forms.Timer();
        public Form1()
        {

            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();



        }


        public void timer_Tick(object sender, EventArgs e)
        {
            int w = this.Size.Width - label1.Size.Width;
            int h = this.Size.Height - label1.Size.Height;
            int x = r.Next(0, w);
            int y = r.Next(0, h);
            label1.Location = new Point(x, y);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_MouseMove_1(object sender, MouseEventArgs e)
        {

                timerbut.Interval = 100000;
                timerbut.Tick += new EventHandler(timer_Tick_button);
                timerbut.Start();
            Random r = new Random();
            button1.Left = r.Next(0, this.Size.Width - button1.Width);
            button1.Top = r.Next(0, this.Size.Height - button1.Height);

        }
        public void timer_Tick_button(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Location = button1.Location;
            button2.Visible = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
