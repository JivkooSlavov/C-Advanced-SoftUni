using System;
namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
        int n = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();

            for (int i = 0; i < n; i++)
            {
                double stringValue = double.Parse(Console.ReadLine());
                box.Items.Add(stringValue);
            }
            double comparingItem = double.Parse(Console.ReadLine());

            int value = box.CountGreaterThan(comparingItem);

            Console.WriteLine(value);
        }
    }
}
