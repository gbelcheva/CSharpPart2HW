namespace DateFirst.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Town
    {
        private ICollection<UserProfile> userProfiles;

        public Town()
        {
            this.userProfiles = new HashSet<UserProfile>();
        }

        public int Id { get; set; }

        [MinLength(2)]
        [MaxLength(100)]
        [Index(IsClustered = false)]
        public string Name { get; set; }

        public virtual ICollection<UserProfile> UserProfiles
        {
            get { return this.userProfiles; }
            set { this.userProfiles = value; }
        }
    }
}