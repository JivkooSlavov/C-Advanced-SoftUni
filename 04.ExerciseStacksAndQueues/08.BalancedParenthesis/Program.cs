namespace _08.BalancedParenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string inputParenthesis = Console.ReadLine();

          Stack<char> stack = new Stack<char>();

            foreach (char ch in inputParenthesis)
            {
                if (ch == '(' || ch == '[' || ch =='{')
                {
                    stack.Push(ch);
                    continue;
                }
                if (stack.Count==0)
                {
                    stack.Push(ch);
                    break;
                }
                if (ch == ')' && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else if (ch == ']' && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else if (ch == '}' && stack.Peek() == '{')
                {
                    stack.Pop();
                }
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}