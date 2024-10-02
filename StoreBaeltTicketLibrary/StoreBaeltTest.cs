using System;
using TicketClassLibrary; // Namespace from the DLL

namespace StoreBaeltTicketLibrary
{
    public class StoreBaeltTest
    {
        public void TestMethod()
        {
            Car car = new Car
            {
                Licenseplate = "SB12345",
                Date = DateTime.Now,
                BrobizzUsed = true
            };

            Console.WriteLine($"Vehicle Type: {car.VehicleType()}");
            Console.WriteLine($"Price: {car.Price()}");
        }
    }
}