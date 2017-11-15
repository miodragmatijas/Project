using Project.Service.Common;
using System.Collections.Generic;
using System.Threading.Tasks;
using Project.Repository.Common;
using Project.Model.Common;


namespace Project.Service
{
    public class VehicleMakeService : IVehicleMakeService

    {
        private readonly IUnitOfWork Repository;
        public VehicleMakeService(IUnitOfWork repository)
        {
            this.Repository = repository;
        }

        //#region Costructors
        //public VehicleMakeService(IUnitOfWork repository)
        //{
        //    this.Repository = repository;
        //}
        //#endregion Constructors

        //#region Properties
        //protected IUnitOfWork Repository { get; set; }
        //#endregion Properties

        #region Metodhs

        public async Task<IEnumerable<IVehicleMake>> GetAllVehicleMake()
        {
            return await Repository.GetAllVehicleMake();
        }

        #endregion Metodhs

    }
}
