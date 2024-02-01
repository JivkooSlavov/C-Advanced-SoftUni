int[] programmerTime = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] numberOfTaks = Console.ReadLine().Split().Select(int.Parse).ToArray();
Queue<int> times = new Queue<int>(programmerTime);
Stack<int> tasks = new Stack<int>(numberOfTaks);

Dictionary<string, int> rubberDucks = new Dictionary<string, int>();
rubberDucks.Add("Darth Vader Ducky", 0);
rubberDucks.Add("Thor Ducky", 0);
rubberDucks.Add("Big Blue Rubber Ducky", 0);
rubberDucks.Add("Small Yellow Rubber Ducky", 0);

while (times.Count > 0 && tasks.Count > 0)
{
    int currentTime = times.Dequeue();
    int currentTask = tasks.Pop();

    int result = currentTime * currentTask;
    if (result >= 0 && result <= 60)
    {
        rubberDucks["Darth Vader Ducky"]++;
    }
    else if (result >= 61 && result <= 120)
    {
        rubberDucks["Thor Ducky"]++;
    }
    else if (result >= 121 && result <= 180)
    {
        rubberDucks["Big Blue Rubber Ducky"]++;
    }
    else if (result >= 181 && result <= 240)
    {
        rubberDucks["Small Yellow Rubber Ducky"]++;
    }
    else
    {
        currentTask -= 2;
        tasks.Push(currentTask);
        times.Enqueue(currentTime);
    }
}
Console.WriteLine("Congratulations, all tasks have been completed! Rubber ducks rewarded:");
foreach (var duck in rubberDucks)
{
    Console.WriteLine($"{duck.Key}: {duck.Value}");
}