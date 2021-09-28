using System;
using System.Collections.Generic;
using System.Text;

namespace Tshopper.Data
{
    public class Category : BaseEntity
    {
        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
