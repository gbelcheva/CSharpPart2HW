namespace DateFirst.Data.Tests
{
    using Contracts;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using Repositories;
    using TestObjects;

    [TestClass]
    public class DateFirstDataTests
    {
        private static IDateFirstData mockedDataObject;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            IRepository<TestEntity> mockedRepositoryObject = new Mock<IRepository<TestEntity>>().Object;
            var mockedData = new Mock<IDateFirstData>();
            mockedData.Setup(x => x.GetRepository<TestEntity>())
                .Returns(mockedRepositoryObject);
            mockedDataObject = mockedData.Object;
        }

        /// <summary>
        /// Only this method is being tested since it is invoked for every repository
        /// </summary>
        [TestMethod]
        public void GetEntityShouldNotReturnNull()
        {
            IRepository<TestEntity> repository = mockedDataObject.GetRepository<TestEntity>();
            Assert.AreNotEqual(null, repository);
        }
    }
}
