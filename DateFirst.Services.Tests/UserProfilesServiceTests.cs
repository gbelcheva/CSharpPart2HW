using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DateFirst.Services.Tests
{
    using Data.Repositories;
    using Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using System.Linq;
    using System.Collections.Generic;
    using Contracts;

    [TestClass]
    public class UserProfilesServiceTests
    {
        private static readonly IQueryable<User> mockedUsers = new List<User>().AsQueryable();

        private static Mock<IUserProfilesService> mockedUserProfiles;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            var mockedUserProfilesService = new Mock<IUserProfilesService>();
            mockedUserProfilesService.Setup(s => s.GetAllUsers())
                .Returns(mockedUsers);
            mockedUserProfilesService.Setup(s => s.AddUser(It.IsAny<User>()))
                .Verifiable();
            mockedUserProfiles = mockedUserProfilesService;
        }

        [TestMethod]
        public void GetAllUsersShouldNotReturnNull()
        {
            IQueryable<User> users = mockedUserProfiles.Object.GetAllUsers();
            Assert.AreNotEqual(null, users);
        }

        [TestMethod]
        public void AddUserShouldBeCalled()
        {
            mockedUserProfiles.Object.AddUser(new User());
            mockedUserProfiles.Verify(s => s.AddUser(It.IsAny<User>()));
        }
    }
}
