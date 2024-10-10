namespace FormMayTinh
{
    public partial class Form1 : Form
    {
        private double result = 0;
        private string operation = "";
        private bool operationPressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void tbKetQua_TextChanged(object sender, EventArgs e)
        {

        }

        private void AppendNumber(string number)
        {
            if (operationPressed)
            {
                tbKetQua.Text = number;
                operationPressed = false;
            }
            else
            {
                tbKetQua.Text += number;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AppendNumber("1");
        }

        private void btn2_Click(object sender, EventArgs e) 
        {
            AppendNumber("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AppendNumber("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AppendNumber("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AppendNumber("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AppendNumber("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AppendNumber("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AppendNumber("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AppendNumber("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            AppendNumber("0");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tbKetQua.Clear();
            result = 0;
            operation = "";
        }

        private void SetOperation(string op)
        {
            if (result != 0)
            {
                btnTinh.PerformClick();
                operationPressed = true;
            }
            else
            {
                result = double.Parse(tbKetQua.Text);
                operation = op;
                operationPressed = true;
            }
        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (operation != "")
            {
                switch (operation)
                {
                    case "+":
                        tbKetQua.Text = (result + double.Parse(tbKetQua.Text)).ToString();
                        break;
                    case "-":
                        tbKetQua.Text = (result - double.Parse(tbKetQua.Text)).ToString();
                        break;
                    case "*":
                        tbKetQua.Text = (result * double.Parse(tbKetQua.Text)).ToString();
                        break;
                    case "/":
                        if (double.Parse(tbKetQua.Text) != 0)
                            tbKetQua.Text = (result / double.Parse(tbKetQua.Text)).ToString();
                        else
                            MessageBox.Show("Không thể chia cho 0!");
                        break;
                }
                result = double.Parse(tbKetQua.Text);
                operation = "";

            }
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            SetOperation("+");
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            SetOperation("-");
        }

        private void buttonNhan_Click(object sender, EventArgs e)
        {
            SetOperation("*");
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            SetOperation("/");
        }
    }
}
