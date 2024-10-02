using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using TicketClassLibrary;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass]
    public class StoreBaeltTicketRepositoryTests
    {
        [TestInitialize]
        public void TestInitialize()
        {
            // Clear the static list before each test
            var ticketsField = typeof(StoreBaeltTicketRepository).GetField("Tickets", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);
            var tickets = (List<Vehicle>)ticketsField.GetValue(null);
            tickets.Clear();
        }

        [TestMethod]
        public void AddTicket_AddsTicketToRepository()
        {
            // Arrange
            var repository = new StoreBaeltTicketRepository();
            var car = new StoreBaeltCar
            {
                Licenseplate = "ABC123",
                Date = DateTime.Now
            };

            // Act
            repository.AddTicket(car);
            var allTickets = repository.GetAllTickets();

            // Assert
            Assert.AreEqual(1, allTickets.Count);
            Assert.AreEqual(car, allTickets[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddTicket_NullTicket_ThrowsArgumentNullException()
        {
            // Arrange
            var repository = new StoreBaeltTicketRepository();

            // Act
            repository.AddTicket(null);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        public void GetAllTickets_ReturnsAllTickets()
        {
            // Arrange
            var repository = new StoreBaeltTicketRepository();
            var car1 = new StoreBaeltCar { Licenseplate = "ABC123", Date = DateTime.Now };
            var car2 = new StoreBaeltCar { Licenseplate = "DEF456", Date = DateTime.Now };
            repository.AddTicket(car1);
            repository.AddTicket(car2);

            // Act
            var allTickets = repository.GetAllTickets();

            // Assert
            Assert.AreEqual(2, allTickets.Count);
            CollectionAssert.Contains(allTickets, car1);
            CollectionAssert.Contains(allTickets, car2);
        }

        [TestMethod]
        public void GetTicketsByLicensePlate_ReturnsMatchingTickets()
        {
            // Arrange
            var repository = new StoreBaeltTicketRepository();
            var car1 = new StoreBaeltCar { Licenseplate = "ABC123", Date = DateTime.Now };
            var car2 = new StoreBaeltCar { Licenseplate = "DEF456", Date = DateTime.Now };
            var car3 = new StoreBaeltCar { Licenseplate = "abc123", Date = DateTime.Now };
            repository.AddTicket(car1);
            repository.AddTicket(car2);
            repository.AddTicket(car3);

            // Act
            var matchingTickets = repository.GetTicketsByLicensePlate("ABC123");

            // Assert
            Assert.AreEqual(2, matchingTickets.Count);
            CollectionAssert.Contains(matchingTickets, car1);
            CollectionAssert.Contains(matchingTickets, car3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetTicketsByLicensePlate_NullOrEmptyLicensePlate_ThrowsArgumentException()
        {
            // Arrange
            var repository = new StoreBaeltTicketRepository();

            // Act
            repository.GetTicketsByLicensePlate(null);

            // Assert is handled by ExpectedException
        }
    }
}
