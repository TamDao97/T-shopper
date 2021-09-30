using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Tshopper.Data.Entities
{
    [Table("District")]
    public class District : BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }

        public Guid ProvinceId { get; set; }

        [ForeignKey("ProvinceId")]
        public Province Province { get; set; }

        public ICollection<Ward> wards { get; set; }
    }
}
