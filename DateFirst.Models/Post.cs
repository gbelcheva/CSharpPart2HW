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

        public DateTime CreatedOn { get; set; }

        public int Id { get; set; }

        [MinLength(2)]
        [MaxLength(500)]
        public string Content { get; set; }

        public virtual UserProfile Receiver { get; set; }

        public virtual UserProfile Sender { get; set; }
    }
}