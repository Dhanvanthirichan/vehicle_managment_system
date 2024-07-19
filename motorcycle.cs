public class Motorcycle : Vehicle
{
    public int EngineCapacity { get; set; }
    public string FuelType { get; set; }
    public bool HasFairing { get; set; }

    public Motorcycle(string model, string manufacturer, int year, decimal rentalPrice,
                      int engineCapacity, string fuelType, bool hasFairing)
        : base(model, manufacturer, year, rentalPrice)
    {
        EngineCapacity = engineCapacity;
        FuelType = fuelType;
        HasFairing = hasFairing;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Motorcycle: {Manufacturer} {Model} ({Year})");
        Console.WriteLine($"Rental Price: ${RentalPrice}/day");
        Console.WriteLine($"Engine Capacity: {EngineCapacity}cc, Fuel Type: {FuelType}");
        Console.WriteLine($"Has Fairing: {(HasFairing ? "Yes" : "No")}");
    }
}