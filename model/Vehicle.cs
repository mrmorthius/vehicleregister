
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

    public virtual void CreateVehicle()
    {
        //Legge til skiltnummer
        Console.WriteLine("Skiltnummer: ");
        string input = Console.ReadLine();
        while (input.Length <= 2 || input.Length > 8)
        {
            Console.Write("Lengden må være mellom 3-8 teng. Prøv igjen: ");
            input = Console.ReadLine();
        }
        string plateNumber = input;

        //Legge til merke 
        Console.WriteLine("Merke: ");
        input = Console.ReadLine();
        while (input.Length == 0)
        {
            Console.Write("Lengden kan ikke være tom. Prøv igjen: ");
            input = Console.ReadLine();
        }
        string brand = input;

        //Legge til modell
        Console.WriteLine("Modell: ");
        input = Console.ReadLine();
        while (input.Length == 0)
        {
            Console.Write("Lengden kan ikke være tom. Prøv igjen: ");
            input = Console.ReadLine();
        }
        string model = input;

        // Legge til årsmodell
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

        PlateNumber = plateNumber;
        Brand = brand;
        Model = model;
        YearModel = yearModel;
    }

    // Generisk metode som lager children med properties
    // public static Child CreateChild<Child>() where Child : Vehicle, new()
    // {
    //     Console.WriteLine("Skiltnummer: ");
    //     string plateNumber = Console.ReadLine();
    //     Console.WriteLine("Merke: ");
    //     string brand = Console.ReadLine();
    //     Console.WriteLine("Modell: ");
    //     string model = Console.ReadLine();
    //     Console.WriteLine("Årsmodell: ");
    //     int yearModel = VehicleService.IsInt();

    // //     DateTime dt = DateTime.Now;
    //     int year = dt.Year;
    //     while (yearModel > year || yearModel < 1850)
    //     {
    //         if (yearModel > year)
    //         {
    //             Console.WriteLine($"{yearModel} er frem i tid. Prøv igjen: ");
    //             // input = Console.ReadLine();
    //             yearModel = VehicleService.IsInt();
    //         }
    //         else if (yearModel < 1850)
    //         {
    //             Console.WriteLine($"{yearModel} er før 1850. Prøv igjen: ");
    //             // input = Console.ReadLine();
    //             yearModel = VehicleService.IsInt();
    //         }
    //     }

    //         return new Child
    //         {
    //             PlateNumber = plateNumber,
    //             Brand = brand,
    //             Model = model,
    //             YearModel = yearModel
    // };
}