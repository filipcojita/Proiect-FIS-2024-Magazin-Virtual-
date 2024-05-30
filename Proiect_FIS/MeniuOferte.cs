using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_FIS
{
    public partial class MeniuOferte : Form
    {
        private string userEmail;
        private string password;
        private bool isSeller;

        public MeniuOferte(string userEmail, bool isSeller)
        {
            InitializeComponent();
            this.userEmail = userEmail;
            this.isSeller = isSeller;
            LoadProducts();
            if (isSeller)
            {
                LoadOffers();
            }
        }

        private void LoadProducts()
        {
            lstProducts.Items.Clear();
            string[] lines = File.ReadAllLines("produse.txt");

            foreach (string line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length >= 5 && bool.Parse(parts[5])) // If negotiable
                {
                    string productDetails = $"ID: {parts[0]}, Name: {parts[1]}, Price: {parts[2]}, Description: {parts[4]}";
                    if (parts[3].Trim() != userEmail || isSeller)
                    {
                        lstProducts.Items.Add(productDetails);
                    }
                }
            }

            if (lstProducts.Items.Count == 0)
            {
                lstProducts.Items.Add("Niciun produs negociabil disponibil");
            }
        }

        private void LoadOffers()
        {
            lstOffers.Items.Clear();
            string[] lines = File.ReadAllLines("oferte.txt");

            foreach (string line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length >= 3 && parts[1].Trim() == userEmail) // Offer for the seller
                {
                    lstOffers.Items.Add(line);
                }
            }

            if (lstOffers.Items.Count == 0)
            {
                lstOffers.Items.Add("Nicio oferta disponibilă");
            }
        }

        private void AcceptOffer_btn_Click_1(object sender, EventArgs e)
        {
            if (lstOffers.SelectedItem == null)
            {
                MessageBox.Show("Selectați o ofertă pentru a o accepta.");
                return;
            }

            string selectedOffer = lstOffers.SelectedItem.ToString();
            var parts = selectedOffer.Split(',');
            string productName = parts[0].Trim();
            string buyerEmail = parts[1].Trim();
            int offerPrice = int.Parse(parts[2].Trim());

            // Add the sale to istoricvanzari.txt
            string saleDetails = $"{productName}, {buyerEmail}, {offerPrice}";
            File.AppendAllText("istoricvanzari.txt", saleDetails + Environment.NewLine);

            // Remove the offer and product
            RemoveOffer(selectedOffer);
            RemoveProduct(productName);

            MessageBox.Show("Oferta a fost acceptată și produsul a fost vândut!");
            //refresh needed
            LoadProducts();
            LoadOffers();
        }

        private void DeclineOffer_btn_Click_1(object sender, EventArgs e)
        {
            if (lstOffers.SelectedItem == null)
            {
                MessageBox.Show("Selectați o ofertă pentru a o respinge.");
                return;
            }

            string selectedOffer = lstOffers.SelectedItem.ToString();

            RemoveOffer(selectedOffer);

            MessageBox.Show("Oferta a fost respinsă!");
            LoadOffers();
        }

        private void RemoveOffer(string offer)
        {
            string[] lines = File.ReadAllLines("oferte.txt");
            var updatedLines = new List<string>(lines);
            updatedLines.Remove(offer);
            File.WriteAllLines("oferte.txt", updatedLines);
        }

        private void RemoveProduct(string productName)
        {
            string[] lines = File.ReadAllLines("produse.txt");
            var updatedLines = new List<string>();

            foreach (string line in lines)
            {
                var parts = line.Split(',');
                if (parts[1].Trim() != productName)
                {
                    updatedLines.Add(line);
                }
            }

            File.WriteAllLines("produse.txt", updatedLines);
        }

        private void Return_btn_Click_1(object sender, EventArgs e)
        {
            if (isSeller)
            {
                SellerMenu sellerMenu = new SellerMenu(userEmail);
                sellerMenu.Show();
            }
            else
            {
                UserMenu userMenu = new UserMenu(true, userEmail, password);
                userMenu.Show();
            }
            this.Close();
        }
    }
}
