using System.Linq;
using eLoopV2.Models;

namespace eLoopV2.Data
{
    public static class DbInitializer
    {
        public static void Seed(ElectricCarLeaseContext context)
        {
            // Checks if the database already has any ElectricCar data
            if (context.ElectricCars.Any())
            {
                return;   // Database has already been seeded
            }

            //Location data
            var locations = new Location[]
            {
                new Location { Name = "San Francisco" },
                new Location { Name = "Los Angeles" },
                new Location { Name = "New York" }
            };

            context.ElectricCarLocations.AddRange(locations);

            //ElectricCar data with locations
            var electricCars = new ElectricCar[]
            {
                new ElectricCar { Make = "Tesla", Model = "Model S", Year = 2020, Color = "Red", VIN = "1GNEK13R7YJ148928", BatteryCapacity = 85, ChargingTime = 10, PlateNumber = "ABC-123", IsAvailable = true, Location = locations[0] },
                new ElectricCar { Make = "Nissan", Model = "Leaf", Year = 2019, Color = "Blue", VIN = "2GNEK13R7YJ148929", BatteryCapacity = 50, ChargingTime = 8, PlateNumber = "DEF-456", IsAvailable = true, Location = locations[1] },
                new ElectricCar { Make = "BMW", Model = "i3", Year = 2021, Color = "Black", VIN = "3GNEK13R7YJ148930", BatteryCapacity = 60, ChargingTime = 12, PlateNumber = "GHI-789", IsAvailable = false, Location = locations[2] },
                new ElectricCar { Make = "Chevrolet", Model = "Bolt", Year = 2018, Color = "Green", VIN = "4GNEK13R7YJ148931", BatteryCapacity = 70, ChargingTime = 11, PlateNumber = "JKL-012", IsAvailable = true, Location = locations[0] },
                new ElectricCar { Make = "Ford", Model = "Mustang Mach-E", Year = 2022, Color = "Yellow", VIN = "5GNEK13R7YJ148932", BatteryCapacity = 75, ChargingTime = 9, PlateNumber = "MNO-345", IsAvailable = false, Location = locations[1] }
            };

            context.ElectricCars.AddRange(electricCars);
            context.SaveChanges();
        }

    }
}
