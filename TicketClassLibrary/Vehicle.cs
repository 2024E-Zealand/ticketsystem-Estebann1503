using System;

namespace TicketClassLibrary
{
    /// <summary>
    /// Represents a general vehicle.
    /// </summary>
    public abstract class Vehicle
    {
        private string _licenseplate;

        /// <summary>
        /// Gets or sets the license plate of the vehicle.
        /// The license plate must not be longer than 7 characters.
        /// </summary>
        public string Licenseplate
        {
            get { return _licenseplate; }
            set
            {
                if (value.Length > 7)
                    throw new ArgumentException("License plate cannot be longer than 7 characters.");
                _licenseplate = value;
            }
        }

        /// <summary>
        /// Gets or sets the date associated with the vehicle.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Returns the price of the vehicle.
        /// </summary>
        /// <returns>The price of the vehicle.</returns>
        public abstract double Price();

        /// <summary>
        /// Returns the type of the vehicle.
        /// </summary>
        /// <returns>A string indicating the vehicle type.</returns>
        public abstract string VehicleType();
    }
}