﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void Vehicle_ReturnsMC()
        {
            // Arrange
            MC mc = new MC();

            // Act
            string vehicleType = mc.Vehicle();

            // Assert
            Assert.AreEqual("MC", vehicleType);
        }
    }
}