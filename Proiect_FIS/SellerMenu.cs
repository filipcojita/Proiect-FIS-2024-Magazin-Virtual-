using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Abstractions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_FIS
{
    public partial class SellerMenu : Form
    {
        private string userEmail;
        public IFileSystem FileSystem { get; set; } = new FileSystem(); // Default to real file system
        private string userPassword;

        public SellerMenu(string userEmail)
        {
            InitializeComponent();
            this.userEmail = userEmail;
            SetWelcomeMessage();
            LoadProducts();
        }

        public void SetWelcomeMessage()
        {
            welcome_label.Text = $"Welcome to SELLER MENU, {userEmail}";
        }

        public void LoadProducts()
        {
            lstProducts.Items.Clear();
            string[] lines = File.ReadAllLines("produse.txt");
            bool hasProducts = false;

            foreach (string line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length >= 5)
                {
                    string productSeller = parts[3].Trim();
                    if (productSeller == userEmail)
                    {
                        hasProducts = true;
                        string productDetails = $"ID: {parts[0]}, Name: {parts[1]}, Price: {parts[2]}, Description: {parts[4]}";
                        if (bool.Parse(parts[5])) // if negotiable, show min price
                        {
                            productDetails += $", Min Price: {parts[6]}";
                        }
                        lstProducts.Items.Add(productDetails);
                    }
                }
            }

            if (!hasProducts)
            {
                lstProducts.Items.Add("niciun produs de vanzare");
            }
        }

        private void Return_btn_Click_1(object sender, EventArgs e)
        {
            UserMenu userMenu = new UserMenu(true, userEmail, userPassword); // Assuming the user is approved
            userMenu.Show();
            this.Close();
        }

        private void Adaugare_btn_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm(userEmail);
            addProductForm.Show();
            this.Hide();
        }

        private void Anulare_btn_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedItem == null)
            {
                MessageBox.Show("Selectați un produs pentru a-l anula.");
                return;
            }

            // Parse the product ID from the selected item
            string selectedItem = lstProducts.SelectedItem.ToString();
            string productId = selectedItem.Split(',')[0].Split(':')[1].Trim();

            RemoveProduct(productId);
            LoadProducts(); // Reload the products after removal
        }

        public void RemoveProduct(string productId)
        {
            string[] lines = File.ReadAllLines("produse.txt");
            var updatedLines = new List<string>();

            foreach (string line in lines)
            {
                var parts = line.Split(',');
                if (parts[0].Trim() != productId)
                {
                    updatedLines.Add(line);
                }
            }

            File.WriteAllLines("produse.txt", updatedLines);
        }

        private void Oferte_btn_Click(object sender, EventArgs e)
        {
            MeniuOferte meniuOferte = new MeniuOferte(userEmail, true); // true indicates that the user is a seller
            meniuOferte.Show();
            this.Hide();
        }

    }
}
