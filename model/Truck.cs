
public class Truck : Vehicle
{
    public int LoadCapacity { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Lastekapasitet: {LoadCapacity}");
    }
    public override void CreateVehicle()
    {
        base.CreateVehicle();
        Console.WriteLine("Lastekapasitet: ");
        int loadCapacity = VehicleService.IsInt();
        LoadCapacity = loadCapacity;
    }
}