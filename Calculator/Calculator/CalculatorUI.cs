using System;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorUI : Form
    {
        public CalculatorUI()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);

        private char calledOperator;
        private double[] operand = new double[2];
        private double result;

        // Hide blinking cursor from textboxes

        private void MainDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            HideCaret(MainDisplay.Handle);
        }

        private void FormulaDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            HideCaret(FormulaDisplay.Handle);
        }

        // 'Zero' button

        private void ButtonZero_Click(object sender, EventArgs e)
        {
            if (MainDisplay.Text.Length != 10)
            {
                MainDisplay.Text += "0";
            }
        }

        // 'One' button

        private void ButtonOne_Click(object sender, EventArgs e)
        {
            if (MainDisplay.Text.Length != 10)
            {
                if (MainDisplay.Text == result.ToString())
                {
                    MainDisplay.Clear();
                    FormulaDisplay.Clear();
                }
                if (MainDisplay.Text == "0")
                {
                    MainDisplay.Clear();
                    MainDisplay.Text += "1";
                }
                else
                {
                    MainDisplay.Text += "1";
                } 
            }
        }

        // 'Two' button

        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            if (MainDisplay.Text.Length != 10)
            {
                if (MainDisplay.Text == result.ToString())
                {
                    MainDisplay.Clear();
                    FormulaDisplay.Clear();
                }
                if (MainDisplay.Text == "0")
                {
                    MainDisplay.Clear();
                    MainDisplay.Text += "2";
                }
                else
                {
                    MainDisplay.Text += "2";
                }
            }
        }

        // 'Three' button

        private void ButtonThree_Click(object sender, EventArgs e)
        {
            if (MainDisplay.Text.Length != 10)
            {
                if (MainDisplay.Text == result.ToString())
                {
                    MainDisplay.Clear();
                    FormulaDisplay.Clear();
                }
                if (MainDisplay.Text == "0")
                {
                    MainDisplay.Clear();
                    MainDisplay.Text += "3";
                }
                else
                {
                    MainDisplay.Text += "3";
                }
            }
        }

        // 'Four' button

        private void ButtonFour_Click(object sender, EventArgs e)
        {
            if (MainDisplay.Text.Length != 10)
            {
                if (MainDisplay.Text == result.ToString())
                {
                    MainDisplay.Clear();
                    FormulaDisplay.Clear();
                }
                if (MainDisplay.Text == "0")
                {
                    MainDisplay.Clear();
                    MainDisplay.Text += "4";
                }
                else
                {
                    MainDisplay.Text += "4";
                }
            }
        }

        // 'Five' button

        private void ButtonFive_Click(object sender, EventArgs e)
        {
            if (MainDisplay.Text.Length != 10)
            {
                if (MainDisplay.Text == result.ToString())
                {
                    MainDisplay.Clear();
                    FormulaDisplay.Clear();
                }
                if (MainDisplay.Text == "0")
                {
                    MainDisplay.Clear();
                    MainDisplay.Text += "5";
                }
                else
                {
                    MainDisplay.Text += "5";
                }
            }
        }

        // 'Six' button

        private void ButtonSix_Click(object sender, EventArgs e)
        {
            if (MainDisplay.Text.Length != 10)
            {
                if (MainDisplay.Text == result.ToString())
                {
                    MainDisplay.Clear();
                    FormulaDisplay.Clear();
                }
                if (MainDisplay.Text == "0")
                {
                    MainDisplay.Clear();
                    MainDisplay.Text += "6";
                }
                else
                {
                    MainDisplay.Text += "6";
                }
            }
        }

        // 'Seven' button

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            if (MainDisplay.Text.Length != 10)
            {
                if (MainDisplay.Text == result.ToString())
                {
                    MainDisplay.Clear();
                    FormulaDisplay.Clear();
                }
                if (MainDisplay.Text == "0")
                {
                    MainDisplay.Clear();
                    MainDisplay.Text += "7";
                }
                else
                {
                    MainDisplay.Text += "7";
                }
            }
        }

        // 'Eight' button

        private void ButtonEight_Click(object sender, EventArgs e)
        {
            if (MainDisplay.Text.Length != 10)
            {
                if (MainDisplay.Text == result.ToString())
                {
                    MainDisplay.Clear();
                    FormulaDisplay.Clear();
                }
                if (MainDisplay.Text == "0")
                {
                    MainDisplay.Clear();
                    MainDisplay.Text += "8";
                }
                else
                {
                    MainDisplay.Text += "8";
                }
            }
        }

        // 'Nine' button

        private void ButtonNine_Click(object sender, EventArgs e)
        {
            if (MainDisplay.Text.Length != 10)
            {
                if (MainDisplay.Text == result.ToString())
                {
                    MainDisplay.Clear();
                    FormulaDisplay.Clear();
                }
                if (MainDisplay.Text == "0")
                {
                    MainDisplay.Clear();
                    MainDisplay.Text += "9";
                }
                else
                {
                    MainDisplay.Text += "9";
                }
            }
        }

        // 'Dot' button

        private void ButtonDot_Click(object sender, EventArgs e)
        {
            if (MainDisplay.Text.Length != 10)
            {
                if (MainDisplay.Text != String.Empty)
                {
                    if (!MainDisplay.Text.Contains("."))
                    {
                        MainDisplay.Text += ".";
                    }
                }
                else
                {
                    MainDisplay.Text = "0.";
                }
            }
        }

        // Cancel button

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            MainDisplay.Clear();
            FormulaDisplay.Clear();
            Array.Clear(operand, 0, 2);

        }

        // Add button

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            if (MainDisplay.Text != String.Empty)
            {
                if (MainDisplay.Text == result.ToString())
                {
                    operand[0] = result;
                    MainDisplay.Clear();
                    FormulaDisplay.Clear();
                    FormulaDisplay.Text = $"{operand[0]} + ";
                }
                else if (FormulaDisplay.Text != String.Empty)
                {
                    if (FormulaDisplay.Text.Contains('+'))
                    {
                        operand[0] = operand[0] + double.Parse(MainDisplay.Text);
                    }
                    else if (FormulaDisplay.Text.Contains('-'))
                    {
                        operand[0] = operand[0] - double.Parse(MainDisplay.Text);
                    }
                    else if (FormulaDisplay.Text.Contains('×'))
                    {
                        operand[0] = operand[0] * double.Parse(MainDisplay.Text);
                    }
                    else if (FormulaDisplay.Text.Contains('÷'))
                    {
                        operand[0] = operand[0] / double.Parse(MainDisplay.Text);
                    }
                    MainDisplay.Clear();
                    FormulaDisplay.Text = $"{operand[0]} + ";
                }
                else
                {
                    operand[0] = double.Parse(MainDisplay.Text);
                    MainDisplay.Clear();
                    FormulaDisplay.Text = $"{operand[0]} + ";
                }
                calledOperator = '+';
            }
        }

        // Substract button

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            if (MainDisplay.Text != String.Empty)
            {
                if (MainDisplay.Text == result.ToString())
                {
                    operand[0] = result;
                    MainDisplay.Clear();
                    FormulaDisplay.Clear();
                    FormulaDisplay.Text = $"{operand[0]} - ";
                }
                else if (FormulaDisplay.Text != String.Empty)
                {
                    if (FormulaDisplay.Text.Contains('+'))
                    {
                        operand[0] = operand[0] + double.Parse(MainDisplay.Text);
                    }
                    else if (FormulaDisplay.Text.Contains('-'))
                    {
                        operand[0] = operand[0] - double.Parse(MainDisplay.Text);
                    }
                    else if (FormulaDisplay.Text.Contains('×'))
                    {
                        operand[0] = operand[0] * double.Parse(MainDisplay.Text);
                    }
                    else if (FormulaDisplay.Text.Contains('÷'))
                    {
                        operand[0] = operand[0] / double.Parse(MainDisplay.Text);
                    }
                    MainDisplay.Clear();
                    FormulaDisplay.Text = $"{operand[0]} - ";
                }
                else
                {
                    operand[0] = double.Parse(MainDisplay.Text);
                    MainDisplay.Clear();
                    FormulaDisplay.Text = $"{operand[0]} - ";
                }
                calledOperator = '-';
            }
        }

        // Multiply button

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            if (MainDisplay.Text != String.Empty)
            {
                if (MainDisplay.Text == result.ToString())
                {
                    operand[0] = result;
                    MainDisplay.Clear();
                    FormulaDisplay.Clear();
                    FormulaDisplay.Text = $"{operand[0]} × ";
                }
                else if (FormulaDisplay.Text != String.Empty)
                {
                    if (FormulaDisplay.Text.Contains('+'))
                    {
                        operand[0] = operand[0] + double.Parse(MainDisplay.Text);
                    }
                    else if (FormulaDisplay.Text.Contains('-'))
                    {
                        operand[0] = operand[0] - double.Parse(MainDisplay.Text);
                    }
                    else if (FormulaDisplay.Text.Contains('×'))
                    {
                        operand[0] = operand[0] * double.Parse(MainDisplay.Text);
                    }
                    else if (FormulaDisplay.Text.Contains('÷'))
                    {
                        operand[0] = operand[0] / double.Parse(MainDisplay.Text);
                    }
                    MainDisplay.Clear();
                    FormulaDisplay.Text = $"{operand[0]} × ";
                }
                else
                {
                    operand[0] = double.Parse(MainDisplay.Text);
                    MainDisplay.Clear();
                    FormulaDisplay.Text = $"{operand[0]} × ";
                }
                calledOperator = '*';
            }
        }

        // Divide button

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            if (MainDisplay.Text != String.Empty)
            {
                if (MainDisplay.Text == result.ToString())
                {
                    operand[0] = result;
                    MainDisplay.Clear();
                    FormulaDisplay.Clear();
                    FormulaDisplay.Text = $"{operand[0]} ÷ ";
                }
                else if (FormulaDisplay.Text != String.Empty)
                {
                    if (FormulaDisplay.Text.Contains('+'))
                    {
                        operand[0] = operand[0] + double.Parse(MainDisplay.Text);
                    }
                    else if (FormulaDisplay.Text.Contains('-'))
                    {
                        operand[0] = operand[0] - double.Parse(MainDisplay.Text);
                    }
                    else if (FormulaDisplay.Text.Contains('×'))
                    {
                        operand[0] = operand[0] * double.Parse(MainDisplay.Text);
                    }
                    else if (FormulaDisplay.Text.Contains('÷'))
                    {
                        operand[0] = operand[0] / double.Parse(MainDisplay.Text);
                    }
                    MainDisplay.Clear();
                    FormulaDisplay.Text = $"{operand[0]} ÷ ";
                }
                else
                {
                    operand[0] = double.Parse(MainDisplay.Text);
                    MainDisplay.Clear();
                    FormulaDisplay.Text = $"{operand[0]} ÷ ";
                }
                calledOperator = '/';
            }
        }

        // Square root button

        private void ButtonSquareRoot_Click(object sender, EventArgs e)
        {
            if (MainDisplay.Text != String.Empty)
            {
                operand[0] = double.Parse(MainDisplay.Text);
                result = Math.Sqrt(operand[0]);
                MainDisplay.Text = result.ToString();
                FormulaDisplay.Text = $"√({operand[0]})";
            }
        }

        // Square (power) button

        private void ButtonSquare_Click(object sender, EventArgs e)
        {
            if (MainDisplay.Text != String.Empty)
            {
                operand[0] = double.Parse(MainDisplay.Text);
                result = operand[0] * operand[0];
                MainDisplay.Text = result.ToString();
                FormulaDisplay.Text = $"sqr({operand[0]})";
            }
        }

        // Equal button

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            if (MainDisplay.Text != result.ToString())
            {
                if (operand.Length != 0)
                {
                    if (MainDisplay.Text != String.Empty)
                    {
                        operand[1] = double.Parse(MainDisplay.Text);
                        FormulaDisplay.Text += operand[1];
                        MainDisplay.Clear();

                        switch (calledOperator)
                        {
                            case '+':
                                result = operand[0] + operand[1];
                                break;
                            case '-':
                                result = operand[0] - operand[1];
                                break;
                            case '*':
                                result = operand[0] * operand[1];
                                break;
                            case '/':
                                result = operand[0] / operand[1];
                                break;
                        }

                        MainDisplay.Text = result.ToString();
                    }
                }
            }
        }

        // Assign keyboard keys

        private void CalculatorUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus)
            {
                ButtonPlus.PerformClick();
            }
            else if (e.KeyCode == Keys.Divide || e.KeyCode == Keys.OemQuestion)
            {
                ButtonDivide.PerformClick();
            }
            else if (e.KeyCode == Keys.Multiply || (e.Shift && e.KeyCode == Keys.D8))
            {
                ButtonMultiply.PerformClick();
            }
            else if (e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract)
            {
                ButtonMinus.PerformClick();
            }
            else if (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal)
            {
                ButtonDot.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                ButtonCancel.PerformClick();
            }
        }

        private void CalculatorUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.D0 || e.KeyChar == (char)Keys.NumPad0)
            {
                ButtonZero.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.D1 || e.KeyChar == (char)Keys.NumPad1)
            {
                ButtonOne.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.D2 || e.KeyChar == (char)Keys.NumPad2)
            {
                ButtonTwo.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.D3 || e.KeyChar == (char)Keys.NumPad3)
            {
                ButtonThree.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.D4 || e.KeyChar == (char)Keys.NumPad4)
            {
                ButtonFour.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.D5 || e.KeyChar == (char)Keys.NumPad5)
            {
                ButtonFive.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.D6 || e.KeyChar == (char)Keys.NumPad6)
            {
                ButtonSix.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.D7 || e.KeyChar == (char)Keys.NumPad7)
            {
                ButtonSeven.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.D8 || e.KeyChar == (char)Keys.NumPad8)
            {
                ButtonEight.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.D9 || e.KeyChar == (char)Keys.NumPad9)
            {
                ButtonNine.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                ButtonCancel.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                if (MainDisplay.Text != String.Empty)
                {
                    if (MainDisplay.Text != result.ToString())
                    {
                        MainDisplay.Text = MainDisplay.Text.Substring(0, MainDisplay.Text.Length - 1);
                    }
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (this.ActiveControl.Handle != ButtonEqual.Handle)
                {
                    this.SelectNextControl(ButtonDot, true, true, true, true);
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
