using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DateFirst.Api.IntegrationTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MyTested.WebApi;
    using System.Net;
    using System.Net.Http;

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
                .WithStatusCode(HttpStatusCode.OK);
        }

        [ClassCleanup]
        public static void Clean()
        {
            MyWebApi.Server().Stops();
        }
    }
}
