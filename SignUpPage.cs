using FinancialManagementSystem;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

                if (VerifyUsername(userName) && VerifyEmail(email))
                {
                    try
                    {
                        Random random = new Random();
                        int code = random.Next(1000, 10000);

                        MailAddress to = new MailAddress(email);
                        MailAddress from = new MailAddress("test@test.test");
                        MailMessage message = new MailMessage(from, to);
                        message.Subject = "Verification code Finance System.";
                        message.Body = $"Here is verification code: <b>{code}</b>";
                        message.IsBodyHtml = true;

                        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                        smtp.EnableSsl = true;
                        NetworkCredential netCre = new NetworkCredential("applicationfinance4@gmail.com", "bemm vayb erbm gjmw");
                        smtp.Credentials = netCre;

                        try
                        {
                            smtp.Send(message);
                            User createdUser = new User();
                            createdUser.Username = userName;
                            createdUser.Email = email;
                            createdUser.Password = password;
                            VerificationForm verification = new VerificationForm(code, createdUser);
                            verification.Show();
                            Hide();
                            // Email sent successfully
                        }
                        catch (Exception ex)
                        {
                            // Handle any exceptions (e.g., unable to connect to the server)
                            Console.WriteLine(ex);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(" Error in Database Operation", "Error", MessageBoxButtons.OK);
                    }
                } else
                {
                    MessageBox.Show("User with this credentials already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private bool VerifyUsername(string userName)
        {
            string qStr = $"SELECT * FROM USERS WHERE UNAME = '{userName}';";
            MySqlCommand command = new MySqlCommand(qStr, connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                return !reader.HasRows;
            }
        }

        private bool VerifyEmail(string email)
        {
            string qStr = $"SELECT * FROM USERS WHERE EMAIL = '{email}';";
            MySqlCommand command = new MySqlCommand(qStr, connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                return !reader.HasRows;
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
