namespace DateFirst.Models
{
    using System.Collections.Generic;

    public class Hobby
    {
        private ICollection<AdditionalInfo> additionalInfos;

        public Hobby()
        {
            this.additionalInfos = new HashSet<AdditionalInfo>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<AdditionalInfo> AdditionalInfos
        {
            get { return this.additionalInfos; }
            set { this.additionalInfos = value; }
        }
    }
}