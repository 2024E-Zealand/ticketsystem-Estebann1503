using System;

namespace TicketClassLibrary
{
    /// <summary>
    /// Represents a car with a license plate and a date.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Gets or sets the license plate of the car.
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// Gets or sets the date associated with the car.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Returns the fixed price of the car.
        /// </summary>
        /// <returns>The price of the car (240).</returns>
        public double Price()
        {
            return 240;
        }

        /// <summary>
        /// Returns the type of the vehicle.
        /// </summary>
        /// <returns>A string indicating the vehicle type ("Car").</returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}