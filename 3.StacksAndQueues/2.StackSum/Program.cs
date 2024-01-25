namespace _2.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(input);
            var commandInfo = "";
            while ((commandInfo = Console.ReadLine().ToLower())!= "end")
            {
                var tokens = commandInfo.Split();
                var command = tokens[0].ToLower();
                if (command == "add")
                {
                    stack.Push(int.Parse(tokens[1]));
                    stack.Push(int.Parse(tokens[2]));
                }
                else if (command == "remove")
                {
                    var countOfRemovedNums = int.Parse(tokens[1]);
                    if (countOfRemovedNums<=stack.Count)
                    {
                        for (int i = 0; i < countOfRemovedNums; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }
            var sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}