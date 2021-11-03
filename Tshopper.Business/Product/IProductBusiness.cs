using System;
using System.Threading.Tasks;
using Tshopper.Infrastructure;

namespace Tshopper.Business
{
    public interface IProductBusiness
    {
        Task<Response> Insert(ProductCreateModel model);
        Task<Response> Update(ProductUpdateModel model);
        Task<Response> Delete(Guid id);
        Task<Response<ProductModel>> GetById(Guid id);
        Task<Response<ProductViewModel>> GetFilter(ProductFilterModel model);
    }
}
