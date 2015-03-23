namespace _05Problem
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    class GenList
    {
        class GenericList<T> : IEnumerable<T> where T : System.IComparable<T>
        {
            private const int DEFAULT_CAPACITY = 0;
            private const int INITIAL_CAPACITY = 4;

            private T[] GList;
            public int Count { get; private set; }
            public int Capacity{ get; private set; }
            // indexer
            public T this[int index]
            {
                get
                {
                    if (0 > index || index > this.Count - 1)
                    {
                        throw new IndexOutOfRangeException("Index must be in the range [0," + (this.Count - 1) + "]");
                    }
                    return this.GList[index];
                }
                private set
                {
                    this.GList[index] = value;
                }
            }
            // constructor
            public GenericList(int capacity = DEFAULT_CAPACITY)
            {
                this.Capacity = capacity;
                this.GList = new T[this.Capacity];
            }
            // Add() method
            public void Add(T element)
            {
                if (this.Capacity == 0)
                {
                    this.Capacity = INITIAL_CAPACITY;
                    this.GList = new T[this.Capacity];
                }
                if (this.Count == this.Capacity)
                {
                    
                    var tmpElements = this.GList;
                    this.Capacity = 2 * this.Capacity;
                    this.GList = new T[this.Capacity];
                    Array.Copy(tmpElements, this.GList, this.Count);
                }
                this.GList[this.Count] = element;
                this.Count++;
            }
            // remove element by index
            public void Remove(int index)
            {
                if (0 > index || index > this.Count)
                {
                    throw new IndexOutOfRangeException("Index must be in the range [0," + (this.Count - 1) + "]");
                }
                if (this.Capacity == 0)
                {
                    throw new IndexOutOfRangeException("No element to remove. The GenericList is empty.");
                }
                var tmpElements = new T[this.Count];
                Array.Copy(this.GList, tmpElements, this.Count);
                Array.Copy(tmpElements, this.GList, index);
                Array.Copy(tmpElements, index + 1, this.GList, index, this.Count - 1 - index);
                this.Count--;
            }
            // insert element at index
            public void Insert(T element, int index)
            {
                if (0 > index || index > this.Count)
                {
                    throw new IndexOutOfRangeException("Index must be in the range [0," + (this.Count - 1) + "]");
                }
                var tmpElements = new T[this.Count];
                Array.Copy(this.GList, tmpElements, this.Count);
                Add(element); // add element to adjust count and capacity
                Array.Copy(tmpElements, this.GList, index);
                this.GList[index] = element;
                Array.Copy(tmpElements, index, this.GList, index + 1, this.Count - 1 - index);
            }
            // clear list
            public void Clear()
            {
                this.Count = 0;
                this.Capacity = 0;
                this.GList = new T[0];
            }
            // find element by value
            public int IndexOf(T element)
            {
                int foundIndex = -1;
                for (int i = 0; i < this.Count; i++)
                {
                    if (this.GList[i].Equals(element))
                    {
                        return foundIndex = i;
                    }
                }
                return foundIndex;
            }

            public T Min()
            {
                if (this.Count == 0)
                {
                    throw new ArgumentOutOfRangeException("No minimal element. The GenericList is empty.");
                }
                T minElement = this.GList[0];
                for (int i = 1; i < this.Count; i++)
                {
                    if (minElement.CompareTo(this.GList[i]) > 0)
                    {
                        minElement = this.GList[i];
                    }
                }
                return minElement;
            }

            public T Max()
            {
                if (this.Count == 0)
                {
                    throw new ArgumentOutOfRangeException("No minimal element. The GenericList is empty.");
                }
                T maxElement = this.GList[0];
                for (int i = 1; i < this.Count; i++)
                {
                    if (maxElement.CompareTo(this.GList[i]) < 0)
                    {
                        maxElement = this.GList[i];
                    }
                }
                return maxElement;
            }

            // ToString() override
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < this.Count; i++)
                {
                    sb.Append(this.GList[i] + " ");
                }
                if (sb.Length != 0)
                {
                    sb.Length -= 1;
                }
                return sb.ToString();
            }

            public IEnumerator<T> GetEnumerator() 
            {
                for (int i = 0; i < this.Count; i++)
                {
                    var element = this.GList[i];
                    yield return element;
                }
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return this.GetEnumerator();
            }
        }




        static void Main()
        {
            GenericList<int> test = new GenericList<int>();
            test.Add(1);
            test.Add(2);
            test.Add(54);
            test.Add(5);
            test.Add(6);
            Console.WriteLine("check ToString()");
            Console.WriteLine(test);
            Console.WriteLine("check capacity");
            Console.WriteLine(test.Capacity);
            Console.WriteLine("check count");
            Console.WriteLine(test.Count);
            Console.WriteLine("check foreach");
            foreach (var item in test)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("check indexer");
            for (int i = 0; i < test.Count; i++)
            {
                Console.WriteLine(test[i]);
            }
            Console.WriteLine("check accessing element at index 3");
            Console.WriteLine(test[3]);
            Console.WriteLine("check remove element at index 0");
            test.Remove(0);
            Console.WriteLine(test);
            Console.WriteLine("check insert element 256 at index 2");
            test.Insert(256, 2);
            Console.WriteLine(test);
            Console.WriteLine("check index of element 6");
            int index = test.IndexOf(6);
            Console.WriteLine(index);
            Console.WriteLine("check index of element 102");
            index = test.IndexOf(102);
            Console.WriteLine(index);
            Console.WriteLine("check min element");
            Console.WriteLine(test.Min());
            Console.WriteLine("check max element");
            Console.WriteLine(test.Max());
            Console.WriteLine("check clear list");
            test.Clear();
            Console.WriteLine(test);
            
        }
    }
}
