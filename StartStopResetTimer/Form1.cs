using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StartStopResetTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int hour, min, sec, milsec = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = hour + ":" + min + ":" + sec + ":" + milsec.ToString();

            milsec++;
            if (milsec > 10)
            {
                sec++;
                milsec = 0;

            }
            else
            {
                milsec++;
            }
            if (sec > 60)
            {
                min++;
                sec = 0;
            }
            if (min > 60)
            {
                hour++;
                min = 0;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            milsec = 0;
            sec = 0;
            min = 0;
            hour = 0;
            // This work correctly with toString() method
            //textBox1.Text = 0 + ":" + 0 + ":" + 0 + ":" + 0.ToString();


            // This work correctly without toString() method
            textBox1.Text = 0 + ":" + 0 + ":" + 0 + ":" + 0;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
