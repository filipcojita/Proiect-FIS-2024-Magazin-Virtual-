using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proiect_FIS
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUp_btn_Click(object sender, EventArgs e)
        {
            string email = email_txt.Text.Trim();
            string password = password_txt.Text.Trim();
            string confirmPassword = confirmpassword_txt.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Toate câmpurile trebuie completate!");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Parolele nu se potrivesc!");
                return;
            }

            if (IsEmailAlreadyRegistered(email))
            {
                MessageBox.Show("Acest email este deja înregistrat!");
                return;
            }

            SaveNewUser(email, password);
            MessageBox.Show("Cont creat cu succes!");
            ReturnToLoginForm();
        }

        private void Return_btn_Click(object sender, EventArgs e)
        {
            ReturnToLoginForm();
        }

        private bool IsEmailAlreadyRegistered(string email)
        {
            if (!File.Exists("users.txt"))
            {
                return false;
            }

            string[] users = File.ReadAllLines("users.txt");
            foreach (string user in users)
            {
                var parts = user.Split(',');
                if (parts[0].Trim() == email)
                {
                    return true;
                }
            }
            return false;
        }

        private void SaveNewUser(string email, string password)
        {
            using (StreamWriter sw = new StreamWriter("users.txt", true))
            {
                sw.WriteLine($"{email},{password},false");
            }
        }

        private void SignUpSeller_btn_Click(object sender, EventArgs e)
        {
            string email = email_txt.Text.Trim();
            string password = password_txt.Text.Trim();
            string confirmPassword = confirmpassword_txt.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Toate câmpurile trebuie completate!");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Parolele nu se potrivesc!");
                return;
            }

            if (IsEmailAlreadyRegistered(email))
            {
                MessageBox.Show("Acest email este deja înregistrat!");
                return;
            }

            SaveSellerApplication(email, password);
            MessageBox.Show("Cererea dvs. a fost trimisă pentru aprobare de către admin.");
            ReturnToLoginForm();
        }

        private void SaveSellerApplication(string email, string password)
        {
            using (StreamWriter sw = new StreamWriter("cereri.txt", true))
            {
                sw.WriteLine($"{email},{password},false");
            }
        }

        private void ReturnToLoginForm()
        {
            this.Close();
        }
    }
}
