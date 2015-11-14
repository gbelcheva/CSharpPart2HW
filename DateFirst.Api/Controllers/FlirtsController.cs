namespace DateFirst.Api.Controllers
{
    using System.Web.Http;
    using DateFirst.Api.DataTransferModels;
    using DateFirst.Data.Repositories;
    using System.Net.Http;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.Owin;

    public class FlirtsController : ApiController
    {
        private readonly IDateFirstData data;

        public FlirtsController(IDateFirstData data)
        {
            this.data = data;

        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var userManager = Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var user = userManager.FindByName(User.Identity.Name);

            var currentUser = this.data.Users.GetById(user.Id);
            return this.Ok(currentUser.Flirts);
        }

        [HttpPut]
        public IHttpActionResult Put([FromBody]UserTransferModel user)
        {
            var userManager = Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
            if (User.Identity.Name == null)
            {
                return this.BadRequest("You must login!");
            }
            var currentLoginUser = userManager.FindByName(User.Identity.Name);

            if (currentLoginUser.Id == user.Id)
            {
                return this.BadRequest("You cannot flirts your on profile!");
            }

            var currentProfilUser = this.data.Users.GetById(user.Id);
            currentProfilUser.Flirts += 1;
            this.data.Users.Update(currentProfilUser);
            this.data.SaveChanges();

            return this.Ok();
        }
    }
}