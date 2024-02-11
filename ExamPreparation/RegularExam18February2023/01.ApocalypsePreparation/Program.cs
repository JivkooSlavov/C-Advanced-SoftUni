Queue<int> textile = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
Stack<int> medicaments = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

Dictionary<string, int> healing = new Dictionary<string, int>();

while (textile.Count>0 && medicaments.Count>0)
{
    int currTextile = textile.Dequeue();
    int currMedic = medicaments.Pop();
    int sumOfThem = currMedic + currTextile;

    if (sumOfThem ==30)
    {
        if (!healing.ContainsKey("Patch"))
        {
            healing.Add("Patch", 1);
            continue;
        }
        healing["Patch"]++;
        continue;
    }
    if (sumOfThem == 40)
    {
        if (!healing.ContainsKey("Bandage"))
        {
            healing.Add("Bandage", 1);
            continue;
        }
        healing["Bandage"]++;
        continue;
    }
    if (sumOfThem == 100)
    {
        if (!healing.ContainsKey("MedKit"))
        {
            healing.Add("MedKit", 1);
            continue;
        }
        healing["MedKit"]++;
        continue;
    }
    if (sumOfThem>100)
    {
        int diff = sumOfThem - 100;
        int newElement = medicaments.Pop() + diff;
        medicaments.Push(newElement);

        if (!healing.ContainsKey("MedKit"))
        {
            healing.Add("MedKit", 1);
            continue;
        }
        healing["MedKit"]++;
    }
    else
    {
        currMedic += 10;
        medicaments.Push(currMedic);
    }
}
if (textile.Count==0 && medicaments.Count==0)
{
    Console.WriteLine("Textiles and medicaments are both empty.");   
}
else if (textile.Count == 0)
{
    Console.WriteLine("Textiles are empty.");
}
else if (medicaments.Count == 0)
{
    Console.WriteLine("Medicaments are empty.");
}

foreach (var item in healing.OrderByDescending(x => x.Value).ThenBy(y=>y.Key))
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}
if (medicaments.Count!=0)
{
    Console.WriteLine($"Medicaments left: {string.Join(", ", medicaments)}");
}
if (textile.Count!=0)
{
    Console.WriteLine($"Textiles left: {string.Join(", ", textile)}");

}