namespace _2.SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstSet = input[0];
            int secondSet = input[1];
            for (int i = 0; i < firstSet; i++)
            {
                int number = int.Parse(Console.ReadLine());
                first.Add(number);
            }
            for (int i = 0; i < secondSet; i++)
            {
                int number = int.Parse(Console.ReadLine());
                second.Add(number);
            }
            first.IntersectWith(second);

            Console.WriteLine(string.Join(" ", first));
        }
    }
}