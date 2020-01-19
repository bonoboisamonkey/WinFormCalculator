using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculationForm
{
    public partial class Calculator : Form
    {
        float number=0;
        char symbol;
        bool flag = true;
        
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(flag)
            {
                flag = false;
                txbx_screen.Clear();
                txbx_screen.Text += button1.Text;
            }
            else
            {
                txbx_screen.Text += button1.Text;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                txbx_screen.Clear();
                txbx_screen.Text += button2.Text;
            }
            else
            {
                txbx_screen.Text += button2.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                txbx_screen.Clear();
                txbx_screen.Text += button3.Text;
            }
            else
            {
                txbx_screen.Text += button3.Text;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                txbx_screen.Clear();
                txbx_screen.Text += button4.Text;
            }
            else
            {
                txbx_screen.Text += button4.Text;
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                txbx_screen.Clear();
                txbx_screen.Text += button5.Text;
            }
            else
            {
                txbx_screen.Text += button5.Text;
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                txbx_screen.Clear();
                txbx_screen.Text += button6.Text;
            }
            else
            {
                txbx_screen.Text += button6.Text;
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                txbx_screen.Clear();
                txbx_screen.Text += button7.Text;
            }
            else
            {
                txbx_screen.Text += button7.Text;
            }
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                txbx_screen.Clear();
                txbx_screen.Text += button8.Text;
            }
            else
            {
                txbx_screen.Text += button8.Text;
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                txbx_screen.Clear();
                txbx_screen.Text += button9.Text;
            }
            else
            {
                txbx_screen.Text += button9.Text;
            }
           
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                txbx_screen.Clear();
                txbx_screen.Text += zero.Text;
            }
            else
            {
                txbx_screen.Text += zero.Text;
            }
            
        }

        private void addition_Click(object sender, EventArgs e)
        {
            flag = true;
            number = calculate(number, float.Parse(txbx_screen.Text));
            txbx_screen.Text = number.ToString();
            symbol = '+';
            isPointClicked = false;
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            flag = true;
            number = calculate(number, float.Parse(txbx_screen.Text));
            txbx_screen.Text = number.ToString();
            symbol = '-';
            isPointClicked = false;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            flag = true;
            number = calculate(number, float.Parse(txbx_screen.Text));
            txbx_screen.Text = number.ToString();
            symbol = '*';
            isPointClicked = false;
        }

        private void devide_Click(object sender, EventArgs e)
        {
            flag = true;
            number = calculate(number, float.Parse(txbx_screen.Text));
            txbx_screen.Text = number.ToString();
            symbol = '/';
            isPointClicked = false;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            flag = true;
            txbx_screen.Text = calculate(number, float.Parse(txbx_screen.Text)).ToString();
            number = 0;
            symbol = ' ';
            isPointClicked = false;
        }

        private float calculate(float a, float b)
        {
            float result = 0;
            switch (symbol)
            {
                case '+': result = a + b; break;
                case '-': result = a - b; break;
                case '*': result = a * b; break;
                case '/': result = a / b; break;
                case '%': result = a * b / 100; break;
                default: result = float.Parse(txbx_screen.Text);
                    break;
            }
            return result;
        }
        bool isPointClicked = false;
        private void decimal_point_Click(object sender, EventArgs e)
        {
            if (!isPointClicked)
            {
                txbx_screen.Text += '.'; 
                isPointClicked = true;
            }
        }

        private void percentage_Click(object sender, EventArgs e)
        {
            number = calculate(number, float.Parse(txbx_screen.Text));
            txbx_screen.Text = number.ToString();
            flag = true;
            symbol = '%';
            isPointClicked = false;
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            number = 0;
            txbx_screen.Text = number.ToString();
            flag = true;
        }
    }
}
