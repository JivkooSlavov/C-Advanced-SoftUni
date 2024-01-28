using DefeningClasses;
using System.Reflection;
using System.Collections.Generic;
using System;

Dictionary<string,Engine> Engines = new Dictionary<string, Engine>();

int countOfEngines = int.Parse(Console.ReadLine());
for (int i = 0; i < countOfEngines; i++)
{
    string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    string engineModel = command[0];
    int power = int.Parse(command[1]);
    Engine engine = new Engine();
    if (command.Length==2)
    {
        engine = new Engine(engineModel, power);
        Engines.Add(engineModel, engine);
    }
    else if (command.Length==3)
    {
        if (char.IsDigit(command[2][0]))
        {
            int displacement = int.Parse(command[2]);
            engine = new Engine(engineModel, power, displacement);
            Engines.Add(engineModel, engine);
        }
        else
        {
            string efficiency = command[2];
            engine = new Engine(engineModel, power, efficiency);
            Engines.Add(engineModel, engine);
        }

    }
    else if (command.Length ==4)
    {
        int displacement = int.Parse(command[2]);
        string efficiency = command[3];
        engine = new Engine(engineModel, power, displacement, efficiency);
        Engines.Add(engineModel, engine);
    }
}
int countOfCars = int.Parse(Console.ReadLine());
List<Car> carsList = new List<Car>();
for (int i = 0; i < countOfCars; i++)
{
    string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    string model = data[0];
    string carEngine = data[1];
    Engine engine = Engines[carEngine];

    if (data.Length == 2)
    {

        Car car = new Car(model, engine);
        carsList.Add(car);
    }
    else if (data.Length == 3)
    {
        if (char.IsDigit(data[2][0]))
        {
            int weight = int.Parse(data[2]);
            Car car = new Car(model, engine, weight);
            carsList.Add(car);
        }
        else
        {
            string color = data[2];
            Car car = new Car(model, engine, color);
            carsList.Add(car);
        }

    }
    else if (data.Length == 4)
    {
        int weight = int.Parse(data[2]);
        string color = data[3];
        Car car = new Car(model, engine, weight, color);
        carsList.Add(car);
    }
}
foreach (var car in carsList)
{
    Console.WriteLine(car.ToString());
}