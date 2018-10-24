using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormDemo
{
    public partial class SignupFormControl : UserControl
    {
        public SignupFormControl()
        {
            InitializeComponent();
        }

        private void UsernameTxtBox_MouseClick(object sender, MouseEventArgs e)
        {
            var thisTextBox = (sender as TextBox); // the username txtbox on sign up form

            thisTextBox.Text = "";
            thisTextBox.ForeColor = Color.FromArgb(23, 23, 23);
        }

        private void PwdTxtBox_MouseClick(object sender, MouseEventArgs e)
        {
            var thisTextBox = (sender as TextBox); // the password txtbox on signup form

            thisTextBox.Text = "";
            thisTextBox.ForeColor = Color.FromArgb(23, 23, 23);
            thisTextBox.PasswordChar = '•';
        }

        private void EmailTxtBox_MouseClick(object sender, MouseEventArgs e)
        {
            var thisTextBox = (sender as TextBox); // the email txtbox on sing up form

            thisTextBox.Text = "";
            thisTextBox.ForeColor = Color.FromArgb(23, 23, 23);
        }
    }
}
