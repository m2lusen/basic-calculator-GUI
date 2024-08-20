using NCalc;

namespace SimpleCalulator_GUI
{
    public partial class Calc : Form
    {
        string textInput = "";

        public Calc()
        {
            InitializeComponent();
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            textInput = Input.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Input.Text = "";
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            Input.Text = Input.Text.Substring(0, Input.Text.Length - 1);
        }

        private void butDiv_Click(object sender, EventArgs e)
        {
            Input.Text += " / ";
        }

        private void butTim_Click(object sender, EventArgs e)
        {
            Input.Text += " * ";
        }

        private void butSub_Click(object sender, EventArgs e)
        {
            Input.Text += " - ";
        }

        private void butPlus_Click(object sender, EventArgs e)
        {
            Input.Text += " + ";
        }

        private void butLBrac_Click(object sender, EventArgs e)
        {
            Input.Text += "(";
        }

        private void butRBrac_Click(object sender, EventArgs e)
        {
            Input.Text += ")";
        }

        private void butDP_Click(object sender, EventArgs e)
        {
            Input.Text += ".";
        }

        private void but1_Click(object sender, EventArgs e)
        {
            Input.Text += "1";
        }

        private void but2_Click(object sender, EventArgs e)
        {
            Input.Text += "2";
        }

        private void but3_Click(object sender, EventArgs e)
        {
            Input.Text += "3";
        }

        private void but4_Click(object sender, EventArgs e)
        {
            Input.Text += "4";
        }

        private void but5_Click(object sender, EventArgs e)
        {
            Input.Text += "5";
        }

        private void but6_Click(object sender, EventArgs e)
        {
            Input.Text += "6";
        }

        private void but7_Click(object sender, EventArgs e)
        {
            Input.Text += "7";
        }

        private void but8_Click(object sender, EventArgs e)
        {
            Input.Text += "8";
        }

        private void but9_Click(object sender, EventArgs e)
        {
            Input.Text += "9";
        }

        private void but0_Click(object sender, EventArgs e)
        {
            Input.Text += "0";
        }

        private void butEq_Click(object sender, EventArgs e)
        {
            try
            {
                Expression eqExpress = new Expression(textInput);
                var result = eqExpress.Evaluate();

                Input.Text = result.ToString();
            }
            catch (EvaluationException ex)
            {
                MessageBox.Show("Invalid expression: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Input.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Input.Text = string.Empty;
            }
        }
    }
}
