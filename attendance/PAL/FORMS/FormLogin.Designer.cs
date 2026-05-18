using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace attendance.PAL.FORMS
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxName = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            labelError = new Label();
            label1 = new Label();
            label2 = new Label();
            labelFP = new Label();
            pictureBox1 = new PictureBox();
            pictureBoxMinimize = new PictureBox();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)pictureBoxMinimize).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(200, 98);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(150, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(200, 138);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(150, 23);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(67, 3, 125);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(200, 200);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(100, 30);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Secure Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(150, 170);
            labelError.Name = "labelError";
            labelError.Size = new Size(170, 15);
            labelError.TabIndex = 4;
            labelError.Text = "Invalid Username Or Password.";
            labelError.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label1.Location = new Point(100, 100);
            label1.Name = "label1";
            label1.Size = new Size(86, 17);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label2.Location = new Point(100, 140);
            label2.Name = "label2";
            label2.Size = new Size(82, 17);
            label2.TabIndex = 0;
            label2.Text = "Password:";
            // 
            // labelFP
            // 
            labelFP.AutoSize = true;
            labelFP.Cursor = Cursors.Hand;
            labelFP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            labelFP.ForeColor = Color.FromArgb(67, 3, 125);
            labelFP.Location = new Point(200, 240);
            labelFP.Name = "labelFP";
            labelFP.Size = new Size(122, 15);
            labelFP.TabIndex = 5;
            labelFP.Text = "Forgot Password?";
            labelFP.Click += labelFP_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxMinimize
            // 
            pictureBoxMinimize.Location = new Point(0, 0);
            pictureBoxMinimize.Name = "pictureBoxMinimize";
            pictureBoxMinimize.Size = new Size(0, 0);
            pictureBoxMinimize.TabIndex = 7;
            pictureBoxMinimize.TabStop = false;
            // 
            // FormLogin
            // 
            ClientSize = new Size(570, 478);
            Controls.Add(labelFP);
            Controls.Add(labelError);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBoxMinimize);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FormLogin_Load;
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)pictureBoxMinimize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox textBoxName;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private Label labelError;
        private Label label1;
        private Label label2;
        private Label labelFP;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxMinimize;
    }
}