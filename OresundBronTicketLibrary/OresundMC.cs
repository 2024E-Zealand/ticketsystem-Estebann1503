using System;
using TicketClassLibrary; // Reference to the standard library

namespace OresundBronTicketLibrary
{
    /// <summary>
    /// Represents a motorcycle crossing the Øresund Bridge with specific pricing.
    /// </summary>
    public class OresundMC : MC
    {
        /// <summary>
        /// Returns the price for crossing the Øresund Bridge.
        /// </summary>
        /// <returns>The price for the motorcycle.</returns>
        public override double Price()
        {
            if (BrobizzUsed)
            {
                return 73;
            }
            else
            {
                return 210;
            }
        }

        /// <summary>
        /// Returns the vehicle type.
        /// </summary>
        /// <returns>A string indicating the vehicle type ("Oresund MC").</returns>
        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}