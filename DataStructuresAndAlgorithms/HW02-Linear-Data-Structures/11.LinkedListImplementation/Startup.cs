//Implement the data structure linked list.

//    Define a class ListItem<T> that has two fields: value(of type T) and NextItem(of type ListItem<T>).
//    Define additionally a class LinkedList<T> with a single field FirstElement(of type ListItem<T>).


namespace LinkedListImplementation
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var testList = new LinkedList<string>();

            Console.WriteLine("Count: {0}", testList.Count());
            Console.WriteLine(new string('=', Console.BufferWidth - 1));

            for (int i = 0; i < 10; i++)
            {
                var currentString = "string" + i;
                Console.WriteLine("Inserting first: {0}", currentString);
                testList.InsertFirst(currentString);
            }

            Console.WriteLine("count: {0}", testList.Count());
            Console.WriteLine("First element: {0}", testList.FirstElement);
            Console.WriteLine("Full list: {0}", testList);
            Console.WriteLine(new string('=', Console.BufferWidth - 1));

            Console.WriteLine("Inserting first: hello");
            testList.InsertFirst("hello");
            Console.WriteLine("Count: {0}", testList.Count());
            Console.WriteLine("First element: {0}", testList.FirstElement);
            Console.WriteLine("Full list: {0}", testList);
            Console.WriteLine(new string('=', Console.BufferWidth - 1));

            Console.WriteLine("Inserting last: bye");
            testList.InsertLast("bye");
            Console.WriteLine("Count: {0}", testList.Count());
            Console.WriteLine("Full list: {0}", testList);
            Console.WriteLine(new string('=', Console.BufferWidth - 1));

            Console.WriteLine("Deleting first");
            testList.DeleteFirst();
            Console.WriteLine("Count: {0}", testList.Count());
            Console.WriteLine("Full list: {0}", testList);
        }
    }
}
