namespace FinancialManagementSystem
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            UserName = new Label();
            Password = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnSignUp = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.BackColor = Color.Transparent;
            UserName.Font = new Font("Tahoma", 10.5F);
            UserName.ForeColor = Color.Black;
            UserName.Location = new Point(213, 338);
            UserName.Name = "UserName";
            UserName.Size = new Size(141, 34);
            UserName.TabIndex = 0;
            UserName.Text = "Username";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.BackColor = Color.Transparent;
            Password.Font = new Font("Tahoma", 10.5F);
            Password.ForeColor = Color.Black;
            Password.Location = new Point(213, 401);
            Password.Name = "Password";
            Password.Size = new Size(132, 34);
            Password.TabIndex = 1;
            Password.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Font = new Font("Tahoma", 10.5F);
            txtUserName.Location = new Point(387, 338);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(326, 41);
            txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Tahoma", 10.5F);
            txtPassword.Location = new Point(387, 401);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(326, 41);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.GreenYellow;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Tahoma", 10.5F);
            btnLogin.Location = new Point(299, 495);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(147, 59);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.GreenYellow;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Tahoma", 10.5F);
            btnSignUp.Location = new Point(515, 495);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(152, 59);
            btnSignUp.TabIndex = 5;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(317, 258);
            label1.Name = "label1";
            label1.Size = new Size(437, 46);
            label1.TabIndex = 6;
            label1.Text = "Login to Your Account";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(409, 71);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(139, 133);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1002, 620);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(btnSignUp);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(Password);
            Controls.Add(UserName);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserName;
        private Label Password;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnSignUp;
        private Label label1;
        private PictureBox pictureBox2;
    }
}