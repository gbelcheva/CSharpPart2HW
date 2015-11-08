namespace DateFirst.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("AdditionalInfos")]
    public class AdditionalInfo
    {
        private ICollection<Hobby> hobbies;

        public AdditionalInfo()
        {
            this.Hobbies = new HashSet<Hobby>();
        }

        public int Id { get; set; }

        public int UserProfileId { get; set; }

        [Required]
        public virtual UserProfile UserProfile { get; set; }

        [Index]
        [Range(0, int.MaxValue)]
        public decimal? Salary { get; set; }

        [MinLength(2)]
        [MaxLength(50)]
        public string JobTitle { get; set; }

        [Index]
        [Range(40, 250)]
        public int? Heigth { get; set; }

        [Index]
        [Range(20, 400)]
        public int? Weight { get; set; }

        [Index]
        [Range(16, 130)]
        public int? Age { get; set; }

        [MaxLength(500)]
        public string AboutMe { get; set; }

        public virtual StarSign StarSign { get; set; }

        public virtual EyeColor EyeColor { get; set; }

        public virtual HairColor HairColor { get; set; }

        public ICollection<Hobby> Hobbies
        {
            get { return this.hobbies; }
            set { this.hobbies = value; }
        }
    }
}