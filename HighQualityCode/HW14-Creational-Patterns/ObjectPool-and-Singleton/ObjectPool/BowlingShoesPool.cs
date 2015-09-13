namespace BowlExample.ObjectPool
{
    using System.Collections.Generic;

    class BowlingShoesPool
    {
        private Queue<BowlingShoes> poolQueue = new Queue<BowlingShoes>();
        private HashSet<int> hashCodes = new HashSet<int>();
        private static readonly object objectLock = new object();
        private const int PoolSize = 10;
        private int count = 0;
        private static BowlingShoesPool poolManager = null;

        private BowlingShoesPool()
        {
            this.CreatePoolObjects();
        }
        public static BowlingShoesPool Instance
        {
            get
            {
                if (poolManager == null)
                {
                    poolManager = new BowlingShoesPool();
                }

                return poolManager;
            }
        }

        public int CurrentObjectsInPoolCount
        {
            get
            {
                return count;
            }
        }

        public int MaxObjectsInPool
        {
            get
            {
                return PoolSize;
            }
        }

        public BowlingShoes GetBowlingShoes()
        {
            if (count == 0)
            {
                return null;
            }

            lock (objectLock)
            {

                if (poolQueue.Count > 0)
                {
                    count--;

                    return poolQueue.Dequeue();
                }
            }

            return null;
        }

        public bool ReleaseBowlingShoes(BowlingShoes bowlingShoes)
        {
            bool belongsToThisPool = hashCodes.Contains(bowlingShoes.GetHashCode());
            bool poolIsFull = (count == PoolSize);

            if (poolIsFull || !belongsToThisPool)
            {
                return false;
            }

            lock (objectLock)
            {
                bowlingShoes.Size = 0;
                poolQueue.Enqueue(bowlingShoes);
                count++;
            }

            return true;
        }

        private void CreatePoolObjects()
        {
            count = 0;
            poolQueue.Clear();
            hashCodes.Clear();

            for (int objCounter = 0; objCounter < PoolSize; objCounter++)
            {
                var bowlingShoes = new BowlingShoes();

                lock (objectLock)
                {
                    hashCodes.Add(bowlingShoes.GetHashCode());
                    poolQueue.Enqueue(bowlingShoes);
                    count++;
                }
            }
        }
    }
}
