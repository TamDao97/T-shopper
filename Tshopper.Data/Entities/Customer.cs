using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Tshopper.Data.Entities
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
        public Province Province { get; set; }

        [ForeignKey("DistrictId")]
        public District District { get; set; }

        [ForeignKey("WardId")]
        public Ward Ward { get; set; }
    }
}
