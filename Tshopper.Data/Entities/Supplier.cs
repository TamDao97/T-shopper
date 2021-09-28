using System;
using System.Collections.Generic;

namespace Tshopper.Data
{
    public class Supplier : BaseEntity
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }

        public virtual ICollection<SupplierDetail> SupplierDetails { get; set; }
    }
}
