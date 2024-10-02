using System;

namespace TicketClassLibrary
{
    /// <summary>
    /// Represents a motorcycle (MC).
    /// </summary>
    public class MC : Vehicle
    {
        /// <summary>
        /// Returns the price of the motorcycle ticket.
        /// </summary>
        /// <returns>The price of the motorcycle ticket.</returns>
        public override double Price()
        {
            double basePrice = 125;
            return ApplyBrobizzDiscount(basePrice);
        }

        /// <summary>
        /// Returns the type of the vehicle.
        /// </summary>
        /// <returns>A string indicating the vehicle type ("MC").</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}