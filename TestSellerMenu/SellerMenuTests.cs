using NUnit.Framework;
using Moq;
using System.IO.Abstractions.TestingHelpers;
using System.IO.Abstractions;

namespace Proiect_FIS.Tests
{
    [TestFixture]
    public class TestSellerMenu
    {
        private SellerMenu sellerMenu;
        private Mock<IFileSystem> fileSystemMock;

        [SetUp]
        public void Setup()
        {
            fileSystemMock = new Mock<IFileSystem>();
            sellerMenu = new SellerMenu("test@example.com");
            sellerMenu.FileSystem = fileSystemMock.Object;
        }

        [Test]
        public void SetWelcomeMessage_CorrectMessage()
        {
            sellerMenu.SetWelcomeMessage();
            Assert.AreEqual("Welcome to SELLER MENU, test@example.com", sellerMenu.welcome_label.Text);
        }

        [Test]
        public void LoadProducts_NoProducts()
        {
            // Arrange
            fileSystemMock.Setup(fs => fs.File.ReadAllLines("produse.txt")).Returns(new string[] { });

            // Act
            sellerMenu.LoadProducts();

            // Assert
            Assert.AreEqual(1, sellerMenu.lstProducts.Items.Count);
            Assert.AreEqual("niciun produs de vanzare", sellerMenu.lstProducts.Items[0]);
        }

        [Test]
        public void LoadProducts_WithProducts()
        {
            // Arrange
            fileSystemMock.Setup(fs => fs.File.ReadAllLines("produse.txt")).Returns(new string[]
            {
                "1,Product A,100,SellerA,DescriptionA,False",
                "2,Product B,200,SellerB,DescriptionB,True,150"
            });

            // Act
            sellerMenu.LoadProducts();

            // Assert
            Assert.AreEqual(1, sellerMenu.lstProducts.Items.Count);
            Assert.AreEqual("ID: 1, Name: Product A, Price: 100, Description: DescriptionA", sellerMenu.lstProducts.Items[0]);
        }

        [Test]
        public void RemoveProduct_RemovesCorrectProduct()
        {
            // Arrange
            fileSystemMock.Setup(fs => fs.File.ReadAllLines("produse.txt")).Returns(new string[]
            {
                "1,Product A,100,SellerA,DescriptionA,False",
                "2,Product B,200,SellerB,DescriptionB,True,150"
            });

            // Act
            sellerMenu.RemoveProduct("1");

            // Assert
            fileSystemMock.Verify(fs => fs.File.WriteAllLines("produse.txt", It.Is<string[]>(lines => lines.Length == 1 && lines[0] == "2,Product B,200,SellerB,DescriptionB,True,150")));
        }
    }
}
