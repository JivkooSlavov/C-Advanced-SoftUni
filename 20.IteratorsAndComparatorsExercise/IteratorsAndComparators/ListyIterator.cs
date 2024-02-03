using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class ListyIterator<T>: IEnumerable<T>
    {
        public List<T> Elements { get; set; }
        public int Index { get; set; }
        public ListyIterator(List<T> elements)
        {
            Elements = elements;
            Index = 0;
        }

        public bool Move()
        {
            if (HasNext())
            {
                Index++;
                return true;
            }
            return false;
        }
        public bool HasNext()
        {
            if (Index+1<Elements.Count)
            {
                return true;
            }
            return false;
        }
        public void Print()
        {
            if (Elements.Count==0)
            {
                throw new Exception("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(Elements[Index]);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in Elements)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
