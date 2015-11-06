namespace DateFirst.Service.DataTransferModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class NotificationTransferModel
    {
        public DateTime SentOn { get; set; }

        [MinLength(2)]
        [MaxLength(150)]
        public string Content { get; set; }

        public string ReceiverUsername { get; set; }

        public string SenderUsername { get; set; }
    }
}
