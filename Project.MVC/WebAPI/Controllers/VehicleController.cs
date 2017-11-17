using Project.Model.Common;
using Project.Service;
using Project.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using WebAPI.Views;

namespace WebAPI.Controllers
{
    [System.Web.Http.RoutePrefix("api/Vehicle")]
    public class VehicleController : ApiController
    {

        private IVehicleMakeService _VehicleMakeService;
        public VehicleController(IVehicleMakeService vehicleMakeService)
        {
            _VehicleMakeService = vehicleMakeService;
        }

        //// GET: api/Vehicle
        public  async  Task<HttpResponseMessage> GetAsync()
        {
            var model = AutoMapper.Mapper.Map<IEnumerable<VehicleMakeView>>(await _VehicleMakeService.GetAll());     
                       
            return Request.CreateResponse(HttpStatusCode.OK, model);                      
        }     
        
        /*
        
        // GET: api/Vehicle/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Vehicle
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Vehicle/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Vehicle/5
        public void Delete(int id)
        {
        }

       */
    }
}
