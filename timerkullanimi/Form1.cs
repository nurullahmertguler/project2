using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timerkullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            pictureBox1.Left += rd.Next(10, 16);
            pictureBox2.Left += rd.Next(10, 16);
            if (pictureBox1.Left > label1.Left)
            {
                timer1.Stop();
                label4.Text = "1. koşucu kazandı. ";

            }
            if (pictureBox2.Left > label1.Left)
            {
                timer1.Stop();
                label4.Text = "2. koşucu kazandı. ";

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label4.Text = "Basladi";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            timer1.Stop();
        }
    }
}
