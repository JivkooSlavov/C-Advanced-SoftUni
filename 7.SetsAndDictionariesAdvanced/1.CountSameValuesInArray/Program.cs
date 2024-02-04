namespace _1.CountSameValuesInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();


            Dictionary<double, int> numbersCount = new Dictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!numbersCount.ContainsKey(number))
                {
                    numbersCount.Add(number, 1);
                }
                else
                {
                    numbersCount[number]++; 
                }
            }
            foreach (var item in numbersCount)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }

        }
    }
}