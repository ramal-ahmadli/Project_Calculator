namespace Calculator
{
    public partial class Form1 : Form
    {

        char simbol;
        bool cleanDispley;
        decimal oneNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox_conclusion.Text = "0";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }


        private void btn_00_Click(object sender, EventArgs e)
        {
            if (cleanDispley)
            {
                textBox_conclusion.Text = " ";
                cleanDispley = false;
            }

            Button btn = (Button)sender;
            textBox_conclusion.Text += btn.Text;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox_conclusion.Text += btn.Text;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (cleanDispley)
            {
                textBox_conclusion.Text = " ";
                cleanDispley = false;
            }

            Button btn = (Button)sender;
            textBox_conclusion.Text += btn.Text;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (cleanDispley)
            {
                textBox_conclusion.Text = " ";
                cleanDispley = false;
            }

            Button btn = (Button)sender;
            textBox_conclusion.Text += btn.Text;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (cleanDispley)
            {
                textBox_conclusion.Text = " ";
                cleanDispley = false;
            }

            Button btn = (Button)sender;
            textBox_conclusion.Text += btn.Text;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (cleanDispley)
            {
                textBox_conclusion.Text = " ";
                cleanDispley = false;
            }

            Button btn = (Button)sender;
            textBox_conclusion.Text += btn.Text;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (cleanDispley)
            {
                textBox_conclusion.Text = " ";
                cleanDispley = false;
            }

            Button btn = (Button)sender;
            textBox_conclusion.Text += btn.Text;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (cleanDispley)
            {
                textBox_conclusion.Text = " ";
                cleanDispley = false;
            }

            Button btn = (Button)sender;
            textBox_conclusion.Text += btn.Text;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (cleanDispley)
            {
                textBox_conclusion.Text = " ";
                cleanDispley = false;
            }
            Button btn = (Button)sender;
            textBox_conclusion.Text += btn.Text;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (cleanDispley)
            {
                textBox_conclusion.Text = " ";
                cleanDispley = false;
            }

            Button btn = (Button)sender;
            textBox_conclusion.Text += btn.Text;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (cleanDispley)
            {
                textBox_conclusion.Text = " ";
                cleanDispley = false;
            }

            Button btn = (Button)sender;
            textBox_conclusion.Text += btn.Text;
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            if (cleanDispley)
            {
                textBox_conclusion.Text = " ";
                cleanDispley = false;
            }

            Button btn = (Button)sender;
            textBox_conclusion.Text += btn.Text;
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            simbol = '÷';
            cleanDispley = true;
            oneNumber = Convert.ToDecimal(textBox_conclusion.Text);

            Button btn = (Button)sender;
            textBox_conclusion.Text += btn.Text;
        }

        private void btn_multiplication_Click(object sender, EventArgs e)
        {
            simbol = '*';
            cleanDispley = true;
            oneNumber = Convert.ToDecimal(textBox_conclusion.Text);

            Button btn = (Button)sender;
            textBox_conclusion.Text += btn.Text;
        }

        private void btn_subtraction_Click(object sender, EventArgs e)
        {
            simbol = '-';
            cleanDispley = true;
            oneNumber = Convert.ToDecimal(textBox_conclusion.Text);

            Button btn = (Button)sender;
            textBox_conclusion.Text += btn.Text;
        }

        private void btn_addition_Click(object sender, EventArgs e)
        {
            simbol = '+';
            cleanDispley = true;
            oneNumber = Convert.ToDecimal(textBox_conclusion.Text);

            Button btn = (Button)sender;
            textBox_conclusion.Text += btn.Text;
        }

        private void btn_percent_Click(object sender, EventArgs e)
        {
            simbol = '%';
            cleanDispley = true;
            oneNumber = Convert.ToDecimal(textBox_conclusion.Text);

            Button btn = (Button)sender;
            textBox_conclusion.Text += btn.Text;
        }

        private void btn_equality_Click(object sender, EventArgs e)
        {
            decimal twoNumber = Convert.ToDecimal(textBox_conclusion.Text);
            decimal total;

            switch (simbol)
            {
                case '÷':
                    total = oneNumber / twoNumber;
                    break;

                case '*':
                    total = oneNumber * twoNumber;
                    break;

                case '-':
                    total = oneNumber - twoNumber;
                    break;

                case '+':
                    total = oneNumber + twoNumber;
                    break;
                case '%':
                    total = (oneNumber * twoNumber) / 100;
                    break;
                default:
                    total = 0;
                    break;
            }
            textBox_conclusion.Text = total.ToString();
        }
    }
}
