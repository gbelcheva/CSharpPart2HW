namespace DateFirst.Services
{
    using System.Linq;

    using Contracts;
    using Data.Repositories;
    using Models;

    public class UserProfilesService : IUserProfilesService
    {
        private readonly IDateFirstData data;

        public UserProfilesService(IDateFirstData data)
        {
            this.data = data;
        }

        public IQueryable<User> GetAllUsers()
        {
            return this.data.Users.All();
        }

        public int AddUser(User newUserProfile)
        {
            this.data.Users.Add(newUserProfile);
            return this.data.SaveChanges();
        }
    }
}
