using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3._2_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static double f(double x)
        {
            double s;
            if (Math.Abs(x) < 2)
            {
                s = Math.Sqrt(5 * x * x + 5);
            }
            else if (Math.Abs(x) >= 2 && Math.Abs(x) < 10)
            {
                s = Math.Abs(x) / Math.Sqrt(5 * x * x + 5);
            }
            else
                s = 0;
            return s;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, h;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            h = Convert.ToDouble(textBox3.Text);
            for (double i = a; i <= b; i = i + h)
            {
                textBox4.Text += "\n\r" + f(i) + "\n\r";
            }
        }
    }
}
