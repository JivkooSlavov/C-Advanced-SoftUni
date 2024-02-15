int n  =int.Parse(Console.ReadLine());  
List<int> dividers = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> numbers = new();
for (int i = 1; i <= n; i++)
{
    numbers.Add(i);
}

List<int> printNumbers = new(); 

foreach (var number in numbers)
{
	bool isDivisible = true;
	foreach (var divider in dividers)
	{
		Predicate<int> divisible = number => number % divider == 0;

		if (!divisible(number))
		{
			isDivisible = false;
			break;
		}
	}
	if (isDivisible)
	{
		printNumbers.Add(number);
	}
}
Console.WriteLine(string.Join(" ", printNumbers));