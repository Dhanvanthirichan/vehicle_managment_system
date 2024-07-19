public class Truck : Vehicle
{
    public int Capacity { get; private set; }
    public string TruckType { get; private set; }
    public bool FourWheelDrive { get; private set; }

    public Truck(string model, string manufacturer, int year, decimal rentalPrice, int capacity, string truckType, bool fourWheelDrive)
        : base(model, manufacturer, year, rentalPrice)
    {
        Capacity = capacity;
        TruckType = truckType;
        FourWheelDrive = fourWheelDrive;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Model: {Model}, Manufacturer: {Manufacturer}, Year: {Year}, Rental Price: {RentalPrice:C}");
        Console.WriteLine($"Capacity: {Capacity}, Truck Type: {TruckType}, Four Wheel Drive: {FourWheelDrive}");
    }
}
