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

        public string ReceiverId { get; set; }

        public virtual User Receiver { get; set; }

        [Required]
        public string SenderId { get; set; }

        public virtual User Sender { get; set; }
    }
}