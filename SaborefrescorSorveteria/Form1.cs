namespace SaborefrescorSorveteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            Form2 tela2 = new Form2();
            tela2.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 tela3 = new Form3();
            tela3.ShowDialog();
            this.Visible = true;
        }
    }
}
