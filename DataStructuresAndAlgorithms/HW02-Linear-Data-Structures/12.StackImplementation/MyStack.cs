namespace StackImplementation
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MyStack<T> : IEnumerable<T>
    {
        private T[] elements;

        public MyStack()
        {
            this.elements = new T[this.Capacity];
        }

        public int Count { get; set; }

        public int Capacity { get; private set;}

        public void Push(T element)
        {
            if (this.Capacity == 0)
            {
                this.Capacity = 1;
                this.elements = new T[this.Capacity];
            }

            if (this.Count + 1 > this.Capacity)
            {
                this.Capacity *= 2;
                T[] currentElements = this.elements;
                this.elements = new T[this.Capacity];

                for (int i = 0; i < currentElements.Length; i++)
                {
                    this.elements[i] = currentElements[i];
                }

                this.Count = currentElements.Length;
            }

            this.elements[this.Count] = element;
            this.Count++;
        }

        public T Pop()
        {
            this.Count--;
            T currentItem = this.elements[this.Count];

            return currentItem;
        }

        public void Clear()
        {
            while (this.Count > 0)
            {
                this.Pop();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            return string.Join(", ", this).Trim(new char[] { ' ', ',' });
        }
    }
}
