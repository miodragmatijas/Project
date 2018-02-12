using Project.Model;
using Project.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Common
{
    public interface IVehicleMakeService
    {
        Task<IEnumerable<IVehicleMake>> GetPagingData(int pageIndex, int pageSize, string txtSearch, string txtSort);
        Task<IVehicleMake> FindById(int id);
        Task<int> Delete(int id);
        Task<int> Add(IVehicleMake data);
        Task<int> Update(IVehicleMake data);
    }
}
