using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using MySqlConnector;


namespace FinancialManagementSystem
{
    public partial class LoginPage : Form
    {
        private MySqlConnection connection = Program.database.GetConnection();
        public LoginPage()
        {
            InitializeComponent();
            CurrentUser.User = new User();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpPage page = new SignUpPage();
            page.Show();
            Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (CheckCredentials())
            {
                string username = txtUserName.Text;
                string password = txtPassword.Text;
                
                CurrentUser.User.Username = username;
                CurrentUser.User.Password = password;
                MainPage form = new MainPage();
                form.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Incorrect user name or password!", "Error", MessageBoxButtons.OK);
            }
        }

        private bool CheckCredentials()
        {
            try
            {
                string username = txtUserName.Text;
                string password = txtPassword.Text;
                string hashedPass = PasswordHasher.ComputeSha256Hash(password);
                string sql = $"""
                    SELECT USERID, EMAIL
                    FROM USERS
                    WHERE UNAME = '{username}'
                    AND PWHASH = '{hashedPass}';
                    """;

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CurrentUser.User.Id = reader.GetInt32(0);
                        CurrentUser.User.Email = reader.GetString(1);
                    }
                    return reader.HasRows;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in database", "Error", MessageBoxButtons.OK);
                return false;
            }
        }


        private void LoginPage_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
