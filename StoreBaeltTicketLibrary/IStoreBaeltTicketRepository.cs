using System.Collections.Generic;
using TicketClassLibrary;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Interface for the Storebælt ticket repository.
    /// </summary>
    public interface IStoreBaeltTicketRepository
    {
        /// <summary>
        /// Adds a new ticket to the repository.
        /// </summary>
        /// <param name="ticket">The vehicle ticket to add.</param>
        void AddTicket(Vehicle ticket);

        /// <summary>
        /// Retrieves all tickets from the repository.
        /// </summary>
        /// <returns>A list of all vehicle tickets.</returns>
        List<Vehicle> GetAllTickets();

        /// <summary>
        /// Retrieves all tickets for a specified license plate.
        /// </summary>
        /// <param name="licensePlate">The license plate to search for.</param>
        /// <returns>A list of tickets matching the license plate.</returns>
        List<Vehicle> GetTicketsByLicensePlate(string licensePlate);
    }
}