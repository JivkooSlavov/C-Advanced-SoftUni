using DefiningClasses;

int n = int.Parse(Console.ReadLine());
List<Car> cars = new List<Car>();
for (int i = 0; i < n; i++)
{
    string[] command = Console.ReadLine().Split().ToArray();
    string model = command[0];
    double fuel = double.Parse(command[1]);
    double fuelConsumptionFor1Km = double.Parse(command[2]);

    Car car = new Car(model,fuel,fuelConsumptionFor1Km);
    cars.Add(car);
}

string newCommand = "";
while ((newCommand = Console.ReadLine())!="End")
{
    string[] data = newCommand.Split().ToArray();
    string carModel = data[1];
    double amountOfKm = double.Parse(data[2]);

    Car carToDrive =cars.FirstOrDefault(car=>car.Model == carModel);
    carToDrive.Drive(amountOfKm);

}

foreach (Car car in cars)
{
    Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
}