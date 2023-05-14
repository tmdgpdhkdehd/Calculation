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

        // ＝ 클릭
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
                    display.Text = "0으로 나눌 수 없습니다.";
                }
                else
                {
                    firstOperand /= secondOperand;
                    display.Text = firstOperand.ToString();
                }
            }
            currentOperator = Operators.None;
        }

        // ＋ 클릭
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            firstOperand = Double.Parse(display.Text);
            currentOperator = Operators.Add;
            operatorChangeFlag = true;
        }

        // － 클릭
        private void ButtonSub_Click(object sender, EventArgs e)
        {
            firstOperand = Double.Parse(display.Text);
            currentOperator = Operators.Subtract;
            operatorChangeFlag = true;
        }

        // × 클릭
        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            firstOperand = Double.Parse(display.Text);
            currentOperator = Operators.Multiply;
            operatorChangeFlag = true;
        }

        // ÷ 클릭
        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            firstOperand = Double.Parse(display.Text);
            currentOperator = Operators.Divide;
            operatorChangeFlag = true;
        }

        // 0 클릭
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

        // 1 클릭
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

        // 2 클릭
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

        // 3 클릭
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

        // 4 클릭
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

        // 5 클릭
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

        // 6 클릭
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

        // 7 클릭
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

        // 8 클릭
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

        // 9 클릭
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

        // AC 클릭
        private void ButtonAC_Click(object sender, EventArgs e)
        {
            firstOperand = 0;
            secondOperand = 0;
            currentOperator = Operators.None;
            display.Text = "0";
        }

        // . 클릭
        private void ButtonDot_Click(object sender, EventArgs e)
        {
            if (!display.Text.Contains("."))
            {
                display.Text = display.Text += ".";
            }
        }
    }
}