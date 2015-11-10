namespace DateFirst.Service.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;

    using AutoMapper.QueryableExtensions;
    using Api.DataTransferModels;
    using DateFirst.Data.Repositories;
    using DateFirst.Models;

    // TODO: Move to AccountController?
    public class HomeController : ApiController
    {
        private readonly IDateFirstData data;

        public HomeController(IDateFirstData data)
        {
            this.data = data;
        }

        [HttpGet]
        [Route("api/HomePageInfo")]
        public IHttpActionResult GetHomePageInfo()
        {
            var result = new Dictionary<string, List<UserProfileTransferModel>>();

            var bestMaleDaters = this.data.UserProfiles
                            .All()
                            .Where(u => u.Gender == Gender.Male)
                            .OrderByDescending(u => u.Flirts)
                            .Take(5)
                            .ProjectTo<UserProfileTransferModel>()
                            .ToList();

            var bestFemaleDaters = this.data.UserProfiles
                            .All()
                            .Where(u => u.Gender == Gender.Female)
                            .OrderByDescending(u => u.Flirts)
                            .Take(5)
                            .ProjectTo<UserProfileTransferModel>()
                            .ToList();

            // TODO: Fix after adding join date to users
            var newestDaters = this.data.UserProfiles
                            .All()
                            .OrderByDescending(u => u.Flirts)
                            .Take(5)
                            .ProjectTo<UserProfileTransferModel>()
                            .ToList();

            result.Add("males", bestMaleDaters);
            result.Add("females", bestFemaleDaters);
            result.Add("newest", newestDaters);

            return this.Ok(result);
        }
    }
}
