using System;

namespace TicketClassLibrary
{
    /// <summary>
    /// Represents a car.
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Returns the price of the car ticket.
        /// </summary>
        /// <returns>The price of the car ticket.</returns>
        public override double Price()
        {
            double basePrice = 240;
            return ApplyBrobizzDiscount(basePrice);
        }

        /// <summary>
        /// Returns the type of the vehicle.
        /// </summary>
        /// <returns>A string indicating the vehicle type ("Car").</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}