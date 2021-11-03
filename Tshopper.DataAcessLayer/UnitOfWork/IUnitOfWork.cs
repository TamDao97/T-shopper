using System;

namespace Tshopper.DataAcessLayer
{
    public interface IUnitOfWork : IDisposable
    {
        CategoryRepository CategoryRepos { get; }
        ProductRepository ProductRepos { get; }
        bool Save();
    }
}
