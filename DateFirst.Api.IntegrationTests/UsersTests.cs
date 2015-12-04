namespace DateFirst.Api.IntegrationTests
{
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;

    using DataTransferModels;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MyTested.WebApi;

    [TestClass]
    public class UsersTests
    {
        private static IServerBuilder server;

        [ClassInitialize]
        public static void Init(TestContext testContext)
        {
            server = MyWebApi.Server().Starts<Startup>();
        }

        [TestMethod]
        public void GetAllUserProfilesShouldReturnCorrectResponse()
        {
            server
                .WithHttpRequestMessage(req => req
                    .WithMethod(HttpMethod.Get)
                    .WithRequestUri("api/userProfiles"))
                .ShouldReturnHttpResponseMessage()
                .WithStatusCode(HttpStatusCode.OK)
                .WithResponseModelOfType<List<UserTransferModel>>()
                .Passing(model =>
                {
                    Assert.AreEqual(2, model.Count);
                });
        }

        [TestMethod]
        public void GetAllMaleUserProfilesShouldReturnCorrectResponse()
        {
            server
                .WithHttpRequestMessage(req => req
                    .WithMethod(HttpMethod.Get)
                    .WithRequestUri("api/MaleUserProfiles"))
                .ShouldReturnHttpResponseMessage()
                .WithStatusCode(HttpStatusCode.OK)
                .WithResponseModelOfType<List<UserTransferModel>>()
                .Passing(model =>
                {
                    Assert.AreEqual(1, model.Count);
                }); ;
        }

        [TestMethod]
        public void GetAllFemaleUserProfilesShouldReturnCorrectResponse()
        {
            server
                .WithHttpRequestMessage(req => req
                    .WithMethod(HttpMethod.Get)
                    .WithRequestUri("api/FemaleUserProfiles"))
                .ShouldReturnHttpResponseMessage()
                .WithStatusCode(HttpStatusCode.OK)
                .WithResponseModelOfType<List<UserTransferModel>>()
                .Passing(model =>
                {
                    Assert.AreEqual(1, model.Count);
                }); ;
        }

        [TestMethod]
        public void SearchUserProfilesShouldReturnCorrectResponse()
        {
            server
                .WithHttpRequestMessage(req => req
                    .WithMethod(HttpMethod.Get)
                    .WithRequestUri("api/UserProfiles/GetSearchedUsers"))
                .ShouldReturnHttpResponseMessage()
                .WithStatusCode(HttpStatusCode.OK);
        }

        [ClassCleanup]
        public static void Clean()
        {
            MyWebApi.Server().Stops();
        }
    }
}
