using System;

namespace VehicleManagementSystem
{
    public static class VehicleManagementSystem
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Vehicle Management System");

            RentalAgency agency = new RentalAgency(10);

            Truck truck1 = new Truck("F-150", "Ford", 2019, 100, 2000, "Pickup", true);
            Truck truck2 = new Truck("Silverado", "Chevrolet", 2018, 120, 2500, "Pickup", true);
            Car car1 = new Car("Civic", "Honda", 2017, 80, 5, "Sedan", "Automatic", false);
            Car car2 = new Car("Accord", "Honda", 2018, 90, 5, "Sedan", "Manual", false);

            agency.AddVehicle(truck1);
            agency.AddVehicle(truck2);
            agency.AddVehicle(car1);
            agency.AddVehicle(car2);

            agency.DisplayAllVehicles();

            Console.WriteLine("\nAfter Renting the Vehicles");
            agency.RentVehicle(truck1, 5);
            agency.RentVehicle(car1, 3);
            agency.RentVehicle(truck2, 2);
            agency.RentVehicle(car2, 4);

            Console.WriteLine($"Total Revenue: {agency.TotalRevenue:C}");

            agency.RemoveVehicle(truck1);
            agency.RemoveVehicle(car1);

            agency.DisplayAllVehicles();

            agency.RentVehicle(truck1, 5);
            agency.RentVehicle(car1, 3);

            Console.WriteLine($"Total Revenue: {agency.TotalRevenue:C}");
        }
    }
}
