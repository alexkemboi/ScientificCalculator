namespace ScientificCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.Parse(screenTextBox.Text) == 0)
            {
                screenTextBox.Text = btnOne.Text;
            }
            else
            {
                screenTextBox.Text = screenTextBox.Text + btnOne.Text;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (double.Parse(screenTextBox.Text) == 0)
            {
                screenTextBox.Text = btnTwo.Text;
            }
            else
            {
                screenTextBox.Text = screenTextBox.Text + btnTwo.Text;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            screenTextBox.Text = "0";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (double.Parse(screenTextBox.Text) == 0)
            {
                screenTextBox.Text = btnThree.Text;
            }
            else
            {
                screenTextBox.Text = screenTextBox.Text + btnThree.Text;
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (double.Parse(screenTextBox.Text) == 0)
            {
                screenTextBox.Text = btnFour.Text;
            }
            else
            {
                screenTextBox.Text = screenTextBox.Text + btnFour.Text;
            }
        }
        private void btnFive_Click(object sender, EventArgs e)
        {
            if (double.Parse(screenTextBox.Text) == 0)
            {
                screenTextBox.Text = btnFive.Text;
            }
            else
            {
                screenTextBox.Text = screenTextBox.Text + btnFive.Text;
            }
        }
        private void btnSix_Click(object sender, EventArgs e)
        {
            if (double.Parse(screenTextBox.Text) == 0)
            {
                screenTextBox.Text = btnSix.Text;
            }
            else
            {
                screenTextBox.Text = screenTextBox.Text + btnSix.Text;
            }
        }
        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (double.Parse(screenTextBox.Text) == 0)
            {
                screenTextBox.Text = btnSeven.Text;
            }
            else
            {
                screenTextBox.Text = screenTextBox.Text + btnSeven.Text;
            }
        }
        private void btnEight_Click(object sender, EventArgs e)
        {
            if (double.Parse(screenTextBox.Text) == 0)
            {
                screenTextBox.Text = btnEight.Text;
            }
            else
            {
                screenTextBox.Text = screenTextBox.Text + btnEight.Text;
            }
        }
        private void btnNine_Click(object sender, EventArgs e)
        {
            if (double.Parse(screenTextBox.Text) == 0)
            {
                screenTextBox.Text = btnNine.Text;
            }
            else
            {
                screenTextBox.Text = screenTextBox.Text + btnNine.Text;
            }
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            if (double.Parse(screenTextBox.Text) == 0)
            {
                screenTextBox.Text = btnZero.Text;
            }
            else
            {
                screenTextBox.Text = screenTextBox.Text + btnZero.Text;
            }
        }
        private void btnPoint_Click(object sender, EventArgs e)
        {

            
                if (screenTextBox.Text.Contains(btnPoint.Text))
                {

                    screenTextBox.Text = screenTextBox.Text;
                }
                else
                {
                    screenTextBox.Text = screenTextBox.Text + btnPoint.Text;
                }
            
        }
    }
}