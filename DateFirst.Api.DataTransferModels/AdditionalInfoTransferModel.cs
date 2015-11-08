namespace DateFirst.Api.DataTransferModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Models;

    public class AdditionalInfoTransferModel
    {
        [Range(0, int.MaxValue)]
        public decimal? Salary { get; set; }

        [MinLength(2)]
        [MaxLength(50)]
        public string JobTitle { get; set; }

        [Range(40, 250)]
        public int? Heigth { get; set; }

        [Range(20, 400)]
        public int? Weight { get; set; }

        [Range(16, 130)]
        public int? Age { get; set; }

        [MaxLength(500)]
        public string AboutMe { get; set; }

        public StarSign StarSign { get; set; }

        public EyeColor EyeColor { get; set; }

        public HairColor HairColor { get; set; }

        public ICollection<HobbyTransferModel> Hobbies { get; set; }
    }
}
