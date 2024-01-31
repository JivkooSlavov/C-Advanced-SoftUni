using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Box<T>
        where T : IComparable
    {
        public List<T> Items { get; set; }
        public Box()
        {
           Items = new List<T>();
        }
        public int CountGreaterThan(T itemToCompare)
        {
            int counter = 0;
            foreach (var item in Items)
            {
                if (item.CompareTo(itemToCompare)>0)
                {
                    counter++;
                }
            }
            return counter;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Items)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }

            return sb.ToString();
        }
        //public override string ToString() => string.Join(Environment.NewLine, Items.Select(x => $"{typeof(T)}: {x}"));
        public void Swap(int firstIndex, int secondIndex)
        {
            (Items[firstIndex], Items[secondIndex]) = (Items[secondIndex], Items[firstIndex]); 
        }
    }
}
