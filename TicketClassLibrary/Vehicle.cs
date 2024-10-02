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

        /// <summary>
        /// Gets or sets a value indicating whether a Brobizz is used.
        /// </summary>
        public bool BrobizzUsed { get; set; }

        /// <summary>
        /// Applies a 5% discount to the price if Brobizz is used.
        /// </summary>
        /// <param name="price">The original price.</param>
        /// <returns>The price after applying the Brobizz discount.</returns>
        protected double ApplyBrobizzDiscount(double price)
        {
            if (BrobizzUsed)
                return price * 0.95; // Apply 5% discount
            else
                return price;
        }

    }
}