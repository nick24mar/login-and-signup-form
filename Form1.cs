using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {
            var thisLabelTab = (sender as Label); //This is the login tab

            thisLabelTab.ForeColor = Color.FromArgb(23,23,23);
            Marker.Location = new Point(
                    thisLabelTab.Location.X + 5,
                    Marker.Location.Y
                );

            LoginFormControl.BringToFront();
            SignupFormControl.SendToBack();
        }

        private void SignupLabel_Click(object sender, EventArgs e)
        {
            var thisLabelTab = (sender as Label); //This is the signup tab

            thisLabelTab.ForeColor = Color.FromArgb(23, 23, 23);
            Marker.Location = new Point(
                    thisLabelTab.Location.X + 5,
                    Marker.Location.Y
                );

            SignupFormControl.BringToFront();
            LoginFormControl.SendToBack();
        }
    }
}
