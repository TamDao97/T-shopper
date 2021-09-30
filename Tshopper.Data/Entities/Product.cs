using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tshopper.Data
{
    [Table("Product")]
    public class Product : BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Column(TypeName = "varchar(8)"), Required]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public double? ImportPrice { get; set; }

        public double? ExportPrice { get; set; }

        public int? Amount { get; set; }

        public int? QuantityOfInventory { get; set; }

        public int? StarPoint { get; set; }

        [Required]
        public bool IsHotTrend { get; set; } = false;

        [Required]
        public Guid CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        public virtual ICollection<SupplierDetail> SupplierDetails { get; set; }
        public virtual ICollection<Image> Images { get; set; }
    }
}
