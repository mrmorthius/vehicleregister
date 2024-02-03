public class VehicleService
{
    List<Vehicle> vehicles = new List<Vehicle>();

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void ShowVehicles()
    {
        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.DisplayInfo();
        }
    }

    public static int IsInt()
    {
        int integer;
        while (!int.TryParse(Console.ReadLine(), out integer))
        {
            Console.Write($"\nAngitt verdi er ikke et heltall. Prøv igjen: ");
        }
        return integer;
    }
}