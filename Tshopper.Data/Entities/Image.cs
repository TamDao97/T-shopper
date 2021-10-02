using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tshopper.Common;

namespace Tshopper.Data
{
    [Table("Image")]
    public class Image : BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        public string Description { get; set; }

        [Required]
        public string Path { get; set; }

        [Required]
        public ImageType Type { get; set; }

        [Required]
        public Guid ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
