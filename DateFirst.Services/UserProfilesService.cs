namespace DateFirst.Services
{
    using Data.Repositories;
    using Models;
    using System.Linq;

    public class UserProfilesService
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
