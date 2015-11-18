using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        private static Mock<IDateFirstData> mockedData;
        private static IDateFirstData mockedDataObject;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            IRepository<TestEntity> mockedRepositoryObject = new Mock<IRepository<TestEntity>>().Object;
            var data = new Mock<IDateFirstData>();
            data.Setup(x => x.GetRepository<TestEntity>())
                .Returns(mockedRepositoryObject);
            mockedDataObject = data.Object;
            mockedData = data;
        }

        /// <summary>
        /// Only this method is being tested since it is invoked for every repository
        /// </summary>

        [TestMethod]
        public void GetRepositoryShouldBeCalled()
        {
            IRepository<TestEntity> repository = mockedDataObject.GetRepository<TestEntity>();
            mockedData.Verify(d => d.GetRepository<TestEntity>());
        }
        
        [TestMethod]
        public void GetEntityShouldNotReturnNull()
        {
            IRepository<TestEntity> repository = mockedDataObject.GetRepository<TestEntity>();
            Assert.AreNotEqual(null, repository);
        }
    }
}
