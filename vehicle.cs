public abstract class Vehicle
{
    public string Model { get; private set; }
    public string Manufacturer { get; private set; }
    public int Year { get; private set; }
    public decimal RentalPrice { get; private set; }

    protected Vehicle(string model, string manufacturer, int year, decimal rentalPrice)
    {
        Model = model;
        Manufacturer = manufacturer;
        Year = year;
        RentalPrice = rentalPrice;
    }

    public abstract void DisplayDetails();
}
