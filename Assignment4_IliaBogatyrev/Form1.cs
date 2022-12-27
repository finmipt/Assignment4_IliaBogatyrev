namespace Assignment4_IliaBogatyrev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Calculate the factorial of the number entered by the user
            int number = Convert.ToInt32(textBox1.Text);
            int factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            // Display the factorial
            label2.Text = String.Format("The factorial of {0} is {1}", number, factorial);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}