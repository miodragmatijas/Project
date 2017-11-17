using Project.Service.Common;
using System.Collections.Generic;
using System.Threading.Tasks;
using Project.Repository.Common;
using Project.Model.Common;
using Project.Model;

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
       

        #endregion Metodhs

    }
}
