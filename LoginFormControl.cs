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
    public partial class LoginFormControl : UserControl
    {
        public LoginFormControl()
        {
            InitializeComponent();
        }

        private void UsernameTxtBox_MouseClick(object sender, MouseEventArgs e)
        {
            var thisTextBox = (sender as TextBox); // the username txtbox

            thisTextBox.Text = "";
            thisTextBox.ForeColor = Color.FromArgb(23,23,23);
        }

        private void PwdTxtBox_MouseClick(object sender, MouseEventArgs e)
        {
            var thisTextBox = (sender as TextBox); // The passwordTextbox

            thisTextBox.Text = "";
            thisTextBox.ForeColor = Color.FromArgb(23, 23, 23);
            thisTextBox.PasswordChar = '•'; //Press ALT + NUMPAD 7 for the character
        }
    }
}
