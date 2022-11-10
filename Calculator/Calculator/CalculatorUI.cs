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
    public partial class CalculatorUI : Form
    {
        public CalculatorUI()
        {
            InitializeComponent();
        }

        double n1, n2, answ;
        string op;

        private void bt1_Click(object sender, EventArgs e)
        {
            if (dspl.Text == answ.ToString())
            {
                dspl.Clear();
                dspl.RightToLeft = RightToLeft.No;
            }
            if (dspl.Text.Length >= 10)
            {
                dspl.RightToLeft = RightToLeft.Yes;
                dspl.Text = dspl.Text + "1";
            }
            else
            {
                if (dspl.Text == "0")
                {
                    dspl.Clear();
                    dspl.Text = dspl.Text + "1";
                }
                else
                {
                    dspl.Text = dspl.Text + "1";
                }
            }
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (dspl.Text == answ.ToString())
            {
                dspl.Clear();
                dspl.RightToLeft = RightToLeft.No;
            }
            if (dspl.Text.Length >= 10)
            {
                dspl.RightToLeft = RightToLeft.Yes;
                dspl.Text = dspl.Text + "2";
            }
            else
            {
                if (dspl.Text == "0")
                {
                    dspl.Clear();
                    dspl.Text = dspl.Text + "2";
                }
                else
                {
                    dspl.Text = dspl.Text + "2";
                }
            }
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (dspl.Text == answ.ToString())
            {
                dspl.Clear();
                dspl.RightToLeft = RightToLeft.No;
            }
            if (dspl.Text.Length >= 10)
            {
                dspl.RightToLeft = RightToLeft.Yes;
                dspl.Text = dspl.Text + "3";
            }
            else
            {
                if (dspl.Text == "0")
                {
                    dspl.Clear();
                    dspl.Text = dspl.Text + "3";
                }
                else
                {
                    dspl.Text = dspl.Text + "3";
                }
            }
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (dspl.Text == answ.ToString())
            {
                dspl.Clear();
                dspl.RightToLeft = RightToLeft.No;
            }
            if (dspl.Text.Length >= 10)
            {
                dspl.RightToLeft = RightToLeft.Yes;
                dspl.Text = dspl.Text + "4";
            }
            else
            {
                if (dspl.Text == "0")
                {
                    dspl.Clear();
                    dspl.Text = dspl.Text + "4";
                }
                else
                {
                    dspl.Text = dspl.Text + "4";
                }
            }
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (dspl.Text == answ.ToString())
            {
                dspl.Clear();
                dspl.RightToLeft = RightToLeft.No;
            }
            if (dspl.Text.Length >= 10)
            {
                dspl.RightToLeft = RightToLeft.Yes;
                dspl.Text = dspl.Text + "5";
            }
            else
            {
                if (dspl.Text == "0")
                {
                    dspl.Clear();
                    dspl.Text = dspl.Text + "5";
                }
                else
                {
                    dspl.Text = dspl.Text + "5";
                }
            }
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if (dspl.Text == answ.ToString())
            {
                dspl.Clear();
                dspl.RightToLeft = RightToLeft.No;
            }
            if (dspl.Text.Length >= 10)
            {
                dspl.RightToLeft = RightToLeft.Yes;
                dspl.Text = dspl.Text + "6";
            }
            else
            {
                if (dspl.Text == "0")
                {
                    dspl.Clear();
                    dspl.Text = dspl.Text + "6";
                }
                else
                {
                    dspl.Text = dspl.Text + "6";
                }
            }
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            if (dspl.Text == answ.ToString())
            {
                dspl.Clear();
                dspl.RightToLeft = RightToLeft.No;
            }
            if (dspl.Text.Length >= 10)
            {
                dspl.RightToLeft = RightToLeft.Yes;
                dspl.Text = dspl.Text + "7";
            }
            else
            {
                if (dspl.Text == "0")
                {
                    dspl.Clear();
                    dspl.Text = dspl.Text + "7";
                }
                else
                {
                    dspl.Text = dspl.Text + "7";
                }
            }
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if (dspl.Text == answ.ToString())
            {
                dspl.Clear();
                dspl.RightToLeft = RightToLeft.No;
            }
            if (dspl.Text.Length >= 10)
            {
                dspl.RightToLeft = RightToLeft.Yes;
                dspl.Text = dspl.Text + "8";
            }
            else
            {
                if (dspl.Text == "0")
                {
                    dspl.Clear();
                    dspl.Text = dspl.Text + "8";
                }
                else
                {
                    dspl.Text = dspl.Text + "8";
                }
            }
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (dspl.Text == answ.ToString())
            {
                dspl.Clear();
                dspl.RightToLeft = RightToLeft.No;
            }
            if (dspl.Text.Length >= 10)
            {
                dspl.RightToLeft = RightToLeft.Yes;
                dspl.Text = dspl.Text + "9";
            }
            else
            {
                if (dspl.Text == "0")
                {
                    dspl.Clear();
                    dspl.Text = dspl.Text + "9";
                }
                else
                {
                    dspl.Text = dspl.Text + "9";
                }
            }
        }

        private void btDot_Click(object sender, EventArgs e)
        {
            if (dspl.Text != "")
            {
                dspl.Text = dspl.Text + ".";
            }
            else if (dspl.Text == "")
            {
                dspl.Text = dspl.Text + "0.";
            }
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(dspl.Text);
            op = "+";
            dspl.Clear();
            dspl.RightToLeft = RightToLeft.No;
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(dspl.Text);
            op = "-";
            dspl.Clear();
            dspl.RightToLeft = RightToLeft.No;
        }

        private void btMultiply_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(dspl.Text);
            op = "*";
            dspl.Clear();
            dspl.RightToLeft = RightToLeft.No;
        }

        private void btDivide_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(dspl.Text);
            op = "/";
            dspl.Clear();
            dspl.RightToLeft = RightToLeft.No;
        }

        private void btSqrt_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(dspl.Text);
            dspl.Clear();
            answ = Math.Sqrt(n1);
            dspl.Text = answ.ToString();
        }

        private void btPower_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(dspl.Text);
            dspl.Clear();
            answ = n1 * n1;
            dspl.Text = answ.ToString();
        }

        private void btEqual_Click(object sender, EventArgs e)
        {
            n2 = double.Parse(dspl.Text);
            dspl.Clear();

            if (op == "+")
            {
                answ = n1 + n2;
            }
            else if (op == "-")
            {
                answ = n1 - n2;
            }
            else if (op == "*")
            {
                answ = n1 * n2;
            }
            else if (op == "/")
            {
                answ = n1 / n2;
            }

            dspl.Text = answ.ToString();
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            dspl.Text = dspl.Text + "0";
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            dspl.Clear();
            dspl.RightToLeft = RightToLeft.No;
        }
    }
}
