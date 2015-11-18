namespace DateFirst.Api.Controllers
{
    using System.Net.Http;
    using System.Web.Http;
    using System.Security.Principal;

    using DataTransferModels;
    using Data.Repositories;
    using Infrastructure;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.Owin;

    public class FlirtsController : ApiController
    {
        private readonly IDateFirstData data;
        private readonly IPrincipal principal;

        public FlirtsController(IDateFirstData data, IIdentityProvider identityProvider)
        {
            this.data = data;
            this.principal = identityProvider.GetIdentity();
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var userManager = Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
            string username = this.principal.Identity.Name;
            if (username == null)
            {
                return this.BadRequest();
            }

            var userId = this.principal.Identity.GetUserId();
            var currentUser = this.data.Users.GetById(userId);
            return this.Ok(currentUser.Flirts);
        }

        [HttpPut]
        public IHttpActionResult Put([FromBody]UserTransferModel user)
        {
            var userManager = Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
            if (this.principal.Identity.Name == null)
            {
                return this.BadRequest("You must login!");
            }

            var currentUserId = this.principal.Identity.GetUserId();
            if (currentUserId == user.Id)
            {
                return this.BadRequest("You cannot flirt with your own profile!");
            }

            var currentProfileUser = this.data.Users.GetById(user.Id);
            currentProfileUser.Flirts += 1;
            this.data.Users.Update(currentProfileUser);
            this.data.SaveChanges();

            return this.Ok();
        }
    }
}