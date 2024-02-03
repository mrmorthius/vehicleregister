
public class Boat : Vehicle
{
    public int Length { get; set; }
    public int Width { get; set; }
    public int HorsePower { get; set; }

    public static Boat ExtraInfo(Boat boat)
    {
        Console.WriteLine("Lengde:  ");
        int length = VehicleService.IsInt();

        Console.WriteLine("Bredde:  ");
        int width = VehicleService.IsInt();

        Console.WriteLine("Hestekrefter:  ");
        int horsePower = VehicleService.IsInt();

        boat.Length = length;
        boat.Width = width;
        boat.HorsePower = horsePower;

        return boat;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Lengde: {Length}, Bredde: {Width}, HK:{HorsePower}");
    }
}