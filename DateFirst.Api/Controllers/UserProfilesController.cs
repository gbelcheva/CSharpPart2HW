namespace DateFirst.Api.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Data.Repositories;
    using DataTransferModels;
    using DateFirst.Models;

    public class UserProfilesController : ApiController
    {
        private readonly IDateFirstData data;

        public UserProfilesController(IDateFirstData data)
        {
            this.data = data;
        }

        // GET: UserProfiles
        public IHttpActionResult Get()
        {
            var res = this.data.UserProfiles.All()
                .ProjectTo<UserTransferModel>()
                .ToList();

            return this.Ok(res);
        }

        public IHttpActionResult Post([FromBody]UserTransferModel value)
        {
            var user = Mapper.Map<UserTransferModel, UserProfile>(value);
            //var dept = new Department
            //{
            //    Name = value.DepartmentName
            //};

            //var userProfile = new UserProfile
            //{
            //    Gender = value.Gender,

            //    Department = dept,
            //};

            data.UserProfiles.Add(user);
            data.SaveChanges();

            return this.Ok(user);
        }

    }
}