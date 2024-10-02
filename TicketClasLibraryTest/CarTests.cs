using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicketClassLibrary;

namespace TicketClassLibrary.Tests
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void Price_ReturnsFixedPrice240()
        {
            // Arrange
            var car = new Car();

            // Act
            double result = car.Price();

            // Assert
            Assert.AreEqual(240, result);
        }

        [TestMethod]
        public void VehicleType_ReturnsCar()
        {
            // Arrange
            var car = new Car();

            // Act
            string result = car.VehicleType();

            // Assert
            Assert.AreEqual("Car", result);
        }
        [TestMethod]
        public void Licenseplate_WhenLongerThan7Characters_ThrowsArgumentException()
        {
            // Arrange
            Car car = new Car();

            // Act & Assert
            var exception = Assert.ThrowsException<ArgumentException>(() =>
            {
                car.Licenseplate = "ABCDEFGH"; // 8 characters
            });

            // Optionally, verify the exception message
            Assert.AreEqual("License plate cannot be longer than 7 characters.", exception.Message);
        }

        [TestMethod]
        public void Licenseplate_When7CharactersOrLess_DoesNotThrowException()
        {
            // Arrange
            Car car = new Car();
            string validLicensePlate = "ABC1234"; // 7 characters

            // Act
            car.Licenseplate = validLicensePlate;

            // Assert
            Assert.AreEqual(validLicensePlate, car.Licenseplate);
        }

        [TestMethod]
        public void Price_WithBrobizz_ReturnsDiscountedPrice()
        {
            // Arrange
            Car car = new Car();
            car.BrobizzUsed = true;

            // Act
            double price = car.Price();

            // Assert
            double expectedPrice = 240 * 0.95;
            double delta = 0.001;
            Assert.AreEqual(expectedPrice, price, delta, "Price with Brobizz discount is incorrect.");
        }

        [TestMethod]
        public void Price_WithoutBrobizz_ReturnsFullPrice()
        {
            // Arrange
            Car car = new Car();
            car.BrobizzUsed = false;

            // Act
            double price = car.Price();

            // Assert
            double expectedPrice = 240;
            Assert.AreEqual(expectedPrice, price, "Price without Brobizz discount should be full price.");
        }


    }
}