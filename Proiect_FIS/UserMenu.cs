using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_FIS
{
    public partial class UserMenu : Form
    {
        private bool isApproved;

        public UserMenu(bool isApproved)
        {
            InitializeComponent();
            this.isApproved = isApproved;
            CheckApprovalStatus();
        }

        private void CheckApprovalStatus()
        {
            if (isApproved)
            {
                approvalStatusLabel.Text = "Contul dvs. este aprobat. Aveți acces la meniu vanzator";
            }
            else
            {
                approvalStatusLabel.Text = "Nu detineti un cont de vanzator aprobat";
            }
        }


        private void MeniuVanzator_btn_Click(object sender, EventArgs e)
        {
            if (isApproved)
            {
                // Allow access to the restricted feature
                SellerMenu sellermenu = new SellerMenu();
                sellermenu.Show();
            }
            else
            {
                // Deny access to the restricted feature
                MessageBox.Show("Nu aveți acces la această funcționalitate. Aplicati pentru un cont de vanzator pentru a vinde produse!");
            }
        }

        private void Return_btn_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void Exit_btn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
