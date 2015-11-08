namespace DateFirst.Api.DataTransferModels
{
    using System.ComponentModel.DataAnnotations;

    public class DepartmentTransferModel
    {
        [MinLength(2)]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
