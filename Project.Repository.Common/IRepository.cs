﻿using Project.Model.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project.Repository.Common
{
    public interface IRepository 
    {
        Task<IEnumerable<T>> GetAll<T>() where T : class;
        Task<T> GetIdAsync<T>(int id) where T : class;
        Task<int> DeleteAsync<T>(int id) where T : class;
        Task<int> AddAsync<T>(T entity) where T : class;
        Task<int> UpdateAsync<T>(T entity) where T : class;
    }
}
