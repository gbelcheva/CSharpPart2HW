namespace DateFirst.Api.DataTransferModels
{
    using System;
    using System.Collections.Generic;

    using Models;

    public class UserTransferModel
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string AvatarUrl { get; set; }

        public DateTime CreatedOn { get; set; }

        public int Flirts { get; set; }

        public AdditionalInfoTransferModel AdditionalInfo { get; set; }

        public TownTransferModel Town { get; set; }

        public DepartmentTransferModel Department { get; set; }

        public ICollection<ImageTransferModel> Images { get; set; }

        public ICollection<PostTransferModel> Posts { get; set; }

        public virtual ICollection<NotificationTransferModel> Notifications { get; set; }
    }
}
