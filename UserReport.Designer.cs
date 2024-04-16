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
            dataGridView1 = new DataGridView();
            ImportBtn = new Button();
            GenerateBtn = new Button();
            BackBtn = new Button();
            CopyTranBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(415, 447);
            dataGridView1.TabIndex = 0;
            // 
            // ImportBtn
            // 
            ImportBtn.Location = new Point(496, 92);
            ImportBtn.Name = "ImportBtn";
            ImportBtn.Size = new Size(90, 36);
            ImportBtn.TabIndex = 1;
            ImportBtn.Text = "Import";
            ImportBtn.UseVisualStyleBackColor = true;
            ImportBtn.Click += ImportBtn_Click;
            // 
            // GenerateBtn
            // 
            GenerateBtn.Location = new Point(496, 134);
            GenerateBtn.Name = "GenerateBtn";
            GenerateBtn.Size = new Size(90, 42);
            GenerateBtn.TabIndex = 2;
            GenerateBtn.Text = "Generate";
            GenerateBtn.UseVisualStyleBackColor = true;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(501, 552);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(85, 38);
            BackBtn.TabIndex = 3;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // CopyTranBtn
            // 
            CopyTranBtn.Location = new Point(501, 489);
            CopyTranBtn.Name = "CopyTranBtn";
            CopyTranBtn.Size = new Size(90, 50);
            CopyTranBtn.TabIndex = 4;
            CopyTranBtn.Text = "Copy Transaction";
            CopyTranBtn.UseVisualStyleBackColor = true;
            // 
            // UserReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 602);
            Controls.Add(CopyTranBtn);
            Controls.Add(BackBtn);
            Controls.Add(GenerateBtn);
            Controls.Add(ImportBtn);
            Controls.Add(dataGridView1);
            Name = "UserReport";
            Text = "UserReport";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button ImportBtn;
        private Button GenerateBtn;
        private Button BackBtn;
        private Button CopyTranBtn;
    }
}