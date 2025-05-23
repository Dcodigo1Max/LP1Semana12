using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipes;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JustLikeACollection
{
    public class Guarda3<T> : IEnumerable<T>
    {
        private T Item0;
        private T Item1;
        private T Item2;
        
        private int count;

        public IEnumerator<T> GetEnumerator()
        {
            yield return Item0;
            yield return Item1;
            yield return Item2;

        }


        public void Add(T item)
        {
            int list = this.count;

            if (list == 0)
            {
                Item0 = item;
            }
            else if (list == 1)
            {
                Item1 = item;

            }
            else if (list == 2)
            {
                Item2 = item;
            }
            else
            {
                return;
            }
            count++;
            
        }



        public T GetItem(int i)
        {
            switch (i)
            {
                case 0:
                    return Item0;
                case 1:
                    return Item1;
                case 2:
                    return Item2;
            }

            throw new IndexOutOfRangeException();

        }


        public void SetItem(int i, T item)
        {
            if (i < 0 || i > 2)
            {
                throw new IndexOutOfRangeException();
            }

            switch (i)
            {
                case 0:
                    Item0 = item;
                    break;
                case 1:
                    Item1 = item;
                    break;
                case 2:
                    Item2 = item;
                    break;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}