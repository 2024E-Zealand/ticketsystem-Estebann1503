using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass]
    public class StoreBaeltCarTests
    {
        [TestMethod]
        public void Price_WeekendWithoutBrobizz_ReturnsPriceWithWeekendDiscount()
        {
            // Arrange
            StoreBaeltCar car = new StoreBaeltCar
            {
                Date = new DateTime(2023, 10, 7), // Saturday
                BrobizzUsed = false
            };

            // Act
            double price = car.Price();

            // Assert
            double expectedPrice = 240 * 0.80; // 20% discount
            Assert.AreEqual(expectedPrice, price, 0.01, "Price should have a 20% weekend discount without Brobizz.");
        }

        [TestMethod]
        public void Price_WeekendWithBrobizz_ReturnsPriceWithWeekendAndBrobizzDiscount()
        {
            // Arrange
            StoreBaeltCar car = new StoreBaeltCar
            {
                Date = new DateTime(2023, 10, 8), // Sunday
                BrobizzUsed = true
            };

            // Act
            double price = car.Price();

            // Assert
            double expectedPrice = 240 * 0.80 * 0.95; // 20% weekend discount, then 5% Brobizz discount
            Assert.AreEqual(expectedPrice, price, 0.01, "Price should have both 20% weekend and 5% Brobizz discounts.");
        }

        [TestMethod]
        public void Price_WeekdayWithBrobizz_ReturnsPriceWithBrobizzDiscountOnly()
        {
            // Arrange
            StoreBaeltCar car = new StoreBaeltCar
            {
                Date = new DateTime(2023, 10, 6), // Friday
                BrobizzUsed = true
            };

            // Act
            double price = car.Price();

            // Assert
            double expectedPrice = 240 * 0.95; // Only 5% Brobizz discount
            Assert.AreEqual(expectedPrice, price, 0.01, "Price should have a 5% Brobizz discount only.");
        }

        [TestMethod]
        public void Price_WeekdayWithoutBrobizz_ReturnsFullPrice()
        {
            // Arrange
            StoreBaeltCar car = new StoreBaeltCar
            {
                Date = new DateTime(2023, 10, 5), // Thursday
                BrobizzUsed = false
            };

            // Act
            double price = car.Price();

            // Assert
            double expectedPrice = 240; // No discounts
            Assert.AreEqual(expectedPrice, price, 0.01, "Price should be full price with no discounts.");
        }
    }
}
