
using System.Linq.Expressions;

var vehicleService = new VehicleService();

while (true)
{
    Console.WriteLine("1. Legg til bil!");
    Console.WriteLine("2. Legg til lastebil!");
    Console.WriteLine("3. Legg til motorsykkel!");
    Console.WriteLine("4. Legg til båt!");
    Console.WriteLine("5. Vis alle kjøretøy!");
    Console.WriteLine("6. Avslutt!");

    string choice = Console.ReadLine();

    try //lar oss avbryte prosessen med å legge til kjøretøy uten å avslutte programmet
    {
        switch (choice)
        {

            case "1":
                Car car = new();
                car.CreateVehicle();
                vehicleService.AddVehicle(car);
                break;
            case "2":
                Truck truck = new();
                truck.CreateVehicle();
                vehicleService.AddVehicle(truck);
                break;
            case "3":
                Motorcycle mc = new();
                mc.CreateVehicle();
                vehicleService.AddVehicle(mc);
                break;
            case "4":
                Boat boat = new();
                boat.CreateVehicle();
                vehicleService.AddVehicle(boat);
                break;
            case "5":

                vehicleService.ShowVehicles();
                Console.WriteLine("------------------------------------------------------------\n");
                break;
            case "6":
                return;
            default:
                Console.WriteLine("Ugyldig valg, prøv igjen!");
                break;
        }
    }

    catch (Exception ex)
    {
        Console.WriteLine("Kjøretøy ikke lagt til");
    }
}