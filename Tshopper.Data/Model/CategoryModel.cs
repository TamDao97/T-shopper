using System;
using System.Collections.Generic;
using System.Text;

namespace Tshopper.Infrastructure
{
    public class CategoryModel : BaseModel
    {
        public Guid? ParentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class CategoryCreateModel : CategoryModel
    {
        public Guid CreatedByUserId { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }

    public class CategoryUpdateModel : CategoryModel
    {
        public Guid ModifiedByUserId { get; set; }
        public DateTime DateModified { get; set; }
    }
}
