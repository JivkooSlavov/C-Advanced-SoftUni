using _4.OpinionPoll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.OpinionPoll
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfMembers = int.Parse(Console.ReadLine());
            var listOfPeople = new List<Person>();
            for (int i = 0; i < numberOfMembers; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                string name = command[0];
                int age = int.Parse(command[1]);

                Person person = new Person(name, age);
                listOfPeople.Add(person);
            }
            var sortedListOfPeople = listOfPeople.Where(p => p.Age > 30).OrderBy(p => p.Name);

            foreach (var person in sortedListOfPeople)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
