namespace _05.HashsetImplementation
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using _04.HashtableImplementation;


    public class HashSet<T> : IEnumerable, IEnumerable<T> where T : IComparable<T>
    {
        private readonly HashTable<T, bool> elements;

        public HashSet()
        {
            this.elements = new HashTable<T, bool>();
        }

        public HashSet(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("Collection cannot be null.");
            }

            this.elements = new HashTable<T, bool>();

            foreach (var item in collection)
            {
                this.Add(item);
            }
        }

        public int Count
        {
            get
            {
                return this.elements.Count;
            }
        }

        public IEnumerable<T> Keys
        {
            get
            {
                var keys = new List<T>(this.elements.Keys);
                return keys;
            }
        }

        public bool Add(T item)
        {
            if (this.Contains(item))
            {
                return false;
            }

            this.elements.Add(item, true);

            return true;
        }

        public bool Contains(T item)
        {
            return this.elements.ContainsKey(item);
        }

        public bool Remove(T item)
        {
            return this.elements.Remove(item);
        }

        public void Clear()
        {
            this.elements.Clear();
        }

        public void UnionWith(IEnumerable<T> other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("Collection for union cannot be null.");
            }

            foreach (var item in other)
            {
                this.Add(item);
            }
        }

        public void IntersectWith(IEnumerable<T> other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("Collection for intersect cannot be null.");
            }

            var otherHashSet = new HashSet<T>(other);

            foreach (var item in this.Keys)
            {
                if (!otherHashSet.Contains(item))
                {
                    this.Remove(item);
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.Keys)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
