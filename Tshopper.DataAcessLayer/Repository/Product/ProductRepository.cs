using Tshopper.Infrastructure;

namespace Tshopper.DataAcessLayer
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(TshopperContext context) : base(context)
        {

        }
    }
}
