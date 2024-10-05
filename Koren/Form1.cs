namespace Koren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            double b = 1;
            double x;
            while (true)
            {
                x = 0.5 * (b + a / b);
                if (x == b)
                {
                    MessageBox.Show(b.ToString());
                    break;
                }
                else
                    b = x; 
            }
        }
    }
}
