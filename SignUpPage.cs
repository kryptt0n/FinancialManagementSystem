using FinancialManagementSystem;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinancialManagementSystem
{
    public partial class SignUpPage : Form
    {
        private MySqlConnection connection = Program.database.GetConnection();

        public SignUpPage()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            Hide();
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            // validate 
            if (NameValidate() && PassWordValidate() && EmailValidate())
            {
                // get field contents
                string userName = txtName.Text;
                string password = txtPassword.Text;
                string hashedPassword = PasswordHasher.ComputeSha256Hash(password);
                string email = txtEmail.Text;
                try
                {
                    String qStr = $"INSERT INTO USERS(UNAME, PWHASH, EMAIL) VALUES ('{userName}','{hashedPassword}','{email}')";
                    MySqlCommand mySqlCommand = new MySqlCommand(qStr, connection);
                    mySqlCommand.ExecuteNonQuery();

                    MessageBox.Show(" New user added successfully!!!", "New User", MessageBoxButtons.OK);

                    LoginPage login = new LoginPage();
                    login.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Error in Database Operation", "Error", MessageBoxButtons.OK);
                }
            }
        }

        // hide password
        private void UserDetail_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private bool NameValidate()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtName.Text.Length > 30)
            {
                MessageBox.Show("Name length can't exceed 30!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // method to validate password is not empty and at least 4
        private bool PassWordValidate()
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtPassword.Text.Length < 4)
            {
                MessageBox.Show("Password should be longer than 4!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

       

        // method to validate email follow the rule of email
        private bool EmailValidate()
        {
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                {
                    MessageBox.Show("Invalid email address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
    }
}
