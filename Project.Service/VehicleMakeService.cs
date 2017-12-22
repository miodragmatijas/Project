using Project.Service.Common;
using System.Collections.Generic;
using System.Threading.Tasks;
using Project.Repository.Common;
using Project.Model.Common;
using Project.Model;
using System;
using System.Linq;
using PagedList;

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

        public async Task<Tuple<IEnumerable<IVehicleMake>, int>> GetAll(int pageIndex, int pageSize, string txtSearch, string txtSort)
        {
            var model = await Repository.GetAll<VehicleMake>();

            

            var data = from d in model
                       where d.Name.ToLower().Contains(txtSearch.ToLower()) || d.Abrv.ToLower().Contains(txtSearch.ToLower())
                       select d;

            switch (txtSort)
            {
                case "name_desc":
                    data = data.OrderByDescending(s => s.Name).ToList();
                    break;
                case "abrv":
                    data = data.OrderBy(s => s.Abrv).ToList();
                    break;
                case "abrv_desc":
                    data = data.OrderByDescending(s => s.Abrv).ToList();
                    break;
                case "ID":
                    data = data.OrderBy(s => s.ID).ToList();
                    break;
                case "ID_desc":
                    data = data.OrderByDescending(s => s.ID).ToList();
                    break;
                default:
                    data = data.OrderBy(s => s.Name).ToList();
                    break;
            }

            int dataCount = data.Count();

            data = data.ToPagedList(pageIndex, pageSize);
            
            var dataVehicle = AutoMapper.Mapper.Map<IEnumerable<IVehicleMake>>(data);


            return new Tuple<IEnumerable<IVehicleMake>, int>(dataVehicle, dataCount);
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

        public async Task<int> Update(IVehicleMake data)
        {
            var model = AutoMapper.Mapper.Map<VehicleMake>(data);
            var x = await Repository.UpdateAsync(model);
            return x;
        }
        #endregion Metodhs

    }
}
