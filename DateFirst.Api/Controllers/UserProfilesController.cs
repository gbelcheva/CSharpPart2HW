namespace DateFirst.Api.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;

    using AutoMapper.QueryableExtensions;
    using Data.Repositories;
    using DataTransferModels;
    using Services;
    using DateFirst.Models;

    public class UserProfilesController : ApiController
    {
        private const string UserSuccessfullyAddedMessage = "User successfully added";
        private const string InvalidUserToAddMessage = "Invalid user";

        private readonly UserProfilesService users;

        public UserProfilesController(IDateFirstData data)
        {
            this.users = new UserProfilesService(data);
        }
        
        [HttpGet]
        public IHttpActionResult Get()
        {
            IEnumerable<UserTransferModel> res = this.users.GetAllUsers()
                .ProjectTo<UserTransferModel>()
                .ToList();

            return this.Ok(res);
        }

        [HttpGet]
        public IHttpActionResult Get(string id)
        {
            var res = this.users.GetAllUsers()
                .Where(u => u.Id == id)
                .ProjectTo<UserTransferModel>()
                .FirstOrDefault();

            return this.Ok(res);
        }

        //[HttpPost]
        //public IHttpActionResult Post([FromBody]UserProfileTransferModel value)
        //{
        //    if (value == null || !this.ModelState.IsValid)
        //    {
        //        return this.BadRequest(InvalidUserToAddMessage);
        //    }

        //    UserProfile user = Mapper.Map<UserProfileTransferModel, UserProfile>(value);
        //    int changesMade = this.users.AddUser(user);
        //    return this.Ok(UserSuccessfullyAddedMessage);
        //}

    }
}