namespace DateFirst.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Town
    {      
        public int Id { get; set; }

        [MinLength(2)]
        [MaxLength(100)]
        [Index]
        public string Name { get; set; }
    }
}