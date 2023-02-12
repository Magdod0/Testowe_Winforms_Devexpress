using System;
using System.Data.Entity;


namespace Testowe_WinF_Dev.DataModels.UnitOfWorks
{
    public abstract class UnitOfWork<CurrentDbContext> : IUnitOfWork
        where CurrentDbContext: DbContext
    {
        private bool disposed = false;
        protected CurrentDbContext _context;
        public UnitOfWork(CurrentDbContext context)
        {
            _context = context;
        }
        public bool HasChanges() => _context.ChangeTracker.HasChanges();
        public void SaveChanges() => _context.SaveChanges();
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                this.disposed = true;
            }
        }
    }
}
