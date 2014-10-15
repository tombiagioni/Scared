using Scared.Data.Contracts;
using Scared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scared.Data
{
    public class ScaredUow : IScaredUow, IDisposable 
    {

        private ScaredDbContext DbContext { get; set;
        }
        public ScaredUow(IRepositoryProvider repositoryProvider)
        {
            CreateDbContext();

            repositoryProvider.DbContext = DbContext;
            RepositoryProvider = repositoryProvider;
        }

        //Scared Repositories
        public ITransactionsRepository Transactions { get { return GetRepo<ITransactionsRepository>(); } }
        public IEmployeesRepository Employees { get { return GetRepo<IEmployeesRepository>(); } }
        public IEmployeesStoresRepository EmployeesStores { get { return GetRepo<IEmployeesStoresRepository>(); } }
        public IStoresDistrictsRepository StoresDistricts { get { return GetRepo<IStoresDistrictsRepository>(); } }
        public IRepository<Shift> Shifts { get { return GetStandardRepo<Shift>(); } }
        public IRepository<Store> Stores { get { return GetStandardRepo<Store>(); } }
        public IRepository<District> Districts { get { return GetStandardRepo<District>(); } }

        public void Commit()
        {
            DbContext.SaveChanges();
        }

        protected void CreateDbContext()
        {
            DbContext = new ScaredDbContext();

            // Do NOT enable proxied entities, else serialization fails
            DbContext.Configuration.ProxyCreationEnabled = false;

            // Load navigation properties explicitly (avoid serialization trouble)
            DbContext.Configuration.LazyLoadingEnabled = false;

            // Because Web API will perform validation, we don't need/want EF to do so
            DbContext.Configuration.ValidateOnSaveEnabled = false;

            //DbContext.Configuration.AutoDetectChangesEnabled = false;
            // We won't use this performance tweak because we don't need 
            // the extra performance and, when autodetect is false,
            // we'd have to be careful. We're not being that careful.
        }
        protected IRepositoryProvider RepositoryProvider { get; set; }

        private IRepository<T> GetStandardRepo<T>() where T : class
        {
            return RepositoryProvider.GetRepositoryForEntityType<T>();
        }
        private T GetRepo<T>() where T : class
        {
            return RepositoryProvider.GetRepository<T>();
        }

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (DbContext != null)
                {
                    DbContext.Dispose();
                }
            }
        }

        #endregion
    }
}
