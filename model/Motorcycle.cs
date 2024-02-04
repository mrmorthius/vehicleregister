

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
        Console.WriteLine("Sidevogn? (Ja/Nei): ");
        string input = Console.ReadLine();
        if (input.ToLower() == "exit")
            throw new Exception("Kjøretøy ble ikke lagt til");
        bool sideCar = input.ToLower() == "ja";
        HasSidecar = sideCar;
    }
}