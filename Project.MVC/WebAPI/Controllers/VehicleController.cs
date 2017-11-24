using Project.Model.Common;
using Project.Service.Common;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebAPI.Views;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/Vehicle")]
    public class VehicleController : ApiController
    {

        private IVehicleMakeService _VehicleMakeService;
        public VehicleController(IVehicleMakeService vehicleMakeService)
        {
            _VehicleMakeService = vehicleMakeService;
        }

        // GET: api/Vehicle
        [HttpGet]
        public async Task<HttpResponseMessage> GetAsync()
        {
            var model = AutoMapper.Mapper.Map<IEnumerable<VehicleMakeView>>(await _VehicleMakeService.GetAll());
            return Request.CreateResponse(HttpStatusCode.OK, model);
        }

        // GET: api/Vehicle/5
        [HttpGet]
        public async Task<HttpResponseMessage> GetId(int id)
        {
            var model = AutoMapper.Mapper.Map<VehicleMakeView>(await _VehicleMakeService.FindById(id));
            return Request.CreateResponse(HttpStatusCode.OK, model);
        }

        // DELETE: api/Vehicle/5
        [HttpDelete]
        public async Task<HttpResponseMessage> Delete(int id)
        {
            await _VehicleMakeService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
                
        // POST: api/Vehicle
        [HttpPost]
        public async Task<HttpResponseMessage> Add(VehicleMakeView vehicleMakeView)
        {
            var model = AutoMapper.Mapper.Map<IVehicleMake>(vehicleMakeView);
            var response = await _VehicleMakeService.Add(model);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        /*

        // PUT: api/Vehicle/5
        public void Put(int id, [FromBody]string value)
        {
        }     

       */
    }
}
