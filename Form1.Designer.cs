namespace LoginFormDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginLabel = new System.Windows.Forms.Label();
            this.SignupLabel = new System.Windows.Forms.Label();
            this.Marker = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginFormControl = new LoginFormDemo.LoginFormControl();
            this.SignupFormControl = new LoginFormDemo.SignupFormControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginLabel.Font = new System.Drawing.Font("Aileron", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(459, 44);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(69, 24);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "LOGIN";
            this.LoginLabel.Click += new System.EventHandler(this.LoginLabel_Click);
            // 
            // SignupLabel
            // 
            this.SignupLabel.AutoSize = true;
            this.SignupLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignupLabel.Font = new System.Drawing.Font("Aileron", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.SignupLabel.Location = new System.Drawing.Point(555, 44);
            this.SignupLabel.Name = "SignupLabel";
            this.SignupLabel.Size = new System.Drawing.Size(85, 24);
            this.SignupLabel.TabIndex = 2;
            this.SignupLabel.Text = "SIGN UP";
            this.SignupLabel.Click += new System.EventHandler(this.SignupLabel_Click);
            // 
            // Marker
            // 
            this.Marker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.Marker.Location = new System.Drawing.Point(463, 72);
            this.Marker.Name = "Marker";
            this.Marker.Size = new System.Drawing.Size(67, 2);
            this.Marker.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoginFormDemo.Properties.Resources.Asset_5;
            this.pictureBox1.Location = new System.Drawing.Point(-292, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(722, 514);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginFormControl
            // 
            this.LoginFormControl.Font = new System.Drawing.Font("Aileron", 8.25F);
            this.LoginFormControl.Location = new System.Drawing.Point(432, 105);
            this.LoginFormControl.Name = "LoginFormControl";
            this.LoginFormControl.Size = new System.Drawing.Size(404, 350);
            this.LoginFormControl.TabIndex = 4;
            // 
            // SignupFormControl
            // 
            this.SignupFormControl.Location = new System.Drawing.Point(432, 105);
            this.SignupFormControl.Name = "SignupFormControl";
            this.SignupFormControl.Size = new System.Drawing.Size(404, 350);
            this.SignupFormControl.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 514);
            this.Controls.Add(this.LoginFormControl);
            this.Controls.Add(this.Marker);
            this.Controls.Add(this.SignupLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SignupFormControl);
            this.Font = new System.Drawing.Font("Aileron", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label SignupLabel;
        private System.Windows.Forms.Panel Marker;
        private LoginFormControl LoginFormControl;
        private SignupFormControl SignupFormControl;
    }
}

