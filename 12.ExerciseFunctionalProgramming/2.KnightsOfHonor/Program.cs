using System.Threading.Channels;

List <string> knights = Console.ReadLine().Split().ToList();

Func<string, string> addPrefix = name => "Sir" + name;

foreach (var name in knights)
{
    Console.WriteLine(addPrefix(name));
}