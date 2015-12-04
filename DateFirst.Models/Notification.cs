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

        public string ReceiverId { get; set; }

        public virtual User Receiver { get; set; }

        //// Notifications doesn't have a user sender?
        [Required]
        public string SenderId { get; set; }

        public virtual User Sender { get; set; }
    }
}