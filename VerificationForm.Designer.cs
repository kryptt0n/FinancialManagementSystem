namespace FinancialManagementSystem
{
    partial class VerificationForm
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
            label1 = new Label();
            CodeTb = new TextBox();
            verifyBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(113, 186);
            label1.Name = "label1";
            label1.Size = new Size(125, 54);
            label1.TabIndex = 0;
            label1.Text = "Code:";
            // 
            // CodeTb
            // 
            CodeTb.Font = new Font("Segoe UI", 15F);
            CodeTb.Location = new Point(265, 183);
            CodeTb.Name = "CodeTb";
            CodeTb.Size = new Size(324, 61);
            CodeTb.TabIndex = 1;
            // 
            // verifyBtn
            // 
            verifyBtn.BackColor = Color.GreenYellow;
            verifyBtn.Font = new Font("Segoe UI", 12F);
            verifyBtn.Location = new Point(297, 322);
            verifyBtn.Name = "verifyBtn";
            verifyBtn.Size = new Size(202, 68);
            verifyBtn.TabIndex = 2;
            verifyBtn.Text = "Verify";
            verifyBtn.UseVisualStyleBackColor = false;
            verifyBtn.Click += verifyBtn_Click;
            // 
            // VerificationForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(800, 450);
            Controls.Add(verifyBtn);
            Controls.Add(CodeTb);
            Controls.Add(label1);
            Name = "VerificationForm";
            Text = "Verification";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox CodeTb;
        private Button verifyBtn;
    }
}