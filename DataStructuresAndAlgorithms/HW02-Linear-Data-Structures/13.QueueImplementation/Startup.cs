//Implement the ADT queue as dynamic linked list.

//    Use generics(LinkedQueue<T>) to allow storing different data types in the queue.


namespace QueueImplementation
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var testQueue = new MyQueue<int>();

            Console.WriteLine("Initial count: {0}", testQueue.Count);
            Console.WriteLine(new string('=', Console.BufferWidth - 1));

            for (int i = 1; i <= 10; i++)
            {
                testQueue.Enqueue(i);
                Console.WriteLine("Enqueuing: {0}", i);
            }

            Console.WriteLine("Count: {0}", testQueue.Count);
            Console.WriteLine("Queue: {0}", testQueue);
            Console.WriteLine(new string('=', Console.BufferWidth - 1));

            Console.WriteLine("Dequeuing one element: {0}", testQueue.Dequeue());
            Console.WriteLine("Count: {0}", testQueue.Count);
            Console.WriteLine("Queue: {0}", testQueue);
        }
    }
}
