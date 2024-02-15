List<int> array = Console.ReadLine().Split().Select(int.Parse).ToList();
Func<List<int>, int> getMinElement = numbers =>numbers.Min();

Console.WriteLine(getMinElement(array));