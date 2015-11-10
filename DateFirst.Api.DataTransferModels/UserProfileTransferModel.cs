namespace DateFirst.Api.DataTransferModels
{
    using System.Collections.Generic;
    using Models;

    public class UserProfileTransferModel
    {
        public int Flirts { get; set; }

        public AdditionalInfoTransferModel AdditionalInfo { get; set; }

        public UserTransferModel User { get; set; }

        public Gender Gender { get; set; }

        public TownTransferModel Town { get; set; }

        public DepartmentTransferModel Department { get; set; }

        public ICollection<ImageTransferModel> Images { get; set; }

        public ICollection<PostTransferModel> Posts { get; set; }

        public virtual ICollection<NotificationTransferModel> Notifications { get; set; }
    }
}