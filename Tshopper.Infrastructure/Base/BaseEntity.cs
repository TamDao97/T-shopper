using System;
using System.ComponentModel.DataAnnotations;

namespace Tshopper.Infrastructure
{
    public class BaseEntity
    {
        [Required]
        public int Order { get; set; } = 0;

        [Required]
        public Guid CreatedByUserId { get; set; }

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public Guid ModifiedByUserId { get; set; }

        [Required]
        public DateTime DateModified { get; set; }

        [Required]
        public bool IsDeleted { get; set; } = true;
    }
}
