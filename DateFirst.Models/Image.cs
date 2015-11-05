namespace DateFirst.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Image
    {
        public int Id { get; set; }

        [MinLength(2)]
        [MaxLength(242)]
        public string Url { get; set; }

        public virtual User User { get; set; }
    }
}
