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
    }
}