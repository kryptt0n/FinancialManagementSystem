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
            TransactionsGv.Location = new Point(23, 92);
            TransactionsGv.Margin = new Padding(6);
            TransactionsGv.Name = "TransactionsGv";
            TransactionsGv.RowHeadersWidth = 82;
            TransactionsGv.Size = new Size(600, 342);
            TransactionsGv.TabIndex = 0;
            TransactionsGv.CellContentClick += TransactionsGv_CellContentClick;
            // 
            // ImportBtn
            // 
            ImportBtn.BackColor = Color.GreenYellow;
            ImportBtn.Location = new Point(647, 176);
            ImportBtn.Margin = new Padding(6);
            ImportBtn.Name = "ImportBtn";
            ImportBtn.Size = new Size(90, 41);
            ImportBtn.TabIndex = 1;
            ImportBtn.Text = "Import";
            ImportBtn.UseVisualStyleBackColor = false;
            ImportBtn.Click += ImportBtn_Click;
            // 
            // GenerateBtn
            // 
            GenerateBtn.BackColor = Color.GreenYellow;
            GenerateBtn.Location = new Point(647, 229);
            GenerateBtn.Margin = new Padding(6);
            GenerateBtn.Name = "GenerateBtn";
            GenerateBtn.Size = new Size(90, 41);
            GenerateBtn.TabIndex = 2;
            GenerateBtn.Text = "Export";
            GenerateBtn.UseVisualStyleBackColor = false;
            GenerateBtn.Click += GenerateBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.GreenYellow;
            BackBtn.Location = new Point(647, 388);
            BackBtn.Margin = new Padding(6);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(90, 41);
            BackBtn.TabIndex = 3;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // CopyTranBtn
            // 
            CopyTranBtn.BackColor = Color.GreenYellow;
            CopyTranBtn.Location = new Point(647, 335);
            CopyTranBtn.Margin = new Padding(6);
            CopyTranBtn.Name = "CopyTranBtn";
            CopyTranBtn.Size = new Size(90, 41);
            CopyTranBtn.TabIndex = 4;
            CopyTranBtn.Text = "Copy Transaction";
            CopyTranBtn.UseVisualStyleBackColor = false;
            CopyTranBtn.Click += CopyTranBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 61);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "From:";
            // 
            // FromDtp
            // 
            FromDtp.Checked = false;
            FromDtp.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            FromDtp.Format = DateTimePickerFormat.Custom;
            FromDtp.Location = new Point(69, 61);
            FromDtp.Name = "FromDtp";
            FromDtp.ShowCheckBox = true;
            FromDtp.Size = new Size(183, 23);
            FromDtp.TabIndex = 6;
            FromDtp.ValueChanged += FromDtp_ValueChanged;
            // 
            // ToDtp
            // 
            ToDtp.Checked = false;
            ToDtp.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            ToDtp.Format = DateTimePickerFormat.Custom;
            ToDtp.Location = new Point(307, 61);
            ToDtp.Name = "ToDtp";
            ToDtp.ShowCheckBox = true;
            ToDtp.Size = new Size(179, 23);
            ToDtp.TabIndex = 8;
            ToDtp.ValueChanged += ToDtp_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 66);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 7;
            label2.Text = "To:";
            // 
            // TypeCb
            // 
            TypeCb.FormattingEnabled = true;
            TypeCb.Items.AddRange(new object[] { "None", "Income", "Expense" });
            TypeCb.Location = new Point(647, 85);
            TypeCb.Name = "TypeCb";
            TypeCb.Size = new Size(132, 23);
            TypeCb.TabIndex = 9;
            TypeCb.SelectedIndexChanged += TypeCb_SelectedIndexChanged;
            // 
            // TypeLb
            // 
            TypeLb.AutoSize = true;
            TypeLb.Location = new Point(647, 56);
            TypeLb.Name = "TypeLb";
            TypeLb.Size = new Size(31, 15);
            TypeLb.TabIndex = 10;
            TypeLb.Text = "Type";
            // 
            // GroupLb
            // 
            GroupLb.AutoSize = true;
            GroupLb.Location = new Point(647, 114);
            GroupLb.Name = "GroupLb";
            GroupLb.Size = new Size(40, 15);
            GroupLb.TabIndex = 11;
            GroupLb.Text = "Group";
            // 
            // GroupTb
            // 
            GroupTb.Location = new Point(647, 143);
            GroupTb.Name = "GroupTb";
            GroupTb.Size = new Size(132, 23);
            GroupTb.TabIndex = 12;
            GroupTb.TextChanged += GroupTb_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label3.Location = new Point(18, 20);
            label3.Name = "label3";
            label3.Size = new Size(93, 32);
            label3.TabIndex = 13;
            label3.Text = "Report";
            // 
            // GenerateReportBtn
            // 
            GenerateReportBtn.BackColor = Color.GreenYellow;
            GenerateReportBtn.Location = new Point(647, 282);
            GenerateReportBtn.Margin = new Padding(6);
            GenerateReportBtn.Name = "GenerateReportBtn";
            GenerateReportBtn.Size = new Size(90, 41);
            GenerateReportBtn.TabIndex = 14;
            GenerateReportBtn.Text = "Generate Report";
            GenerateReportBtn.UseVisualStyleBackColor = false;
            GenerateReportBtn.Click += GenerateReportBtn_Click;
            // 
            // UserReportPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(811, 446);
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
            Margin = new Padding(6);
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