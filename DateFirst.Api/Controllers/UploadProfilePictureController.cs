﻿namespace DateFirst.Api.Controllers
{
    using System.IO;
    using System.Linq;
    using System.Web;
    using System.Web.Http;
    using System.Net.Http;
    using Data.Repositories;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.Owin;
    using Spring.IO;
    using Spring.Social.Dropbox.Api;
    using Spring.Social.Dropbox.Connect;

    public class UploadProfilePictureController : ApiController
    {
        private const string DropboxAppKey = "zyg48v1jsvk9yfm";
        private const string DropboxAppSecret = "m6dha3d29jfjkr5";
        private string name;

        private readonly IDateFirstData data;

        public UploadProfilePictureController(IDateFirstData data)
        {
            this.data = data;
        }

        [Authorize]
        [HttpPost]
        public void UploadFile()
        {
            var filePath = string.Empty;

            if (HttpContext.Current.Request.Files.AllKeys.Any())
            {
                var httpPostedFile = HttpContext.Current.Request.Files["UploadedImage"];

                if (httpPostedFile != null)
                {
                    var fileSavePath = Path.Combine(HttpContext.Current.Server.MapPath("~/UploadedFiles"), httpPostedFile.FileName);
                    filePath = fileSavePath;
                    name = httpPostedFile.FileName;
                    httpPostedFile.SaveAs(fileSavePath);
                }
            }

            DropboxServiceProvider dropboxServiceProvider = new DropboxServiceProvider(DropboxAppKey, DropboxAppSecret, AccessLevel.AppFolder);

            IDropbox dropbox = dropboxServiceProvider.GetApi("ewl8tryz0hmkulda", "p1n05i71cfhohlu");

            Entry uploadFileEntry = dropbox.UploadFileAsync(new FileResource(string.Format(filePath)), string.Format("/DateFirstImagesDb/{0}", name)).Result;

            var link = dropbox.GetMediaLinkAsync(string.Format("/DateFirstImagesDb/{0}", name));
            var avatarUrl = link.Result.Url;

            var userManager = Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
            
            var loginUser = userManager.FindById(User.Identity.GetUserId());
            var userForUpdate = this.data.Users.GetById(loginUser.Id);

            userForUpdate.AvatarUrl = avatarUrl;
            data.SaveChanges();
        }
    }
}