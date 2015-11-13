namespace DateFirst.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Town
    {
        private ICollection<User> users;

        public Town()
        {
            this.users = new HashSet<User>();
        }

        public int Id { get; set; }

        [MinLength(2)]
        [MaxLength(100)]
        [Index(IsClustered = false)]
        public string Name { get; set; }

        public virtual ICollection<User> UserProfiles
        {
            get { return this.users; }
            set { this.users = value; }
        }
    }
}