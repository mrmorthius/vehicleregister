
public class Boat : Vehicle
{
    public double Length { get; set; }
    public double Width { get; set; }
    public int HorsePower { get; set; }

    public override void CreateVehicle()
    {
        base.CreateVehicle();
        Console.WriteLine("Lengde:  ");
        double length = VehicleService.isDouble();
        while (length <= 0) //Sjekker at lengden er større enn 0
        {
            Console.WriteLine("Lengden kan ikke være 0.");
            length = VehicleService.IsInt();
        }

        Console.WriteLine("Bredde:  ");
        double width = VehicleService.isDouble();
        while (width <= 0 || width >= length) //Sjekker at båten ikke er bredere enn lengden
        {
            if (width == 0)
            {
                Console.Write("Lengden kan ikke være 0. Prøv igjen: ");
                width = VehicleService.isDouble();
            }
            else
            {
                Console.Write("Bredden kan ikke være større eller lik lengden. Prøv igjen: ");
                width = VehicleService.isDouble();
            }
        }

        Console.WriteLine("Hestekrefter:  ");
        int horsePower = VehicleService.IsInt();
        while (horsePower == 0)
            horsePower = VehicleService.IsInt();

        Length = length;
        Width = width;
        HorsePower = horsePower;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Lengde: {Length}, Bredde: {Width}, HK:{HorsePower}");
    }
}