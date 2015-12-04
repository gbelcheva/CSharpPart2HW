namespace QueueImplementation
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class MyQueue<T> : IEnumerable<T>
    {
        private LinkedList<T> elements;

        public MyQueue()
        {
            this.elements = new LinkedList<T>();
        }

        public int Count
        {
            get { return this.elements.Count; }
        }

        public void Enqueue(T element)
        {
            this.elements.AddLast(element);
        }

        public T Dequeue()
        {
            if (this.elements.Count == 0)
            {
                throw new InvalidOperationException("No elements to dequeue.");
            }

            T firstElement = this.elements.First.Value;
            this.elements.RemoveFirst();

            return firstElement;
        }

        public T Peek()
        {
            if (this.elements.Count == 0)
            {
                throw new InvalidOperationException("No elements in queue.");
            }

            T value = this.elements.First.Value;

            return value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.elements)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            return string.Join(", ", this.elements).Trim(new char[] { ' ', ',' });
        }
    }
}
