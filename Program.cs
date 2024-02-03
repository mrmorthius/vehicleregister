
var vehicleService = new VehicleService();
Car testCar = new Car();
testCar.SetVehicleInfo();
testCar = Car.ExtraInfo(testCar);
testCar.DisplayInfo();



while (true)
{
    Console.WriteLine("1. Legg til bil!");
    Console.WriteLine("2. Legg til lastebil!");
    Console.WriteLine("3. Legg til motorsykkel!");
    Console.WriteLine("4. Legg til båt!");
    Console.WriteLine("5. Vis alle kjøretøy!");
    Console.WriteLine("6. Avslutt!");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Car car = Car.ExtraInfo(Vehicle.CreateChild<Car>());
            vehicleService.AddVehicle(car);
            break;

        case "2":
            Truck truck = Truck.ExtraInfo(Vehicle.CreateChild<Truck>());
            vehicleService.AddVehicle(truck);
            break;
        case "3":
            Motorcycle motorcycle = Motorcycle.ExtraInfo(Vehicle.CreateChild<Motorcycle>());
            vehicleService.AddVehicle(motorcycle);
            break;
        case "4":
            Boat boat = Boat.ExtraInfo(Vehicle.CreateChild<Boat>());
            vehicleService.AddVehicle(boat);
            break;
        case "5":
            vehicleService.ShowVehicles();
            break;
        case "6":
            return;
        default:
            Console.WriteLine("Ugyldig valg, prøv igjen!");
            break;
    }
}