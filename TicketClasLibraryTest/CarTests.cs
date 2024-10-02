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

    }
}