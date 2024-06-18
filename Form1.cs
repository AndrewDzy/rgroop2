namespace Andrii
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            Iducations secondForm = new Iducations();
            secondForm.Show();
            this.Hide();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Test secondForm = new Test();
            secondForm.Show();
            this.Hide();
        }
    }
}
