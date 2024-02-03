
public class Truck : Vehicle
{
    public int LoadCapacity { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Lastekapasitet: {LoadCapacity}");
    }
    public static Truck ExtraInfo(Truck truck)
    {
        Console.WriteLine("Lastekapasitet: ");
        int loadCapacity = VehicleService.IsInt();
        truck.LoadCapacity = loadCapacity;

        return truck;
    }
}