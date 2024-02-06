namespace _08.TrafficLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numbersOfCars = int.Parse(Console.ReadLine());
           Queue<string> cars = new Queue<string>();
            int passedCars = 0;
            string command = "";
            while ((command = Console.ReadLine())!="end")
            {
                if (command =="green")
                {
                    for (int i = 0; i < numbersOfCars; i++)
                    {
                        if (cars.Count==0)
                        {
                            break;
                        }
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        passedCars++;
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
            }
            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}