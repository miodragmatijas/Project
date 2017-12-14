﻿using Project.Model;
using Project.Model.Common;
using Project.Service.Common;
using System;
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
            int pageIndex = 2;
            int pageSize = 5;
            string txtSearch = "";
            string txtSort = "name";

            var vehicle = await _VehicleMakeService.GetAll(pageIndex, pageSize, txtSearch, txtSort);

               var model = AutoMapper.Mapper.Map<IEnumerable<VehicleMakeView>>(vehicle.Item1);

            return Request.CreateResponse(HttpStatusCode.OK, model);
        }

        // GET: api/Vehicle/5
        [HttpGet]
        public async Task<HttpResponseMessage> GetId(int id)
        {
            var vehicle= await _VehicleMakeService.FindById(id);
            var model = AutoMapper.Mapper.Map<VehicleMakeView>(vehicle);
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
        //[Route("add")]
        public async Task<HttpResponseMessage> Add([FromBody] VehicleMakeView vehicleMakeView)
        {
            
            var model = AutoMapper.Mapper.Map<IVehicleMake>(vehicleMakeView);
            var response = await _VehicleMakeService.Add(model);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // PUT: api/Vehicle/5
        [HttpPut]
        public async Task<HttpResponseMessage> Update(int id, [FromBody]VehicleMakeView vehicleMakeView)
        {
            vehicleMakeView.ID = id;
            var model = AutoMapper.Mapper.Map<IVehicleMake>(vehicleMakeView);
            var response =await _VehicleMakeService.Update(model);
            return Request.CreateResponse(HttpStatusCode.OK);
        }     
    }
}
