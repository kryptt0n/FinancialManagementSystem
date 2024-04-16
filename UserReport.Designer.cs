namespace FinancialManagementSystem
{
    partial class UserReport
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
            ((System.ComponentModel.ISupportInitialize)TransactionsGv).BeginInit();
            SuspendLayout();
            // 
            // TransactionsGv
            // 
            TransactionsGv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TransactionsGv.Location = new Point(71, 196);
            TransactionsGv.Margin = new Padding(6, 6, 6, 6);
            TransactionsGv.Name = "TransactionsGv";
            TransactionsGv.RowHeadersWidth = 82;
            TransactionsGv.Size = new Size(771, 954);
            TransactionsGv.TabIndex = 0;
            // 
            // ImportBtn
            // 
            ImportBtn.Location = new Point(921, 196);
            ImportBtn.Margin = new Padding(6, 6, 6, 6);
            ImportBtn.Name = "ImportBtn";
            ImportBtn.Size = new Size(167, 77);
            ImportBtn.TabIndex = 1;
            ImportBtn.Text = "Import";
            ImportBtn.UseVisualStyleBackColor = true;
            ImportBtn.Click += ImportBtn_Click;
            // 
            // GenerateBtn
            // 
            GenerateBtn.Location = new Point(921, 286);
            GenerateBtn.Margin = new Padding(6, 6, 6, 6);
            GenerateBtn.Name = "GenerateBtn";
            GenerateBtn.Size = new Size(167, 90);
            GenerateBtn.TabIndex = 2;
            GenerateBtn.Text = "Generate";
            GenerateBtn.UseVisualStyleBackColor = true;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(930, 1178);
            BackBtn.Margin = new Padding(6, 6, 6, 6);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(158, 81);
            BackBtn.TabIndex = 3;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // CopyTranBtn
            // 
            CopyTranBtn.Location = new Point(930, 1043);
            CopyTranBtn.Margin = new Padding(6, 6, 6, 6);
            CopyTranBtn.Name = "CopyTranBtn";
            CopyTranBtn.Size = new Size(167, 107);
            CopyTranBtn.TabIndex = 4;
            CopyTranBtn.Text = "Copy Transaction";
            CopyTranBtn.UseVisualStyleBackColor = true;
            // 
            // UserReport
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 1284);
            Controls.Add(CopyTranBtn);
            Controls.Add(BackBtn);
            Controls.Add(GenerateBtn);
            Controls.Add(ImportBtn);
            Controls.Add(TransactionsGv);
            Margin = new Padding(6, 6, 6, 6);
            Name = "UserReport";
            Text = "UserReport";
            ((System.ComponentModel.ISupportInitialize)TransactionsGv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TransactionsGv;
        private Button ImportBtn;
        private Button GenerateBtn;
        private Button BackBtn;
        private Button CopyTranBtn;
    }
}