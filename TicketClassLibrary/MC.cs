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
        /// <returns>The price of the motorcycle ticket (125).</returns>
        public override double Price()
        {
            return 125;
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