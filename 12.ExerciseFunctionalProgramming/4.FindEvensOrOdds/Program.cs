int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
int start = num[0];
int end = num[1];

List<int> numbers = new List<int>();

for (int i = start; i <= end; i++)
{
    numbers.Add(i);
}

Predicate<int> sortedNumbers = null;
string command = Console.ReadLine();
if (command == "odd")
{
    sortedNumbers = numbers => numbers % 2 != 0;
}
else if (command == "even")
{
    sortedNumbers = numbers => numbers % 2 == 0;
}
numbers= numbers.FindAll(sortedNumbers).ToList();
Console.WriteLine(string.Join(" ", numbers));