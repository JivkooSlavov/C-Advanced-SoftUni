using System.Diagnostics;

namespace _4.ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();
            string command = "";
            while ((command=Console.ReadLine())!= "Revision")
            {
                string[] array = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string nameOfShop = array[0];
                string nameOfProduct = array[1];
                double priceOfProduct = double.Parse(array[2]);

                if (!shops.ContainsKey(nameOfShop))
                {
                    shops.Add(nameOfShop, new Dictionary<string, double>());
                }
                shops[nameOfShop].Add(nameOfProduct, priceOfProduct);

            }
            foreach (var shop in shops.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var item in shop.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}