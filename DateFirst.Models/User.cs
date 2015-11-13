namespace DateFirst.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class User : IdentityUser
    {
        private ICollection<Image> images;
        private ICollection<Post> posts;
        private ICollection<Notification> notifications;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public User()
            : base()
        {
            this.CreatedOn = DateTime.Now;
            this.images = new HashSet<Image>();
            this.posts = new HashSet<Post>();
            this.notifications = new HashSet<Notification>();
        }

        public string AvatarUrl { get; set; }

        public DateTime CreatedOn { get; set; }

        [Index(IsClustered = false)]
        public int Flirts { get; set; }

        public virtual AdditionalInfo AdditionalInfo { get; set; }

        [ForeignKey("Town")]
        public int? TownId { get; set; }

        public virtual Town Town { get; set; }

        [ForeignKey("Department")]
        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public virtual ICollection<Image> Images
        {
            get { return this.images; }
            set { this.images = value; }
        }

        public virtual ICollection<Post> Posts
        {
            get { return this.posts; }
            set { this.posts = value; }
        }

        public virtual ICollection<Notification> Notifications
        {
            get { return this.notifications; }
            set { this.notifications = value; }
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            ClaimsIdentity userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            return userIdentity;
        }
    }
}
