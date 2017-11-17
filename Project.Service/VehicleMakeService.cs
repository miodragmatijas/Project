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
        public VehicleMakeService(IUnitOfWork repository)
        {
            this.Repository = repository;
        }
        #endregion Constructors

        #region Properties
        protected IUnitOfWork Repository { get; set; }
        #endregion Properties

        #region Metodhs

        public async Task<IEnumerable<IVehicleMake>> GetAll()
        {
            var dataVehicle = AutoMapper.Mapper.Map<IEnumerable<IVehicleMake>>(await Repository.GetAll<VehicleMake>());
            return dataVehicle;
        }

        public async Task<IVehicleMake> FindById(int id)
        {
            var dataVehicle = AutoMapper.Mapper.Map<IVehicleMake>(await Repository.GetIdAsync<VehicleMake>(id));
            return dataVehicle;

        }

        public async Task<int> Delete(int id)
        {
            return await Repository.DeleteAsync<VehicleMake>(id);
        }

        #endregion Metodhs

    }
}
