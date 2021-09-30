using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tshopper.Data.Entities
{
    [Table("Province")]
    public class Province : BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<District> Districts { get; set; }
    }
}
