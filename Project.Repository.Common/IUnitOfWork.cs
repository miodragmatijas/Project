﻿using Project.Model.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Repository.Common
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> CommitAsync();

        //Task<int> AddAsync<T>(T entity) where T : class;
        //Task<int> UpdateAsync<T>(T entity) where T : class;
        //Task<int> DeleteAsync<T>(T entity) where T:class;
        //Task<int> DeleteAsync<T>(Guid id) where T : class;

        Task<IEnumerable <IVehicleMake>> GetAllVehicleMake();
    }
}
