using System;

namespace Tshopper.DataAcessLayer
{
    public interface IUnitOfWork : IDisposable
    {
        CategoryRepository CategoryRepos { get; }
        bool Save();
    }
}
