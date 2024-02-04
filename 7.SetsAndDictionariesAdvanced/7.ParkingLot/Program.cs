namespace _07.ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet <string> collection = new HashSet<string>();

            string input = "";
            while ((input =Console.ReadLine())!="END")
            {
                string[] array = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string operation = array[0];
                string number = array[1];
                if (operation == "IN")
                {
                    collection.Add(number);
                }
                else
                {
                    collection.Remove(number);
                }
            }
            if (collection.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }
            foreach (string item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}