namespace ZooExample.Animals
{
    using System;
    using ZooExample.Contracts;

    public class WildTurkey : ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("- Gobble-gobble.");
        }

        public void Fly()
        {
            Console.WriteLine("- I am flying a short distance.");
        }
    }
}
