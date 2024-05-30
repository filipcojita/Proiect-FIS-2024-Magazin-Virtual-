using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.IO.Abstractions;
using System.Windows.Forms;
using Proiect_FIS;

namespace Proiect_FIS.Tests
{
    [TestClass]
    public class SellerMenuTests
    {
        private SellerMenu sellerMenu;
        private ListBox lstProducts; // Declare a ListBox variable

        [TestInitialize]
        public void Setup()
        {
            // Instantiate SellerMenu and assign lstProducts to the accessor property
            sellerMenu = new SellerMenu("test@example.com");
            lstProducts = sellerMenu.LstProductsAccessor;
        }

        // Write your tests using lstProducts variable
    }

}
