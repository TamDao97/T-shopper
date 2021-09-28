using System;
using System.Collections.Generic;

namespace Tshopper.Data
{
    public class Product : BaseEntity
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double? ImportPrice { get; set; }
        public double? ExportPrice { get; set; }
        public int Amount { get; set; } = 0;
        public int QuantityOfInventory { get; set; }
        public int StarPoint { get; set; }
        public bool IsHotTrend { get; set; } = false;

        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<SupplierDetail> SupplierDetails { get; set; }
        public virtual ICollection<Image> Images { get; set; }
    }
}
