using Project.Service.Common;
using System.Collections.Generic;
using System.Threading.Tasks;
using Project.Repository.Common;
using Project.Model.Common;
using Project.Model;
using System;

namespace Project.Service
{
    public class VehicleMakeService : IVehicleMakeService

    {

        #region Costructors
        public VehicleMakeService(IRepository repository)
        {
            this.Repository = repository;
        }
        #endregion Constructors

        #region Properties
        protected IRepository Repository { get; set; }
        #endregion Properties

        #region Metodhs

        public async Task<IEnumerable<IVehicleMake>> GetAll()
        {
            var model = await Repository.GetAll<VehicleMake>();
            var dataVehicle = AutoMapper.Mapper.Map<IEnumerable<IVehicleMake>>(model);
            return dataVehicle;
        }

        public async Task<IVehicleMake> FindById(int id)
        {
            var model = await Repository.GetIdAsync<VehicleMake>(id);
            var dataVehicle = AutoMapper.Mapper.Map<IVehicleMake>(model);
            return dataVehicle;

        }

        public async Task<int> Delete(int id)
        {
            return await Repository.DeleteAsync<VehicleMake>(id);
        }

        public async Task<int> Add(IVehicleMake data)
        {
            var model = AutoMapper.Mapper.Map<VehicleMake>(data);
            var x = await Repository.AddAsync(model);
            return x;
        }

        #endregion Metodhs

    }
}
