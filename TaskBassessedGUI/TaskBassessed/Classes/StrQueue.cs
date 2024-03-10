using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBassessed.Classes
{
    class StrQueue
    {
        private readonly int maxsize = 20;
        private string[] store;
        private int head = 0;
        private int tail = 0;
        private int numItems;

        public StrQueue()
        {
            store = new string[maxsize];
        }

        public StrQueue(int size) // could also use this
        {
            maxsize = size;
            store = new string[maxsize];
        }

        public void Enqueue(string name)
        {
            numItems++;
            store[tail] = name;
            if (++tail == maxsize)
            {
                tail = 0;
            }
        }

        public string Dequeue()
        {
            string headItem;
            numItems--;
            headItem = store[head];
            if (++head == maxsize)
            {
                head = 0;
            }
            return headItem;
        }

        public bool IsEmpty()
        {
            return numItems == 0;
        }

        public bool IsFull()
        {
            return numItems == maxsize;
        }

        public int getNumItems()
        {
            return numItems;
        }

        public string Print()
        {
            StringBuilder output = new StringBuilder(); // doing it this way because using a rich text box
            int LoopCount = 0;
            for (int i = tail - 1; LoopCount < numItems; LoopCount++)
            {
                if (i < 0) // need to correct for circular queue to not get out of bounds indexing
                {
                    i = maxsize - 1;
                }

                output.Append("[" + (numItems - LoopCount) + "] " + store[i] + Environment.NewLine);
                i--;

            }
            return output.ToString();
        }
    }
}
