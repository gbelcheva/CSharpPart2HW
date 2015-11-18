namespace DateFirst.Api.IntegrationTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Data.Contracts;
    using Data.Repositories;
    using DateFirst.Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using Ninject;

    [TestClass]
    public class AssemblyInitialization
    {
        [AssemblyInitialize]
        public static void Init(TestContext testContext)
        {
            Mock<IDateFirstData> mockedData = GetMockedData();
            Action<IKernel> mockedDependencyResolver = kernel =>
            {
                kernel.Bind<IDateFirstData>().ToConstant(mockedData.Object);
            };

            NinjectConfig.ResolveDependencies = mockedDependencyResolver;
            AutomapperConfig.Initialize();
        }

        private static Mock<IDateFirstData> GetMockedData()
        {
            var mockedRepository = new Mock<IRepository<User>>();
            mockedRepository.Setup(r => r.All()).Returns(new List<User>().AsQueryable());

            var result = new Mock<IDateFirstData>();
            result.Setup(d => d.Users).Returns(mockedRepository.Object);

            return result;
        }
    }
}
