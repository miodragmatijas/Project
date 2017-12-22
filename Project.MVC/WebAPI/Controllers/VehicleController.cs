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
        public async Task<HttpResponseMessage> GetAsync(int pageIndex, int pageSize, string txtSearch, string txtSort)
        {
            if (txtSearch == null) { txtSearch = ""; };
            if (txtSort == null) { txtSearch = ""; };

            var vehicles = await _VehicleMakeService.GetAll(pageIndex, pageSize, txtSearch, txtSort);

            var model = AutoMapper.Mapper.Map<IEnumerable<VehicleMakesView>>(vehicles.Item1);

            VehiclePaged vehiclePaged = new VehiclePaged
            {
                CountData = vehicles.Item2,
                VehicleMakesView = model
            };

            return Request.CreateResponse(HttpStatusCode.OK, vehiclePaged);
        }

        // GET: api/Vehicle/5
        [HttpGet]
        public async Task<HttpResponseMessage> GetId(int id)
        {
            var vehicle = await _VehicleMakeService.FindById(id);
            var model = AutoMapper.Mapper.Map<VehicleMakesView>(vehicle);
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
        public async Task<HttpResponseMessage> Add([FromBody] VehicleMakesView vehicleMakesView)
        {

            var model = AutoMapper.Mapper.Map<IVehicleMake>(vehicleMakesView);
            var response = await _VehicleMakeService.Add(model);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // PUT: api/Vehicle/5
        [HttpPut]
        public async Task<HttpResponseMessage> Update([FromBody] VehicleMakesView vehicleMakesView)
        {
            var model = AutoMapper.Mapper.Map<IVehicleMake>(vehicleMakesView);
            var response = await _VehicleMakeService.Update(model);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
