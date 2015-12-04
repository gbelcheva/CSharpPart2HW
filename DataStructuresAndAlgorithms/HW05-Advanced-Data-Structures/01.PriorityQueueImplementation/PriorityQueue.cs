namespace _01.PriorityQueueImplementation
{
    using System;

    public class PriorityQueue<T> where T : IComparable
    {
        private const int InitialCapacity = 4;
        private T[] innerHeap;
        private int index;
        
        public PriorityQueue()
        {
            this.innerHeap = new T[InitialCapacity];
            this.index = -1;
        }

        public int Count
        {
            get
            {
                return this.index + 1;
            }
        }
        
        public void Enqueue(T element)
        {


            this.index++;

            if (this.index >= this.innerHeap.Length)
            {
                T[] doubledHeap = new T[this.innerHeap.Length * 2];

                Array.Copy(this.innerHeap, 0, doubledHeap, 0, this.innerHeap.Length);

                this.innerHeap = doubledHeap;
            }

            this.innerHeap[this.index] = element;

            int childIndex = this.index;
            int parentIndex = (childIndex) / 2;


            while (innerHeap[childIndex].CompareTo(innerHeap[parentIndex]) > 0)
            {
                T childIndexValue = this.innerHeap[childIndex];
                this.innerHeap[childIndex] = this.innerHeap[parentIndex];
                this.innerHeap[parentIndex] = childIndexValue;
                
                if (parentIndex == 0)
                {
                    break;
                }

                childIndex = parentIndex;
                parentIndex = (childIndex) / 2;
            }
        }
        
        public T Dequeue()
        {

            if (this.Count <= 0)
            {
                throw new InvalidOperationException("Priority queue is empty.");
            }

            var result = this.innerHeap[0];
            var copyArray = new T[this.Count - 1];
            Array.Copy(this.innerHeap, 1, copyArray, 0, this.Count - 1);
            innerHeap = copyArray;

            this.index--;

            return result;
        }
        
        public T Peek()
        {
            return this.innerHeap[0];
        }
    }
}
