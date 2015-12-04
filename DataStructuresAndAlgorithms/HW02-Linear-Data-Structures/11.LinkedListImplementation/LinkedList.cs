namespace LinkedListImplementation
{
    using System;
    using System.Collections.Generic;

    public class LinkedList<T> : IEnumerable<T>
    {
        public ListItem<T> FirstElement { get; set; }

        public int Count()
        {
            if (this.FirstElement == null)
            {
                return 0;
            }

            int counter = 1;

            var currentElement = this.FirstElement;

            while (currentElement.NextItem != null)
            {
                currentElement = currentElement.NextItem;
                counter++;
            }

            return counter;
        }

        public void InsertFirst(T value)
        {
            var newElement = new ListItem<T>(value);

            if (this.FirstElement == null)
            {
                this.FirstElement = newElement;

                return;
            }

            newElement.NextItem = this.FirstElement;
            this.FirstElement = newElement;
        }

        public void InsertLast(T value)
        {
            if (this.FirstElement == null)
            {
                this.FirstElement = new ListItem<T>(value);

                return;
            }

            var newElement = this.FirstElement;

            while (newElement.NextItem != null)
            {
                newElement = newElement.NextItem;
            }

            newElement.NextItem = new ListItem<T>(value);
        }

        public void DeleteFirst()
        {
            this.FirstElement = this.FirstElement.NextItem;
        }

        public void DeleteLast()
        {
            ListItem<T> newElement = this.FirstElement;

            while (newElement.NextItem != null)
            {
                newElement = newElement.NextItem;
            }

            newElement.NextItem = null;
        }


        public IEnumerator<T> GetEnumerator()
        {
            var currentElement = this.FirstElement;

            while (currentElement != null)
            {
                yield return currentElement.Value;
                currentElement = currentElement.NextItem;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            return string.Join(", ", this).TrimEnd(new char[] { ' ', ','});
        }
    }
}

