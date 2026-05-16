namespace attendance.PAL.FORMS
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pictureBox1 = new PictureBox();
            pictureBoxMinimize = new PictureBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBoxName = new TextBox();
            button1 = new Button();
            label2 = new Label();
            textBoxPassword = new TextBox();
            pictureBoxHide = new PictureBox();
            pictureBoxShow = new PictureBox();
            labelError = new Label();
            pictureBoxError = new PictureBox();
            label3 = new Label();
            buttonLogin = new Button();
            labelFP = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1157, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxMinimize
            // 
            pictureBoxMinimize.Cursor = Cursors.Hand;
            pictureBoxMinimize.Image = (Image)resources.GetObject("pictureBoxMinimize.Image");
            pictureBoxMinimize.Location = new Point(1110, 12);
            pictureBoxMinimize.Name = "pictureBoxMinimize";
            pictureBoxMinimize.Size = new Size(31, 31);
            pictureBoxMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMinimize.TabIndex = 1;
            pictureBoxMinimize.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(pictureBoxError);
            groupBox1.Controls.Add(labelError);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(pictureBoxShow);
            groupBox1.Controls.Add(pictureBoxHide);
            groupBox1.Controls.Add(buttonLogin);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(labelFP);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10F);
            groupBox1.Location = new Point(107, 190);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(452, 348);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Please LogIn First";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label1.Location = new Point(92, 59);
            label1.Name = "label1";
            label1.Size = new Size(86, 17);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            label1.Click += label1_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(95, 92);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(265, 23);
            textBoxName.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label2.Location = new Point(92, 133);
            label2.Name = "label2";
            label2.Size = new Size(82, 17);
            label2.TabIndex = 0;
            label2.Text = "Password:";
            label2.Click += label1_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(95, 166);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(241, 23);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // pictureBoxHide
            // 
            pictureBoxHide.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxHide.Cursor = Cursors.Hand;
            pictureBoxHide.Image = (Image)resources.GetObject("pictureBoxHide.Image");
            pictureBoxHide.Location = new Point(335, 166);
            pictureBoxHide.Name = "pictureBoxHide";
            pictureBoxHide.Size = new Size(25, 24);
            pictureBoxHide.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHide.TabIndex = 2;
            pictureBoxHide.TabStop = false;
            // 
            // pictureBoxShow
            // 
            pictureBoxShow.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxShow.Cursor = Cursors.Hand;
            pictureBoxShow.Image = (Image)resources.GetObject("pictureBoxShow.Image");
            pictureBoxShow.Location = new Point(335, 166);
            pictureBoxShow.Name = "pictureBoxShow";
            pictureBoxShow.Size = new Size(25, 24);
            pictureBoxShow.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxShow.TabIndex = 3;
            pictureBoxShow.TabStop = false;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new Font("Microsoft Sans Serif", 9F);
            labelError.ForeColor = Color.FromArgb(234, 73, 73);
            labelError.Location = new Point(124, 207);
            labelError.Name = "labelError";
            labelError.Size = new Size(179, 15);
            labelError.TabIndex = 4;
            labelError.Text = "Invalid Username Or Password.";
            labelError.Click += label3_Click;
            // 
            // pictureBoxError
            // 
            pictureBoxError.Cursor = Cursors.Hand;
            pictureBoxError.Image = (Image)resources.GetObject("pictureBoxError.Image");
            pictureBoxError.Location = new Point(93, 202);
            pictureBoxError.Name = "pictureBoxError";
            pictureBoxError.Size = new Size(25, 25);
            pictureBoxError.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxError.TabIndex = 5;
            pictureBoxError.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label3.Location = new Point(92, 133);
            label3.Name = "label3";
            label3.Size = new Size(82, 17);
            label3.TabIndex = 0;
            label3.Text = "Password:";
            label3.Click += label1_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(67, 3, 125);
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(165, 279);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(118, 33);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Secure Login";
            buttonLogin.TextAlign = ContentAlignment.MiddleRight;
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += button1_Click;
            // 
            // labelFP
            // 
            labelFP.AutoSize = true;
            labelFP.Cursor = Cursors.Hand;
            labelFP.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            labelFP.ForeColor = Color.FromArgb(67, 3, 125);
            labelFP.Location = new Point(165, 239);
            labelFP.Name = "labelFP";
            labelFP.Size = new Size(138, 17);
            labelFP.TabIndex = 0;
            labelFP.Text = "Forgot Password?";
            labelFP.Click += label1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.Control;
            flowLayoutPanel1.Location = new Point(696, 163);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(5, 408);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(840, 185);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(202, 218);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(67, 3, 125);
            label4.Location = new Point(807, 419);
            label4.Name = "label4";
            label4.Size = new Size(273, 25);
            label4.TabIndex = 4;
            label4.Text = "Attendance Management";
            label4.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(67, 3, 125);
            label5.Location = new Point(906, 460);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 5;
            label5.Text = "System";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(888, 500);
            label6.Name = "label6";
            label6.Size = new Size(125, 20);
            label6.TabIndex = 6;
            label6.Text = "By Group Namin";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1527, 771);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBoxMinimize);
            Controls.Add(pictureBox1);
            Font = new Font("Microsoft Sans Serif", 12F);
            ForeColor = Color.FromArgb(17, 123, 201);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBoxMinimize;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBoxName;
        private Label label1;
        private TextBox textBoxPassword;
        private Label label2;
        private PictureBox pictureBoxShow;
        private PictureBox pictureBoxHide;
        private PictureBox pictureBoxError;
        private Label labelError;
        private Button buttonLogin;
        private Label label3;
        private Label labelFP;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}