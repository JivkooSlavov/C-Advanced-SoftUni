using _04.OpinionPoll;
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
            List<Person> people = new List<Person>();
            int countOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfPeople; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                string name = command[0];
                int age = int.Parse(command[1]);

                Person person = new Person(name, age);
                people.Add(person);
            }
        }
    }
}
