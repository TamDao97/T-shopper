using System;

namespace Tshopper.Data
{
    public class BaseEntity
    {
        public int Order { get; set; } = 0;
        public Guid CreatedByUserId { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public Guid ModifiedByUserId { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDeleted { get; set; } = true;
    }
}
