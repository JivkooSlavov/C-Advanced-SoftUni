using System;

namespace ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();


            string information = Console.ReadLine();

            while (information != "END")
            {
                string[] personInfo = information.Split();
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                string town = personInfo[2];

                Person person = new Person(name, age, town);
                people.Add(person);

                information = Console.ReadLine();
            }

            int n = int.Parse(Console.ReadLine());

            Person personToCompare = people[n - 1];

            int equals = 0;
            int diff = 0;
            foreach (Person person in people)
            {
                if (person.CompareTo(personToCompare) == 0)
                {
                    equals++;
                }
                else
                {
                    diff++;
                }
            }
            if (equals==1)
            {
                Console.WriteLine("No matches");
                return;
            }

            Console.WriteLine($"{equals} {diff} {people.Count}");
        }
    }
}