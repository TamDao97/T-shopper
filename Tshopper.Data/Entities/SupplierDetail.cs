using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tshopper.Infrastructure
{
    [Table("SupplierDetail")]
    public class SupplierDetail : BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid SupplierId { get; set; }

        [Required]
        public Guid ProductId { get; set; }

        [ForeignKey("SupplierId")]
        public virtual Supplier Supplier { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
