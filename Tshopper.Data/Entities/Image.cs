using System;
using System.Collections.Generic;
using System.Text;
using Tshopper.Common;

namespace Tshopper.Data
{
    public class Image : BaseEntity
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public ImageType Type { get; set; }

        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
