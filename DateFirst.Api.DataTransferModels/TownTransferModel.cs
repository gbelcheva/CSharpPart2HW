namespace DateFirst.Api.DataTransferModels
{
    using System.ComponentModel.DataAnnotations;

    public class TownTransferModel
    {
        [MinLength(2)]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
