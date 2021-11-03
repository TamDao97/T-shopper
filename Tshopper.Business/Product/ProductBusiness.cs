using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tshopper.DataAcessLayer;
using Tshopper.Infrastructure;

namespace Tshopper.Business
{
    public class ProductBusiness : IProductBusiness
    {
        private readonly IProductRepository _productRepos;
        public ProductBusiness(IProductRepository productRepos)
        {
            _productRepos = productRepos;
        }

        public async Task<Response> Insert(ProductCreateModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<Response> Update(ProductUpdateModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<Response> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<Response<ProductModel>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<Response<ProductViewModel>> GetFilter(ProductFilterModel model)
        {
            throw new NotImplementedException();
        }
    }
}
