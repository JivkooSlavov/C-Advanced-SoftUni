using DefiningClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            int numberOfMembers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfMembers; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                string name = command[0];
                int age = int.Parse(command[1]);

                Person person = new Person(name, age);
                family.AddMember(person);
            }
            Person oldestPerson = family.GetOldestMember();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
