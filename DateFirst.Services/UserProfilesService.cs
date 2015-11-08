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

        public IQueryable<UserProfile> GetAllUsers()
        {
            return this.data.UserProfiles.All();
        }

        public int AddUser(UserProfile newUserProfile)
        {
            this.data.UserProfiles.Add(newUserProfile);
            return this.data.SaveChanges();
        }
    }
}
