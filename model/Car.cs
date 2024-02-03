
public class Car : Vehicle
{
    public int Seats { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Antallseter: {Seats}");
    }

    public string GetPlateNumber(Car car)
    {
        return car.PlateNumber;
    }

    public static Car ExtraInfo(Car car)
    {
        Console.WriteLine("Antall seter:  ");
        int seats = VehicleService.IsInt();
        car.Seats = seats;

        return car;
    }
}