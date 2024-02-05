Stack<int> fuel  = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
Queue<int> consumption = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
Queue<int> altitude = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());



int attempt = 0;
int success = 0;
bool hasReachedAny = false;
List<string> listSuccess = new List<string>();
while (fuel.Count>0 && consumption.Count>0)
{
    int currentFuel = fuel.Peek();
    int currentConsuption = consumption.Peek();
    int currentNeededFuel = altitude.Peek();
    int substact = currentFuel - currentConsuption;



    if (substact >= currentNeededFuel)
    {
        fuel.Pop();
        consumption.Dequeue();
        altitude.Dequeue();
        attempt++;
        success++;
        hasReachedAny = true;
        listSuccess.Add($"Altitude {success}");
        Console.WriteLine($"John has reached: Altitude {attempt}");
    }
    else
    {
        attempt++;
        Console.WriteLine($"John did not reach: Altitude {attempt}");
        Console.WriteLine("John failed to reach the top.");
        if (hasReachedAny)
        {
            Console.WriteLine("Reached altitudes: " + string.Join(", ", listSuccess));
        }
        else
        {
            Console.WriteLine("John didn't reach any altitude.");
        }
        Environment.Exit(0);
    }


}
if (altitude.Count==0)
{
    Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
}


