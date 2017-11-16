using Project.Repository.Common;
using System;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Transactions;
using Project.DAL;
using Project.Model.Common;
using System.Collections.Generic;
using System.Linq;

namespace Project.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        #region Costructor
        public UnitOfWork(VehicleContext dbContext)
        {
            if (dbContext == null)
            {
                throw new ArgumentException("DbContext");
            }
            DbContext = dbContext;
        }
        #endregion Contructor

        #region Properties
        protected VehicleContext DbContext { get; set; }
        #endregion Properties

        #region Method
        public async Task<IEnumerable<IVehicleMake>> GetAllVehicleMake()
        {
            var model = from s in DbContext.VehicleMakeEntities select s;

            return await model.ToListAsync();
        }

        //public Task<int> AddAsync<T>(T entity) where T : class
        //{
        //    try
        //    {
        //        DbEntityEntry dbEntityEntry = DbContext.Entry(entity);
        //        if (dbEntityEntry.State != EntityState.Detached)
        //        {
        //            dbEntityEntry.State = EntityState.Added;
        //        }
        //        else
        //        {
        //            DbContext.Set<T>().Add(entity);
        //        }
        //        return Task.FromResult(1);
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}
        public async Task<int> CommitAsync()
        {
            int result = 0;
            using (TransactionScope scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                result = await DbContext.SaveChangesAsync();
                scope.Complete();
            }
            return result;
        }
        public void Dispose()
        {
            DbContext.Dispose();
        }
        #endregion Mehod

    }
}
