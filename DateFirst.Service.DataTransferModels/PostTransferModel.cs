namespace DateFirst.Service.DataTransferModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class PostTransferModel
    {
        public DateTime CreatedOn { get; set; }

        [MinLength(2)]
        [MaxLength(500)]
        public string Content { get; set; }

        public string ReceiverUsername { get; set; }

        public string SenderUsername { get; set; }
    }
}
