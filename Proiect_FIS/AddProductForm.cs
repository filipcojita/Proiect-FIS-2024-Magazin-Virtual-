using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_FIS
{
    public partial class AddProductForm : Form
    {
        private string userEmail;

        public AddProductForm(string userEmail)
        {
            InitializeComponent();
            this.userEmail = userEmail;
            SetWelcomeMessage();
        }

        private void SetWelcomeMessage()
        {
            welcome_label.Text = $"Add a new product, {userEmail}";
        }

        private void Salvare_btn_Click(object sender, EventArgs e)
        {
            string nume = nume_txt.Text.Trim();
            string pretText = pret_txt.Text.Trim();
            string descriere = descriere_txt.Text.Trim();
            bool negociabil = negociabil_check.Checked;
            string pretMinimText = pretminim_txt.Text.Trim();

            if (string.IsNullOrEmpty(nume) || string.IsNullOrEmpty(pretText) || string.IsNullOrEmpty(descriere))
            {
                MessageBox.Show("Toate câmpurile sunt obligatorii, cu excepția prețului minim dacă produsul nu este negociabil!");
                return;
            }

            if (!decimal.TryParse(pretText, out decimal pret))
            {
                MessageBox.Show("Prețul trebuie să fie un număr valid!");
                return;
            }

            decimal? pretMinim = null;
            if (negociabil)
            {
                if (string.IsNullOrEmpty(pretMinimText) || !decimal.TryParse(pretMinimText, out decimal pretMinimValue))
                {
                    MessageBox.Show("Prețul minim trebuie să fie un număr valid!");
                    return;
                }
                if (pretMinimValue > pret)
                {
                    MessageBox.Show("Prețul minim nu poate fi mai mare decât prețul!");
                    return;
                }
                pretMinim = pretMinimValue;
            }

            int newId = GetNewProductId();
            Product product = new Product
            {
                Id = newId,
                Nume = nume,
                Pret = pret,
                Vanzator = userEmail,
                Descriere = descriere,
                Negociabil = negociabil,
                PretMinim = pretMinim
            };

            SaveProduct(product);
            MessageBox.Show("Produs salvat cu succes!");
            ReturnToSellerMenu();
        }

        private int GetNewProductId()
        {
            if (!File.Exists("produse.txt"))
            {
                return 1;
            }

            string[] lines = File.ReadAllLines("produse.txt");
            if (lines.Length == 0)
            {
                return 1;
            }

            int lastId = lines.Select(line => int.Parse(line.Split(',')[0])).Max();
            return lastId + 1;
        }

        private void SaveProduct(Product product)
        {
            using (StreamWriter sw = new StreamWriter("produse.txt", true))
            {
                if (product.Negociabil)
                {
                    sw.WriteLine($"{product.Id},{product.Nume},{product.Pret},{product.Vanzator},{product.Descriere},{product.Negociabil},{product.PretMinim}");
                }
                else
                {
                    sw.WriteLine($"{product.Id},{product.Nume},{product.Pret},{product.Vanzator},{product.Descriere},{product.Negociabil}");
                }
            }
        }


        private void ReturnToSellerMenu()
        {
            SellerMenu sellerMenu = new SellerMenu(userEmail);
            sellerMenu.Show();
            this.Close();
        }

        private void Return_btn_Click_1(object sender, EventArgs e)
        {
            ReturnToSellerMenu();
        }
    }
}
