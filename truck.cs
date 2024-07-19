public class Truck : Vehicle
{
    public int Capacity { get; set; }
    public string TruckType { get; set; }
    public bool FourWheelDrive { get; set; }

    public Truck(string model, string manufacturer, int year, decimal rentalPrice,
                 int capacity, string truckType, bool fourWheelDrive)
        : base(model, manufacturer, year, rentalPrice)
    {
        Capacity = capacity;
        TruckType = truckType;
        FourWheelDrive = fourWheelDrive;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Truck: {Manufacturer} {Model} ({Year})");
        Console.WriteLine($"Rental Price: ${RentalPrice}/day");
        Console.WriteLine($"Capacity: {Capacity} kg, Type: {TruckType}");
        Console.WriteLine($"Four Wheel Drive: {(FourWheelDrive ? "Yes" : "No")}");
    }
}