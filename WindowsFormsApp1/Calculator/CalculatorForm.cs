using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CalculatorForm : Form
    {
         private Calculator calculator;


        public CalculatorForm()
        {
            InitializeComponent();
            calculator = new Calculator();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            calculator.Clear();
            calcTextBox.Text = calculator.getCurrentNumber().ToString();
        }

        private void ButtonNegate_Click(object sender, EventArgs e)
        {
            calculator.Negate();
            calcTextBox.Text = calculator.getCurrentNumber().ToString();
            //calcTextBox.Text = calcTextBox.Text + "-" ;
        }

        private void ButtonPercent_Click(object sender, EventArgs e)
        {
            calculator.Percent();
            if(calculator.getCurrentNumber() != 0)
            {
                calcTextBox.Text = calculator.getCurrentNumber().ToString();
            }
            else
            {
                calcTextBox.Text = calculator.getLastNumber().ToString();
            }
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            {
            calculator.setLastOperation("÷");
            calculator.setLastNumber(calculator.getCurrentNumber());
            calculator.setCurrentNumber(0);
            calculator.negateDot();
            }
}

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            if (calculator.getLastNumber() == 0)
            {
                calculator.setLastOperation("x");
                calculator.setLastNumber(calculator.getCurrentNumber());
                calculator.setCurrentNumber(0);
                calculator.negateDot();
            }
            else
            {
                calculator.setLastOperation("x");
                calculator.negateDot();
            }
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            if (calculator.getLastNumber() == 0)
            {
                calculator.setLastOperation("-");
                calculator.setLastNumber(calculator.getCurrentNumber());
                calculator.setCurrentNumber(0);
                calculator.negateDot();
            }
            else
            {
                calculator.setLastOperation("-");
                calculator.negateDot();
            }
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            if (calculator.getLastNumber() == 0)
            {
                calculator.setLastOperation("+");
                calculator.setLastNumber(calculator.getCurrentNumber());
                calculator.setCurrentNumber(0);
                calculator.negateDot();
            }
            else
            {
                calculator.setLastOperation("+");
                calculator.negateDot();
            }
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            calcTextBox.Text = calculator.Operation().ToString();
            calculator.setLastNumber(calculator.getResult());
            //calculator.setCurrentNumber(0);
        }

        private void ButtonDot_Click(object sender, EventArgs e)
        {
            calcTextBox.Text = calcTextBox.Text+ ".";
            calculator.changeDot();
        }

        private void ButtonNine_Click(object sender, EventArgs e)
        {
            if (calculator.getDot() == false)
            {
                if (calculator.getCurrentNumber() == 0)
                {
                    calculator.setCurrentNumber(9);
                    calcTextBox.Text = calculator.getCurrentNumber().ToString();
                }
                else
                {
                    calculator.Shift(9);
                    calcTextBox.Text = calculator.getCurrentNumber().ToString();
                }
            }
            else
            {
                if(calculator.getFirstDotNumber() == true)
                {
                    calculator.setCurrentNumber(((calculator.getCurrentNumber() * 10) + 0.9) / 10);
                    calcTextBox.Text = calculator.getCurrentNumber().ToString();
                }
                else
                {
                    calculator.setCurrentNumber(calculator.getCurrentNumber() + 0.9);
                    calcTextBox.Text = calculator.getCurrentNumber().ToString();
                    calculator.changeFirstDotNumber();
                }
            }
        }

        private void ButtonEight_Click(object sender, EventArgs e)
        {
            if (calculator.getDot() == false)
            {
                if (calculator.getCurrentNumber() == 0)
                {
                    calculator.setCurrentNumber(8);
                    calcTextBox.Text = calculator.getCurrentNumber().ToString();
                }
                else
                {
                    calculator.Shift(8);
                    calcTextBox.Text = calculator.getCurrentNumber().ToString();
                }
            }
            else
            {
                if (calculator.getFirstDotNumber() == true)
                {
                    calculator.setCurrentNumber(((calculator.getCurrentNumber() * 10) + 0.8) / 10);
                    calcTextBox.Text = calculator.getCurrentNumber().ToString();
                }
                else
                {
                    calculator.setCurrentNumber(calculator.getCurrentNumber() + 0.8);
                    calcTextBox.Text = calculator.getCurrentNumber().ToString();
                    calculator.changeFirstDotNumber();
                }
            }
        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            if (calculator.getDot() == false)
            {
                if (calculator.getCurrentNumber() == 0)
                {
                    calculator.setCurrentNumber(7);
                    calcTextBox.Text = calculator.getCurrentNumber().ToString();
                }
                else
                {
                    calculator.Shift(7);
                    calcTextBox.Text = calculator.getCurrentNumber().ToString();
                }
            }
            else
            {
                calculator.setCurrentNumber(calculator.getCurrentNumber() + 0.7);
                calcTextBox.Text = calculator.getCurrentNumber().ToString();
            }
        }

        private void ButtonSix_Click(object sender, EventArgs e)
        {
            if (calculator.getDot() == false)
            {
                if (calculator.getCurrentNumber() == 0)
                {
                    calculator.setCurrentNumber(6);
                    calcTextBox.Text = calculator.getCurrentNumber().ToString();
                }
                else
                {
                    calculator.Shift(6);
                    calcTextBox.Text = calculator.getCurrentNumber().ToString();
                }
            }
            else
            {
                calculator.setCurrentNumber(calculator.getCurrentNumber() + 0.6);
                calcTextBox.Text = calculator.getCurrentNumber().ToString();
            }
        }

        private void ButtonFive_Click(object sender, EventArgs e)
        {
            if (calculator.getDot() == false)
            {
                if (calculator.getCurrentNumber() == 0)
                {
                    calculator.setCurrentNumber(5);
                    calcTextBox.Text = calculator.getCurrentNumber().ToString();
                }
                else
                {
                    calculator.Shift(5);
                    calcTextBox.Text = calculator.getCurrentNumber().ToString();
                }
            }
            else
            {
                calculator.setCurrentNumber(calculator.getCurrentNumber() + 0.5);
                calcTextBox.Text = calculator.getCurrentNumber().ToString();
            }
        }

        private void ButtonFour_Click(object sender, EventArgs e)
        {
            if (calculator.getDot() == false)
            {
                if (calculator.getCurrentNumber() == 0)
                {
                    calculator.setCurrentNumber(4);
                    calcTextBox.Text = calculator.getCurrentNumber().ToString();
                }
                else
                {
                    calculator.Shift(4);
                    calcTextBox.Text = calculator.getCurrentNumber().ToString();
                }
            }
            else
            {
                calculator.setCurrentNumber(calculator.getCurrentNumber() + 0.4);
                calcTextBox.Text = calculator.getCurrentNumber().ToString();
            }
        }

        private void ButtonThree_Click(object sender, EventArgs e)
        {
            if (calculator.getDot() == false)
            {
                if (calculator.getCurrentNumber() == 0)
                {
                    calculator.setCurrentNumber(3);
                    calcTextBox.Text = calculator.getCurrentNumber().ToString();
                }
                else
                {
                    calculator.Shift(3);
                    calcTextBox.Text = calculator.getCurrentNumber().ToString();
                }
            }
            else
            {
                calculator.setCurrentNumber(calculator.getCurrentNumber() + 0.3);
                calcTextBox.Text = calculator.getCurrentNumber().ToString();
            }
        }

        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            if (calculator.getDot() == false)
            {
                if (calculator.getCurrentNumber() == 0)
                {
                    calculator.setCurrentNumber(2);
                    calcTextBox.Text = calculator.getCurrentNumber().ToString();
                }
                else
                {
                    calculator.Shift(2);
                    calcTextBox.Text = calculator.getCurrentNumber().ToString();
                }
            }
            else
            {
                calculator.setCurrentNumber(calculator.getCurrentNumber() + 0.2);
                calcTextBox.Text = calculator.getCurrentNumber().ToString();
            }
        }

        private void ButtonOne_Click(object sender, EventArgs e)
        {
            if (calculator.getDot() == false)
            {
                if (calculator.getCurrentNumber() == 0)
                {
                    calculator.setCurrentNumber(1);
                    calcTextBox.Text = calculator.getCurrentNumber().ToString();
                }
                else
                {
                    calculator.Shift(1);
                    calcTextBox.Text = calculator.getCurrentNumber().ToString();
                }
            }
            else
            {
                calculator.setCurrentNumber(calculator.getCurrentNumber() + 0.1);
                calcTextBox.Text = calculator.getCurrentNumber().ToString();
            }
        }

        private void ButtonZero_Click(object sender, EventArgs e)
        {
            if (calculator.getDot() == false)
            {
                if (calculator.getCurrentNumber() == 0)
                {
                    calculator.setCurrentNumber(0);
                    calcTextBox.Text = calculator.getCurrentNumber().ToString();
                }
                else
                {
                    calculator.Shift(0);
                    calcTextBox.Text = calculator.getCurrentNumber().ToString();
                }
            }
            else
            {
                calculator.setCurrentNumber(calculator.getCurrentNumber() + 0.0);
                calcTextBox.Text = calculator.getCurrentNumber().ToString();
            }
        }
    }
}
