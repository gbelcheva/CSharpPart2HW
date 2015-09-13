namespace BowlExample
{
    using BowlExample.ObjectPool;
    using System;

    class Client
    {
        static void Main(string[] args)
        {
            BowlingShoesPool poolManager = BowlingShoesPool.Instance;

            Console.WriteLine("Shoes in pool: " + poolManager.CurrentObjectsInPoolCount);

            var bowlingShoes = poolManager.GetBowlingShoes();
            bowlingShoes.Size = 39;

            Console.WriteLine("Getting a pair of shoes from pool: " + bowlingShoes);
            Console.WriteLine("Shoes objects left in pool: " + poolManager.CurrentObjectsInPoolCount);
            Console.WriteLine("Releasing bowling shoes: " + poolManager.ReleaseBowlingShoes(bowlingShoes));
            Console.WriteLine("Shoes objects left in pool: " + poolManager.CurrentObjectsInPoolCount);            
        }
    }
}
