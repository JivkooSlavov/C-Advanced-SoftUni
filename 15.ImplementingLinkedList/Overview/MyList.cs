using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overview
{
      public class MyList
    {
        private int[] data;
        private int capacity;

        public MyList()
            :this  (4)
        {
              
        }

        public MyList(int capacity)
        {
           this.capacity = capacity;
            this.data = new int[capacity];
        }

        public int Coint { get; private set; }

        public int this[int index]
        {
            get
            {
                this.ValidateIndex(index);
                return this.data[index];
            }
            set
            {
                this.ValidateIndex(index);
                this.data[index] = value;
            }
        }
        public void Add(int number) 
        {
            if (this.Coint==this.data.Length)
            {
                this.Resize();
            }
            this.data[this.Coint] = number;
            this.Coint++;
        }
        private void Shift(int index)
        {
            for (int i = index; i < this.Coint-1; i++)
            {
                this.data[i] = this.data[i + 1];

            }
        }
        private void Shrink()
        {
            var newCapacity = this.data.Length / 2;
            var newData = new int[newCapacity];
            for (int i = 0; i < this.data.Length; i++)
            {
                newData[i] = this.data[i];
            }
            this.data = newData;
        }
        public int RemoveAt(int index) 
        {
            this.ValidateIndex(index);
            var result = this.data[index];
            for (int i = index+1; i < this.Coint; i++)
            {
                this.data[i - 1] = this.data[i];
            }
            this.Coint--;
            return result;
        }
        public bool Contains(int element)
        {
            for (int i = 0; i < this.Coint; i++)
            {
                if (this.data[i]==element)
                {
                    return true;
                }
            }
            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            this.ValidateIndex(firstIndex);
            this.ValidateIndex(secondIndex);
            var firstValue = this.data[firstIndex];
            this.data[firstIndex] = this.data[secondIndex];
            this.data[secondIndex] = firstIndex;
        }
        public void Clear()
        {
            this.Coint = 0;
            this.data = new int[this.capacity]; 
        }
        private void ValidateIndex(int index)
        {
            if (index >=0 && index <this.Coint)
            {
                return;
            }

            var message = this.Coint == 0 ? "This list is empty" : $"This list has {this.Coint} elements and it`s zero-based";
            throw new ArgumentException($"Index out of range. {message}");
        }
        
        private void Resize()
        {
            var newCapacity = this.data.Length * 2;
            var newData = new int[newCapacity];
            for (int i = 0; i < this.data.Length; i++)
            {
                newData[i] = this.data[i];
            }
            this.data = newData; 
        }
    }
}
