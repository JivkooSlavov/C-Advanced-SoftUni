namespace _1.UniqueUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> usernames = new();
            int counts = int.Parse(Console.ReadLine());
            for (int i = 0; i < counts; i++)
            {
                string user = Console.ReadLine();
                usernames.Add(user);
            }
            foreach (var item in usernames)
            {
                Console.WriteLine(item);
            }
        }
    }
}