using System;
using System.Windows.Forms;

namespace PasswordApp.Forms
{
    public partial class AddLoginDetail : Form
    {
        public AddLoginDetail()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
        }

        private void DiscardButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}