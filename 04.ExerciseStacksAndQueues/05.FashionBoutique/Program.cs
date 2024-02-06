namespace _05.FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> racks = new Stack<int>(clothes);
            int capacityOfRacks = int.Parse(Console.ReadLine());

            int total = 1;
            int currentCapacity = 0;

            while (racks.Count > 0)
            {
                int currentValue = racks.Pop();
                if (currentValue + currentCapacity<= capacityOfRacks)
                {
                    currentCapacity += currentValue;
                }
                else
                {
                    total++;
                    currentCapacity = currentValue;
                }
            }
            Console.WriteLine(total);
        }
    }
}