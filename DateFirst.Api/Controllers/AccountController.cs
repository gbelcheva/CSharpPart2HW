namespace DateFirst.Api.Controllers
{
    using System;
    using System.Net.Http;
    using System.Security.Cryptography;
    using System.Web;
    using System.Web.Http;
    using AutoMapper;
    using DateFirst.Models;
    using Data.Repositories;
    using DataTransferModels;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.Owin;
    using Microsoft.Owin.Security;
    using Microsoft.Owin.Security.Cookies;

    [Authorize]
    [RoutePrefix("api/Account")]
    public class AccountController : ApiController
    {
        private const string LocalLoginProvider = "Local";
        private ApplicationUserManager _userManager;
        private readonly IDateFirstData data;

        public AccountController(IDateFirstData data)
        {
            this.data = data;
        }

        public AccountController(ApplicationUserManager userManager,
            ISecureDataFormat<AuthenticationTicket> accessTokenFormat)
        {
            UserManager = userManager;
            AccessTokenFormat = accessTokenFormat;
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        public ISecureDataFormat<AuthenticationTicket> AccessTokenFormat { get; private set; }

        [HttpPut]
        [Route("UpdateUserInfo")]
        public IHttpActionResult Put([FromBody]AdditionalInfoTransferModel additionaInfo)
        {
            if (additionaInfo == null || !this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            AdditionalInfo info = Mapper.Map<AdditionalInfoTransferModel, AdditionalInfo>(additionaInfo);

            var existingInfo = this.data.AdditionalInfos.GetById(additionaInfo.Id);
            if (existingInfo != null)
            {
                this.data.AdditionalInfos.Delete(existingInfo);
                this.data.SaveChanges();
            }

            this.data.AdditionalInfos.Add(info);
            this.data.SaveChanges();

            return this.Ok();
        }

        [Route("LoggedUser")]
        public IHttpActionResult GetLoggedUserId()
        {
            var user = UserManager
                .FindByName(User.Identity.Name)
                .Id;

            return this.Ok(user);
        }

        [Route("UserName")]
        public IHttpActionResult GetLoggedUserName()
        {
            var user = UserManager
                .FindByName(User.Identity.Name);

            string userNames = user.FirstName + " " + user.LastName;

            return this.Ok(userNames);
        }
        
        [Route("Logout")]
        public IHttpActionResult Logout()
        {
            Authentication.SignOut(CookieAuthenticationDefaults.AuthenticationType);
            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && _userManager != null)
            {
                _userManager.Dispose();
                _userManager = null;
            }

            base.Dispose(disposing);
        }

        #region Helpers

        private IAuthenticationManager Authentication
        {
            get { return Request.GetOwinContext().Authentication; }
        }

        private IHttpActionResult GetErrorResult(IdentityResult result)
        {
            if (result == null)
            {
                return InternalServerError();
            }

            if (!result.Succeeded)
            {
                if (result.Errors != null)
                {
                    foreach (string error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }

                if (ModelState.IsValid)
                {
                    return BadRequest();
                }

                return BadRequest(ModelState);
            }

            return null;
        }

        private static class RandomOAuthStateGenerator
        {
            private static RandomNumberGenerator _random = new RNGCryptoServiceProvider();

            public static string Generate(int strengthInBits)
            {
                const int bitsPerByte = 8;

                if (strengthInBits % bitsPerByte != 0)
                {
                    throw new ArgumentException("strengthInBits must be evenly divisible by 8.", "strengthInBits");
                }

                int strengthInBytes = strengthInBits / bitsPerByte;

                byte[] data = new byte[strengthInBytes];
                _random.GetBytes(data);
                return HttpServerUtility.UrlTokenEncode(data);
            }
        }

        #endregion
    }
}
