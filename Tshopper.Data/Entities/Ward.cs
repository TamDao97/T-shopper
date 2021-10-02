using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tshopper.Data.Entities
{
    [Table("Ward")]
    public class Ward
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Guid DistrictId { get; set; }

        [ForeignKey("DistrictId")]
        public District District { get; set; }
    }
}
