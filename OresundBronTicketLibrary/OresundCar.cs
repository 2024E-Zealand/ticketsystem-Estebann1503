using System;
using TicketClassLibrary; // Reference to the standard library

namespace OresundBronTicketLibrary
{
    /// <summary>
    /// Represents a car crossing the Øresund Bridge with specific pricing.
    /// </summary>
    public class OresundCar : Car
    {
        /// <summary>
        /// Returns the price for crossing the Øresund Bridge.
        /// </summary>
        /// <returns>The price for the car.</returns>
        public override double Price()
        {
            if (BrobizzUsed)
            {
                return 161;
            }
            else
            {
                return 410;
            }
        }

        /// <summary>
        /// Returns the vehicle type.
        /// </summary>
        /// <returns>A string indicating the vehicle type ("Oresund car").</returns>
        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}