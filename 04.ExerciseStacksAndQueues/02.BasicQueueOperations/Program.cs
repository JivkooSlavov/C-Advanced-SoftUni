namespace _01.BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int valuePush = values[0];
            int valuePop = values[1];
            int valuePeek = values[2];

            Queue<int> stack = new Queue<int>();

            for (int i = 0; i < valuePush; i++)
            {
                stack.Enqueue(input[i]);
            }

            while (stack.Count > 0 && valuePop > 0)
            {
                stack.Dequeue();
                valuePop--;
            }
            if (stack.Contains(valuePeek))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }

        }
    }
}