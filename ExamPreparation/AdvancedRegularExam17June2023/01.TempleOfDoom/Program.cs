Queue<int> tools = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
Stack<int> substances = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

List<int> challenges = Console.ReadLine().Split().Select(int.Parse).ToList();

while (tools.Count > 0 && substances.Count > 0 && challenges.Count > 0)
{
    int currentTool = tools.Peek();
    int currentSubstance = substances.Peek();
    int result = currentSubstance * currentTool;

    if (challenges.Contains(result))
    {
        challenges.Remove(result);
        tools.Dequeue();
        substances.Pop();
        if (challenges.Count == 0)
        {
            Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
        }
    }
    else
    {
        currentTool += 1;
        tools.Dequeue();
        tools.Enqueue(currentTool);

        currentSubstance -= 1;
        if (currentSubstance == 0)
        {
            substances.Pop();
        }
        else
        {
            substances.Pop();
            substances.Push(currentSubstance);
        }
        if (substances.Count == 0)
        {
            Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
        }

    }
}

if (tools.Count != 0)
{
    Console.WriteLine($"Tools: {string.Join(", ", tools)}");
}
if (substances.Count != 0)
{
    Console.WriteLine($"Substances: {string.Join(", ", substances)}");

}
if (challenges.Count != 0)
{
    Console.WriteLine($"Challenges: {string.Join(", ", challenges)}");

}

