using DefiningClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> familyMembers;

		public Family()
        {
            FamilyMembers = new List<Person>();
        }

        public List<Person> FamilyMembers
        {
            get; set;
        }

        public void AddMember(Person member)
        {
            this.familyMembers.Add(member);
        }

        public Person GetOldestMember()
        {
            int maxAge = FamilyMembers.Max(member => member.Age);
            return FamilyMembers.First(member => member.Age == maxAge);
        }

	}
}
