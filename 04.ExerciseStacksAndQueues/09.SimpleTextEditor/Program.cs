namespace _09.SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string text = "";

            Stack<string> state = new Stack<string>();

            for (int i = 0; i < input; i++)
            {
                string[] commands = Console.ReadLine().Split();

                if (commands[0] == "1")
                {
                    state.Push(text);
                    text += commands[1];
                }
                else if (commands[0] == "2")
                {
                    state.Push(text);
                    int count = int.Parse(commands[1]);
                    text = text.Substring(0, text.Length - count);
                }
                else if (commands[0] == "3")
                {
                    int index = int.Parse(commands[1])-1;
                    Console.WriteLine(text[index]);
                }
                else if (commands[0] == "4")
                {
                    text = state.Pop();
                }
            }
        }
    }
}