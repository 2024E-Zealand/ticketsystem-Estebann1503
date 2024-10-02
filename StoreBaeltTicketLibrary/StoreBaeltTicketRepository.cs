using System;
using System.Collections.Generic;
using TicketClassLibrary;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Repository for managing tickets at Storebælt bridge.
    /// </summary>
    public class StoreBaeltTicketRepository : IStoreBaeltTicketRepository
    {
        // Static list to hold all tickets
        private static readonly List<Vehicle> Tickets = new List<Vehicle>();

        /// <summary>
        /// Adds a new ticket to the repository.
        /// </summary>
        /// <param name="ticket">The vehicle ticket to add.</param>
        public void AddTicket(Vehicle ticket)
        {
            if (ticket == null)
                throw new ArgumentNullException(nameof(ticket), "Ticket cannot be null.");

            Tickets.Add(ticket);
        }

        /// <summary>
        /// Retrieves all tickets from the repository.
        /// </summary>
        /// <returns>A list of all vehicle tickets.</returns>
        public List<Vehicle> GetAllTickets()
        {
            // Return a copy to prevent external modification
            return new List<Vehicle>(Tickets);
        }

        /// <summary>
        /// Retrieves all tickets for a specified license plate.
        /// </summary>
        /// <param name="licensePlate">The license plate to search for.</param>
        /// <returns>A list of tickets matching the license plate.</returns>
        public List<Vehicle> GetTicketsByLicensePlate(string licensePlate)
        {
            if (string.IsNullOrWhiteSpace(licensePlate))
                throw new ArgumentException("License plate cannot be null or whitespace.", nameof(licensePlate));

            var matchingTickets = Tickets.FindAll(ticket =>
                ticket.Licenseplate.Equals(licensePlate, StringComparison.OrdinalIgnoreCase));

            return matchingTickets;
        }
    }
}