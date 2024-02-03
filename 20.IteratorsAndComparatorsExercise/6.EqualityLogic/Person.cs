using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(Person other)
        {
            if (this.Name.CompareTo(other.Name)!=0)
            {
                return this.Name.CompareTo(other.Name);
            }
            else if (this.Age.CompareTo(other.Age)!=0)
            {
                return this.Age.CompareTo(other.Age);
            }
            return 0;
        }

        public override bool Equals(object obj)
        {
            Person person =obj as Person;
            return this.Name == person.Name && this.Age == person.Age;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() + this.Age.GetHashCode();
        }
    }
}
