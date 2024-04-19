using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManagementSystem
{
    public partial class VerificationForm : Form
    {
        private int code;
        private int counter = 0;
        private User user;
        private MySqlConnection connection;
        public VerificationForm(int code, User user)
        {
            InitializeComponent();
            this.code = code;
            this.user = user;
            connection = Program.database.GetConnection();
        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            int inputCode;
            if (int.TryParse(CodeTb.Text, out inputCode))
            {
                if (code == inputCode)
                {
                    string hashedPassword = PasswordHasher.ComputeSha256Hash(user.Password);
                    String qStr = $"INSERT INTO USERS(UNAME, PWHASH, EMAIL) VALUES ('{user.Username}','{hashedPassword}','{user.Email}')";
                    MySqlCommand mySqlCommand = new MySqlCommand(qStr, connection);
                    mySqlCommand.ExecuteNonQuery();

                    MessageBox.Show(" New user added successfully!!!", "New User", MessageBoxButtons.OK);

                    LoginPage login = new LoginPage();
                    login.Show();
                    Hide();
                } else
                {
                    MessageBox.Show("Wrong code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (counter++ == 3)
                    {
                        MessageBox.Show("Too many wrong attempts", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LoginPage login = new LoginPage();
                        login.Show();
                        Hide();
                    }

                }
            } else
            {
                MessageBox.Show("Code should be a numerical value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
