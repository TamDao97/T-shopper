using System;
using System.Collections.Generic;
using System.Text;

namespace Tshopper.Data
{
    public class SupplierDetail
    {
        public Guid Id { get; set; }
        public Guid SupplierId { get; set; }
        public Guid ProductId { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Product Product { get; set; }
    }
}
