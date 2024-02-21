List<double> numbers = Console.ReadLine().Split(", ").Select(double.Parse).Select(x=>x*1.2).ToList();

foreach (var number in numbers)
{
    Console.WriteLine($"{number:f2}");
}