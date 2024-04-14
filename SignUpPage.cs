﻿using FinancialManagementSystem;
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

namespace EventManagementSystem
{
    public partial class SignUpPage : Form
    {
        private MySqlConnection connection = Program.database.GetConnection();


        // constructor for add new user
        public SignUpPage()
        {
            InitializeComponent();
            ConfigureVisibleElements();

        }

        // menubar actions
        private void viewEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void allUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            

        }

        // save button action
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

                /*if (actionType == ActionType.Edit)
                {
                    try
                    {
                        String qStr = $"UPDATE User SET Password = '{password}', Email = '{email}', WHERE UserName = '{userName}'";
                        MySqlCommand mySqlCommand = new MySqlCommand(qStr, connection);
                        mySqlCommand.ExecuteNonQuery();

                        MessageBox.Show(" User updated!!!", "Edit User", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(" Error in Database Operation", "Error", MessageBoxButtons.OK);
                    }
                }*/

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void myEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registForEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        // hide password
        private void UserDetail_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        // method to validate name is not empty and not exceed 30
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

 
      

        private void ConfigureVisibleElements()
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            Hide();
        }
    }
}
