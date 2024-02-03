
public class Boat : Vehicle
{
    public int Length { get; set; }
    public int Width { get; set; }
    public int HorsePower { get; set; }

    public override void CreateVehicle()
    {
        base.CreateVehicle();
        Console.WriteLine("Lengde:  ");
        int length = VehicleService.IsInt();

        Console.WriteLine("Bredde:  ");
        int width = VehicleService.IsInt();

        Console.WriteLine("Hestekrefter:  ");
        int horsePower = VehicleService.IsInt();

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