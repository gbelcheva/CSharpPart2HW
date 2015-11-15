namespace DateFirst.Data.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Transactions;

    using Contracts;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using TestObjects;

    [TestClass]
    public class EfRepositoryTests
    {
        private TransactionScope tran;
        private static Mock<IRepository<TestEntity>> mockedRepository;
        private static IRepository<TestEntity> mockedRepositoryObject;
        private static readonly IList<TestEntity> entitiesSet = new List<TestEntity>
        {
            new TestEntity { Id = 1, Name = "Pesho" },
            new TestEntity { Id = 2, Name = "Gosho" },
            new TestEntity { Id = 3, Name = "Stamat" },
            new TestEntity { Id = 4, Name = "Mariika" },
            new TestEntity { Id = 5, Name = "Stoqnka" },
        };

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            mockedRepository = new Mock<IRepository<TestEntity>>();
            mockedRepository.Setup(r => r.All())
                .Returns(entitiesSet.AsQueryable());
            mockedRepository.Setup(r => r.Add(It.IsAny<TestEntity>()))
                .Callback(() => entitiesSet.Add(It.IsAny<TestEntity>()));
            mockedRepository.Setup(r => r.Update(It.IsAny<TestEntity>()))
                .Verifiable();
            mockedRepository.Setup(r => r.Delete(It.IsAny<TestEntity>()))
                .Callback(() => entitiesSet.RemoveAt(default(int)));
            mockedRepository.Setup(r => r.Delete(It.IsAny<int>()))
                .Callback(() => entitiesSet.RemoveAt(default(int)));
            mockedRepository.Setup(r => r.GetById(It.IsAny<int>()))
                .Callback(() => entitiesSet.FirstOrDefault());
            mockedRepository.Setup(r => r.Attach(It.IsAny<TestEntity>()))
                .Verifiable();
            mockedRepository.Setup(r => r.Detach(It.IsAny<TestEntity>()))
                .Verifiable();
            mockedRepository.Setup(r => r.Dispose())
                .Verifiable();
            mockedRepository.Setup(r => r.SaveChanges())
                .Verifiable();
            mockedRepositoryObject = mockedRepository.Object;
        }

        [TestInitialize]
        public void TestInit()
        {
            this.tran = new TransactionScope();
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            this.tran.Dispose();
        }

        [TestMethod]
        public void AllShouldReturnDbData()
        {
            IQueryable<TestEntity> dbData = mockedRepositoryObject.All();
            Assert.AreEqual(entitiesSet.Count(), dbData.Count());
        }

        [TestMethod]
        public void AddShouldAddDbObject()
        {
            int oldEntitiesCount = mockedRepositoryObject.All().Count();
            var entity = new TestEntity { Id = 21, Name = "TestEntity" };
            mockedRepositoryObject.Add(entity);
            int newEntitiesCount = mockedRepositoryObject.All().Count();
            Assert.AreEqual(oldEntitiesCount + 1, newEntitiesCount);
        }

        [TestMethod]
        public void RemoveEntityShouldRemoveEntity()
        {
            int oldEntitiesCount = mockedRepositoryObject.All().Count();
            TestEntity entity = mockedRepositoryObject.All().FirstOrDefault();
            mockedRepositoryObject.Delete(entity);
            int newEntitiesCount = mockedRepositoryObject.All().Count();
            Assert.AreEqual(oldEntitiesCount - 1, newEntitiesCount);
        }

        [TestMethod]
        public void RemoveEntityByIdShouldRemoveEntity()
        {
            int oldEntitiesCount = mockedRepositoryObject.All().Count();
            int entityId = mockedRepositoryObject.All().FirstOrDefault().Id;
            mockedRepositoryObject.Delete(entityId);
            int newEntitiesCount = mockedRepositoryObject.All().Count();
            Assert.AreEqual(oldEntitiesCount - 1, newEntitiesCount);
        }

        [TestMethod]
        public void AttachShouldAttachEntity()
        {
            var entity = new TestEntity { Id = 25, Name = "TestEntity" };
            mockedRepositoryObject.Attach(entity);
            mockedRepository.Verify(x => x.Attach(It.IsAny<TestEntity>()));
        }

        [TestMethod]
        public void DetachShouldDetachEntity()
        {
            TestEntity entity = mockedRepositoryObject.All().FirstOrDefault();
            mockedRepositoryObject.Detach(entity);
            mockedRepository.Verify(x => x.Detach(It.IsAny<TestEntity>()));
        }

        [TestMethod]
        public void DisposeShouldBeCalled()
        {
            mockedRepositoryObject.Dispose();
            mockedRepository.Verify(x => x.Dispose());
        }

        [TestMethod]
        public void SaveChangesShouldBeCalled()
        {
            mockedRepositoryObject.SaveChanges();
            mockedRepository.Verify(x => x.SaveChanges());
        }
    }
}
