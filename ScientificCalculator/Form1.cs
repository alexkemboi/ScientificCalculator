namespace ScientificCalculator
{
    public partial class Form1 : Form
    {
        private string storedOperator = null;
        private double currentValue = 0;
        private double storedValue = 0;
        public Form1(string storedOperator, int currentValue, int storedValue)
        {
            InitializeComponent();
            this.storedOperator = storedOperator;
            this.currentValue = currentValue;
            this.storedValue = storedValue;
        }


        private void NumberBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string number = button.Text;
            currentValue = (currentValue * 10) + double.Parse(number);
            UpdateDisplay();
        }
        public void UpdateDisplay()
        {
            screenOneTextBox.Text = currentValue.ToString();
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            storedOperator = button.Text;
            screenTextBox.Text = storedValue.ToString();
            StoreValueAndOperator(storedOperator);
        }
        private void StoreValueAndOperator(string storedOperator)
        {

            // Perform calculation if there is already a stored operator
            if (storedOperator != null)
            {
                switch (storedOperator)
                {
                    case "+":
                        currentValue = storedValue + currentValue;
                        break;
                    case "-":
                        currentValue = storedValue - currentValue;
                        break;
                    case "*":
                        currentValue = storedValue * currentValue;
                        break;
                    case "/":
                        currentValue = storedValue / currentValue;
                        break;
                }
            }

            UpdateDisplay();
            // Store the current value and the selected operator
            storedValue = currentValue;
            screenTextBox.Text = storedValue.ToString();

            // Reset the current value for the next input
            currentValue = 0;
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            StoreValueAndOperator(storedOperator);
        }
        private void button29_Click(object sender, EventArgs e)
        {
            currentValue = 0;
            storedValue = 0;
            storedOperator = "";
            screenTextBox.Text = currentValue.ToString();
            UpdateDisplay();
        }
    }
}