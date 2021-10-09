using Microsoft.EntityFrameworkCore;

namespace Tshopper.Infrastructure
{
    public class TshopperContext : DbContext
    {
        protected TshopperContext()
        { }

        public TshopperContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierDetail> SupplierDetails { get; set; }
        public DbSet<Ward> Wards { get; set; }
    }
}
