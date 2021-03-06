using System;
using Tshopper.Infrastructure;

namespace Tshopper.DataAcessLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposed = false;
        TshopperContext _context;
        private CategoryRepository _categoryRepository;

        public UnitOfWork(TshopperContext context)
        {
            _context = context;
        }

        CategoryRepository IUnitOfWork.CategoryRepos
        {
            get
            {
                return _categoryRepository ?? (_categoryRepository = new CategoryRepository(_context));
            }
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
