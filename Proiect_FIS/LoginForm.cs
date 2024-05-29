using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proiect_FIS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var loginResult = AuthenticateUser(username, password);
            if (loginResult.Item1)
            {
                MessageBox.Show("Autentificare reușită!");

                if (username == "admin@email.com" && password == "admin")
                {
                    AdminMenu adminForm = new AdminMenu();
                    adminForm.Show();
                }
                else
                {
                    UserMenu userForm = new UserMenu(loginResult.Item2);
                    userForm.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Nume de utilizator sau parolă incorecte!");
            }
        }

        private Tuple<bool, bool> AuthenticateUser(string username, string password)
        {
            string[] lines = File.ReadAllLines("users.txt");
            foreach (string line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length == 3)
                {
                    string fileUsername = parts[0].Trim();
                    string filePassword = parts[1].Trim();
                    bool aprobat = bool.Parse(parts[2].Trim());
                    if (fileUsername == username && filePassword == password)
                    {
                        return Tuple.Create(true, aprobat);
                    }
                }
            }
            return Tuple.Create(false, false);
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignUp_btn_Click(object sender, EventArgs e)
        {
            SignUpForm signupform = new SignUpForm();
            signupform.Show();
        }
    }
}
