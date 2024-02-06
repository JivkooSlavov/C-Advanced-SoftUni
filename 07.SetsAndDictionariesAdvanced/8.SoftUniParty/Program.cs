namespace _8.SoftUniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new();
            HashSet<string> guestsArrived = new();
            string command = "";
            while ((command=Console.ReadLine())!= "END")
            {
                if (command=="PARTY")
                {
                    string invited = Console.ReadLine();
                    guestsArrived.Add(invited);
                    continue;
                }
                guests.Add(command);
            }
            guests.IntersectWith(guestsArrived);

            foreach (var item in guests)
            {
                Console.WriteLine(guests.Count);
                Console.WriteLine(item);

            }
        }
    }
}