using Project.Model.Common;
using Project.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class VehicleController : ApiController
    {
        private readonly IVehicleMakeService Service;
        public VehicleController(IVehicleMakeService service)
        {
            this.Service = service;
        }

        //#region Constructor
        //public VehicleController(IVehicleMakeService servise)
        //{
        //    this.Service = servise;
        //}
        //#endregion Constructor

        //#region Properties
        //protected IVehicleMakeService Service { get; set; }
        //#endregion Properties

        #region Methods

        [HttpGet]
        public async Task<IEnumerable<IVehicleMake>> GetAll()
        {
            return await Service.GetAllVehicleMake();
        }
        #endregion Methods
    }
}
