using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tshopper.Infrastructure
{
    [Table("Supplier")]
    public class Supplier : BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Column(TypeName = "varchar(8)"), Required]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }

        public string Address { get; set; }

        [Column(TypeName = "varchar(12)")]
        public string Phone { get; set; }

        public string Description { get; set; }

        public virtual ICollection<SupplierDetail> SupplierDetails { get; set; }
    }
}
