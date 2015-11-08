namespace DateFirst.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Notification
    {
        public Notification()
        {
            this.SentOn = DateTime.Now;
        }

        public DateTime SentOn { get; set; }

        public int Id { get; set; }

        [MinLength(2)]
        [MaxLength(150)]
        public string Content { get; set; }

        public int ReceiverId { get; set; }

        [Required]
        public virtual UserProfile Receiver { get; set; }

        public int SenderId { get; set; }

        [Required]
        public virtual UserProfile Sender { get; set; }
    }
}