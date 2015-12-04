//We are given the following sequence:

//    S1 = N;
//    S2 = S1 + 1;
//    S3 = 2* S1 + 1;
//    S4 = S1 + 2;
//    S5 = S2 + 1;
//    S6 = 2* S2 + 1;
//    S7 = S2 + 2;
//    ...
//    Using the Queue<T> class write a program to print its first 50 members for given N.
//    Example: N= 2 → 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...


namespace First50MembersQueue
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Input N:");
            int n = Int32.Parse(Console.ReadLine());

            Queue<int> membersQueue = new Queue<int>();
            membersQueue.Enqueue(n);

            List<int> members = new List<int>();

            for (int i = 0; i < 50; i++)
            {
                int currentMember = membersQueue.Dequeue();
                members.Add(currentMember);

                membersQueue.Enqueue(currentMember + 1);
                membersQueue.Enqueue(2 * currentMember + 1);
                membersQueue.Enqueue(currentMember + 2);
            }

            Console.WriteLine(string.Join(", ", members));
        }
    }
}
