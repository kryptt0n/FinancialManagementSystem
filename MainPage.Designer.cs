namespace FinancialManagementSystem
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ViewReportBtn = new Button();
            LogOutBtn = new Button();
            UserNameTagLb = new Label();
            UserNameLb = new Label();
            BlanaceLb = new Label();
            BalanceValueLb = new Label();
            SuspendLayout();
            // 
            // ViewReportBtn
            // 
            ViewReportBtn.Font = new Font("Segoe UI", 10F);
            ViewReportBtn.Location = new Point(303, 274);
            ViewReportBtn.Name = "ViewReportBtn";
            ViewReportBtn.Size = new Size(94, 38);
            ViewReportBtn.TabIndex = 1;
            ViewReportBtn.Text = "View Report";
            ViewReportBtn.UseVisualStyleBackColor = true;
            ViewReportBtn.Click += ViewReportBtn_Click;
            // 
            // LogOutBtn
            // 
            LogOutBtn.Font = new Font("Segoe UI", 10F);
            LogOutBtn.Location = new Point(303, 22);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Size = new Size(94, 36);
            LogOutBtn.TabIndex = 2;
            LogOutBtn.Text = "Log Out";
            LogOutBtn.UseVisualStyleBackColor = true;
            LogOutBtn.Click += LogOutBtn_Click;
            // 
            // UserNameTagLb
            // 
            UserNameTagLb.AutoSize = true;
            UserNameTagLb.Font = new Font("Segoe UI", 12F);
            UserNameTagLb.Location = new Point(59, 29);
            UserNameTagLb.Name = "UserNameTagLb";
            UserNameTagLb.Size = new Size(91, 21);
            UserNameTagLb.TabIndex = 3;
            UserNameTagLb.Text = "User Name:";
            // 
            // UserNameLb
            // 
            UserNameLb.AutoSize = true;
            UserNameLb.Font = new Font("Segoe UI", 12F);
            UserNameLb.Location = new Point(156, 29);
            UserNameLb.Name = "UserNameLb";
            UserNameLb.Size = new Size(84, 21);
            UserNameLb.TabIndex = 4;
            UserNameLb.Text = "UserName";
            // 
            // BlanaceLb
            // 
            BlanaceLb.AutoSize = true;
            BlanaceLb.Font = new Font("Segoe UI", 15F);
            BlanaceLb.Location = new Point(68, 224);
            BlanaceLb.Name = "BlanaceLb";
            BlanaceLb.Size = new Size(82, 28);
            BlanaceLb.TabIndex = 5;
            BlanaceLb.Text = "Balance:";
            // 
            // BalanceValueLb
            // 
            BalanceValueLb.AutoSize = true;
            BalanceValueLb.Font = new Font("Segoe UI", 15F);
            BalanceValueLb.Location = new Point(156, 224);
            BalanceValueLb.Name = "BalanceValueLb";
            BalanceValueLb.Size = new Size(130, 28);
            BalanceValueLb.TabIndex = 6;
            BalanceValueLb.Text = "Balance Value";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(431, 360);
            Controls.Add(BalanceValueLb);
            Controls.Add(BlanaceLb);
            Controls.Add(UserNameLb);
            Controls.Add(UserNameTagLb);
            Controls.Add(LogOutBtn);
            Controls.Add(ViewReportBtn);
            Margin = new Padding(2, 1, 2, 1);
            Name = "MainPage";
            Text = "Form1";
            Load += MainPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ViewReportBtn;
        private Button LogOutBtn;
        private Label UserNameTagLb;
        private Label UserNameLb;
        private Label BlanaceLb;
        private Label BalanceValueLb;
    }
}
