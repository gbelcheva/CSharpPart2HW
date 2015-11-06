namespace DateFirst.Service.DataTransferModels
{
    using System.Collections.Generic;
    using Models;

    public class UserTransferModel
    {
        public int Flirts { get; set; }

        public AdditionalInfoTransferModel AdditionalInfo { get; set; }

        public Gender Gender { get; set; }

        public string TownName { get; set; }

        public string DepartmentName { get; set; }

        public ICollection<ImageTransferModel> Images { get; set; }

        public ICollection<PostTransferModel> Posts { get; set; }

        public virtual ICollection<NotificationTransferModel> Notifications { get; set; }
    }
}