
public abstract class Vehicle
{
    public string PlateNumber { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int YearModel { get; set; }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine($"Kjøretøy: {PlateNumber}, {Brand}, {Model}, {YearModel}");

    }

    public void SetVehicleInfo()
    {
        Console.WriteLine("Skiltnummer: ");
        string plateNumber = Console.ReadLine();
        Console.WriteLine("Merke: ");
        string brand = Console.ReadLine();
        Console.WriteLine("Modell: ");
        string model = Console.ReadLine();
        Console.WriteLine("Årsmodell: ");
        int yearModel = VehicleService.IsInt();
        yearModel = VehicleService.IsInt();

        PlateNumber = plateNumber;
        Brand = brand;
        Model = model;
        YearModel = yearModel;
    }

    public static Child CreateChild<Child>() where Child : Vehicle, new()
    {
        Console.WriteLine("Skiltnummer: ");
        string plateNumber = Console.ReadLine();
        Console.WriteLine("Merke: ");
        string brand = Console.ReadLine();
        Console.WriteLine("Modell: ");
        string model = Console.ReadLine();
        Console.WriteLine("Årsmodell: ");
        int yearModel = VehicleService.IsInt();

        DateTime dt = DateTime.Now;
        int year = dt.Year;
        while (yearModel > year || yearModel < 1850)
        {
            if (yearModel > year)
            {
                Console.WriteLine($"{yearModel} er frem i tid. Prøv igjen: ");
                // input = Console.ReadLine();
                yearModel = VehicleService.IsInt();
            }
            else if (yearModel < 1850)
            {
                Console.WriteLine($"{yearModel} er før 1850. Prøv igjen: ");
                // input = Console.ReadLine();
                yearModel = VehicleService.IsInt();
            }
        }

        return new Child
        {
            PlateNumber = plateNumber,
            Brand = brand,
            Model = model,
            YearModel = yearModel
        };
    }
}