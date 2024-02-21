string input = Console.ReadLine();
Func<string, int> parse = x => int.Parse(x);
int[] array = input.Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries).Select(parse).ToArray();
Console.WriteLine(array.Length);
Console.WriteLine(array.Sum());