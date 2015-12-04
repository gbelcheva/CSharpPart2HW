//Implement the ADT stack as auto-resizable array.

//    Resize the capacity on demand (when no space is available to add / insert a new element).


namespace StackImplementation
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var testStack = new MyStack<int>();
            Console.WriteLine("Initial capacity: {0}", testStack.Capacity);
            Console.WriteLine("Initial count: {0}", testStack.Count);
            Console.WriteLine(new string('=', Console.BufferWidth - 1));

            for (int i = 1; i <= 10; i++)
            {
                testStack.Push(i);
                Console.WriteLine("Adding: {0}, (Capacity: {1})", i, testStack.Capacity);
            }

            Console.WriteLine("Capacity: {0}", testStack.Capacity);
            Console.WriteLine("Count: {0}", testStack.Count);
            Console.WriteLine("Stack: {0}", testStack);
            Console.WriteLine(new string('=', Console.BufferWidth - 1));

            Console.WriteLine("Popping one element: {0}", testStack.Pop());
            Console.WriteLine("Capacity: {0}", testStack.Capacity);
            Console.WriteLine("Count: {0}", testStack.Count);
            Console.WriteLine("Stack: {0}", testStack);
            Console.WriteLine(new string('=', Console.BufferWidth - 1));

            Console.WriteLine("Clearing stack.");
            testStack.Clear();
            Console.WriteLine("Capacity: {0}", testStack.Capacity);
            Console.WriteLine("Count: {0}", testStack.Count);
            Console.WriteLine("Stack: {0}", testStack);
        }
    }
}
