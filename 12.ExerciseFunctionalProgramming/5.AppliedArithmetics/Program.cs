using System.Security.Cryptography.X509Certificates;

List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

Func<List<int>, List<int>> add = list => list.Select(x => x += 1).ToList();
Func<List<int>, List<int>> multiply = list => list.Select(x => x *= 2).ToList();
Func<List<int>, List<int>> subtract = list => list.Select(x => x -= 1).ToList();

Action<List<int>> print = list => Console.WriteLine(string.Join(" ", list));

string command = "";

while ((command=Console.ReadLine())!="end")
{
	if (command=="add")
	{
		numbers = add(numbers);
	}
	else if (command=="multiply")
	{
		numbers = multiply(numbers);
    }
	else if (command=="subtract")
	{
		numbers = subtract(numbers);
    }
	else if (command=="print")
	{
        print(numbers);
    }
}