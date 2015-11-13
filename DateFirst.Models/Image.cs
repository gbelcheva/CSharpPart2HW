namespace DateFirst.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Image
    {
        public int Id { get; set; }

        [MinLength(2)]
        [MaxLength(242)]
        public string Url { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}
