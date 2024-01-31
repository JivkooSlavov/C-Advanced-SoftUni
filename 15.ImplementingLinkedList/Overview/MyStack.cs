using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overview
{
    public class MyStack
    {
        private const int INITIAL_CAPACITY = 4;

        private int[] data;
        
        public int Count { get; private set; }

        public MyStack()
        {
            this.Count = 0;
            this.data = new int[INITIAL_CAPACITY];
        }

        public void Push(int element)
        {
            if (this.Count == data.Length)
            {
                this.ResizeStack();
            }
            this.data[this.Count] = element;
            Count++;
        }

        private void ResizeStack()
        {
            var newData = new int[this.data.Length * 2];
            for (int i = 0; i < this.data.Length; i++)
            {
                newData[i] = this.data[i];

            }
            this.data = newData;
        }
    }
}
