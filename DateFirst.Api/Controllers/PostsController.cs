namespace DateFirst.Api.Controllers
{
    using DateFirst.Data.Repositories;
    using DateFirst.Models;
    using System.Web.Http;

    public class PostsController : ApiController
    {
        private readonly IDateFirstData data;

        public PostsController(IDateFirstData data)
        {
            this.data = data;
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody]Post post)
        {
            if (post == null || !this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            var user = this.data.Users.GetById(post.ReceiverId);
            user.Posts.Add(post);
            //this.data.Posts.Add(value);
            this.data.SaveChanges();

            return this.Ok();
        }
    }
}