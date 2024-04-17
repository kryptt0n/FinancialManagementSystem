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
            IncomeTagLb = new Label();
            ExpensesTagLb = new Label();
            ExpensesLb = new Label();
            IncomeLb = new Label();
            AddTransactionBtn = new Button();
            SuspendLayout();
            // 
            // ViewReportBtn
            // 
            ViewReportBtn.BackColor = Color.GreenYellow;
            ViewReportBtn.Font = new Font("Segoe UI", 10F);
            ViewReportBtn.Location = new Point(563, 484);
            ViewReportBtn.Margin = new Padding(6);
            ViewReportBtn.Name = "ViewReportBtn";
            ViewReportBtn.Size = new Size(175, 66);
            ViewReportBtn.TabIndex = 1;
            ViewReportBtn.Text = "View Report";
            ViewReportBtn.UseVisualStyleBackColor = false;
            ViewReportBtn.Click += ViewReportBtn_Click;
            // 
            // LogOutBtn
            // 
            LogOutBtn.BackColor = Color.GreenYellow;
            LogOutBtn.Font = new Font("Segoe UI", 10F);
            LogOutBtn.Location = new Point(563, 47);
            LogOutBtn.Margin = new Padding(6);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Size = new Size(175, 66);
            LogOutBtn.TabIndex = 2;
            LogOutBtn.Text = "Log Out";
            LogOutBtn.UseVisualStyleBackColor = false;
            LogOutBtn.Click += LogOutBtn_Click;
            // 
            // UserNameTagLb
            // 
            UserNameTagLb.AutoSize = true;
            UserNameTagLb.Font = new Font("Segoe UI", 12F);
            UserNameTagLb.Location = new Point(43, 56);
            UserNameTagLb.Margin = new Padding(6, 0, 6, 0);
            UserNameTagLb.Name = "UserNameTagLb";
            UserNameTagLb.Size = new Size(160, 45);
            UserNameTagLb.TabIndex = 3;
            UserNameTagLb.Text = "Welcome,";
            // 
            // UserNameLb
            // 
            UserNameLb.AutoSize = true;
            UserNameLb.Font = new Font("Segoe UI", 12F);
            UserNameLb.Location = new Point(197, 56);
            UserNameLb.Margin = new Padding(6, 0, 6, 0);
            UserNameLb.Name = "UserNameLb";
            UserNameLb.Size = new Size(169, 45);
            UserNameLb.TabIndex = 4;
            UserNameLb.Text = "UserName";
            // 
            // BlanaceLb
            // 
            BlanaceLb.AutoSize = true;
            BlanaceLb.Font = new Font("Segoe UI", 15F);
            BlanaceLb.Location = new Point(40, 496);
            BlanaceLb.Margin = new Padding(6, 0, 6, 0);
            BlanaceLb.Name = "BlanaceLb";
            BlanaceLb.Size = new Size(167, 54);
            BlanaceLb.TabIndex = 5;
            BlanaceLb.Text = "Balance:";
            // 
            // BalanceValueLb
            // 
            BalanceValueLb.AutoSize = true;
            BalanceValueLb.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BalanceValueLb.Location = new Point(220, 496);
            BalanceValueLb.Margin = new Padding(6, 0, 6, 0);
            BalanceValueLb.Name = "BalanceValueLb";
            BalanceValueLb.Size = new Size(294, 54);
            BalanceValueLb.TabIndex = 6;
            BalanceValueLb.Text = "Balance Value";
            // 
            // IncomeTagLb
            // 
            IncomeTagLb.AutoSize = true;
            IncomeTagLb.Font = new Font("Segoe UI", 12F);
            IncomeTagLb.Location = new Point(40, 192);
            IncomeTagLb.Margin = new Padding(6, 0, 6, 0);
            IncomeTagLb.Name = "IncomeTagLb";
            IncomeTagLb.Size = new Size(133, 45);
            IncomeTagLb.TabIndex = 7;
            IncomeTagLb.Text = "Income:";
            // 
            // ExpensesTagLb
            // 
            ExpensesTagLb.AutoSize = true;
            ExpensesTagLb.Font = new Font("Segoe UI", 12F);
            ExpensesTagLb.Location = new Point(40, 268);
            ExpensesTagLb.Margin = new Padding(6, 0, 6, 0);
            ExpensesTagLb.Name = "ExpensesTagLb";
            ExpensesTagLb.Size = new Size(150, 45);
            ExpensesTagLb.TabIndex = 8;
            ExpensesTagLb.Text = "Expenses";
            // 
            // ExpensesLb
            // 
            ExpensesLb.AutoSize = true;
            ExpensesLb.Font = new Font("Segoe UI", 12F);
            ExpensesLb.ForeColor = Color.Red;
            ExpensesLb.Location = new Point(266, 268);
            ExpensesLb.Margin = new Padding(6, 0, 6, 0);
            ExpensesLb.Name = "ExpensesLb";
            ExpensesLb.Size = new Size(150, 45);
            ExpensesLb.TabIndex = 10;
            ExpensesLb.Text = "Expenses";
            // 
            // IncomeLb
            // 
            IncomeLb.AutoSize = true;
            IncomeLb.Font = new Font("Segoe UI", 12F);
            IncomeLb.ForeColor = Color.ForestGreen;
            IncomeLb.Location = new Point(266, 192);
            IncomeLb.Margin = new Padding(6, 0, 6, 0);
            IncomeLb.Name = "IncomeLb";
            IncomeLb.Size = new Size(126, 45);
            IncomeLb.TabIndex = 9;
            IncomeLb.Text = "Income";
            // 
            // AddTransactionBtn
            // 
            AddTransactionBtn.BackColor = Color.GreenYellow;
            AddTransactionBtn.Font = new Font("Segoe UI", 10F);
            AddTransactionBtn.Location = new Point(563, 392);
            AddTransactionBtn.Name = "AddTransactionBtn";
            AddTransactionBtn.Size = new Size(175, 66);
            AddTransactionBtn.TabIndex = 11;
            AddTransactionBtn.Text = "+";
            AddTransactionBtn.UseVisualStyleBackColor = false;
            AddTransactionBtn.Click += AddTransactionBtn_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 598);
            Controls.Add(AddTransactionBtn);
            Controls.Add(ExpensesLb);
            Controls.Add(IncomeLb);
            Controls.Add(ExpensesTagLb);
            Controls.Add(IncomeTagLb);
            Controls.Add(BalanceValueLb);
            Controls.Add(BlanaceLb);
            Controls.Add(UserNameLb);
            Controls.Add(UserNameTagLb);
            Controls.Add(LogOutBtn);
            Controls.Add(ViewReportBtn);
            Margin = new Padding(4, 2, 4, 2);
            Name = "MainPage";
            Text = "Main menu";
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
        private Label IncomeTagLb;
        private Label ExpensesTagLb;
        private Label ExpensesLb;
        private Label IncomeLb;
        private Button AddTransactionBtn;
    }
}
