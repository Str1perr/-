using System;
using System.Windows.Forms;

namespace Курсовой_проект
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
