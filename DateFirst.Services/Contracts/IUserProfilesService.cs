namespace DateFirst.Services.Contracts
{
    using System.Linq;

    using Models;

    public interface IUserProfilesService
    {
        IQueryable<User> GetAllUsers();

        int AddUser(User newUserProfile);
    }
}
