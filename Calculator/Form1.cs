namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum Operation
        {
            Add,
            Subtract,
            Multiply,
            Divide,
            Modulo,
            None
        }
        static Operation previousOperation = Operation.None;


        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (txtCurrentOperand.Text.Length > 0 && !(txtCurrentOperand.Text.Equals("0")))
            {
                decimal digit;
                if (!decimal.TryParse(txtCurrentOperand.Text[txtCurrentOperand.Text.Length - 1].ToString(), out digit))
                    previousOperation = Operation.None;
                txtCurrentOperand.Text = txtCurrentOperand.Text.Remove(txtCurrentOperand.Text.Length - 1, 1);
                if (txtCurrentOperand.Text == "") txtCurrentOperand.Text = "0";
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            previousOperation = Operation.None;
            ResetCalculator();
        }

        private void BtnNum_Click(object digit, EventArgs e)
        {
            if (digit is not Button btnNum) return;

            bool isComma = btnNum.Text.Equals(",");
            bool isEquals = lblOperator.Text.Equals("=");
            bool isNegativeToggle = btnNum.Text.Equals("±");
            bool isZero = btnNum.Text.Equals("0");

            if (isZero && txtCurrentOperand.Text[0].Equals('0')) return; 

            if (isComma && (isEquals || txtCurrentOperand.Text.Contains(','))) return;

            if (isEquals) ResetCalculator();

            if (isNegativeToggle && !txtCurrentOperand.Text.Equals("0")) ToggleNegative();

            if (txtCurrentOperand.Text.Equals("0") && !isComma) txtCurrentOperand.Text = "";

            txtCurrentOperand.Text += isNegativeToggle ? "" : btnNum.Text;
        }

        private void ResetCalculator()
        {
            txtCurrentOperand.Text = "0";
            lblOperator.Text = "";
            txtPreviousOperand.Clear();
        }

        private void ToggleNegative()
        {
            txtCurrentOperand.Text = txtCurrentOperand.Text.Contains('-')
                ? txtCurrentOperand.Text.Remove(0, 1)
                : $"-{txtCurrentOperand.Text}";
        }

        private void BtnOperator_Click(object sender, EventArgs e)
        {
            if (previousOperation != Operation.None && txtCurrentOperand.Text != "0")
                Evaluate(previousOperation);

            if (string.IsNullOrEmpty(txtCurrentOperand.Text) && string.IsNullOrEmpty(txtPreviousOperand.Text))
                return;

            if (!(sender is Button btnOperator)) return;

            SetOperation(btnOperator.Text);
        }

        private void SetOperation(string operationSymbol)
        {
            if (txtCurrentOperand.Text == "0")
            {
                UpdateOperation(operationSymbol);
            }
            else
            {
                previousOperation = GetOperationFromSymbol(operationSymbol);
                txtPreviousOperand.Text = txtCurrentOperand.Text;
                txtCurrentOperand.Text = "0";
                lblOperator.Text = operationSymbol;
            }
        }

        private void UpdateOperation(string operationSymbol)
        {
            previousOperation = GetOperationFromSymbol(operationSymbol);
            lblOperator.Text = operationSymbol;
        }

        private static Operation GetOperationFromSymbol(string symbol)
        {
            return symbol switch
            {
                "+" => Operation.Add,
                "-" => Operation.Subtract,
                "×" => Operation.Multiply,
                "÷" => Operation.Divide,
                "%" => Operation.Modulo,
                _ => previousOperation
            };
        }



        private void Evaluate(Operation previousOperation)
        {
            //string[] historyRes = txtHistory.Text.Split("\n\n");
            //string[] latestRes = historyRes[historyRes.Length - 1].Split('e');

            //if (txtPreviousOperand.Text.Contains('e'))
            //{
            //    double integralVal = double.Parse(latestRes[0]);
            //    double decimalVal = double.Parse(latestRes[1]);
            //    txtPreviousOperand.Text = (integralVal * Math.Pow(10, decimalVal)).ToString();
            //}

            if (!decimal.TryParse(txtPreviousOperand.Text, out decimal prev) ||
                !decimal.TryParse(txtCurrentOperand.Text, out decimal curr))
            {
                MessageBox.Show("Invalid Operand", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string result = previousOperation switch
            {
                Operation.Add => (prev + curr).ToString(),
                Operation.Subtract => (prev - curr).ToString(),
                Operation.Multiply => (prev * curr).ToString(),
                Operation.Divide => DivideNumbers(prev, curr),
                Operation.Modulo => (prev % curr).ToString(),
                _ => txtCurrentOperand.Text
            };

            int decimalPlaces = GetDecimalPlaces(decimal.Parse(result));
            int integralDigits = GetIntegralDigits(decimal.Parse(result));

            txtPreviousOperand.Text = $"{prev} {GetOperatorSymbol(previousOperation)} {curr}";
            string altResult;

            if (result.Contains(','))
            {
                if (decimalPlaces > 8 || integralDigits > 8)
                {
                    altResult = decimal.Parse(result).ToString("#.###e+00");
                    result = decimal.Parse(result).ToString("N9");
                }
                else
                {
                    altResult = decimal.Parse(result).ToString($"N{decimalPlaces}");
                    result = altResult;
                }
            }
            else
            {
                if (result.Length > 9)
                {
                    altResult = decimal.Parse(result).ToString("#.###e+00");
                    result = decimal.Parse(result).ToString("N");
                }
                else
                {
                    result = decimal.Parse(result).ToString("N0");
                    altResult = result;
                }
            }

            txtCurrentOperand.Text = result;
            txtHistory.Text += $"{txtPreviousOperand.Text} = {altResult}\n\n";
        }

        private string DivideNumbers(decimal prev, decimal curr)
        {
            if (curr == 0)
            {
                txtPreviousOperand.Clear();
                lblOperator.Text = string.Empty;
                return "Undefined";
            }
            return (prev / curr).ToString();
        }

        private static string GetOperatorSymbol(Operation operation)
        {
            return operation switch
            {
                Operation.Add => "+",
                Operation.Subtract => "-",
                Operation.Multiply => "×",
                Operation.Divide => "÷",
                Operation.Modulo => "%",
                _ => ""
            };
        }

        private static int GetDecimalPlaces(decimal number)
        {
            string[] splitNumber = number.ToString().Split(',');
            return (splitNumber.Length > 1) ? splitNumber[1].Length : 0;
        }

        private static int GetIntegralDigits(decimal number)
        {
            string[] splitNumber = number.ToString().Split(',');
            return splitNumber[0].Length;
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData >= Keys.D0 && keyData <= Keys.D9) // Handle numeric keys
            {
                int digit = (int)(keyData - Keys.D0);
                txtCurrentOperand.Text += digit.ToString();
                return true; // Prevent default handling
            }
            else if (keyData == Keys.Add) // Handle '+'
            {
                txtCurrentOperand.Text += "+";
                return true;
            }
            else if (keyData == Keys.Subtract) // Handle '-'
            {
                txtCurrentOperand.Text += "-";
                return true;
            }
            else if (keyData == Keys.Multiply) // Handle '*'
            {
                txtCurrentOperand.Text += "×";
                return true;
            }
            else if (keyData == Keys.Divide) // Handle '/'
            {
                txtCurrentOperand.Text += "÷";
                return true;
            }
            else if (keyData == Keys.Enter) // Handle '='
            {
                MessageBox.Show("Whatttt");
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void BtnEval_Click(object sender, EventArgs e)
        {
            if (previousOperation != Operation.None)
            {
                Evaluate(previousOperation);
                lblOperator.Text = "=";
            }

            previousOperation = Operation.None;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Coral;
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Black;
        }

        private void BtnClose_MouseDown(object sender, MouseEventArgs e)
        {
            btnClose.BackColor = Color.Gray;
        }

        private void BtnClearHistory_Click(object sender, EventArgs e)
        {
            txtHistory.Clear();
        }
    }
}
