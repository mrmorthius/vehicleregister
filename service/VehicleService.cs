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
        string input = Console.ReadLine();
        while (!int.TryParse(input, out integer))
        {
            Console.Write($"\nAngitt verdi er ikke et heltall. Prøv igjen: ");

            if (input.ToLower() == "exit")
                throw new Exception("Kjøretøy ble ikke lagt til");
            else
            {
                input = Console.ReadLine();
            }
        }
        return integer;
    }

    public static double isDouble()
    {
        double number;
        string input = Console.ReadLine();
        while (!double.TryParse(input, out number))
        {
            Console.Write($"\nAngitt verdi er ikke et tall. Prøv igjen: ");

            if (input.ToLower() == "exit")
                throw new Exception("Kjøretøy ble ikke lagt til");
            else
            {
                input = Console.ReadLine();
            }
        }
        return number;
    }
}