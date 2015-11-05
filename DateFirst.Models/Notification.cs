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

        public virtual UserProfile Receiver { get; set; }

        public virtual UserProfile Sender { get; set; }
    }
}