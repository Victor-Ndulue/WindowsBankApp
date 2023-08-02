using Services.UnitOfWork.Interfaces;
using System.Windows.Forms;

namespace WindowsBankForm
{
    public partial class WindowsBankForm : Form
    {
        private readonly IServiceUnitOfWork _serviceUnitOfWork;
        public WindowsBankForm(IServiceUnitOfWork serviceUnitOfWork)
        {
            _serviceUnitOfWork = serviceUnitOfWork;
            InitializeComponent();
        }

        private void WindowsBankForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void WindowsBankForm_Load_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void HeaderText_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUp form = new SignUp();
            form.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

        }
    }
}