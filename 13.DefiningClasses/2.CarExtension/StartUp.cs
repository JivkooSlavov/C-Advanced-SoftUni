namespace CarManufacturer

{
    public class StartUp

    {
        static void Main()

        {
            Car car = new Car();
            car.Make = "VW";
            car.Model = "Golf";
            car.Year = 2006;
            car.FuelQuantity = 200;
            car.FuelConsumption = 50;

            car.Drive(1);

            Console.WriteLine(car.WhoAmI());
        }

    }

}