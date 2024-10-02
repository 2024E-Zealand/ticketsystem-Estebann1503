using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBronTicketLibrary;
using System;

namespace OresundBronTicketLibrary.Tests
{
    [TestClass]
    public class OresundMCTests
    {
        [TestMethod]
        public void Price_WithoutBrobizz_Returns210()
        {
            // Arrange
            OresundMC mc = new OresundMC
            {
                BrobizzUsed = false
            };

            // Act
            double price = mc.Price();

            // Assert
            Assert.AreEqual(210, price, "Price without Brobizz should be 210 kr.");
        }

        [TestMethod]
        public void Price_WithBrobizz_Returns73()
        {
            // Arrange
            OresundMC mc = new OresundMC
            {
                BrobizzUsed = true
            };

            // Act
            double price = mc.Price();

            // Assert

            Assert.AreEqual(73, price, "Price with Brobizz should be 73 kr.");
        }

        [TestMethod]
        public void VehicleType_ReturnsOresundMC()
        {
            // Arrange
            OresundMC mc = new OresundMC();

            // Act
            string vehicleType = mc.VehicleType();

            // Assert
            Assert.AreEqual("Oresund MC", vehicleType, "VehicleType should return 'Oresund MC'.");
        }
    }
}