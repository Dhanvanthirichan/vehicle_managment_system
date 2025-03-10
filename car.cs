public class Car : Vehicle
{
    public int Seats { get; private set; }
    public string EngineType { get; private set; }
    public string Transmission { get; private set; }
    public bool Convertible { get; private set; }

    public Car(string model, string manufacturer, int year, decimal rentalPrice, int seats, string engineType, string transmission, bool convertible)
        : base(model, manufacturer, year, rentalPrice)
    {
        Seats = seats;
        EngineType = engineType;
        Transmission = transmission;
        Convertible = convertible;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Model: {Model}, Manufacturer: {Manufacturer}, Year: {Year}, Rental Price: {RentalPrice:C}");
        Console.WriteLine($"Seats: {Seats}, Engine Type: {EngineType}, Transmission: {Transmission}, Convertible: {Convertible}");
    }
}
