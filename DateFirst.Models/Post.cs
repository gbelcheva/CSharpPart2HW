namespace DateFirst.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Post
    {
        public Post()
        {
            this.CreatedOn = DateTime.Now;
        }

        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        [MinLength(2)]
        [MaxLength(500)]
        public string Content { get; set; }

        public int ReceiverId { get; set; }

        [Required]
        public virtual UserProfile Receiver { get; set; }

        public int SenderId { get; set; }

        [Required]
        public virtual UserProfile Sender { get; set; }
    }
}