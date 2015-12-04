namespace DateFirst.Api.IntegrationTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Principal;

    using Data.Contracts;
    using Data.Repositories;
    using DateFirst.Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using Ninject;

    [TestClass]
    public class AssemblyInitialization
    {
        public static IIdentity IdentityMock;

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

        public static Mock<IDateFirstData> GetMockedData()
        {
            var mockedRepository = new Mock<IRepository<User>>();
            mockedRepository.Setup(r => r.All()).Returns(new List<User>
            {
               new User
               {
                   Id = "peshoId",
                   AdditionalInfo = new AdditionalInfo
                   {
                       Gender = Gender.Male,
                       EyeColor = EyeColor.Brown
                   },

                   Flirts = 3
               },

               new User
               {
                   Id = "goshoId",
                   AdditionalInfo = new AdditionalInfo
                   {
                       Gender = Gender.Female,
                       EyeColor = EyeColor.Brown
                   },

                   Flirts = 20
               }
            }
            .AsQueryable());

            mockedRepository.Setup(r => r.GetById("peshoId"))
                .Returns(mockedRepository.Object.All().First());
            mockedRepository.Setup(r => r.GetById("goshoId"))
                .Returns(mockedRepository.Object.All().Last());

            var result = new Mock<IDateFirstData>();
            result.Setup(d => d.Users).Returns(mockedRepository.Object);

            return result;
        }
    }
}
