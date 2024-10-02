using System;
using TicketClassLibrary;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Represents a car for Storebæltsbroen, with additional weekend discount.
    /// </summary>
    public class StoreBaeltCar : Car
    {
        /// <summary>
        /// Returns the price of the car ticket, applying weekend discount and Brobizz discount if applicable.
        /// </summary>
        /// <returns>The final price after discounts.</returns>
        public override double Price()
        {
            double basePrice = 240;

            // Check if the day is Saturday or Sunday
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                // Apply 20% weekend discount
                basePrice *= 0.80;
            }

            // Apply Brobizz discount if applicable
            return ApplyBrobizzDiscount(basePrice);
        }
    }
}