namespace Calculation
{
    public partial class Form1 : Form
    {
        enum Operators
        {
            None,
            Add,
            Subtract,
            Multiply,
            Divide,
            Result
        }

        Operators currentOperator = Operators.None;
        bool operatorChangeFlag = false;
        Double firstOperand = 0;
        Double secondOperand = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // �� Ŭ��
        private void ButtonResult_Click(object sender, EventArgs e)
        {
            secondOperand = Double.Parse(display.Text);
            if (currentOperator == Operators.Add)
            {
                firstOperand += secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Subtract)
            {
                firstOperand -= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Multiply)
            {
                firstOperand *= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Divide)
            {
                if (secondOperand == 0)
                {
                    display.Text = "0���� ���� �� �����ϴ�.";
                }
                else
                {
                    firstOperand /= secondOperand;
                    display.Text = firstOperand.ToString();
                }
            }
            currentOperator = Operators.None;
        }

        // �� Ŭ��
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            firstOperand = Double.Parse(display.Text);
            currentOperator = Operators.Add;
            operatorChangeFlag = true;
        }

        // �� Ŭ��
        private void ButtonSub_Click(object sender, EventArgs e)
        {
            firstOperand = Double.Parse(display.Text);
            currentOperator = Operators.Subtract;
            operatorChangeFlag = true;
        }

        // �� Ŭ��
        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            firstOperand = Double.Parse(display.Text);
            currentOperator = Operators.Multiply;
            operatorChangeFlag = true;
        }

        // �� Ŭ��
        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            firstOperand = Double.Parse(display.Text);
            currentOperator = Operators.Divide;
            operatorChangeFlag = true;
        }

        // 0 Ŭ��
        private void ButtonZero_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "0";
            Double DoubleNumber = Double.Parse(strNumber);
            display.Text = DoubleNumber.ToString();
        }

        // 1 Ŭ��
        private void ButtonOne_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text + "1";
            Double DoubleNumber = Double.Parse(strNumber);
            display.Text = DoubleNumber.ToString();
        }

        // 2 Ŭ��
        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text + "2";
            Double DoubleNumber = Double.Parse(strNumber);
            display.Text = DoubleNumber.ToString();
        }

        // 3 Ŭ��
        private void ButtonThree_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "3";
            Double DoubleNumber = Double.Parse(strNumber);
            display.Text = DoubleNumber.ToString();
        }

        // 4 Ŭ��
        private void ButtonFour_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "4";
            Double DoubleNumber = Double.Parse(strNumber);
            display.Text = DoubleNumber.ToString();
        }

        // 5 Ŭ��
        private void ButtonFive_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "5";
            Double DoubleNumber = Double.Parse(strNumber);
            display.Text = DoubleNumber.ToString();
        }

        // 6 Ŭ��
        private void ButtonSix_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "6";
            Double DoubleNumber = Double.Parse(strNumber);
            display.Text = DoubleNumber.ToString();
        }

        // 7 Ŭ��
        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "7";
            Double DoubleNumber = Double.Parse(strNumber);
            display.Text = DoubleNumber.ToString();
        }

        // 8 Ŭ��
        private void ButtonEight_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "8";
            Double DoubleNumber = Double.Parse(strNumber);
            display.Text = DoubleNumber.ToString();
        }

        // 9 Ŭ��
        private void ButtonNine_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "9";
            Double DoubleNumber = Double.Parse(strNumber);
            display.Text = DoubleNumber.ToString();
        }

        // AC Ŭ��
        private void ButtonAC_Click(object sender, EventArgs e)
        {
            firstOperand = 0;
            secondOperand = 0;
            currentOperator = Operators.None;
            display.Text = "0";
        }

        // . Ŭ��
        private void ButtonDot_Click(object sender, EventArgs e)
        {
            if (!display.Text.Contains("."))
            {
                display.Text = display.Text += ".";
            }
        }
    }
}