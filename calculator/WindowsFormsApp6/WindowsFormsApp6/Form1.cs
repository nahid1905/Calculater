using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double eded = 0;
        double next = 0;
        double netice = 0;
        string ob = "";
        double last;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ResultBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "1";
            }
            else
            {
                ResultBox.Text += "1";
            }
            
            eded = Convert.ToDouble(ResultBox.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "2";
            }
            else
            {
                ResultBox.Text += "2";
            }
            eded = Convert.ToDouble(ResultBox.Text);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "3";
            }
            else
            {
                ResultBox.Text += "3";
            }
            eded = Convert.ToDouble(ResultBox.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "4";
            }
            else
            {
                ResultBox.Text += "4";
            }
            eded = Convert.ToDouble(ResultBox.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "5";
            }
            else
            {
                ResultBox.Text += "5";
            }
            eded = Convert.ToDouble(ResultBox.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "6";
            }
            else
            {
                ResultBox.Text += "6";
            }
            eded = Convert.ToDouble(ResultBox.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "7";
            }
            else
            {
                ResultBox.Text += "7";
            }
            eded = Convert.ToDouble(ResultBox.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "8";
            }
            else
            {
                ResultBox.Text += "8";
            }
            eded = Convert.ToDouble(ResultBox.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "9";
            }
            else
            {
                ResultBox.Text += "9";
            }
            eded = Convert.ToDouble(ResultBox.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
            {
                ResultBox.Text = "0";
            }
            else
            {
                ResultBox.Text += "0";
            }
            eded = Convert.ToDouble(ResultBox.Text);
        }
        void label()
        {
            label1.Text=eded+ob;
            
        }
        private void button20_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "+";
            ob = "+";
            next = eded;
            label();
            ResultBox.Text = "";
          
        }
        private void button19_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "-";
            ob = "-";
            next = eded;
            label();
            ResultBox.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "*";
            ob = "*";
            next = eded;
            label();
            ResultBox.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "/";
            ob = "/";
            next = eded;
            label();
            ResultBox.Text = "";
        }
        private void button18_Click(object sender, EventArgs e) // assign
        {
            if (ob == "+")
            {
                netice = next + eded; ;
                ResultBox.Text = netice.ToString();
            }
            if (ob == "-")
            {
                netice = next - eded;
                ResultBox.Text = netice.ToString();
            }
            if (ob == "*")
            {
                netice = next * eded;
                ResultBox.Text = netice.ToString();
            }
            if (ob == "/")
            {
                netice = next / eded;
                ResultBox.Text = netice.ToString();
            }            

        }

        private void button4_Click(object sender, EventArgs e)  //clear
        {
            ResultBox.Text = "";
            label1.Text = "";
            ResultBox.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)  // +/- 
        {
            if (eded<=0)
            {
                ResultBox.Text = eded.ToString();
            }
            else
            {
                ResultBox.Text ="-" + eded.ToString();
            }
            return ;
        }

        private void button3_Click(object sender, EventArgs e) // back delete  last num
        {
            last = Convert.ToDouble(ResultBox.Text)% 10;

            ResultBox.Text=Convert.ToString((Convert.ToDouble(ResultBox.Text)-last)/10);

        }

        private void button2_Click(object sender, EventArgs e) //  % 
        {
            netice = (eded / 100)*next;
            ResultBox.Text = netice.ToString();            
           
        }

        private void button14_Click(object sender, EventArgs e) 
        {
            ResultBox.Text = eded+ ".";
            
        }
    }
}
