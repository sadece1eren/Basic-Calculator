using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_V2022
{
    public partial class Form1 : Form
    {
        bool formTasiniyor = false;
        Point baslangicNoktasi = new Point(0, 0);
        string input = "0";
        string num1 = "0";
        string num2 = "0";
        string function = String.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            formTasiniyor = true;
            baslangicNoktasi = new Point(e.X, e.Y);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            formTasiniyor = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (formTasiniyor)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.baslangicNoktasi.X, p.Y - this.baslangicNoktasi.Y);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (input != "0")
            {
                input = input + "0";
            }
            else
            {
                input = "0";
            }
            this.textBox1.Text = "";
            this.textBox1.Text += input;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (input != "0")
            {
                input = input + "1";
            }
            else
            {
                input = "1";
            }
            this.textBox1.Text = "";
            this.textBox1.Text += input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (input != "0")
            {
                input = input + "2";
            }
            else
            {
                input = "2";
            }
            this.textBox1.Text = "";
            this.textBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (input != "0")
            {
                input = input + "3";
            }
            else
            {
                input = "3";
            }
            this.textBox1.Text = "";
            this.textBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input = "";
            num1 = "";
            num2 = "";
            function = "";
            this.textBox1.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (input != "0")
            {
                input = input + "4";
            }
            else
            {
                input = "4";
            }
            this.textBox1.Text = "";
            this.textBox1.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (input != "0")
            {
                input = input + "5";
            }
            else
            {
                input = "5";
            }
            this.textBox1.Text = "";
            this.textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (input != "0")
            {
                input = input + "6";
            }
            else
            {
                input = "6";
            }
            this.textBox1.Text = "";
            this.textBox1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (input != "0")
            {
                input = input + "7";
            }
            else
            {
                input = "7";
            }
            this.textBox1.Text = "";
            this.textBox1.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (input != "0")
            {
                input = input + "8";
            }
            else
            {
                input = "8";
            }
            this.textBox1.Text = "";
            this.textBox1.Text += input;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (input != "0")
            {
                input = input + "9";
            }
            else
            {
                input = "9";
            }
            this.textBox1.Text = "";
            this.textBox1.Text += input;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 = input;
            input = "0";
            this.textBox1.Text = "";
            function = "+";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num1 = input;
            input = "0";
            this.textBox1.Text = "";
            function = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num1 = input;
            input = "0";
            this.textBox1.Text = "";
            function = "*";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num1 = input;
            input = "0";
            this.textBox1.Text = "";
            function = "/";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num2 = input;
            if (function != string.Empty)
            {
                double n1, n2, result;
                try
                {
                   n1 =  Convert.ToDouble(num1);
                    n2 = Convert.ToDouble(num2);
                    switch (function)
                    {
                     
                        case "+":
                            this.textBox1.Text = "";
                            result = n1 + n2;
                            this.textBox1.Text = result.ToString();
                            listBox1.Items.Add(n1+"+"+n2+"="+result);
                            break;
                        case "-":
                            this.textBox1.Text = "";
                            result = n1 - n2;
                            this.textBox1.Text = result.ToString();
                            listBox1.Items.Add(n1 + "-" + n2 + "=" + result);
                            break;
                        case "*":
                            this.textBox1.Text = "";
                            result = n1 * n2;
                            this.textBox1.Text = result.ToString();
                            listBox1.Items.Add(n1 + "*" + n2 + "=" + result);
                            break;
                        case "/":
                            this.textBox1.Text = "";
                            result = n1 / n2;
                            this.textBox1.Text = result.ToString();
                            listBox1.Items.Add(n1 + "/" + n2 + "=" + result);
                            break;                        
                    }
                }
                catch
                {
                    this.textBox1.Text = "Math Error";
                  input = "";
                    num1 = "";
                    num2 = "";
                    function = "";
                }
            }
        }
    }
}
