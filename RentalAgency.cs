using System;
using System.Collections.Generic;

public class RentalAgency
{
    private Vehicle[] Fleet;
    private int vehicleCount;
    public decimal TotalRevenue { get; private set; }

    public RentalAgency(int fleetSize)
    {
        Fleet = new Vehicle[fleetSize];
        vehicleCount = 0;
        TotalRevenue = 0;
    }

    public void AddVehicle(Vehicle vehicle)
    {
        if (vehicleCount < Fleet.Length)
        {
            Fleet[vehicleCount++] = vehicle;
        }
        else
        {
            Console.WriteLine("Fleet is full. Cannot add more vehicles.");
        }
    }

    public void RemoveVehicle(Vehicle vehicle)
    {
        for (int i = 0; i < vehicleCount; i++)
        {
            if (Fleet[i] == vehicle)
            {
                Fleet[i] = Fleet[--vehicleCount];
                Fleet[vehicleCount] = null;
                Console.WriteLine($"Removed {vehicle.Manufacturer} {vehicle.Model} from the fleet.");
                return;
            }
        }
        Console.WriteLine("Vehicle not found in the fleet.");
    }

    public void RentVehicle(Vehicle vehicle, int days)
    {
        foreach (var v in Fleet)
        {
            if (v == vehicle)
            {
                decimal rentalCost = vehicle.RentalPrice * days;
                TotalRevenue += rentalCost;
                Console.WriteLine($"Rented {vehicle.Manufacturer} {vehicle.Model} for {days} days. Cost: {rentalCost:C}");
                return;
            }
        }
        Console.WriteLine("Vehicle not found in the fleet.");
    }

    public void DisplayAllVehicles()
    {
        Console.WriteLine("Current Fleet:");
        for (int i = 0; i < vehicleCount; i++)
        {
            Fleet[i].DisplayDetails();
            Console.WriteLine();
        }
    }
}
