namespace _5.CountSymbol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> charsCounts = new SortedDictionary<char, int>();

            string input =Console.ReadLine();

            foreach (char ch in input)
            {
                if (!charsCounts.ContainsKey(ch))
                {
                    charsCounts.Add(ch, 0);
                }
                charsCounts[ch]++;
            }
            foreach (var item in charsCounts)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}