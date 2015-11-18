namespace DateFirst.Api.IntegrationTests
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Security.Principal;

    using Data.Repositories;
    using Infrastructure;
    using Microsoft.AspNet.Identity.Fakes;
    using Microsoft.QualityTools.Testing.Fakes;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using MyTested.WebApi;
    using Ninject;

    [TestClass]
    public class FlirtsTests
    {
        private static IServerBuilder server;

        [ClassInitialize]
        public static void Init(TestContext testContext)
        {
            server = MyWebApi.Server().Starts<Startup>();
        }

        [TestMethod]
        public void GetFlirtsAuthenticatedShouldReturnCorrectResponse()
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

            Mock<IDateFirstData> mockedData =
                AssemblyInitialization.GetMockedData();
            Action<IKernel> mockedDependencyResolver = kernel =>
            {
                kernel.Bind<IDateFirstData>().ToConstant(mockedData.Object);
                kernel.Bind<IIdentityProvider>().ToConstant(mockedIdentityProvider.Object);
            };

            NinjectConfig.ResolveDependencies = mockedDependencyResolver;

            using (ShimsContext.Create())
            {
                ShimIdentityExtensions.GetUserIdIIdentity =
                    (identity) => "peshoId";

                server
                    .WithHttpRequestMessage(req => req
                        .WithMethod(HttpMethod.Get)
                        .WithRequestUri("api/flirts"))
                    .ShouldReturnHttpResponseMessage()
                    .WithStatusCode(HttpStatusCode.OK);

            }
        }

        [TestMethod]
        public void GetFlirtsUnauthenticatedShouldReturnCorrectResponse()
        {
            var mockedIdentity = new Mock<IIdentity>();
            mockedIdentity.Setup(i => i.Name)
                .Returns(default(string));

            var mockedPrincipal = new Mock<IPrincipal>();
            mockedPrincipal.Setup(p => p.Identity)
                .Returns(mockedIdentity.Object);

            var mockedIdentityProvider = new Mock<IIdentityProvider>();
            mockedIdentityProvider.Setup(p => p.GetIdentity())
                .Returns(mockedPrincipal.Object);

            Mock<IDateFirstData> mockedData = AssemblyInitialization.GetMockedData();
            Action<IKernel> mockedDependencyResolver = kernel =>
            {
                kernel.Bind<IDateFirstData>().ToConstant(mockedData.Object);
                kernel.Bind<IIdentityProvider>().ToConstant(mockedIdentityProvider.Object);
            };

            NinjectConfig.ResolveDependencies = mockedDependencyResolver;

            server
                .WithHttpRequestMessage(req => req
                    .WithMethod(HttpMethod.Get)
                    .WithRequestUri("api/flirts"))
                .ShouldReturnHttpResponseMessage()
                .WithStatusCode(HttpStatusCode.BadRequest);
        }

        [TestMethod]
        public void PutFlirtsUnauthenticatedShouldReturnCorrectResponse()
        {
            var mockedIdentity = new Mock<IIdentity>();
            mockedIdentity.Setup(i => i.Name)
                .Returns(default(string));

            var mockedPrincipal = new Mock<IPrincipal>();
            mockedPrincipal.Setup(p => p.Identity)
                .Returns(mockedIdentity.Object);

            var mockedIdentityProvider = new Mock<IIdentityProvider>();
            mockedIdentityProvider.Setup(p => p.GetIdentity())
                .Returns(mockedPrincipal.Object);

            Mock<IDateFirstData> mockedData = AssemblyInitialization.GetMockedData();
            Action<IKernel> mockedDependencyResolver = kernel =>
            {
                kernel.Bind<IDateFirstData>().ToConstant(mockedData.Object);
                kernel.Bind<IIdentityProvider>().ToConstant(mockedIdentityProvider.Object);
            };

            NinjectConfig.ResolveDependencies = mockedDependencyResolver;

            server
                .WithHttpRequestMessage(req => req
                    .WithMethod(HttpMethod.Put)
                    .WithRequestUri("api/flirts"))
                .ShouldReturnHttpResponseMessage()
                .WithStatusCode(HttpStatusCode.BadRequest);
        }

        [TestMethod]
        public void PutFlirtsAuthSameUserShouldReturnCorrectResponse()
        {
            var mockedIdentity = new Mock<IIdentity>();
            mockedIdentity.Setup(i => i.Name)
                .Returns("peshoId");

            var mockedPrincipal = new Mock<IPrincipal>();
            mockedPrincipal.Setup(p => p.Identity)
                .Returns(mockedIdentity.Object);

            var mockedIdentityProvider = new Mock<IIdentityProvider>();
            mockedIdentityProvider.Setup(p => p.GetIdentity())
                .Returns(mockedPrincipal.Object);

            Mock<IDateFirstData> mockedData = AssemblyInitialization.GetMockedData();
            Action<IKernel> mockedDependencyResolver = kernel =>
            {
                kernel.Bind<IDateFirstData>().ToConstant(mockedData.Object);
                kernel.Bind<IIdentityProvider>().ToConstant(mockedIdentityProvider.Object);
            };

            NinjectConfig.ResolveDependencies = mockedDependencyResolver;

            using (ShimsContext.Create())
            {
                ShimIdentityExtensions.GetUserIdIIdentity =
                    (identity) => "peshoId";

                server
                    .WithHttpRequestMessage(req => req
                        .WithMethod(HttpMethod.Put)
                        .WithRequestUri("api/flirts")
                        .WithJsonContent("{\"Id\":\"peshoId\"}"))
                    .ShouldReturnHttpResponseMessage()
                    .WithStatusCode(HttpStatusCode.BadRequest);

            }
        }

        [TestMethod]
        public void PutFlirtsAuthDifferentUserShouldReturnCorrectResponse()
        {
            var mockedIdentity = new Mock<IIdentity>();
            mockedIdentity.Setup(i => i.Name)
                .Returns("peshoId");

            var mockedPrincipal = new Mock<IPrincipal>();
            mockedPrincipal.Setup(p => p.Identity)
                .Returns(mockedIdentity.Object);

            var mockedIdentityProvider = new Mock<IIdentityProvider>();
            mockedIdentityProvider.Setup(p => p.GetIdentity())
                .Returns(mockedPrincipal.Object);

            Mock<IDateFirstData> mockedData = AssemblyInitialization.GetMockedData();
            Action<IKernel> mockedDependencyResolver = kernel =>
            {
                kernel.Bind<IDateFirstData>().ToConstant(mockedData.Object);
                kernel.Bind<IIdentityProvider>().ToConstant(mockedIdentityProvider.Object);
            };

            NinjectConfig.ResolveDependencies = mockedDependencyResolver;

            using (ShimsContext.Create())
            {
                ShimIdentityExtensions.GetUserIdIIdentity =
                    (identity) => "peshoId";

                server
                    .WithHttpRequestMessage(req => req
                        .WithMethod(HttpMethod.Put)
                        .WithRequestUri("api/flirts")
                        .WithJsonContent("{\"Id\":\"goshoId\"}"))
                    .ShouldReturnHttpResponseMessage()
                    .WithStatusCode(HttpStatusCode.OK);

            }
        }

        [ClassCleanup]
        public static void Clean()
        {
            MyWebApi.Server().Stops();
        }
    }
}
