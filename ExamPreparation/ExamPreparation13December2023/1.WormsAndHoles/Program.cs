
using System;

Stack<int> worms = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
Queue<int> holes = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
int matchCounter = 0;
int wormsCount = worms.Count;

while (worms.Count>0 && holes.Count>0)
{
    int currentWorm = worms.Peek();
    int currentHole = holes.Peek();

    if (currentWorm == currentHole)
    {
        worms.Pop();
        holes.Dequeue();
        matchCounter++;
    }
    else
    {
        holes.Dequeue();
        worms.Pop();
        currentWorm -= 3;
        worms.Push(currentWorm);
    }
    if (currentWorm <= 0)
    {
        worms.Pop();
    }
}
if (matchCounter!=0)
{
    Console.WriteLine($"Matches: {matchCounter}");
}
else
{
    Console.WriteLine("There are no matches.");
}
if (worms.Count==0 && wormsCount == matchCounter)
{
    Console.WriteLine("Every worm found a suitable hole!");
}
else if (worms.Count==0)
{
    Console.WriteLine("Worms left: none");
}
else if (worms.Count!=0)
{
    Console.WriteLine("Worms left: " + string.Join(", ", worms));
}
if (holes.Count==0)
{
    Console.WriteLine("Holes left: none");
}
else
{
    Console.WriteLine("Holes left: " + string.Join(", ", holes));
}


