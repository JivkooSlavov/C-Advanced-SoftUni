namespace _3.PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> periodicElements = new();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                periodicElements.UnionWith(tokens);
            }
            Console.WriteLine(string.Join(" ", periodicElements));
        }
    }
}