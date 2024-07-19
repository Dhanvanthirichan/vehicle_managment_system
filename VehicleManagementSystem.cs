using System;

namespace VehicleManagmentSystem
{
    public static class VehicleManagementSystem
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Vehicle Management System");

            RentalAgency agency = new RentalAgency();

            Truck truck1 = new Truck("F-150", "Ford", 2019, 100, 2000, "Pickup", true);
            Truck truck2 = new Truck("Silverado", "Chevrolet", 2018, 120, 2500, "Pickup", true);
            Car car1 = new Car("Civic", "Honda", 2017, 80, 5, "Sedan", "Automatic", false);
            Car car2 = new Car("Accord", "Honda", 2018, 90, 5, "Sedan","Manual",  false);

            agency.AddVehicle(truck1);
            agency.AddVehicle(truck2);
            agency.AddVehicle(car1);
            agency.AddVehicle(car2);



        }
    }
}
