using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using DateFirst.Data;
using DateFirst.Models;
using DateFirst.Service.DataTransferModels;

namespace DateFirst.Service.Controllers
{
    public class UserProfilesController : ApiController
    {
        private DateFirstDbContext db = new DateFirstDbContext();

        // GET: UserProfiles
        public IHttpActionResult Get()
        {
            var res = db.UserProfiles
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

            db.UserProfiles.Add(user);
            db.SaveChanges();

            return this.Ok(user);
        }
          
    }
}