namespace DateFirst.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Department
    {
        private ICollection<UserProfile> userProfiles;

        public Department()
        {
            this.userProfiles = new HashSet<UserProfile>();
        }

        [Key]
        public int Id { get; set; }

        [MinLength(2)]
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<UserProfile> UserProfiles
        {
            get { return this.userProfiles; }
            set { this.userProfiles = value; }
        }
    }
}