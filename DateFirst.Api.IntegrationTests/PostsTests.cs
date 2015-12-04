namespace DateFirst.Api.IntegrationTests
{
    using System.Net;
    using System.Net.Http;
    
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MyTested.WebApi;

    [TestClass]
    public class PostsTests
    {
        private static IServerBuilder server;

        [ClassInitialize]
        public static void Init(TestContext testContext)
        {
            server = MyWebApi.Server().Starts<Startup>();
        }


        [TestMethod]
        public void NullRequestModelShouldReturnCorrectResponse()
        {
            server
                .WithHttpRequestMessage(req => req
                    .WithMethod(HttpMethod.Post)
                    .WithRequestUri("api/posts"))
                .ShouldReturnHttpResponseMessage()
                .WithStatusCode(HttpStatusCode.BadRequest);
        }

        [TestMethod]
        public void InvalidRequestModelShouldReturnCorrectResponse()
        {
            server
                .WithHttpRequestMessage(req => req
                    .WithMethod(HttpMethod.Post)
                    .WithJsonContent("{\"Content\":\"Test Content\"")
                    .WithRequestUri("api/posts"))
                .ShouldReturnHttpResponseMessage()
                .WithStatusCode(HttpStatusCode.BadRequest);
        }

        [TestMethod]
        public void ValidRequestModelShouldReturnCorrectResponse()
        {
            server
                .WithHttpRequestMessage(req => req
                    .WithMethod(HttpMethod.Post)
                    .WithJsonContent("{\"Content\":\"Test Content\",\"SenderId\":\"goshoId\",\"ReceiverId\":\"peshoId\"}")
                    .WithRequestUri("api/posts"))
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
