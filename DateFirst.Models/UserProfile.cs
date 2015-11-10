namespace DateFirst.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class UserProfile
    {
        private ICollection<Image> images;
        private ICollection<Post> posts;
        private ICollection<Notification> notifications;

        public UserProfile()
        {
            this.Images = new HashSet<Image>();
            this.Posts = new HashSet<Post>();
            this.Notifications = new HashSet<Notification>();
        }

        public int Id { get; set; }

        [Index(IsClustered = false)]
        public int Flirts { get; set; }

        public int AdditionalInfoId { get; set; }

        public virtual AdditionalInfo AdditionalInfo { get; set; }

        [Index(IsClustered = false)]
        public virtual Gender Gender { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        public virtual User User { get; set; }

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
    }
}
