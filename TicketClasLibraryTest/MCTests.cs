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

    }
}