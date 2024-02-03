

public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Sidevogn: {(HasSidecar ? "JA" : "Nei")}");
    }
    public override void CreateVehicle()
    {
        base.CreateVehicle();
        Console.WriteLine("Antall seter:  ");
        Console.WriteLine("Sidevogn? (Ja/Nei): ");
        bool sideCar = Console.ReadLine().ToLower() == "ja";
        HasSidecar = sideCar;
    }
}