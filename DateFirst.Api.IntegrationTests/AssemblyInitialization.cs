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
    using Infrastructure;

    [TestClass]
    public class AssemblyInitialization
    {
        public static IIdentity IdentityMock;

        [AssemblyInitialize]
        public static void Init(TestContext testContext)
        {
            var mockedIdentity = new Mock<IIdentity>();
            mockedIdentity.Setup(i => i.Name)
                .Returns("pesho");

            var mockedPrincipal = new Mock<IPrincipal>();
            mockedPrincipal.Setup(p => p.Identity)
                .Returns(mockedIdentity.Object);

            var mockedIdentityProvider = new Mock<IIdentityProvider>();
            mockedIdentityProvider.Setup(p => p.GetIdentity())
                .Returns(mockedPrincipal.Object);

            IdentityMock = mockedIdentity.Object;

            Mock<IDateFirstData> mockedData = GetMockedData();
            Action<IKernel> mockedDependencyResolver = kernel =>
            {
                kernel.Bind<IDateFirstData>().ToConstant(mockedData.Object);
                kernel.Bind<IIdentityProvider>().ToConstant(mockedIdentityProvider.Object);
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
                   AdditionalInfo = new AdditionalInfo
                   {
                       Gender = Gender.Female,
                       EyeColor = EyeColor.Brown
                   }
               }
            }
            .AsQueryable());
            mockedRepository.Setup(r => r.GetById("peshoId"))
                .Returns(mockedRepository.Object.All().First());

            var result = new Mock<IDateFirstData>();
            result.Setup(d => d.Users).Returns(mockedRepository.Object);

            return result;
        }
    }
}
