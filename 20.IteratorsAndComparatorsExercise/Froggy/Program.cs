using Froggy;

namespace IteratorsAndComparators
{
    class Froggy
    {
        static void Main(string[] args)
        {
            //1, 2, 3, 4, 5, 6, 7, 8

            List<int> numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            Lake lake = new Lake(numbers);

            Console.WriteLine(string.Join(", ", lake));
            
        }
    }
}