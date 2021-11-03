using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tshopper.Infrastructure
{
    [Table("Customer")]
    public class Customer : BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Column(TypeName = "varchar(8)"), Required]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Identify { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public DateTime? BirthDate { get; set; }

        [Required]
        public Guid ProvinceId { get; set; }

        [Required]
        public Guid DistrictId { get; set; }

        [Required]
        public Guid WardId { get; set; }

        [ForeignKey("ProvinceId")]
        public virtual Province Province { get; set; }
    }
}
