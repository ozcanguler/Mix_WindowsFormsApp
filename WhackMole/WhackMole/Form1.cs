using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhackMole
{
   
    public partial class Form1 : Form
    {
        private Stopwatch watch = new Stopwatch();
        private Random rnd = new Random();
        private int timerIntervale = 1000;
        public int hits = 0;
        private bool btnStopWasClicked = false;
        public Form1()
        {
            InitializeComponent();
            watch.Start();
            timer1.Interval = timerIntervale;
        }

        private void Btn_start_Click(object sender, EventArgs e)
        {
            watch.Start();
            timer1.Start();
            timer1.Interval = timerIntervale;
            btnStopWasClicked = false;
            btn_target.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = watch.Elapsed.ToString();
            btn_target.Top = rnd.Next(0, Height - btn_target.Height * 3);
            btn_target.Left = rnd.Next(btn_start.Location.X + btn_target.Width, Width - btn_target.Width);
            
        }
    

        private void Btn_stop_Click(object sender, EventArgs e)
        {
            watch.Stop();
            //btn_target.Location = new Point(0, 0);
            timer1.Stop();
            btn_target.Enabled = false;
            btnStopWasClicked = true;
        }

        private void Btn_reset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            watch.Stop();
            watch.Reset();
            label1.Text = "";
            label2.Text = "0";
            btn_target.Enabled = false;
            btn_target.Location = new Point(0, 0);
            btnStopWasClicked = true;
            hits = 0;
        }

        private void Btn_target_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(btn_start.Location.X.ToString());
            //MessageBox.Show(Width.ToString());
            if (btn_target.Enabled == true)
            {
                hits++;
                label2.Text = hits.ToString();
                if (hits == 10)
                {
                    reset();
                    MessageBox.Show("Congratulations");

                }
            }
        }
        private void Btn_target_miss_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(btn_start.Location.X.ToString());
            //MessageBox.Show(Width.ToString());
            if (btnStopWasClicked == false)
            {
                hits--;
                label2.Text = hits.ToString();
                if (hits < 0)
                {
                    reset();
                    MessageBox.Show("Game Over");

                }

            }

        }
        public void reset()
        {
            timer1.Stop();
            watch.Stop();
            watch.Reset();
            label1.Text = "";
            label2.Text = "0";
            btn_target.Enabled = false;
            btn_target.Location = new Point(0, 0);
            btnStopWasClicked = true;
            hits = 0;
        }
    }
}
