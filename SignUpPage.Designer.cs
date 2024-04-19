namespace FinancialManagementSystem
{
    partial class SignUpPage
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtName = new TextBox();
            saveBtn = new Button();
            cancelBtn = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.5F);
            label1.Location = new Point(73, 92);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 34);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Tahoma", 10.5F);
            txtName.Location = new Point(266, 90);
            txtName.Margin = new Padding(4, 2, 4, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(369, 41);
            txtName.TabIndex = 1;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.GreenYellow;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Tahoma", 10.5F);
            saveBtn.Location = new Point(161, 356);
            saveBtn.Margin = new Padding(4, 2, 4, 2);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(138, 47);
            saveBtn.TabIndex = 7;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.GreenYellow;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Tahoma", 10.5F);
            cancelBtn.Location = new Point(372, 356);
            cancelBtn.Margin = new Padding(4, 2, 4, 2);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(138, 47);
            cancelBtn.TabIndex = 8;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.5F);
            label4.Location = new Point(73, 249);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 34);
            label4.TabIndex = 10;
            label4.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Tahoma", 10.5F);
            txtEmail.Location = new Point(266, 248);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(369, 41);
            txtEmail.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.5F);
            label5.Location = new Point(73, 173);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(132, 34);
            label5.TabIndex = 15;
            label5.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Tahoma", 10.5F);
            txtPassword.Location = new Point(266, 171);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(369, 41);
            txtPassword.TabIndex = 16;
            // 
            // SignUpPage
            // 
            AutoScaleDimensions = new SizeF(15F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(728, 451);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(txtName);
            Controls.Add(label1);
            Font = new Font("Tahoma", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 2, 4, 2);
            Name = "SignUpPage";
            Text = "Sign up";
            Load += UserDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Button saveBtn;
        private Button cancelBtn;
        private ContextMenuStrip contextMenuStrip1;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtPassword;
    }
}