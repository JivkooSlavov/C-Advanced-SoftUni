using System;

namespace _6.EqualityLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Person> sortedSet = new SortedSet<Person>();
            HashSet<Person> hashSet = new HashSet<Person>();
            int countOfPeople = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfPeople; i++)
            {
                string[] informationForPerson = Console.ReadLine().Split().ToArray();
                string name = informationForPerson[0];
                int age = int.Parse(informationForPerson[1]);
                Person person = new Person(name, age);
                sortedSet.Add(person);
                hashSet.Add(person);
            }

            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(hashSet.Count);
        }
    }
}