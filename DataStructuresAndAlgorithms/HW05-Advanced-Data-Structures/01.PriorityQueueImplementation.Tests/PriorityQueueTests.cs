namespace _01.PriorityQueueImplementation.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PriorityQueueTests
    {

        [TestMethod]
        public void InitialCountShouldBeZero()
        {
            var priorityQueue = new PriorityQueue<int>();
            Assert.AreEqual(0, priorityQueue.Count);
        }

        [TestMethod]
        public void CountShouldReturnNumberOfElements()
        {
            var priorityQueue = new PriorityQueue<int>();

            for (int i = 0; i < 100; i++)
            {
                priorityQueue.Enqueue(i);
            }
            Assert.AreEqual(100, priorityQueue.Count);
        }

        [TestMethod]
        public void DequeueingShouldObservePriority()
        {
            var priorityQueue = new PriorityQueue<int>();
            priorityQueue.Enqueue(8);
            priorityQueue.Enqueue(9);
            priorityQueue.Enqueue(11);
            priorityQueue.Enqueue(5);

            Assert.AreEqual(11, priorityQueue.Dequeue());
            Assert.AreEqual(9, priorityQueue.Dequeue());
            Assert.AreEqual(8, priorityQueue.Dequeue());
            Assert.AreEqual(5, priorityQueue.Dequeue());
        }
    }
}
