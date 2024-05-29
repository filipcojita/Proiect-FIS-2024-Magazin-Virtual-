using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proiect_FIS
{
    public partial class AdminMenu : Form
    {
        private List<string> usersList;
        private List<string> applicantsList;

        public AdminMenu()
        {
            InitializeComponent();
            LoadUsers();
            LoadApplicants();
        }

        private void LoadUsers()
        {
            usersList = File.ReadAllLines("users.txt").ToList();
            lstUsers.Items.Clear();
            foreach (string user in usersList)
            {
                lstUsers.Items.Add(user);
            }
        }

        private void LoadApplicants()
        {
            applicantsList = File.ReadAllLines("cereri.txt").ToList();
            lstApplicants.Items.Clear();
            foreach (string applicant in applicantsList)
            {
                lstApplicants.Items.Add(applicant);
            }
        }

        private void Aprobare_btn_Click(object sender, EventArgs e)
        {
            string applicantName = txtApplicantName.Text.Trim();
            if (string.IsNullOrEmpty(applicantName))
            {
                MessageBox.Show("Introduceți numele aplicantului!");
                return;
            }

            bool found = false;
            for (int i = 0; i < applicantsList.Count; i++)
            {
                var parts = applicantsList[i].Split(',');
                if (parts[0].Trim() == applicantName)
                {
                    // Remove existing user entry if exists
                    RemoveUserIfExists(applicantName);

                    // Add the applicant to the users list with aprobat = true
                    usersList.Add($"{parts[0]},{parts[1]},true");
                    applicantsList.RemoveAt(i);
                    found = true;
                    break;
                }
            }

            if (found)
            {
                File.WriteAllLines("users.txt", usersList);
                File.WriteAllLines("cereri.txt", applicantsList);
                LoadUsers();
                LoadApplicants();
                MessageBox.Show("Aplicant aprobat!");
            }
            else
            {
                MessageBox.Show("Aplicantul nu a fost găsit!");
            }
        }

        private void Respinge_btn_Click(object sender, EventArgs e)
        {
            string applicantName = txtApplicantName.Text.Trim();
            if (string.IsNullOrEmpty(applicantName))
            {
                MessageBox.Show("Introduceți numele aplicantului!");
                return;
            }

            bool found = false;
            for (int i = 0; i < applicantsList.Count; i++)
            {
                var parts = applicantsList[i].Split(',');
                if (parts[0].Trim() == applicantName)
                {
                    // Remove existing user entry if exists
                    RemoveUserIfExists(applicantName);

                    // Add the applicant to the users list with aprobat = false
                    usersList.Add($"{parts[0]},{parts[1]},false");
                    applicantsList.RemoveAt(i);
                    found = true;
                    break;
                }
            }

            if (found)
            {
                File.WriteAllLines("users.txt", usersList);
                File.WriteAllLines("cereri.txt", applicantsList);
                LoadUsers();
                LoadApplicants();
                MessageBox.Show("Aplicantul a fost respins!");
            }
            else
            {
                MessageBox.Show("Aplicantul nu a fost găsit!");
            }
        }

        private void RemoveUserIfExists(string username)
        {
            for (int i = 0; i < usersList.Count; i++)
            {
                var parts = usersList[i].Split(',');
                if (parts[0].Trim() == username)
                {
                    usersList.RemoveAt(i);
                    break;
                }
            }
        }

        private void ANULEAZA_btn_Click(object sender, EventArgs e)
        {
            string applicantName = txtApplicantName.Text.Trim();
            if (string.IsNullOrEmpty(applicantName))
            {
                MessageBox.Show("Introduceți numele utilizatorului!");
                return;
            }

            bool found = false;
            for (int i = 0; i < usersList.Count; i++)
            {
                var parts = usersList[i].Split(',');
                if (parts[0].Trim() == applicantName)
                {
                    if (bool.Parse(parts[2].Trim()) == true) // Check if the user's status is true
                    {
                        // Update the user's status to false
                        usersList[i] = $"{parts[0]},{parts[1]},false";
                        found = true;
                        break;
                    }
                }
            }

            if (found)
            {
                File.WriteAllLines("users.txt", usersList);
                LoadUsers();
                LoadApplicants();
                MessageBox.Show("Contul a fost anulat!");
            }
            else
            {
                MessageBox.Show("Utilizatorul nu a fost găsit sau contul este deja anulat!");
            }
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Return_btn_Click(object sender, EventArgs e)
        {
            //inapoi la forma login
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
