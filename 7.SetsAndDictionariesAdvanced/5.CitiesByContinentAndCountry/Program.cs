namespace _5.CitiesByContinentAndCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfCountries = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> register = new();
                
            for (int i = 0; i < countOfCountries; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continent = input[0];
                string country = input[1];
                string town = input[2];
                if (!register.ContainsKey(continent))
                {
                    register.Add(continent, new Dictionary<string,List<string>>());
                }
                if (!register[continent].ContainsKey(country))
                {
                    register[continent].Add(country, new List<string>());
                }
                register[continent][country].Add(town);
            }
            foreach (var item in register)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var value in item.Value)
                {
                    Console.WriteLine($"   {value.Key} -> {string.Join(", ", value.Value)}");
                }
            }
        }
    }
}