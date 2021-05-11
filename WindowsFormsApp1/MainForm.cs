using MultiToolApplication;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MainTextBox.Text = "Connected";
        }

        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            CalculatorForm calculatorForm = new CalculatorForm();
            //Form.ActiveForm = calculatorForm;
            calculatorForm.ShowDialog();
        }

        private void hangManButton_Click(object sender, EventArgs e)
        {
            HangmanFormcs hangmanForm = new HangmanFormcs();
            hangmanForm.ShowDialog();
        }

        private void SortingButton_Click(object sender, EventArgs e)
        {

        }

        private void PacManButton_Click(object sender, EventArgs e)
        {
            PacManForm pacManForm = new PacManForm();
            pacManForm.ShowDialog();
        }
    }
}
