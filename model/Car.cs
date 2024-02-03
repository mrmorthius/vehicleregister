
public class Car : Vehicle
{
    public int Seats { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Antallseter: {Seats}");
    }

    public override void CreateVehicle()
    {
        base.CreateVehicle();
        Console.WriteLine("Antall seter:  ");
        int seats = VehicleService.IsInt();
        Seats = seats;
    }
}