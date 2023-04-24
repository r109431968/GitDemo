namespace GetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            if (!int.TryParse(Txt_1.Text, out a))
            {
                MessageBox.Show("I need just a number in the first box!");
                return;
            }
            if (!int.TryParse(Txt_2.Text, out b))
            {
                MessageBox.Show("I need just a number in the second box!");
                return;
            }
            labAnswer.Text = (a + b).ToString();
        }
    }
}