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
    public class Repository : IRepository
    {

        #region Costructor
        public Repository(VehicleContext dbContext)
        {           
            DbContext = dbContext;
        }
        #endregion Contructor

        #region Properties
        protected VehicleContext DbContext { get; set; }

        
        #endregion Properties

        #region Method
        public async Task<IEnumerable<T>> GetAll<T>() where T:class
        {
            var data = await DbContext.Set<T>().ToListAsync();
            return data;
        }

        public async Task<T> GetIdAsync<T>(int id) where T : class
        {
            var data = await DbContext.Set<T>().FindAsync(id);
            return data;
        }

        public async Task<int> DeleteAsync<T>(int id) where T : class
        {
            var data= await DbContext.Set<T>().FindAsync(id);
            DbContext.Entry(data).State=EntityState.Deleted;
            return await DbContext.SaveChangesAsync();
        }


        public async  Task<int> AddAsync<T>( T entity) where T : class
        {
            DbContext.Entry(entity).State = EntityState.Added;
            return await DbContext.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync<T>(T entity) where T : class
        {
            DbContext.Entry(entity).State = EntityState.Modified;
            return await DbContext.SaveChangesAsync();            
        }


        #endregion Mehod

    }
}
