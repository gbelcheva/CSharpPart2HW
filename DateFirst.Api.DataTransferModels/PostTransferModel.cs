﻿namespace DateFirst.Api.DataTransferModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class PostTransferModel
    {
        public DateTime CreatedOn { get; set; }

        [MinLength(2)]
        [MaxLength(500)]
        public string Content { get; set; }

        public string ReceiverName { get; set; }

        public string SenderName { get; set; }
    }
}
