using Tshopper.Infrastructure;

namespace Tshopper.DataAcessLayer
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(TshopperContext context) : base(context) { }
    }
}
