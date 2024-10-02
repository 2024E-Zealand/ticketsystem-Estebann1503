using System;

namespace TicketClassLibrary
{
    /// <summary>
    /// Represents a motorcycle with a license plate and a date.
    /// </summary>
    public class MC
    {
        /// <summary>
        /// Gets or sets the license plate of the motorcycle.
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// Gets or sets the date associated with the motorcycle.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Returns the fixed price of the motorcycle.
        /// </summary>
        /// <returns>The price of the motorcycle (125).</returns>
        public double Price()
        {
            return 125;
        }

        /// <summary>
        /// Returns the type of the vehicle.
        /// </summary>
        /// <returns>A string indicating the vehicle type ("MC").</returns>
        public string Vehicle()
        {
            return "MC";
        }
    }
}