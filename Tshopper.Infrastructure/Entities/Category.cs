using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tshopper.Infrastructure
{
    [Table("Category")]
    public class Category : BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        public Guid? ParentId { get; set; }

        [Column(TypeName = "varchar(8)"), Required]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
