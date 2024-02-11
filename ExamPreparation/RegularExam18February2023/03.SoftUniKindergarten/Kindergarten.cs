using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Registry = new List<Child>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Child> Registry { get; set; }
        public int ChildrenCount() => Registry.Count;
        public bool AddChild(Child child)
        {
            if (Capacity> Registry.Count)
            {
                Registry.Add(child);
                return true;
            }
            return false;
        }
        public bool RemoveChild(string fullName) => Registry.Remove(Registry.FirstOrDefault(x => x.FirstName == fullName.Split(" ")[0] && x.LastName == fullName.Split(" ")[1]));

        public Child GetChild(string childFullName) => Registry.FirstOrDefault(x => x.FirstName == childFullName.Split(" ")[0] && x.LastName == childFullName.Split(" ")[1]);

        public string RegistryReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Registered children in {Name}:");
            foreach (var item in Registry.OrderByDescending(x => x.Age).ThenBy(y => y.LastName).ThenBy(x => x.FirstName))
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
