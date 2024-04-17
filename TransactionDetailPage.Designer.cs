namespace FinancialManagementSystem
{
    partial class TransactionDetailPage
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
            SaveBtn = new Button();
            CancelBtn = new Button();
            AmountLb = new Label();
            AmountTb = new TextBox();
            DateLb = new Label();
            GroupTb = new TextBox();
            GroupLb = new Label();
            TypeLb = new Label();
            TransactionDtp = new DateTimePicker();
            TypeCb = new ComboBox();
            SuspendLayout();
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.GreenYellow;
            SaveBtn.Location = new Point(111, 356);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(150, 60);
            SaveBtn.TabIndex = 0;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.GreenYellow;
            CancelBtn.Location = new Point(487, 356);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(150, 60);
            CancelBtn.TabIndex = 1;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // AmountLb
            // 
            AmountLb.AutoSize = true;
            AmountLb.Location = new Point(91, 88);
            AmountLb.Name = "AmountLb";
            AmountLb.Size = new Size(100, 32);
            AmountLb.TabIndex = 2;
            AmountLb.Text = "Amount";
            // 
            // AmountTb
            // 
            AmountTb.Location = new Point(237, 85);
            AmountTb.Name = "AmountTb";
            AmountTb.Size = new Size(400, 39);
            AmountTb.TabIndex = 3;
            // 
            // DateLb
            // 
            DateLb.AutoSize = true;
            DateLb.Location = new Point(127, 155);
            DateLb.Name = "DateLb";
            DateLb.Size = new Size(64, 32);
            DateLb.TabIndex = 4;
            DateLb.Text = "Date";
            // 
            // GroupTb
            // 
            GroupTb.Location = new Point(237, 283);
            GroupTb.Name = "GroupTb";
            GroupTb.Size = new Size(400, 39);
            GroupTb.TabIndex = 9;
            // 
            // GroupLb
            // 
            GroupLb.AutoSize = true;
            GroupLb.Location = new Point(111, 286);
            GroupLb.Name = "GroupLb";
            GroupLb.Size = new Size(80, 32);
            GroupLb.TabIndex = 8;
            GroupLb.Text = "Group";
            // 
            // TypeLb
            // 
            TypeLb.AutoSize = true;
            TypeLb.Location = new Point(127, 219);
            TypeLb.Name = "TypeLb";
            TypeLb.Size = new Size(65, 32);
            TypeLb.TabIndex = 6;
            TypeLb.Text = "Type";
            // 
            // TransactionDtp
            // 
            TransactionDtp.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            TransactionDtp.Format = DateTimePickerFormat.Custom;
            TransactionDtp.Location = new Point(237, 148);
            TransactionDtp.Name = "TransactionDtp";
            TransactionDtp.Size = new Size(400, 39);
            TransactionDtp.TabIndex = 10;
            // 
            // TypeCb
            // 
            TypeCb.FormattingEnabled = true;
            TypeCb.Items.AddRange(new object[] { "Income", "Expense" });
            TypeCb.Location = new Point(237, 219);
            TypeCb.Name = "TypeCb";
            TypeCb.Size = new Size(400, 40);
            TypeCb.TabIndex = 11;
            // 
            // TransactionDetailPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(718, 450);
            Controls.Add(TypeCb);
            Controls.Add(TransactionDtp);
            Controls.Add(GroupTb);
            Controls.Add(GroupLb);
            Controls.Add(TypeLb);
            Controls.Add(DateLb);
            Controls.Add(AmountTb);
            Controls.Add(AmountLb);
            Controls.Add(CancelBtn);
            Controls.Add(SaveBtn);
            Name = "TransactionDetailPage";
            Text = "TransactionDetail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveBtn;
        private Button CancelBtn;
        private Label AmountLb;
        private TextBox AmountTb;
        private Label DateLb;
        private TextBox GroupTb;
        private Label GroupLb;
        private Label TypeLb;
        private DateTimePicker TransactionDtp;
        private ComboBox TypeCb;
    }
}