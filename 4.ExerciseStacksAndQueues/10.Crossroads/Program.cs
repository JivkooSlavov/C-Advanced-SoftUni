int greenLightSeconds = int.Parse(Console.ReadLine());
int freeWindowSeconds = int.Parse(Console.ReadLine());

string command = Console.ReadLine();

Queue<string> cars = new Queue<string>();

int passedCars = 0;

while (command != "END")
{
    if (command != "green")
    {
        cars.Enqueue(command);
        command = Console.ReadLine();
        continue;
    }

    int currenGreenLightSeconds = greenLightSeconds;

    while (cars.Count > 0 && currenGreenLightSeconds > 0)
    {
        string currentCar = cars.Dequeue(); 


        if (currenGreenLightSeconds - currentCar.Length >= 0)
        {
            currenGreenLightSeconds -= currentCar.Length;
            passedCars++;
            continue;
        }

        else if (currenGreenLightSeconds + freeWindowSeconds - currentCar.Length >= 0)
        {
            passedCars++;
            break;
        }
        else
        {
            char hittedSymbol = currentCar[currenGreenLightSeconds + freeWindowSeconds];

            Console.WriteLine("A crash happened!");
            Console.WriteLine($"{currentCar} was hit at {hittedSymbol}.");

            Environment.Exit(0);
        }
    }

    command = Console.ReadLine();
}

Console.WriteLine("Everyone is safe.");
Console.WriteLine($"{passedCars} total cars passed the crossroads.");