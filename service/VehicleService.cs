public class VehicleService
{
    List<Vehicle> vehicles = new List<Vehicle>();

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void ShowVehicles()
    {
        if (vehicles.Count != 0)
        {
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.DisplayInfo();
            }
        }
        else
        {
            Console.WriteLine("Det er ikke lagt til noen kjøretøy i listen.");
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