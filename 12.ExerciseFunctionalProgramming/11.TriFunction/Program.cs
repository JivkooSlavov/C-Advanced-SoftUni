int n = int.Parse(Console.ReadLine());
List<string> people = Console.ReadLine().Split().ToList();

Console.WriteLine(people
    .First(name => name.Select(symbol => (int)symbol).Sum() >= n));