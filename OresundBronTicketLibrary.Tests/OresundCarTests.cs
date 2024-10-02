using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBronTicketLibrary;
using System;

namespace OresundBronTicketLibrary.Tests
{
    [TestClass]
    public class OresundCarTests
    {
        [TestMethod]
        public void Price_WithoutBrobizz_Returns410()
        {
            // Arrange
            OresundCar car = new OresundCar
            {
                BrobizzUsed = false
            };

            // Act
            double price = car.Price();

            // Assert
            Assert.AreEqual(410, price, "Price without Brobizz should be 410 kr.");
        }

        [TestMethod]
        public void Price_WithBrobizz_Returns161()
        {
            // Arrange
            OresundCar car = new OresundCar
            {
                BrobizzUsed = true
            };

            // Act
            double price = car.Price();

            // Assert
            Assert.AreEqual(161, price, "Price with Brobizz should be 161 kr.");
        }

        [TestMethod]
        public void VehicleType_ReturnsOresundCar()
        {
            // Arrange
            OresundCar car = new OresundCar();

            // Act
            string vehicleType = car.VehicleType();

            // Assert
            Assert.AreEqual("Oresund car", vehicleType, "VehicleType should return 'Oresund car'.");
        }
    }
}