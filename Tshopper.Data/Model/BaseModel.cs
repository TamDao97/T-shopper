using System;

namespace Tshopper.Infrastructure
{
    public class BaseModel
    {
        public Guid Id { get; set; }
        public int Order { get; set; }
        public bool IsDeleted { get; set; }
    }
}
