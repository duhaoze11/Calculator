using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double temp1 = 0;
        bool point_flag, num_flag;
        int pos = 0;

        public Form1()
        {
            InitializeComponent();
        }
        public double calc(double a, double b)
        {
            int n = Convert.ToInt32(b);
            double ans = 1;
            for (int i = 1; i <= n; i++)
                ans *= a;
            return ans;
        }
        public void addNum(int num)
        {
            if (num_flag == true) textBox1.Text = num.ToString();
            else textBox1.Text = textBox1.Text + num.ToString();
        }
        public void addPoint()
        {
            if (point_flag == true) textBox1.Text = textBox1.Text + '.';
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            point_flag = true;
            num_flag = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addNum(7);
            num_flag = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addNum(8);
            num_flag = false; 
        }

        private void button17_Click(object sender, EventArgs e)
        {
            pos = 5;
            temp1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            point_flag = true;
            num_flag = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            addNum(0);
            num_flag = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addNum(1);
            num_flag = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addNum(2);
            num_flag = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            addNum(3);
            num_flag = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addNum(4);
            num_flag = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addNum(5);
            num_flag = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addNum(6);
            num_flag = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addNum(9);
            num_flag = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            temp1 = 0;
            pos = 0;
            num_flag = true;
            point_flag = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pos = 1;
            temp1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            point_flag = true;
            num_flag = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            addPoint();
            point_flag = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double temp2 = Convert.ToDouble(textBox1.Text);
            switch (pos)
            {
                case 1 :
                    textBox1.Text = (temp1 + temp2).ToString();
                    break;
                case 2 :
                    textBox1.Text = (temp1 - temp2).ToString();
                    break;
                case 3 :
                    textBox1.Text = (temp1 * temp2).ToString();
                    break;
                case 4:
                    textBox1.Text = (temp1 / temp2).ToString();
                    break;
                case 5:
                    double ans = calc(temp1, temp2);
                    textBox1.Text = (ans.ToString());
                    break;

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pos = 2;
            temp1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            point_flag = true;
            num_flag = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pos = 3;
            temp1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            point_flag = true;
            num_flag = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pos = 4;
            temp1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            point_flag = true;
            num_flag = true;
        }

    }
}
