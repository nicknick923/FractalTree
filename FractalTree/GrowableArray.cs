using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalTree
{
    public class GrowableArray<T> : IEnumerable
    {
        private const int GROW_BY = 1;
        private T[] list = new T[GROW_BY];
        private int numElements = 0;


        public GrowableArray()
        {
            list = new T[GROW_BY];
            numElements = 0;
        }

        private void grow()
        {
            T[] newList = new T[list.Length + GROW_BY];
            for (int i = 0; i < numElements; i++)
                newList[i] = list[i];
            list = newList;
        }

        public void Add(T element)
        {
            if (numElements == list.Length)
                grow();
            list[numElements++] = element;
        }

        public ref T ElementAt(int index)
        {
            return ref list[index];
        }

        public bool isEmpty()
        {
            return numElements == 0;
        }

        public int numberOfItems()
        {
            return numElements;
        }

        public void RemoveItem(T item)
        {
            int index = FindItem(item);
            if (index != -1)
            {
                T[] tempList = new T[--numElements];
                for (int i = index; i < numElements; i++)
                    if (i >= index)
                        tempList[i] = list[i + 1];
                    else
                        tempList[i] = list[i];
                list = tempList;
            }
        }

        private int FindItem(T item)
        {
            for (int i = 0; i < numElements; i++)
                if (list[i].Equals(item))
                    return i;
            return -1;
        }


        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }

    }
}
