using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Proiect_FIS
{
    public partial class UserMenu : Form
    {
        private bool isApproved;
        private string userEmail;
        private string userPassword;

        public UserMenu(bool isApproved, string userEmail, string password)
        {
            InitializeComponent();
            this.isApproved = isApproved;
            this.userEmail = userEmail;
            this.userPassword = password;
            CheckApprovalStatus();
            SetWelcomeMessage();
            LoadAvailableProducts();
        }

        private void CheckApprovalStatus()
        {
            if (isApproved)
            {
                approvalStatusLabel.Text = "Contul dvs. este aprobat. Aveți acces la meniu vânzător.";
            }
            else
            {
                approvalStatusLabel.Text = "Nu dețineți un cont de vânzător aprobat.";
            }
        }

        private void SetWelcomeMessage()
        {
            welcome_label.Text = $"Bun venit în magazinul virtual, {userEmail}!";
        }

        private void LoadAvailableProducts()
        {
            lstProduse.Items.Clear();
            string[] lines = File.ReadAllLines("produse.txt");

            bool hasProducts = false;
            foreach (string line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length >= 5)
                {
                    hasProducts = true;
                    string productName = parts[1];
                    string productPrice = parts[2];
                    string productDescription = parts[4];
                    string productDetails = $"Nume: {productName}, Preț: {productPrice}";

                    if (bool.Parse(parts[5]))
                    {
                        productDetails += ", Negociabil";
                    }

                    productDetails += $", Descriere: {productDescription}";

                    lstProduse.Items.Add(productDetails);
                }
            }

            if (!hasProducts)
            {
                lstProduse.Items.Add("Nu există produse disponibile.");
            }
        }


        private void MeniuVanzator_btn_Click(object sender, EventArgs e)
        {
            if (isApproved)
            {//are voie (e vanzator aprobat)
                SellerMenu sellerMenu = new SellerMenu(userEmail);
                sellerMenu.Show();
                this.Hide();
            }
            else
            {//nu are voie
                MessageBox.Show("Nu aveți acces la această funcționalitate. Aplicați pentru un cont de vânzător pentru a vinde produse!");
            }
        }

        //FUNCTIONALITATEA CUMPARARE
        private void Cumpara_btn_Click_1(object sender, EventArgs e)
        {
            if (lstProduse.SelectedItem != null)
            {
                string selectedProduct = lstProduse.SelectedItem.ToString();

                //confirmare cumparare
                DialogResult result = MessageBox.Show($"Sunteți sigur că doriți să cumpărați următorul produs?\n\n{selectedProduct}", "Confirmare Cumpărare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    //gaseste index produs selectat
                    int selectedIndex = lstProduse.SelectedIndex;

                    // Asigură ștergerea ofertelor legate de produsul cumpărat
                    RemoveProductOffers(selectedProduct);

                    // Adăugare în istoricul vânzărilor
                    AdaugaInIstoric(selectedProduct);

                    //sterge din fisier
                    RemoveProductFromFile(selectedIndex);

                    //mesaj cumparare cu succes
                    string productName = selectedProduct.Split(',')[0].Split(':')[1].Trim();
                    MessageBox.Show($"Ați cumpărat cu succes produsul '{productName}'!");

                    //refresh lista
                    LoadAvailableProducts();
                }
            }
            else
            {
                MessageBox.Show("Vă rugăm să selectați un produs înainte de a încerca să cumpărați.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdaugaInIstoric(string selectedProduct)
        {
            try
            {
                // Extrage informațiile despre produsul cumpărat
                string productName = selectedProduct.Split(',')[0].Split(':')[1].Trim();
                string productPrice = selectedProduct.Split(',')[1].Split(':')[1].Trim(); // Presupunând că prețul este al doilea element din detalii
                string buyer = userEmail; // Utilizatorul curent este cumpărătorul

                // Concatenează informațiile într-o linie
                string saleRecord = $"{productName}, {productPrice}, {buyer}";

                // Adaugă linia în fișierul istoricvanzari.txt
                File.AppendAllText("istoricvanzari.txt", saleRecord + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la adăugarea în istoricul vânzărilor: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveProductFromFile(int index)
        {
            try
            {
                List<string> lines = File.ReadAllLines("produse.txt").ToList();
                if (index >= 0 && index < lines.Count)
                {
                    lines.RemoveAt(index);
                    File.WriteAllLines("produse.txt", lines);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la ștergerea produsului: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveProductOffers(string selectedProduct)
        {
            try
            {
                string productName = selectedProduct.Split(',')[0].Split(':')[1].Trim();

                // Caută și șterge ofertele legate de produsul cumpărat
                List<string> lines = File.ReadAllLines("oferte.txt").ToList();
                List<string> updatedLines = new List<string>();

                foreach (string line in lines)
                {
                    if (!line.Contains(productName))
                    {
                        updatedLines.Add(line);
                    }
                }

                File.WriteAllLines("oferte.txt", updatedLines);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la ștergerea ofertelor: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //pentru ca lista nu afiseaza si pretul minim sau id-ul, trebuie sa accesam fisierul, asa ca trebuie sa-i facem parse complet
        private void Oferta_btn_Click(object sender, EventArgs e)
        {
            if (lstProduse.SelectedItem != null)
            {
                string selectedProduct = lstProduse.SelectedItem.ToString();
                string productName = selectedProduct.Split(',')[0].Split(':')[1].Trim();

                if (selectedProduct.Contains("Negociabil"))
                {
                    // Check if a valid number is entered
                    if (int.TryParse(Oferta_txt.Text, out int offerPrice))
                    {
                        // Read the produse.txt file and search for the product
                        string[] lines = File.ReadAllLines("produse.txt");
                        foreach (string line in lines)
                        {
                            string[] parts = line.Split(',');
                            if (parts.Length >= 5 && parts[1].Trim() == productName)
                            {
                                // Found the product, extract the minimum price
                                int minPrice = int.Parse(parts[6]); // Assuming minPrice is the 7th part
                                                                    // Check if the offer price is greater than or equal to the minimum price
                                if (offerPrice >= minPrice)
                                {
                                    // Write the offer to oferte.txt
                                    string offerDetails = $"{productName}, {userEmail}, {offerPrice}";
                                    File.AppendAllText("oferte.txt", offerDetails + Environment.NewLine);
                                    MessageBox.Show("Oferta a fost înregistrată cu succes!");
                                }
                                else
                                {
                                    MessageBox.Show("Prețul ofertei este mai mic decât prețul minim negociabil.");
                                }
                                return; // Exit loop after finding the product
                            }
                        }
                        MessageBox.Show("Produsul nu a fost găsit în baza de date.");
                    }
                    else
                    {
                        MessageBox.Show("Vă rugăm să introduceți un număr valid în câmpul de ofertă.");
                    }
                }
                else
                {
                    MessageBox.Show("Acest produs nu este negociabil.");
                }
            }
            else
            {
                MessageBox.Show("Vă rugăm să selectați un produs înainte de a face o ofertă.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Solicitare_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Load users list
                List<string> usersList = File.ReadAllLines("users.txt").ToList();

                // Check if the user already has a verified seller account
                bool alreadyVerified = usersList.Any(user =>
                {
                    var parts = user.Split(',');
                    return parts[0].Trim() == userEmail && bool.Parse(parts[2].Trim()) == true;
                });

                if (alreadyVerified)
                {
                    MessageBox.Show("Cont deja activ");
                    return;
                }

                // Add new request to cereri.txt
                string newRequest = $"{userEmail},{userPassword}"; // Include password in the new request
                File.AppendAllText("cereri.txt", newRequest + Environment.NewLine);

                MessageBox.Show("Solicitare efectuată");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare: {ex.Message}");
            }
        }
    }
}
