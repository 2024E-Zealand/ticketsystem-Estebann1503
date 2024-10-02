using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;

namespace TicketClassLibrary.Tests
{
    [TestClass]
    public class MCTests
    {
        [TestMethod]
        public void Price_ReturnsFixedPrice125()
        {
            // Arrange
            MC mc = new MC();

            // Act
            double price = mc.Price();

            // Assert
            Assert.AreEqual(125, price);
        }

        [TestMethod]
        public void VehicleType_ReturnsMC()
        {
            // Arrange
            MC mc = new MC();

            // Act
            string vehicleType = mc.VehicleType();

            // Assert
            Assert.AreEqual("MC", vehicleType);

        }

        [TestMethod]
        public void Licenseplate_WhenLongerThan7Characters_ThrowsArgumentException()
        {
            // Arrange
            MC mc = new MC();

            // Act & Assert
            var exception = Assert.ThrowsException<ArgumentException>(() =>
            {
                mc.Licenseplate = "ABCDEFGH"; // 8 characters
            });

            // Optionally, verify the exception message
            Assert.AreEqual("License plate cannot be longer than 7 characters.", exception.Message);
        }

        [TestMethod]
        public void Licenseplate_When7CharactersOrLess_DoesNotThrowException()
        {
            // Arrange
            MC mc = new MC();
            string validLicensePlate = "ABC1234"; // 7 characters

            // Act
            mc.Licenseplate = validLicensePlate;

            // Assert
            Assert.AreEqual(validLicensePlate, mc.Licenseplate);
        }

        
        [TestMethod]
        public void Price_WithBrobizz_ReturnsDiscountedPrice()
        {
            // Arrange
            MC mc = new MC();
            mc.BrobizzUsed = true;

            // Act
            double price = mc.Price();

            // Assert
            double expectedPrice = 125 * 0.95;
            double delta = 0.001;
            Assert.AreEqual(expectedPrice, price, delta, "Price with Brobizz discount is incorrect.");
        }

        [TestMethod]
        public void Price_WithoutBrobizz_ReturnsFullPrice()
        {
            // Arrange
            MC mc = new MC();
            mc.BrobizzUsed = false;

            // Act
            double price = mc.Price();

            // Assert
            double expectedPrice = 125;
            Assert.AreEqual(expectedPrice, price, "Price without Brobizz discount should be full price.");
        }


    }
}