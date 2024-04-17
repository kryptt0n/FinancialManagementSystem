namespace FinancialManagementSystem
{
    partial class UserReportPage
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
            TransactionsGv = new DataGridView();
            ImportBtn = new Button();
            GenerateBtn = new Button();
            BackBtn = new Button();
            CopyTranBtn = new Button();
            label1 = new Label();
            FromDtp = new DateTimePicker();
            ToDtp = new DateTimePicker();
            label2 = new Label();
            TypeCb = new ComboBox();
            TypeLb = new Label();
            GroupLb = new Label();
            GroupTb = new TextBox();
            label3 = new Label();
            GenerateReportBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)TransactionsGv).BeginInit();
            SuspendLayout();
            // 
            // TransactionsGv
            // 
            TransactionsGv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TransactionsGv.Location = new Point(42, 196);
            TransactionsGv.Margin = new Padding(11, 13, 11, 13);
            TransactionsGv.Name = "TransactionsGv";
            TransactionsGv.RowHeadersWidth = 82;
            TransactionsGv.Size = new Size(858, 730);
            TransactionsGv.TabIndex = 0;
            // 
            // ImportBtn
            // 
            ImportBtn.BackColor = Color.GreenYellow;
            ImportBtn.Location = new Point(939, 391);
            ImportBtn.Margin = new Padding(11, 13, 11, 13);
            ImportBtn.Name = "ImportBtn";
            ImportBtn.Size = new Size(167, 87);
            ImportBtn.TabIndex = 1;
            ImportBtn.Text = "Import";
            ImportBtn.UseVisualStyleBackColor = false;
            ImportBtn.Click += ImportBtn_Click;
            // 
            // GenerateBtn
            // 
            GenerateBtn.BackColor = Color.GreenYellow;
            GenerateBtn.Location = new Point(939, 504);
            GenerateBtn.Margin = new Padding(11, 13, 11, 13);
            GenerateBtn.Name = "GenerateBtn";
            GenerateBtn.Size = new Size(167, 87);
            GenerateBtn.TabIndex = 2;
            GenerateBtn.Text = "Export";
            GenerateBtn.UseVisualStyleBackColor = false;
            GenerateBtn.Click += GenerateBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.GreenYellow;
            BackBtn.Location = new Point(939, 843);
            BackBtn.Margin = new Padding(11, 13, 11, 13);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(167, 87);
            BackBtn.TabIndex = 3;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // CopyTranBtn
            // 
            CopyTranBtn.BackColor = Color.GreenYellow;
            CopyTranBtn.Location = new Point(939, 730);
            CopyTranBtn.Margin = new Padding(11, 13, 11, 13);
            CopyTranBtn.Name = "CopyTranBtn";
            CopyTranBtn.Size = new Size(167, 87);
            CopyTranBtn.TabIndex = 4;
            CopyTranBtn.Text = "Copy Transaction";
            CopyTranBtn.UseVisualStyleBackColor = false;
            CopyTranBtn.Click += CopyTranBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 130);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 32);
            label1.TabIndex = 5;
            label1.Text = "From:";
            // 
            // FromDtp
            // 
            FromDtp.Checked = false;
            FromDtp.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            FromDtp.Format = DateTimePickerFormat.Custom;
            FromDtp.Location = new Point(128, 130);
            FromDtp.Margin = new Padding(6);
            FromDtp.Name = "FromDtp";
            FromDtp.ShowCheckBox = true;
            FromDtp.Size = new Size(337, 39);
            FromDtp.TabIndex = 6;
            FromDtp.ValueChanged += FromDtp_ValueChanged;
            // 
            // ToDtp
            // 
            ToDtp.Checked = false;
            ToDtp.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            ToDtp.Format = DateTimePickerFormat.Custom;
            ToDtp.Location = new Point(571, 130);
            ToDtp.Margin = new Padding(6);
            ToDtp.Name = "ToDtp";
            ToDtp.ShowCheckBox = true;
            ToDtp.Size = new Size(329, 39);
            ToDtp.TabIndex = 8;
            ToDtp.ValueChanged += ToDtp_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(499, 141);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 32);
            label2.TabIndex = 7;
            label2.Text = "To:";
            // 
            // TypeCb
            // 
            TypeCb.FormattingEnabled = true;
            TypeCb.Items.AddRange(new object[] { "None", "Income", "Expense" });
            TypeCb.Location = new Point(939, 196);
            TypeCb.Margin = new Padding(6);
            TypeCb.Name = "TypeCb";
            TypeCb.Size = new Size(242, 40);
            TypeCb.TabIndex = 9;
            TypeCb.SelectedIndexChanged += TypeCb_SelectedIndexChanged;
            // 
            // TypeLb
            // 
            TypeLb.AutoSize = true;
            TypeLb.Location = new Point(939, 134);
            TypeLb.Margin = new Padding(6, 0, 6, 0);
            TypeLb.Name = "TypeLb";
            TypeLb.Size = new Size(65, 32);
            TypeLb.TabIndex = 10;
            TypeLb.Text = "Type";
            // 
            // GroupLb
            // 
            GroupLb.AutoSize = true;
            GroupLb.Location = new Point(939, 259);
            GroupLb.Margin = new Padding(6, 0, 6, 0);
            GroupLb.Name = "GroupLb";
            GroupLb.Size = new Size(80, 32);
            GroupLb.TabIndex = 11;
            GroupLb.Text = "Group";
            // 
            // GroupTb
            // 
            GroupTb.Location = new Point(939, 321);
            GroupTb.Margin = new Padding(6);
            GroupTb.Name = "GroupTb";
            GroupTb.Size = new Size(242, 39);
            GroupTb.TabIndex = 12;
            GroupTb.TextChanged += GroupTb_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label3.Location = new Point(34, 43);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(190, 65);
            label3.TabIndex = 13;
            label3.Text = "Report";
            // 
            // GenerateReportBtn
            // 
            GenerateReportBtn.BackColor = Color.GreenYellow;
            GenerateReportBtn.Location = new Point(939, 617);
            GenerateReportBtn.Margin = new Padding(11, 13, 11, 13);
            GenerateReportBtn.Name = "GenerateReportBtn";
            GenerateReportBtn.Size = new Size(167, 87);
            GenerateReportBtn.TabIndex = 14;
            GenerateReportBtn.Text = "Generate Report";
            GenerateReportBtn.UseVisualStyleBackColor = false;
            GenerateReportBtn.Click += GenerateReportBtn_Click;
            // 
            // UserReportPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1246, 951);
            Controls.Add(GenerateReportBtn);
            Controls.Add(label3);
            Controls.Add(GroupTb);
            Controls.Add(GroupLb);
            Controls.Add(TypeLb);
            Controls.Add(TypeCb);
            Controls.Add(ToDtp);
            Controls.Add(label2);
            Controls.Add(FromDtp);
            Controls.Add(label1);
            Controls.Add(CopyTranBtn);
            Controls.Add(BackBtn);
            Controls.Add(GenerateBtn);
            Controls.Add(ImportBtn);
            Controls.Add(TransactionsGv);
            Margin = new Padding(11, 13, 11, 13);
            Name = "UserReportPage";
            Text = "Report";
            ((System.ComponentModel.ISupportInitialize)TransactionsGv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TransactionsGv;
        private Button ImportBtn;
        private Button GenerateBtn;
        private Button BackBtn;
        private Button CopyTranBtn;
        private Label label1;
        private DateTimePicker FromDtp;
        private DateTimePicker ToDtp;
        private Label label2;
        private ComboBox TypeCb;
        private Label TypeLb;
        private Label GroupLb;
        private TextBox GroupTb;
        private Label label3;
        private Button GenerateReportBtn;
    }
}