namespace ZooExample.Animals
{
    using System;
    using ZooExample.Contracts;

    public class MallardDuck : IDuck
    {
        public void Quack()
        {
            Console.WriteLine("- Quack-quack.");
        }

        public void Fly()
        {
            Console.WriteLine("- I am flying.");
        }
    }
}
